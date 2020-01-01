using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

using System.ComponentModel;

using System.Drawing.Design;
using System.Drawing;
using System.Windows.Forms.Design;

using Tripous;
using Tripous.Data;
using Tripous.Model;
using Tripous.Forms;

using DevApp.Lib;

namespace DevApp.WinForms
{
    /// <summary>
    /// Represents this application
    /// </summary>
    static internal class App
    {


        /// <summary>
        /// Starts the application
        /// </summary>
        static public void Start()
        {
            Starter = new AppStarter();
            Starter.Start();
        }

        /// <summary>
        /// Registers commands
        /// </summary>
        static public void RegisterCommands()
        {
            Command P = Registry.MainRootCommand;
            Command Cn;

            /* Admin */
            Cn = Command.CreateContainer(SystemCommands.CMD_ADMIN, SystemCommands.CMD_ADMIN);
            P.InsertAfter(SystemCommands.CMD_FILE, Cn);

            Cn.Add(AppLib.Trader, AppLib.Trader).IconPath = Icons32.User;
        }

        static public void RegisterForms()
        {
            FormOptions Options;

            Options = FormOptions.Register(typeof(DataFormSqlBroker), AppLib.Trader);
        }

        /* properties */
        static public AppStarter Starter { get; set; }
        /// <summary>
        /// BackColor
        /// </summary>
        static public Color BackColor { get; } = Color.Lavender;
        /// <summary>
        /// ImageScalingSize
        /// </summary>
        static public Size ImageScalingSize { get; } = new Size(19, 19);
    }
}
