/*--------------------------------------------------------------------------------
EnumLookUp
----------------------------------------------------------------------------------*/
create table {0} (
   Id                     {1}                  @NOT_NULL primary key
  ,Name                   @NVARCHAR(96)        @NOT_NULL      

  ,constraint UK_{0}_00 unique (Name)           
)

/*--------------------------------------------------------------------------------
EnumLookUp With ErpId
----------------------------------------------------------------------------------*/
create table {0} (
   Id                     {1}                  @NOT_NULL primary key
  ,Name                   @NVARCHAR(96)        @NOT_NULL     
  ,ErpId                  @NVARCHAR(96)        @NULL  

  ,constraint UK_{0}_00 unique (Name)           
)

/*--------------------------------------------------------------------------------
Job
----------------------------------------------------------------------------------*/
create table Job (
    Id			integer @NOT_NULL primary key
   ,Title       @NVARCHAR(96)
) 


/*--------------------------------------------------------------------------------
Trader
----------------------------------------------------------------------------------*/
create table Trader (
   Id                     @NVARCHAR(40)       @NOT_NULL primary key
  ,Code                   @NVARCHAR(40)
  ,Name                   @NVARCHAR(96)

  ,constraint Uc_Trader_00 unique (Code)    
) 


/*--------------------------------------------------------------------------------
Product
----------------------------------------------------------------------------------*/
create table Product (
    Id						@NVARCHAR(40)        @NOT_NULL primary key
   ,Code					@NVARCHAR(40)
   ,Name					@NVARCHAR(96)
   ,Picture                 @BLOB                @NULL
   ,BOQty		            @FLOAT default 0
   ,Price					@FLOAT default 0
)  

/*--------------------------------------------------------------------------------
Barcodes
----------------------------------------------------------------------------------*/
create table Barcodes (
    Id                    @NVARCHAR(40)        @NOT_NULL primary key
   ,ProductId             @NVARCHAR(40)        @NOT_NULL
   ,Code                  @NVARCHAR(96)

   ,constraint FkBarcodes_00 foreign key (ProductId) references Product (Id)
) 

/*--------------------------------------------------------------------------------
Trade
----------------------------------------------------------------------------------*/
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



/*--------------------------------------------------------------------------------
TradeLines
----------------------------------------------------------------------------------*/
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




 