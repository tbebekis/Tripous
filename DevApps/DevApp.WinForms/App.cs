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

using DevApp.Lib;

namespace DevApp.WinForms
{
    /// <summary>
    /// Represents this application
    /// </summary>
    static internal class App
    {

        static public void Start()
        {
            Starter = new AppStarter();
            Starter.Start();
        }
        static public void Stop()
        {
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
