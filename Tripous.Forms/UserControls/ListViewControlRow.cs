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
    /// ListView <see cref="ControlRow"/>
    /// </summary>
    public partial class ListViewControlRow : ControlRow
    {
        /// <summary>
        /// True when is a control row with a multiline control, such as grid, list box, etc
        /// </summary>
        protected override bool IsMultiLine { get { return true; } }

        /* constructor */
        /// <summary>
        /// Constructor
        /// </summary>
        public ListViewControlRow()
        {
            InitializeComponent();

            this.Control = lv;
        }

        /* properties */
        /// <summary>
        /// The control
        /// </summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ListView ListView { get { return lv; } }
    }
}
