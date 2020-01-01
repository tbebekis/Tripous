using System;
using System.Collections.Generic;
using System.Text;

using Tripous.Data;

namespace Tripous.Model
{
    /// <summary>
    /// Registers system model.
    /// </summary>
    static public class SystemModel
    {

        static void RegisterBrokers()
        {
            BrokerDescriptor Broker;
            TableDescriptor Table;
            //JoinTableDescriptor JoinTable;
            SqlFilter SqlFilter;


            NameValueStringList DisplayLabels = new NameValueStringList();

            /* ======================================================================================================= */
            /* SYS_COMPANY */
            /* ======================================================================================================= */
            Broker = Registry.Brokers.Add(SysTables.Company, SysTables.Company, "Tripous.Model.SqlBroker");
            Broker.DescriptorMode = DescriptorMode.System;
            Broker.GuidOids = SysConfig.GuidOids;

            Broker.MainSelect.Text = string.Format(@"
select
  {0}.Id                as Id       
 ,{0}.Name              as Name  
 ,{0}.OfficialName      as OfficialName       
 ,{0}.Tin               as Tin            
from
   {0}               
", SysTables.Company);

            Table = Broker.Tables.Add(Broker.MainTableName, Broker.Title);
            Table.Fields.Add("Id", SysConfig.OidDataType, SysConfig.OidSize, "", FieldFlags.Required);
            Table.Fields.Add("Name", SimpleType.String, 96, "Name", FieldFlags.Visible | FieldFlags.Searchable | FieldFlags.Required);
 

            /* ======================================================================================================= */
            /* SYS_LANG */
            /* ======================================================================================================= */
            Broker = Registry.Brokers.Add(SysTables.Lang, SysTables.Lang, "Tripous.Model.SqlBroker");
            Broker.DescriptorMode = DescriptorMode.System;
            Broker.GuidOids = SysConfig.GuidOids;

            /* browser sql */
            Broker.MainSelect.Text = string.Format("select * from {0}", SysTables.Lang);
            Broker.MainSelect.CheckBoxColumns = "IsActive";


            /* tables */
            Table = Broker.Tables.Add(Broker.MainTableName, Broker.Title);
            Table.Fields.Add("Id", SysConfig.OidDataType, SysConfig.OidSize, "", FieldFlags.Required);
            Table.Fields.Add("Name", SimpleType.String, 40, "Language", FieldFlags.Visible | FieldFlags.Searchable | FieldFlags.Required);
            Table.Fields.Add("CultureCode", SimpleType.String, 40, "CultureCode", FieldFlags.Visible | FieldFlags.Searchable | FieldFlags.Required);
            Table.Fields.Add("SeoCode", SimpleType.String, 40, "SeoCode", FieldFlags.Visible | FieldFlags.Searchable | FieldFlags.Required);
            Table.Fields.Add("FlagImage", SimpleType.String, 255, "FlagImage", FieldFlags.Visible | FieldFlags.Searchable);
            Table.Fields.Add("IsActive", SimpleType.Integer, 0, "IsActive", FieldFlags.Visible | FieldFlags.Boolean).DefaultValue = "1";
            Table.Fields.Add("DisplayOrder", SimpleType.Integer, 0, "DisplayOrder", FieldFlags.Visible);

            /* ======================================================================================================= */
            /* SYS_LOG */
            /* ======================================================================================================= */
            // string DatastoreName, string Name, string MainTableName, string Title, string BrokerClassName
            Broker = Registry.Brokers.Add(SysTables.Log, SysTables.Log, "Tripous.Model.SysLogBroker");
            Broker.DescriptorMode = DescriptorMode.System;
            Broker.GuidOids = SysConfig.GuidOids;
            Broker.CodeProducerName = SysCodeProducers.SysLogCode;


            Broker.MainSelect.Select =
@"Id
 ,LogDate
 ,LogTime
 ,UserName
 ,Host
 ,LogLevel
 ,LogSource
";
            Broker.MainSelect.From = Broker.MainTableName;
            Broker.MainSelect.OrderBy = "LogDate, LogTime";


            DisplayLabels.Clear();
            DisplayLabels.Values["LogDate"] = "LogDate";
            DisplayLabels.Values["LogTime"] = "LogTime";
            DisplayLabels.Values["UserName"] = "UserName";
            DisplayLabels.Values["Host"] = "Host";
            DisplayLabels.Values["LogLevel"] = "LogLevel";
            DisplayLabels.Values["LogSource"] = "LogSource";
            Broker.MainSelect.DisplayLabels = DisplayLabels.Text;

            Broker.MainSelect.SqlFilters.Add(Broker.MainTableName, "LogDate", "Date", SimpleType.Date);
            Broker.MainSelect.SqlFilters.Add(Broker.MainTableName, "UserName", "UserName", SimpleType.String);
            Broker.MainSelect.SqlFilters.Add(Broker.MainTableName, "Host", "Host", SimpleType.String);

            SqlFilter = Broker.MainSelect.SqlFilters.Add(SysTables.Log, "LogType", "LogType", SimpleType.String, SqlFilterMode.EnumQuery);
            SqlFilter.Enum.Sql = string.Format("select distinct LogType from {0}", SysTables.Log);
            SqlFilter.Enum.ResultField = "LogType";
            SqlFilter.Enum.IsMultiChoise = true;
            DisplayLabels.Clear();
            DisplayLabels.Values["LogType"] = "LogType";
            SqlFilter.Enum.DisplayLabels = DisplayLabels.Text;

            SqlFilter = Broker.MainSelect.SqlFilters.Add(SysTables.Log, "LogSubType", "LogSubType", SimpleType.String, SqlFilterMode.EnumQuery);
            SqlFilter.Enum.Sql = string.Format("select distinct LogSubType from {0}", SysTables.Log);
            SqlFilter.Enum.ResultField = "LogSubType";
            SqlFilter.Enum.IsMultiChoise = true;
            DisplayLabels.Clear();
            DisplayLabels.Values["LogSubType"] = "LogSubType";
            SqlFilter.Enum.DisplayLabels = DisplayLabels.Text;

            Table = Broker.Tables.Add(Broker.MainTableName, Broker.Title);
            Table.Fields.Add("Id", SysConfig.OidDataType, SysConfig.OidSize, "", FieldFlags.Required);
            Table.Fields.Add("LogDate", SimpleType.Date, 0, "", FieldFlags.Visible | FieldFlags.Searchable | FieldFlags.ReadOnlyUI);
            Table.Fields.Add("LogTime", SimpleType.String, 12, "", FieldFlags.Visible | FieldFlags.Searchable | FieldFlags.ReadOnlyUI);
            Table.Fields.Add("UserName", SimpleType.String, 96, "", FieldFlags.Visible | FieldFlags.Searchable | FieldFlags.ReadOnlyUI);
            Table.Fields.Add("Host", SimpleType.String, 64, "", FieldFlags.Visible | FieldFlags.Searchable | FieldFlags.ReadOnlyUI);
            Table.Fields.Add("LogLevel", SimpleType.String, 24, "", FieldFlags.Visible | FieldFlags.Searchable | FieldFlags.ReadOnlyUI);
            Table.Fields.Add("LogSource", SimpleType.String, 96, "", FieldFlags.Visible | FieldFlags.Searchable | FieldFlags.ReadOnlyUI);
            Table.Fields.Add("ScopeId", SimpleType.String, 96, "", FieldFlags.Visible | FieldFlags.Searchable | FieldFlags.ReadOnlyUI);
            Table.Fields.Add("EventId", SimpleType.String, 96, "", FieldFlags.Visible | FieldFlags.Searchable | FieldFlags.ReadOnlyUI);
            Table.Fields.Add("Data", SimpleType.Memo, 0, "Data", FieldFlags.Memo | FieldFlags.ReadOnlyUI);


            /* ======================================================================================================= */
            /* SYS_DATA */
            /* ======================================================================================================= */
            Broker = Registry.Brokers.Add(SysTables.Data, SysTables.Data, "Tripous.Model.SysDataBroker");
            Broker.DescriptorMode = DescriptorMode.System;
            Broker.GuidOids = SysConfig.GuidOids;



            /* browser sql */
            Broker.MainSelect.Select =
@"Id
 ,DataName            
 ,Title               
 ,DataType            
 ,StoreName           
 ,Category1           
 ,Category2           
         
";
            Broker.MainSelect.From = Broker.MainTableName;
            Broker.MainSelect.Where = string.Format("{0} = {1}{0}", SysConfig.CompanyFieldName, SysConfig.VariablesPrefix);


            DisplayLabels.Clear();
            DisplayLabels.Values["DataName"] = "DataName";
            DisplayLabels.Values["Title"] = "Title";
            DisplayLabels.Values["DataType"] = "DataType";
            DisplayLabels.Values["StoreName"] = "StoreName";
            DisplayLabels.Values["Category1"] = "Category1";
            DisplayLabels.Values["Category2"] = "Category2";
            Broker.MainSelect.DisplayLabels = DisplayLabels.Text;

            /* tables */
            Table = Broker.Tables.Add(Broker.MainTableName, Broker.Title);
            Table.Fields.Add("Id", SysConfig.OidDataType, SysConfig.OidSize, "", FieldFlags.Required);
            Table.Fields.Add(SysConfig.CompanyFieldName, SysConfig.OidDataType, SysConfig.OidSize, "Company", FieldFlags.Required);
            Table.Fields.Add("DataName", SimpleType.String, 96, "", FieldFlags.Visible | FieldFlags.Searchable | FieldFlags.Required);
            Table.Fields.Add("Title", SimpleType.String, 128, "", FieldFlags.Visible);
            Table.Fields.Add("DataType", SimpleType.String, 96, "", FieldFlags.Visible | FieldFlags.Searchable | FieldFlags.Required | FieldFlags.ReadOnlyEdit);
            Table.Fields.Add("StoreName", SimpleType.String, 64, "", FieldFlags.Visible | FieldFlags.Searchable | FieldFlags.Required);
            Table.Fields.Add("Notes", SimpleType.String, 255, "", FieldFlags.Visible);

            Table.Fields.Add("Category1", SimpleType.String, 64, "", FieldFlags.Visible);
            Table.Fields.Add("Category2", SimpleType.String, 64, "", FieldFlags.Visible);
 
            /* queries */
            Broker.Queries.Add("StoreName", string.Format("select distinct StoreName as Name from {0} ", Broker.MainTableName));
            Broker.Queries.Add("DataType", string.Format("select distinct DataType  as Name  from {0} ", Broker.MainTableName));
            Broker.Queries.Add("Category1", string.Format("select distinct Category1 as Name  from {0} ", Broker.MainTableName));
            Broker.Queries.Add("Category2", string.Format("select distinct Category2 as Name  from {0} ", Broker.MainTableName));


            /* ======================================================================================================= */
            /* SYS_STR_RES */
            /* ======================================================================================================= */
            Broker = Registry.Brokers.Add(SysTables.StrRes, SysTables.StrRes, "Tripous.Model.SqlBroker");
            Broker.DescriptorMode = DescriptorMode.System;
            Broker.GuidOids = SysConfig.GuidOids;

            /* browser sql */
            Broker.MainSelect.Text = string.Format(
@"select
  {0}.Id                as Id                     
 ,{1}.Name              as Language     
 ,{0}.TableName         as TableName             
 ,{0}.EntryKey          as EntryKey         
 ,{0}.TableId           as TableId       
from
  {0}
     left join {1} on {1}.Id = {0}.LanguageId             
", Broker.MainTableName, SysTables.Lang);

            DisplayLabels.Clear();
            DisplayLabels.Values["Language"] = "Language";
            DisplayLabels.Values["TableName"] = "TableName";
            DisplayLabels.Values["EntryKey"] = "EntryKey";
            DisplayLabels.Values["TableId"] = "TableId";
            Broker.MainSelect.DisplayLabels = DisplayLabels.Text;


            /* criteria */
            Broker.MainSelect.SqlFilters.Add(Broker.MainTableName, "EntryKey", "EntryKey", SimpleType.String);

            SqlFilter = Broker.MainSelect.SqlFilters.Add(SysTables.Lang, "Name", "Language", SysConfig.OidDataType, SqlFilterMode.EnumQuery);
            SqlFilter.Enum.Sql = string.Format("select Id, Name from {0}", SysTables.Lang);
            SqlFilter.Enum.IsMultiChoise = true;
            DisplayLabels.Clear();
            DisplayLabels.Values["Name"] = "Language";
            SqlFilter.Enum.DisplayLabels = DisplayLabels.Text;

            SqlFilter = Broker.MainSelect.SqlFilters.Add(Broker.MainTableName, "TableName", "TableName", SysConfig.OidDataType, SqlFilterMode.EnumQuery);
            SqlFilter.Enum.Sql = string.Format("select distinct TableName from {0}", Broker.MainTableName);
            SqlFilter.Enum.IsMultiChoise = true;
            DisplayLabels.Clear();
            DisplayLabels.Values["TableName"] = "TableName";
            SqlFilter.Enum.DisplayLabels = DisplayLabels.Text;


            /* tables */
            Table = Broker.Tables.Add(Broker.MainTableName, Broker.Title);
            Table.Fields.Add("Id", SysConfig.OidDataType, SysConfig.OidSize, "", FieldFlags.Required);
            Table.Fields.Add("LanguageId", SysConfig.OidDataType, SysConfig.OidSize, "LanguageId", FieldFlags.Visible | FieldFlags.Searchable);
            Table.Fields.Add("TableName", SimpleType.String, 96, "TableName", FieldFlags.Visible | FieldFlags.Searchable);
            Table.Fields.Add("TableId", SysConfig.OidDataType, SysConfig.OidSize, "TableId", FieldFlags.Visible | FieldFlags.Searchable);
            Table.Fields.Add("EntryKey", SimpleType.String, 96, "EntryKey", FieldFlags.Visible | FieldFlags.Searchable | FieldFlags.Required);
            Table.Fields.Add("EntryValue", SimpleType.Memo, 0, "EntryValue", FieldFlags.Visible | FieldFlags.Memo);
 
            /* ======================================================================================================= */
            /* SYS_SMTP_PROVIDER */
            /* ======================================================================================================= */
            Broker = Registry.Brokers.Add(SysTables.SmtpProvider, SysTables.SmtpProvider, "Tripous.Model.SqlBroker");
            Broker.DescriptorMode = DescriptorMode.System;
            Broker.GuidOids = SysConfig.GuidOids;
            Broker.CodeProducerName = SysCodeProducers.Simple3;

            /* browser sql */
            Broker.MainSelect.Text = string.Format(@"
select
  Id            
 ,Code          
 ,Host          
 ,Port          
 ,UserName      
 ,SenderAddress      
from
  {0}       
", Broker.MainTableName);

            DisplayLabels.Clear();
            DisplayLabels.Values["Code"] = "Code";
            DisplayLabels.Values["Host"] = "Host";
            DisplayLabels.Values["Port"] = "Port";
            DisplayLabels.Values["UserName"] = "UserName";
            DisplayLabels.Values["SenderAddress"] = "SenderAddress";
            Broker.MainSelect.DisplayLabels = DisplayLabels.Text;

            /* tables */
            Table = Broker.Tables.Add(Broker.MainTableName, Broker.Title);
            Table.Fields.Add("Id", SysConfig.OidDataType, SysConfig.OidSize, "", FieldFlags.Required);
            Table.Fields.Add("Code", SimpleType.String, 40, "Code", FieldFlags.Visible | FieldFlags.Required | FieldFlags.Searchable | FieldFlags.ReadOnlyUI);
            Table.Fields.Add("Host", SimpleType.String, 96, "Host", FieldFlags.Visible | FieldFlags.Required | FieldFlags.Searchable);
            Table.Fields.Add("Port", SimpleType.Integer, 0, "Port", FieldFlags.Visible | FieldFlags.Required).DefaultValue = "25";
            Table.Fields.Add("UserName", SimpleType.String, 96, "UserName", FieldFlags.Visible | FieldFlags.Searchable);
            Table.Fields.Add("SenderAddress", SimpleType.String, 96, "SenderAddress", FieldFlags.Visible | FieldFlags.Searchable);
            Table.Fields.Add("Psw", SimpleType.String, 255, "Password", FieldFlags.Visible);
            Table.Fields.Add("EnableSsl", SimpleType.Integer, 0, "EnableSsl", FieldFlags.Visible | FieldFlags.Required | FieldFlags.Boolean).DefaultValue = "0";
            Table.Fields.Add("MessagesPerMinute", SimpleType.Integer, 0, "MessagesPerMinute", FieldFlags.Visible | FieldFlags.Required).DefaultValue = "-1";
 
            /* ======================================================================================================= */
            foreach (var Item in Registry.Brokers)
                Item.DescriptorMode = DescriptorMode.System;
        }
        static void RegisterCodeProducers()
        {
            CodeDescriptor CodeDescriptor;

            /* all the following code producers have a pivot part mode of CodePartMode.FieldName 
               and a prefix part mode of CodePartMode.Literal.
               The pivot field name is always Code, so the MasterTableName MUST contain a field named Code 
               for any of those code producers to be used. */
            CodeDescriptor = Registry.CodeProducers.Add(SysCodeProducers.Simple2, "Code", "XX", "CodeProducer", "");
            CodeDescriptor = Registry.CodeProducers.Add(SysCodeProducers.Simple3, "Code", "XXX", "CodeProducer", "");
            CodeDescriptor = Registry.CodeProducers.Add(SysCodeProducers.Simple4, "Code", "XXXX", "CodeProducer", "");
            CodeDescriptor = Registry.CodeProducers.Add(SysCodeProducers.Simple5, "Code", "XXXXX", "CodeProducer", "");
            CodeDescriptor = Registry.CodeProducers.Add(SysCodeProducers.Simple6, "Code", "XXXXXX", "CodeProducer", "");

            CodeDescriptor = Registry.CodeProducers.Add(SysCodeProducers.Simple4_2, "Code", "XX-XX", "CodeProducer", "");
            CodeDescriptor = Registry.CodeProducers.Add(SysCodeProducers.Simple6_3, "Code", "XXX-XXX", "CodeProducer", "");


            /* ByYear_3 - a code producer with a 2-digit year literal and a 3-digit pivot */
            CodeDescriptor = Registry.CodeProducers.Add(SysCodeProducers.By2Year_3, "Code", "-XXX", "CodeProducer", "YY");
            CodeDescriptor = Registry.CodeProducers.Add(SysCodeProducers.By2Year_4, "Code", "-XXXX", "CodeProducer", "YY");
            CodeDescriptor = Registry.CodeProducers.Add(SysCodeProducers.By2Year_5, "Code", "-XXXXX", "CodeProducer", "YY");
            CodeDescriptor = Registry.CodeProducers.Add(SysCodeProducers.By2Year_6, "Code", "-XXX-XXX", "CodeProducer", "YY");

            CodeDescriptor = Registry.CodeProducers.Add(SysCodeProducers.By4YearMonth_3, "Code", "-XXX", "CodeProducer", "YYYY-MM");
            CodeDescriptor = Registry.CodeProducers.Add(SysCodeProducers.By4YearMonth_4, "Code", "-XX-XX", "CodeProducer", "YYYY-MM");
            CodeDescriptor = Registry.CodeProducers.Add(SysCodeProducers.By4YearMonth_5, "Code", "-XXXXX", "CodeProducer", "YYYY-MM");
            CodeDescriptor = Registry.CodeProducers.Add(SysCodeProducers.By4YearMonth_6, "Code", "-XXX-XXX", "CodeProducer", "YYYY-MM");

            CodeDescriptor = Registry.CodeProducers.Add(SysCodeProducers.SysLogCode, "Code", "-XXX-XXX", "CodeProducer", "YYYY-MM-DD");


        }
        static void RegisterLocators()
        {
            LocatorDescriptor Locator;
            //LocatorFieldDescriptor Field;
 
            /* SysLang */
            Locator = Registry.Locators.Add("SysLang", SysTables.Lang, "Id", "Languages");
            Locator.SelectSql.CompanyAware = false;
            Locator.Fields.Add(SysConfig.OidDataType, "LanguageId", "Id", "Id", SysTables.Lang, "Id", false, false, false);
            Locator.Fields.Add(SimpleType.String, "", "Name", "Name", SysTables.Lang, "Language", true, true, true);
 
            /* SmtpProvider */
            Locator = Registry.Locators.Add("SmtpProvider", SysTables.SmtpProvider, "Id", "SmtpProviders");
            Locator.SelectSql.Text = string.Format("select Id, Host, SenderAddress from {0} ", SysTables.SmtpProvider);
            Locator.Fields.Add(SysConfig.OidDataType, "", "Id", "Id", SysTables.SmtpProvider, "Id", false, false, false);
            Locator.Fields.Add(SimpleType.String, "", "Host", "Host", SysTables.SmtpProvider, "Host", true, true, true);
            Locator.Fields.Add(SimpleType.String, "", "SenderAddress", "SenderAddress", SysTables.SmtpProvider, "SenderAddress", true, true, true);
        }


        /// <summary>
        /// Registration
        /// </summary>
        static public void Register(Action AfterFunc = null)
        {
            RegisterCodeProducers();
            RegisterLocators();
            RegisterBrokers();

            AfterFunc?.Invoke();
        }

    }
}
