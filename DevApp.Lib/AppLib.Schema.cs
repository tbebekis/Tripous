using System;
using System.Collections.Generic;
using System.Text;

using Tripous;
using Tripous.Data;

namespace DevApp.Lib
{
    /// <summary>
    /// Helper class
    /// </summary>
    static partial class AppLib
    {

        const string EnumLookUpSql = @"
create table {0} (
   Id                     {1}                  @NOT_NULL primary key
  ,Name                   @NVARCHAR(96)        @NOT_NULL      

  ,constraint UK_{0}_00 unique (Name)           
)
";

        const string EnumLookUpWithErpIdSql = @"
create table {0} (
   Id                     {1}                  @NOT_NULL primary key
  ,Name                   @NVARCHAR(96)        @NOT_NULL     
  ,ErpId                  @NVARCHAR(96)        @NULL  

  ,constraint UK_{0}_00 unique (Name)           
)
";

        /// <summary>
        /// Creates an "enum" (integer look-up) table
        /// </summary>
        static public void AddEnum(SchemaVersion schema, string TableName, bool HasErpId = false)
        {
            string S = HasErpId ? EnumLookUpWithErpIdSql : EnumLookUpSql;

            S = string.Format(S, TableName, "integer");

            schema.AddTable(S);
        }
        /// <summary>
        /// Creates an "enum" (integer look-up) table and INSERTs the EnumType values to it.
        /// </summary>
        static public void AddEnum(SchemaVersion schema, string TableName, Type EnumType, bool HasErpId = false)
        {
            AddEnum(schema, TableName, HasErpId);

            string SqlText = "insert into {0} (Id, Name) values ({1}, '{2}')";
            string S2;

            Array A = Enum.GetValues(EnumType);
            for (int i = 0; i < A.Length; i++)
            {
                S2 = Sys.SplitCamelCase(A.GetValue(i).ToString());
                S2 = string.Format(SqlText, TableName, (int)A.GetValue(i), S2);
                schema.AddStatementAfter(S2);
            }

        }
        /// <summary>
        /// Creates look-up table
        /// </summary>
        static public void AddLookUp(SchemaVersion schema, string TableName, bool HasErpId = false)
        {
            string S = HasErpId ? EnumLookUpWithErpIdSql : EnumLookUpSql;

            S = string.Format(S, TableName, "@NVARCHAR(40)");

            schema.AddTable(S);
        }


        static void RegisterSchema_01()
        {
            string SqlText;
            SchemaVersion schema = Schemas.AppSchema.Add(SysConfig.DefaultConnection, 1);

            SqlText = @"
create table Trader (
   Id                     @NVARCHAR(40)       @NOT_NULL primary key
  ,Code                   @NVARCHAR(40)
  ,Name                   @NVARCHAR(96) 

  ,constraint Uc_Trader_00 unique (Code)     
) 
";

            schema.AddTable(SqlText);
        }



        /// <summary>
        /// Registration method
        /// </summary>
        static public void RegisterSchemas()
        {
            RegisterSchema_01();
        }


    }
}
