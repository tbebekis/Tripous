/*--------------------------------------------------------------------------------------        
                           Copyright © 2018 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Tripous.Data
{

    /// <summary>
    /// The holder of all schema versions of a certain Schema.
    /// </summary>
    public class Schema : NamedItem
    {
        OwnedCollection<SchemaVersion> fVersions = new OwnedCollection<SchemaVersion>();


        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public Schema()
        {
            fVersions = new OwnedCollection<SchemaVersion>();
            Versions.Owner = this;
        }


        /* public */
        /// <summary>
        /// Returns the first schema version with Domain, DatastoreName and Version, if any else null
        /// </summary>
        public SchemaVersion Find(string Domain, string DatastoreName, int Version)
        {
            return Versions.FirstOrDefault(item => Domain.IsSameText(item.Domain)
                                                    && DatastoreName.IsSameText(item.ConnectionName)
                                                    && (Version == item.Version));
        }
        /// <summary>
        /// True if a version with Domain, DatastoreName and Version is already registered.
        /// </summary>
        public bool Contains(string Domain, string DatastoreName, int Version)
        {
            return Find(Domain, DatastoreName, Version) != null;
        }

        /// <summary>
        /// Returns the first schema version with Domain and DatastoreName
        /// and having a version equal to or greater than the specified Version, if any, else null.
        /// </summary>
        public SchemaVersion FindGreaterOrEqual(string Domain, string DatastoreName, int Version)
        {
            return Versions.FirstOrDefault(item => Domain.IsSameText(item.Domain)
                                                    && DatastoreName.IsSameText(item.ConnectionName)
                                                    && (item.Version >= Version));
        }
        /// <summary>
        /// Checks to see if there is already a schema version with this Domain, DatastoreName
        /// and greater or equal Version. Throws an exception if it finds one.
        /// </summary>
        public void Check(string Domain, string DatastoreName, int Version)
        {
            SchemaVersion Item = FindGreaterOrEqual(Domain, DatastoreName, Version);
            if (Item != null)
                Sys.Error("Invalid schema datastore version: Domain: {0}, Datastore {1}, Version {2}", Domain, DatastoreName, Version);
        }

        /// <summary>
        /// Adds a new schema version
        /// </summary>
        public SchemaVersion Add(string Domain, string DatastoreName, int Version)
        {
            Check(Domain, DatastoreName, Version);
            SchemaVersion Result = new SchemaVersion();
            Result.Domain = Domain;
            Result.ConnectionName = DatastoreName;
            Result.Version = Version;
            Versions.Add(Result);
            return Result;
        }
        /// <summary>
        /// Adds a new schema version for the system
        /// </summary>
        internal SchemaVersion AddSystem(string DatastoreName, int Version)
        {
            return Add(Sys.SYSTEM, DatastoreName, Version);
        }
        /// <summary>
        /// Adds a new schema version for the application
        /// </summary>
        public SchemaVersion Add(string DatastoreName, int Version)
        {
            return Add(Sys.APPLICATION, DatastoreName, Version);
        }

        /* execution methods */
        /// <summary>
        /// Executes all schemas.
        /// </summary>
        internal void Execute()
        { 
            List<SqlConnectionInfo> Connections = new List<SqlConnectionInfo>(Db.Connections);

            /* group schema versions by Domain */
            Dictionary<string, List<SchemaVersion>> Dic = Versions
                .GroupBy(item => item.Domain)                    // IEnumerable<IGrouping<string, SchemaVersion>>
                .ToDictionary(g => g.Key, g => g.ToList());


            /*  Executes a schema against Datastore, registered by Domain.
                VersionList is a by Version sorted list of schemas for that datastore. */
            Action<string, SqlConnectionInfo, List<SchemaVersion>> ExecuteSchema = delegate (string Domain, SqlConnectionInfo Connection, List<SchemaVersion> VersionList)
            {
                /* get the current version of the datastore from the dbIni table */
                DbIni Ini = Db.MainIni;
                string Entry = string.Format("Datastore.Version.{0}.{1}", Connection.Name, Domain);
                int Version = Ini.ReadInteger(Entry, -1);

                  
                foreach (SchemaVersion Item in VersionList)
                {
                    if (Item.Version > Version)
                    {
                        SchemaExecutor.Execute(Connection, Item);
                        Db.Metastores.Find(Connection.Name).ReLoad();

                        /* write the version to the dbIni */
                        Ini.WriteInteger(Entry, Item.Version); ;
                    }
                }
            };


            /*  creates a list of versions regarding a certain domain and a certain datastore. 
                The list is sorted by Version. 
                It then sends that sorted list for execution. */
            Action<string> ExecuteDomain = delegate (string Domain)
            {
                List<SchemaVersion> List = Dic[Domain];

                foreach (SqlConnectionInfo Connection in Connections)
                {
                    var q = from item in List
                            where item.ConnectionName.IsSameText(Connection.Name)
                            orderby item.Version
                            select item;

                    ExecuteSchema(Domain, Connection, q.ToList());
                }
            };


            /* executes the SYSTEM domain schema versions first */
            if (Dic.ContainsKey(Sys.SYSTEM))
            {
                ExecuteDomain(Sys.SYSTEM);
                Dic.Remove(Sys.SYSTEM);
            }

            /* executes the APPLICATION domain schema versions first */
            if (Dic.ContainsKey(Sys.APPLICATION))
            {
                ExecuteDomain(Sys.APPLICATION);
                Dic.Remove(Sys.APPLICATION);
            }


            /* execute the rest of the domains */
            foreach (var item in Dic)
            {
                ExecuteDomain(item.Key);
            }



        }


        /* property */
        /// <summary>
        /// The registered versions
        /// </summary>
        public OwnedCollection<SchemaVersion> Versions { get { return fVersions; } }
    }
}
