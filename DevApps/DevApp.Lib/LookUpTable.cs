using System;
using System.Collections.Generic;
using System.Linq;
 

namespace DevApp.Lib
{
    /// <summary>
    /// Base class 
    /// </summary>
    public class LookUpOrEnumTable
    {
        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public LookUpOrEnumTable()
        {
        }

        /* properties */
        /// <summary>
        /// The name of the table/form/command
        /// </summary>
        public string Name { get; protected set; }
        /// <summary>
        /// The title resource key
        /// </summary>
        public string TitleKey { get; protected set; }
        /// <summary>
        /// The group where the lookup item belongs to.
        /// </summary>
        public string Group { get; protected set; }
        /// <summary>
        /// True when it has a third field called ErpId
        /// </summary>
        public bool HasErpId { get; protected set; }
    }


    /// <summary>
    /// Helper for enum (integer look-up) tables
    /// </summary>
    public class EnumTable: LookUpOrEnumTable
    {
        /// <summary>
        /// LookUpTables List
        /// </summary>
        static public List<EnumTable> Tables = new List<EnumTable>();

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public EnumTable(string Name, string TitleKey, string Group, bool HasErpId = false)
        {
            this.Name = Name;
            this.TitleKey = TitleKey;
            this.Group = Group;
            this.HasErpId = HasErpId;
        }
        /// <summary>
        /// Static constructor
        /// </summary>
        static EnumTable()
        {
            //string Group = "Tables";
            //Tables.Add(new EnumTable("AppDataType", "AppDataType", Group));
        }

        /* static */
        /// <summary>
        /// Returns items grouped by Group
        /// </summary>
        static public IEnumerable<IGrouping<string, EnumTable>> GetGroups()
        {
            return Tables.GroupBy(item => item.Group, item => item);
        }

 
    }



    /// <summary>
    /// Represents a lookup table/form/command, that is a 
    /// unit of information with Id and Name only.
    /// </summary>
    public class LookUpTable : LookUpOrEnumTable
    {
        /// <summary>
        /// LookUpTables List
        /// </summary>
        static public List<LookUpTable> Tables = new List<LookUpTable>();

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public LookUpTable(string Name, string TitleKey, string Group, bool HasErpId = false)
        {
            this.Name = Name;
            this.TitleKey = TitleKey;
            this.Group = Group;
            this.HasErpId = HasErpId;
        }
        /// <summary>
        /// Static constructor
        /// </summary>
        static LookUpTable()
        {
            //string Group = "LookUps";
            //Tables.Add(new LookUpTable("EmployeeRole", "EmployeeRole", Group));
        }

        /* static */
        /// <summary>
        /// Returns lookup items grouped by Group
        /// </summary>
        static public IEnumerable<IGrouping<string, LookUpTable>> GetGroups()
        {
            return Tables.GroupBy(item => item.Group, item => item);
        }
 
    }
}
