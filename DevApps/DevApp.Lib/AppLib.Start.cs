using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Xml;
using System.IO;

using Tripous;
using Tripous.Data;
using Tripous.Model;

namespace DevApp.Lib
{
    /// <summary>
    /// Helper class
    /// </summary>
    static public partial class AppLib
    {
 
        

        /// <summary>
        /// Loads database configuration settings.
        /// </summary>
        static public void ConnectDatabases()
        {
            SqlConnectionInfoList ConnectionInfoList = new SqlConnectionInfoList();
            ConnectionInfoList.Load();
            Db.Connections = ConnectionInfoList.SqlConnections;
        }
        /// <summary>
        /// Creates any non-existing creatable database.
        /// </summary>
        static public void CreateDatabases()
        {
            SqlConnectionInfo DefaultConnectionInfo = Db.DefaultConnectionInfo;            
            SqlProvider Provider = DefaultConnectionInfo.GetSqlProvider();
            string ConnectionString = DefaultConnectionInfo.ConnectionString;

            if (!Provider.DatabaseExists(ConnectionString) && Provider.CanCreateDatabases)
            {
                Provider.CreateDatabase(ConnectionString);
            }
        }
        /// <summary>
        /// Creates database tables etc. based on the registered schemas
        /// </summary>
        static public void ExecuteSchemas()
        {
            Schemas.Execute();
        }
       
        /// <summary>
        /// Sets the value of the <see cref="SysConfig.CompanyId" /> property.
        /// </summary>
        static public void SetupCompanyId()
        {

        }

        /// <summary>
        /// Registers any config provider
        /// </summary>
        static public void RegisterConfigProviders()
        {            
        }
        /// <summary>
        /// Loads the application config, that is the various settings files of the application and the external modules.
        /// </summary>
        static public void LoadConfig()
        {            
        }

        /// <summary>
        /// Registers code producers.
        /// </summary>
        static public void RegisterCodeProducers()
        {
        }
    }
}
