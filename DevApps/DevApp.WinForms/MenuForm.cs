using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using WeifenLuo.WinFormsUI.Docking;

using Tripous;
using Tripous.Logging;
using Tripous.Data;
using Tripous.Forms;


namespace DevApp.WinForms
{
    /// <summary>
    /// Main form
    /// </summary>
    public partial class MenuForm : ToolForm
    {      

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public MenuForm()
        {
            InitializeComponent();
        }
    }
}
