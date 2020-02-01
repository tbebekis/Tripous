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
    /// DateTimePicker box <see cref="UiControlRow"/>
    /// </summary>
    public partial class DateBoxControlRow : UiControlRow
    {
        /// <summary>
        /// Returns the value of the <see cref="UiControlRow.Value"/> property
        /// </summary>
        protected override object GetValue()
        {
            return edtDateTimePicker.Value;
        }
        /// <summary>
        /// Sets the value of the <see cref="UiControlRow.Value"/> property
        /// </summary>
        protected override void SetValue(object V)
        {
            try
            {
                if (V.GetType().IsAssignableFrom(typeof(DateTime)))
                {
                    edtDateTimePicker.Value = Convert.ToDateTime(V);
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
        public DateBoxControlRow()
        {
            InitializeComponent();

            this.Control = edtDateTimePicker;
        }


        /// <summary>
        /// The control
        /// </summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTimePicker Box { get { return edtDateTimePicker; } }
    }
}
