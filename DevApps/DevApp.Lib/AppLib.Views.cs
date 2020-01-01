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
        static public void RegisterViews()
        {
            UiView V;
            UiColumn Column;

            V = UiViews.Register("Trader");
            Column = new UiColumn();
            V.Columns.Add(Column);

            Column.AddRow("Code", "Code", UiViews.TextBox, "Code", true, true);
            Column.AddRow("Name", "Name", UiViews.TextBox, "Name", true, false);
        }
    }
}
