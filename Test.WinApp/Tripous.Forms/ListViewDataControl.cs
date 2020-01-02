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
    /// ListView <see cref="DataControl"/>
    /// </summary>
    public partial class ListViewDataControl : DataControl
    {
        /* constructor */
        /// <summary>
        /// Constructor
        /// </summary>
        public ListViewDataControl()
        {
            InitializeComponent();

            this.Control = lv;
        }
    }
}
