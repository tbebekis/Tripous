/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tripous.Forms
{
    /// <summary>
    /// Represents a Windows picture box control for displaying an image.
    /// </summary>
    [ToolboxBitmap(typeof(PictureBox))]
    public class PictureBoxButton : PictureBox
    {
        /* overrides */
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            base.BackColor = ControlPaint.Light(this.Parent.BackColor);
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            base.BackColor = System.Drawing.Color.Transparent;
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            base.BackColor = ControlPaint.Dark(this.Parent.BackColor);
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            base.BackColor = System.Drawing.Color.Transparent;
        }

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary> 
        public PictureBoxButton()
        {
            Size = new System.Drawing.Size(16, 16);
            base.SizeMode = PictureBoxSizeMode.StretchImage;
            base.BackColor = System.Drawing.Color.Transparent;
            base.BorderStyle = System.Windows.Forms.BorderStyle.None; 
            base.TabIndex = 0;
            base.TabStop = false;
        }

        /* properties */
        /// <summary>
        /// Indicates how the image is displayed.
        /// </summary>
        [Browsable(false), DefaultValue(typeof(PictureBoxSizeMode), "StretchImage")]
        public new PictureBoxSizeMode SizeMode
        {
            get { return PictureBoxSizeMode.StretchImage; }
            set { }
        }
        /// <summary>
        /// Gets or sets the background color for the control.
        /// </summary>
        [Browsable(false), DefaultValue(typeof(Color), "Transparent")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set { }
        }
        /// <summary>
        /// Indicates the border style for the control.
        /// </summary>
        [Browsable(false), DefaultValue(typeof(System.Windows.Forms.BorderStyle), "None")]
        public new BorderStyle BorderStyle
        {
            get { return System.Windows.Forms.BorderStyle.None; }
            set { }
        }
        /// <summary>
        /// Gets or sets the tab index value.
        /// </summary>
        [Browsable(false), DefaultValue(0)]
        public new int TabIndex
        {
            get { return base.TabIndex; }
            set { base.TabIndex = value; }
        }
        /// <summary>
        /// Gets or sets a value that indicates whether the user can give the focus to
        /// this control by using the TAB key.
        /// </summary>
        [Browsable(false), DefaultValue(false)]
        public new bool TabStop
        {
            get { return base.TabStop; }
            set { base.TabStop = value; }
        }
    }
}
