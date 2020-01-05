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
        /// <summary>
        /// True when is a control row with a multiline control, such as grid, list box, etc
        /// </summary>
        protected override bool IsMultiLine { get { return true; } }


        /* constructor */
        /// <summary>
        /// Constructor
        /// </summary>
        public TreeViewControlRow()
        {
            InitializeComponent();

            this.Control = tv;
        }

        /* properties */
        /// <summary>
        /// The control
        /// </summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TreeView TreeView { get { return tv; } }
    }
}
