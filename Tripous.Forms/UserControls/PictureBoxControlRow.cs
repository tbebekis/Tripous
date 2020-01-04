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
    /// A <see cref="PictureBoxEx"/> <see cref="ControlRow"/>
    /// </summary>
    public partial class PictureBoxControlRow : ControlRow
    {
        ImageContextMenu mnuImage = new ImageContextMenu();


        /// <summary>
        /// Called on a property change
        /// </summary>
        protected override void OnReadOnlyChanged()
        {
            if (Control != null)
            {
                picBox.ContextMenuStrip = !ReadOnly? mnuImage: null;
            }
        }
        /// <summary>
        /// Returns the value of the <see cref="Value"/> property
        /// </summary>
        protected override object GetValue()
        {
            return null;
        }
        /// <summary>
        /// Sets the value of the <see cref="Value"/> property
        /// </summary>
        protected override void SetValue(object V)
        {
            if (!ReadOnly && (Sys.IsNull(V) || V is Image))
            {
                picBox.Image = V as Image;
            }
        }

        /// <summary>
        /// The name of the property to bind to
        /// </summary>
        protected override string BindPropertyName { get { return "Image"; } }

        /* constructor */
        /// <summary>
        /// Constructor
        /// </summary>
        public PictureBoxControlRow()
        {
            InitializeComponent();

            this.Control = picBox;
            picBox.ContextMenuStrip = mnuImage;
        }



        /* properties */
        /// <summary>
        /// The image display mode
        /// </summary>
        [DefaultValue(PictureBoxSizeMode.Zoom)] 
        public PictureBoxSizeMode SizeMode
        {
            get { return picBox.SizeMode; }
            set { picBox.SizeMode = value; }
        }
        /// <summary>
        /// When true, the default, double-clicking the control displays a dialog with the image
        /// </summary>
        [DefaultValue(true), Description("When true, the default, double-clicking the control displays a dialog with the image")]
        public bool DoubleClickDialog
        {
            get { return picBox.DoubleClickDialog; }
            set { picBox.DoubleClickDialog = value; }
        }

        /// <summary>
        /// The control
        /// </summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PictureBoxEx Box { get { return picBox; } }
    }
}
