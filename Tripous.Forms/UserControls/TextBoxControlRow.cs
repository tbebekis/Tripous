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
    /// Text box <see cref="ControlRow"/>
    /// </summary>
    public partial class TextBoxControlRow : ControlRow
    {
        /// <summary>
        /// Returns the value of the <see cref="Value"/> property
        /// </summary>
        protected override object GetValue()
        {
            return edtText.Text;
        }
        /// <summary>
        /// Sets the value of the <see cref="Value"/> property
        /// </summary>
        protected override void SetValue(object V)
        {
            edtText.Text = Sys.IsNull(V) ? null : V.ToString();
        }

        /// <summary>
        /// The name of the property to bind to
        /// </summary>
        protected override string BindPropertyName { get { return "Text"; } }

        /* constructor */
        /// <summary>
        /// Constructor
        /// </summary>
        public TextBoxControlRow()
        {
            InitializeComponent();

            this.Control = edtText;
        }


        /* properties */
        /// <summary>
        /// The control
        /// </summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TextBox Box { get { return edtText; } }
        /// <summary>
        /// The text of the edit box
        /// </summary>
        [DefaultValue(""), Localizable(false), Description("The text of the edit box.")]
        public string EditText
        {
            get { return edtText.Text; }
            set { edtText.Text = value; }
        }
    }
}
