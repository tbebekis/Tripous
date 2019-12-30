/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Tripous.Forms
{
    /// <summary>
    /// A PictureBox
    /// </summary>
    [ToolboxBitmap(typeof(PictureBox))]
    public class PictureBoxEx : PictureBox
    {
 
        /* private */
        void Box_DoubleClick(object sender, EventArgs e)
        {
            (sender as Control).GetParentForm().Close();
        }


        /* overrides */
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnDoubleClick(EventArgs e)
        {
            if (!DoubleClickDialog)
            {
                base.OnDoubleClick(e);
            }
            else
            {
                if (this.Image != null)
                {
                    using (PopUpForm F = PopUpForm.Picture(this.Image))
                    {
                        if (F.ShowDialog() == DialogResult.OK)
                        {
                            this.Image = F.FormResult as Image;
                        }
                    }
                }
                else
                {
                    this.LoadFromFile();
                }
            }
        }



        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public PictureBoxEx()
            : base()
        {
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DoubleClickDialog = true;
        }




        /* properties */
        /// <summary>
        /// When true, the default, double-clicking the control displays a dialog with the image
        /// </summary>
        [DefaultValue(true), Description("When true, the default, double-clicking the control displays a dialog with the image")]
        public bool DoubleClickDialog { get; set; }
    }
}
