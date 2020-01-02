using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripous.Forms
{

    /// <summary>
    /// TreeView <see cref="DataControl"/>
    /// </summary>
    public partial class TreeViewDataControl : DataControl
    {

        /* constructor */
        /// <summary>
        /// Constructor
        /// </summary>
        public TreeViewDataControl()
        {
            InitializeComponent();

            this.Control = tv;
        }
    }
}
