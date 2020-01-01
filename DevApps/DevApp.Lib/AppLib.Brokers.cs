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
        /// <summary>
        /// Registration method
        /// </summary>
        static public void RegisterBrokers()
        {
            BrokerDescriptor Broker;
            TableDescriptor Table;
            //CriterionDescriptor Criterion;
            //JoinTableDescriptor JoinTable;

            NameValueStringList DisplayLabels = new NameValueStringList();

            #region Trader
            Broker = Registry.Brokers.Add("Trader");
            Broker.CodeProducerName = SysCodeProducers.Simple6_3;
            Broker.MainSelect.Text = @"
select 
   Trader.Id            as Id
  ,Trader.Code          as Code
  ,Trader.Name          as Name
from 
  Trader
";
            DisplayLabels.Clear();
            DisplayLabels.Values["Code"] = "Code";
            DisplayLabels.Values["Name"] = "Name";
            Broker.MainSelect.DisplayLabels = DisplayLabels.Text;


            Table = Broker.Tables.Add(Broker.MainTableName, Broker.Title);
            Table.Fields.Add("Id", SysConfig.OidDataType, SysConfig.OidSize, "", FieldFlags.None);
            Table.Fields.Add("Code", SimpleType.String, 40, "Code", FieldFlags.Visible | FieldFlags.Searchable | FieldFlags.Required | FieldFlags.ReadOnlyUI);
            Table.Fields.Add("Name", SimpleType.String, 96, "Trader", FieldFlags.Visible | FieldFlags.Searchable | FieldFlags.Required);
            #endregion

        }
    }
}
