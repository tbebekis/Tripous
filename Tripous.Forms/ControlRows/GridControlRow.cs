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
    /// <see cref="DataGridView"/> <see cref="UiControlRow"/>
    /// </summary>
    public partial class GridControlRow : UiControlRow, IUiGridControlRow
    {
        /// <summary>
        /// True when is a control row with a multiline control, such as grid, list box, etc
        /// </summary>
        protected override bool IsMultiLine { get { return true; } }

        /* constructor */
        /// <summary>
        /// Constructor
        /// </summary>
        public GridControlRow()
        {
            InitializeComponent();

            this.Control = GridControl;
        }

        /* properties */
        /// <summary>
        /// The control
        /// </summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataGridView Grid { get { return GridControl; } }
        /// <summary>
        /// The data source of the Control.
        /// </summary>
        [DefaultValue(null), Browsable(false), Description("The data source of the Control."), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override object DataSource
        {
            get { return Grid.DataSource; }
            set { Grid.DataSource = value; }
        }
    }
}
