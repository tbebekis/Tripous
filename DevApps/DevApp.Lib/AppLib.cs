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
        /// Constant
        /// </summary>
        public const string Trader = "Trader";

        static SqlStore fStore;

        /// <summary>
        /// Returns a resource string for the Key, if any, else Default.
        /// </summary>
        static public string GS(string Key, string Default)
        {
            return Res.GS(Key, Default);
        }
        /// <summary>
        /// Returns a resource string for the Key .
        /// </summary>
        static public string GS(string Key)
        {
            return Res.GS(Key);
        }

        /// <summary>
        /// Fake. Just to have a call in order to force CLR to load this assembly
        /// </summary>
        static public void Initialize()
        {
            ObjectStore.RegisterObjectsOf(typeof(AppLib).Assembly);
        }

        /* select */
        /// <summary>
        /// Executes SqlText and returns a DataTable, actually a Tripous.Data.MemTable.
        /// </summary>
        static public DataTable Select(string SqlText, string Sort = "")
        {
            DataTable Result = Store.Select(SqlText);
            if (!string.IsNullOrWhiteSpace(Sort))
                Result.DefaultView.Sort = Sort;
            return Result;
        }
        /// <summary>
        ///  Executes SqlText and returns the first DataRow of the result set.
        ///  WARNING: If SqlText returns no rows at all then this method returns null.
        /// </summary>
        static public DataRow SelectResults(string SqlText)
        {
            return Store.SelectResults(SqlText);
        }
        /// <summary>
        /// Ideal for executing SELECT statements of the type "select count(ID) as COUNT_ID
        /// from TABLE_NAME where ID = 1234"
        /// </summary>
        static public int IntegerResult(string SqlText, int Default)
        {
            return Store.IntegerResult(SqlText, Default);
        }
        /// <summary>
        /// Ideal for executing SELECT statements of the type "select FIELD_NAME from TABLE_NAME"
        /// </summary>
        static public object SelectResult(string SqlText, object Default)
        {
            return Store.SelectResult(SqlText, Default);
        }
        /// <summary>
        /// Ideal for executing SELECT statements of the type "select FIELD_NAME from TABLE_NAME"
        /// </summary>
        static public object SelectResult(string SqlText)
        {
            return Store.SelectResult(SqlText);
        }
        /// <summary>
        /// Updates TableName enum database table with missing values by checking the specified EnumType
        /// </summary>
        static public void UpdateEnumTable(string TableName, Type EnumType)
        {
            if (AppLib.Store.TableExists(TableName))
            {
                string SqlText = string.Format("select Id from {0}", TableName);
                DataTable Table = AppLib.Select(SqlText, "Id");

                int Index;
                int Id;
                string Name;
                Array A = Enum.GetValues(EnumType);
                for (int i = 0; i < A.Length; i++)
                {
                    Id = (int)A.GetValue(i);
                    Index = Table.DefaultView.Find(Id);
                    if (Index == -1)
                    {
                        Name = Sys.SplitCamelCase(A.GetValue(i).ToString());
                        SqlText = string.Format("insert into {0} (Id, Name) values ({1}, '{2}')",
                            TableName, Id, Name);

                        AppLib.Store.ExecSql(SqlText);
                    }
                }
            }
        }
        /// <summary>
        /// Returns the MAX() of the specified FieldName
        /// </summary>
        static public int GetMaxOrderIndex(DataTable Table, string FieldName)
        {
            int Result = 0;
            foreach (DataRow Row in Table.Rows)
            {
                Result = Math.Max(Result, Row.AsInteger(FieldName, 0));
            }

            Result++;
            return Result;
        }
        /// <summary>
        /// Returns the MAX() of the a field named 'OrderIndex'
        /// </summary>
        static public int GetMaxOrderIndex(DataTable Table)
        {
            return GetMaxOrderIndex(Table, "OrderIndex");
        }

        /* properties */
        /// <summary>
        /// The default data store
        /// </summary>
        static public SqlStore Store { get { return fStore ?? (fStore = SqlStores.CreateDefaultSqlStore()); } }
 
    }
}
