using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        static public void RegisterLocators()
        {
            LocatorDescriptor Locator;

            string TableName;

            #region Enums
            foreach (EnumTable Item in EnumTable.Tables)
            {
                TableName = Item.Name;
                Locator = Registry.Locators.Add(TableName, TableName, "Id", Item.TitleKey);
                Locator.Fields.Add(SimpleType.Integer, "", "Id", "Id", TableName, "Id", false, false, false);
                Locator.Fields.Add(SimpleType.String, TableName + "__Name", "Name", TableName);
                Locator.ZoomCommand = SysConfig.DefaultConnection + "." + TableName;
            }
            #endregion

            #region LookUps
            foreach (LookUpTable Item in LookUpTable.Tables)
            {
                TableName = Item.Name;
                Locator = Registry.Locators.Add(TableName, TableName, "Id", Item.TitleKey);
                Locator.Fields.Add(SysConfig.OidDataType, "", "Id", "Id", TableName, "Id", false, false, false);
                Locator.Fields.Add(SimpleType.String, TableName + "__Name", "Name", TableName);
                Locator.ZoomCommand = SysConfig.DefaultConnection + "." + TableName;
            }
            #endregion

            TableName = "Trader";
            Locator = Registry.Locators.Add(TableName, TableName, "Id");

            Locator.Fields.Add(SimpleType.String, "TraderId", "Id", "Id", "Trader", "Id", false, false, false);
            Locator.Fields.Add(SimpleType.String, TableName + "__Code", "Code", "Code", "Trader", "Code", true, true, true);
            Locator.Fields.Add(SimpleType.String, TableName + "__Name", "Name", "Name", "Trader", "Name", true, true, true);
        }
    }
}
