using System;

namespace Tripous.Data
{
    /// <summary>
    /// Registers system database schema
    /// </summary>
    static public class SystemSchema
    {

        static private string CompanyDataType = SysConfig.GuidOids ? "@NVARCHAR(40)    @NOT_NULL" : "integer default -1 @NOT_NULL";

        /// <summary>
        /// Registers the system schema
        /// </summary>
        static public void RegisterSchema(Action AfterFunc = null)
        {
            RegisterSchema_01();

            AfterFunc?.Invoke();
        }

        static void RegisterSchema_01()
        {
            string SqlText;
            SchemaVersion schema = Schemas.AppSchema.Add(Sys.SYSTEM, SysConfig.DefaultConnection, 1);

            /* Company */
            SqlText = @"
create table {0}  (
   Id                   {1}
  ,Name                 @NVARCHAR(96)    @NOT_NULL

  ,constraint UC_{0}_00 unique (Name)
)
";

            SqlText = string.Format(SqlText, SysTables.Company, SysConfig.PrimaryKeyStr, SysConfig.ForeignKeyStr);
            schema.AddTable(SqlText);

            if (SysConfig.GuidOids)
            {
                SqlText = $"insert into {SysTables.Company} (Id, Name) values ({SysConfig.CompanyIdSql}, 'Default') ";
                schema.AddStatementAfter(SqlText);
            }



            /*  SYS_LANG  */
            SqlText = @"
create table {0} (
    Id                      {1}
   ,Name                    @NVARCHAR(40)        @NOT_NULL                 
   ,CultureCode             @NVARCHAR(40)        @NOT_NULL                   
   ,SeoCode                 @NVARCHAR(40)        @NOT_NULL                   
   ,FlagImage               @NVARCHAR(512)       @NULL
   ,IsActive                integer default 1    @NOT_NULL
   ,DisplayOrder            integer default 0    @NOT_NULL                     
 )
";
            SqlText = string.Format(SqlText, SysTables.Lang, SysConfig.PrimaryKeyStr);
            schema.AddTable(SqlText);

            SqlText = string.Format(@"insert into {0} (Id, Name, CultureCode, SeoCode) values ('{1}', 'English', 'en-US', 'en') ", SysTables.Lang, SysConfig.EnId);
            schema.AddStatementAfter(SqlText);
            SqlText = string.Format(@"insert into {0} (Id, Name, CultureCode, SeoCode) values ('{1}', 'Greek', 'el-GR', 'gr') ", SysTables.Lang, SysConfig.GrId);
            schema.AddStatementAfter(SqlText);


            /* SYS_LOG */
            SqlText = @" 
create table {0}  (
   Id                     {1}
  ,LogDate                @DATE            @NULL
  ,LogTime                @NVARCHAR(12)    @NULL
  ,UserName               @NVARCHAR(96)    @NULL
  ,Host                   @NVARCHAR(64)    @NULL
  ,LogLevel               @NVARCHAR(24)    @NULL     
  ,LogSource              @NVARCHAR(96)    @NULL
  ,ScopeId                @NVARCHAR(96)    @NULL
  ,EventId                @NVARCHAR(96)    @NULL
  ,Data                   @NBLOB_TEXT      @NULL
)
";

            SqlText = string.Format(SqlText, SysTables.Log, SysConfig.PrimaryKeyStr);
            schema.AddTable(SqlText);

            SqlText = string.Format("create index IDX_{0}_00 on {0}(LogDate) ", SysTables.Log);
            schema.AddStatementAfter(SqlText);


            /* SYS_DATA */
            SqlText = @"
create table {0}  (                                                                                      
   Id                  {1}
  ,@COMPANY_ID         {2}

  ,DataName            @NVARCHAR(96)   @NOT_NULL
  ,Title               @NVARCHAR(128)  @NOT_NULL
  ,DataType            @NVARCHAR(96)   @NOT_NULL
  ,StoreName           @NVARCHAR(64)   @NOT_NULL
  ,Notes               @NVARCHAR(255)  @NULL

  ,Category1           @NVARCHAR(64)   @NULL
  ,Category2           @NVARCHAR(64)   @NULL
  ,Category3           @NVARCHAR(64)   @NULL
  ,Category4           @NVARCHAR(64)   @NULL

  ,Data1               @BLOB           @NULL
  ,Data2               @BLOB           @NULL
  ,Data3               @BLOB           @NULL
  ,Data4               @BLOB           @NULL
  ,Data5               @BLOB           @NULL
  ,Data6               @BLOB           @NULL

  ,constraint UC_{0}_00 unique (@COMPANY_ID, DataType, DataName)
)
";
            SqlText = string.Format(SqlText, SysTables.Data, SysConfig.PrimaryKeyStr, CompanyDataType);
            schema.AddTable(SqlText);


            /*  SYS_STR_RES  */
            SqlText = @"
create table {0} (
    Id                      {1} 
   ,LanguageId              {2}                  @NULL                 
   ,TableName               @NVARCHAR(96)        @NULL           
   ,TableId                 {2}                  @NULL           
   ,EntryKey                @NVARCHAR(96)        @NOT_NULL		 
   ,EntryValue              @NBLOB_TEXT          @NOT_NULL                         
 )
";
            SqlText = string.Format(SqlText, SysTables.StrRes, SysConfig.PrimaryKeyStr, SysConfig.ForeignKeyStr);
            schema.AddTable(SqlText);


            /* SYS_SMTP_PROVIDER */
            SqlText = @"
create table {0} (
     Id						{1}
    ,Host                   @NVARCHAR(96)        @NOT_NULL  
    ,Port                   integer default 25   @NOT_NULL  
    ,UserName               @NVARCHAR(96)        @NULL 
    ,SenderAddress          @NVARCHAR(96)        @NULL 
    ,Psw                    @NVARCHAR(255)       @NULL
    ,EnableSsl              integer default 0    @NOT_NULL
    ,MessagesPerMinute      integer default -1   @NOT_NULL                    
    
    ,constraint UK_{0}_00 unique (Host)
)
";
            SqlText = string.Format(SqlText, SysTables.SmtpProvider, SysConfig.PrimaryKeyStr);
            schema.AddTable(SqlText);


        }
    }
}
