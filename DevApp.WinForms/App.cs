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

namespace DevApp.WinForms
{
    static internal class App
    {
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
