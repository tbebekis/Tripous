using System;
using System.Collections.Generic;
using System.Text;

using Tripous;
using Tripous.Data;
using Tripous.Model;

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

 
            /* Job */
            /* ======================================================================================================= */
            SqlText = @"
create table Job (
    Id			integer @NOT_NULL primary key
   ,Title       @NVARCHAR(96)
) 
";

            schema.AddTable(SqlText);

            schema.AddStatementAfter("insert into JOB values (1, 'Inventory')");              /* Απογραφή αυστηρή, δηλαδή πρέπει να υπάρχει ο κωδικός στην database */
            schema.AddStatementAfter("insert into JOB values (2, 'Receipt picking')");        /* Παραλαβές από προμηθευτή */
            schema.AddStatementAfter("insert into JOB values (3, 'Order picking')");          /* Συλλογή για παραγγελία πελάτη */
            schema.AddStatementAfter("insert into JOB values (4, 'Wastes')");                 /* Φθορές */
            schema.AddStatementAfter("insert into JOB values (5, 'Labels')");                 /* Εκτύπωση ετικετών */

 

            /* Trader */
            /* ======================================================================================================= */
            SqlText = @"
create table Trader (
   Id                     @NVARCHAR(40)       @NOT_NULL primary key
  ,Code                   @NVARCHAR(40)
  ,Name                   @NVARCHAR(96)

  ,constraint Uc_Trader_00 unique (Code)     
) 
";

            schema.AddTable(SqlText);

            /* Product */
            /* ======================================================================================================= */
            SqlText = @"
create table Product (
    Id						@NVARCHAR(40)        @NOT_NULL primary key
   ,Code					@NVARCHAR(40)
   ,Name					@NVARCHAR(96)
   ,Picture                 @BLOB                @NULL
   ,BOQty		            @FLOAT default 0
   ,Price					@FLOAT default 0
)  
";

            schema.AddTable(SqlText);
            schema.AddStatementAfter("create unique index IdxProduct_00 on Product(Code)");


            /* Barcodes */
            /* ======================================================================================================= */
            SqlText = @"
create table Barcodes (
    Id                    @NVARCHAR(40)        @NOT_NULL primary key
   ,ProductId             @NVARCHAR(40)        @NOT_NULL
   ,Code                  @NVARCHAR(96)

   ,constraint FkBarcodes_00 foreign key (ProductId) references Product (Id)
) 
";

            schema.AddTable(SqlText);
            schema.AddStatementAfter("create unique index IdxBarcodes_00 on Barcodes(Code)");


            /* Trade */
            /* ======================================================================================================= */
            SqlText = @"
create table Trade (
    Id						@NVARCHAR(40)			@NOT_NULL primary key
   ,Code					@NVARCHAR(40)			@NOT_NULL 
   ,Title					@NVARCHAR(96)			@NOT_NULL 
   ,JobId					integer					@NOT_NULL 
   ,TraderId                @NVARCHAR(40)			@NULL 
   ,TradeDate				@DATE					@NOT_NULL 
   ,RelativeDoc				@NVARCHAR(96)

   ,Closed					integer default 0
   ,Flag					integer default 0
   ,BOFlag			        integer default 1
   
   ,Notes					@NVARCHAR(256) default ''
) 
";

            schema.AddTable(SqlText);
            schema.AddStatementAfter("create index IdxTrade_00 on Trade(JobId)");
            schema.AddStatementAfter("create unique index IdxTrade_01 on Trade(Code)");

            /* TradeLines */
            /* ======================================================================================================= */
            SqlText = @"
create table TradeLines (
   Id						@NVARCHAR(40)        @NOT_NULL primary key
  ,TradeId					@NVARCHAR(40)        @NOT_NULL 	
  ,ProductId				@NVARCHAR(40)        @NOT_NULL 	
  ,BarcodesId				@NVARCHAR(40)        @NULL
  ,Store					@NVARCHAR(96)  default ''	
  ,Qty						@FLOAT		   default 0 
  
  ,PdaName					@NVARCHAR(96)  default ''
  ,PdaIp					@NVARCHAR(96)  default ''
  ,PdaAppName				@NVARCHAR(96)  default ''
  ,PdaUserName				@NVARCHAR(96)  default ''

  ,Flag						integer  default 0

  ,constraint FkTradeLines_00 foreign key (TradeId) references Trade (Id)
  ,constraint FkTradeLines_01 foreign key (ProductId) references Product (Id)
)  
";

            schema.AddTable(SqlText);


        }



        /// <summary>
        /// Registration method
        /// </summary>
        static public void RegisterSchemas()
        {
            SystemSchema.Register();

            RegisterSchema_01();
        }


    }
}
