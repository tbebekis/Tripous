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
        /* constructor */
        /// <summary>
        /// Constructor
        /// </summary>
        public ListViewControlRow()
        {
            InitializeComponent();

            this.Control = lv;
        }
    }
}
