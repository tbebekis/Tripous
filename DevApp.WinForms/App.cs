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

namespace DevApp.WinForms
{
    static internal class App
    {

        static public void AppInitialize()
        {
            AppStarter.InitializeSysConfig();

            //DevApp.Lib.Forms.FormLib.Initialize();

            Tripous.Icons32.Initialize();
            ObjectStore.Initialize();

            Starter = new AppStarter();
            Starter.ApplicationInitialize();
        }
        static public void AppFinalize()
        {

        }

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
