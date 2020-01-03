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
    /// <see cref="DataGridView"/> <see cref="DataControl"/>
    /// </summary>
    public partial class GridViewDataControl : DataControl, IGridControlRow
    {

        /* constructor */
        /// <summary>
        /// Constructor
        /// </summary>
        public GridViewDataControl()
        {
            InitializeComponent();

            this.Control = Grid;
        }

        /* properties */
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
