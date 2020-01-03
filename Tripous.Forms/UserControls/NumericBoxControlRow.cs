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
    /// NumericUpDown box <see cref="ControlRow"/>
    /// </summary>
    public partial class NumericBoxControlRow : ControlRow
    {
        /// <summary>
        /// Returns the value of the <see cref="Value"/> property
        /// </summary>
        protected override object GetValue()
        {
            return edtNumericUpDown.Value;
        }
        /// <summary>
        /// Sets the value of the <see cref="Value"/> property
        /// </summary>
        protected override void SetValue(object V)
        {
            try
            {
                if (V.GetType().IsAssignableFrom(typeof(decimal)))
                {
                    edtNumericUpDown.Value = Convert.ToDecimal(V);
                }
            }
            catch
            {
            }
            
        }

        /// <summary>
        /// The name of the property to bind to
        /// </summary>
        protected override string BindPropertyName { get { return "Value"; } }

        /* constructor */
        /// <summary>
        /// Constructor
        /// </summary>
        public NumericBoxControlRow()
        {
            InitializeComponent();

            this.Control = edtNumericUpDown;
        }
    }
}
