/*--------------------------------------------------------------------------------
SYS_COMPANY
----------------------------------------------------------------------------------*/
create table {0}  (
   Id                   {1}
  ,Name                 @NVARCHAR(96)    @NOT_NULL

  ,constraint UC_{0}_00 unique (Name)
)

/*---------------------------------------------------------------------------------------*/	
insert into {0} (Id, Name) values ('{1}', 'Default')



/*--------------------------------------------------------------------------------
SYS_LANG
----------------------------------------------------------------------------------*/
create table {0} (
    Id                      {1}
   ,Name                    @NVARCHAR(40)        @NOT_NULL                 
   ,CultureCode             @NVARCHAR(40)        @NOT_NULL                  -- Specific culture, e.g. en-US, el-GR  
   ,SeoCode                 @NVARCHAR(40)        @NOT_NULL                  -- e.g. en, gr ... etc.
   ,FlagImage               @NVARCHAR(512)       @NULL
   ,IsActive                integer default 1    @NOT_NULL
   ,DisplayOrder            integer default 0    @NOT_NULL
)

/*---------------------------------------------------------------------------------------*/	
insert into {0} (Id, Name, CultureCode, SeoCode, IsActive, DisplayOrder) values ('{1}', 'English', 'en-US', 'en', 1, 0)


/*--------------------------------------------------------------------------------
 SYS_LOG
----------------------------------------------------------------------------------*/
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


 
 /*--------------------------------------------------------------------------------
 SYS_DATA
----------------------------------------------------------------------------------*/
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




/*--------------------------------------------------------------------------------
SYS_STR_RES
----------------------------------------------------------------------------------*/
create table {0} (
    Id                      {1} 
   ,LanguageId              {2}                  @NULL                 
   ,TableName               @NVARCHAR(96)        @NULL           
   ,TableId                 {2}                  @NULL           
   ,EntryKey                @NVARCHAR(96)        @NOT_NULL		 
   ,EntryValue              @NBLOB_TEXT          @NOT_NULL                         
 )
  

 
 /* ----------------------------------------------------------------------------------   
 SYS_SMTP_PROVIDER

 Email sending provider (i.e. gmail)
 -----------------------------------------------------------------------------------*/
create table {0} (
     Id						{1}
    ,Host                   @NVARCHAR(96)        @NOT_NULL  
    ,Port                   integer default 25   @NOT_NULL  
    ,UserName               @NVARCHAR(96)        @NULL 
    ,SenderAddress          @NVARCHAR(96)        @NULL 
    ,Psw                    @NVARCHAR(255)       @NULL
    ,EnableSsl              integer default 0    @NOT_NULL
    ,MessagesPerMinute      integer default -1   @NOT_NULL                    -- The messages per minute allowed by the provider. -1, the default, means no limit.
    
    ,constraint UK_{0}_00 unique (Host)
)

 