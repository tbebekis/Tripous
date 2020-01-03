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
    /// TreeView <see cref="ControlRow"/>
    /// </summary>
    public partial class TreeViewControlRow : ControlRow
    {

        /* constructor */
        /// <summary>
        /// Constructor
        /// </summary>
        public TreeViewControlRow()
        {
            InitializeComponent();

            this.Control = tv;
        }
    }
}
