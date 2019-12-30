/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Tripous.Forms 
{


 
    /// <summary>
    /// Indicates the appearance style of the Line control
    /// </summary>
    public enum LineDrawStyle
    {
        /// <summary>
        /// Just a flat line
        /// </summary>
        Flat,
        /// <summary>
        /// Inset
        /// </summary>
        Inset,
        /// <summary>
        /// Outset
        /// </summary>
        Outset
    }


    /// <summary>
    /// A Line control
    /// </summary>
    [Designer(typeof(LineDesigner))]
    public class LineControl : Control
    {
 

        #region control designer
        /// <summary>
        /// A designer for the control
        /// </summary>
        public class LineDesigner : ControlDesigner
        {
            /// <summary>
            /// Override
            /// </summary>
            public override SelectionRules SelectionRules
            {
                get
                {
                    return base.SelectionRules & ~(SelectionRules.TopSizeable | SelectionRules.BottomSizeable);
                }
            }
        }
        #endregion


        /* private */
        private LineDrawStyle drawStyle = LineDrawStyle.Outset;
 

        /* overrides */
        /// <summary>
        /// Override
        /// </summary>
        protected override Size DefaultSize { get { return new Size(160, 1); } }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            DashStyle dashStyle = DashStyle.Solid;

            Pen pen1 = null;
            Pen pen2 = null;


            if (drawStyle == LineDrawStyle.Flat)
            {
                pen1 = new Pen(FlatColor.IsEmpty? Color.Silver: FlatColor, 1);
                pen1.DashStyle = dashStyle;
            }
            else if (drawStyle == LineDrawStyle.Inset)
            {
                pen1 = new Pen(SystemColors.ControlLightLight, 1);
                pen2 = new Pen(SystemColors.ControlDark, 1);
                pen1.DashStyle = dashStyle;
                pen2.DashStyle = dashStyle;
            }
            else if (drawStyle == LineDrawStyle.Outset)
            {
                pen1 = new Pen(SystemColors.ControlDark, 1);
                pen2 = new Pen(SystemColors.ControlLightLight, 1);
                pen1.DashStyle = dashStyle;
                pen2.DashStyle = dashStyle;
            }

            if (drawStyle == LineDrawStyle.Flat)
            {
                e.Graphics.DrawLine(pen1, 0, 0, Width - 1, 0);
            }
            else   
            {
                e.Graphics.DrawLine(pen2, 0, 0, Width - 1, 0);
                e.Graphics.DrawLine(pen1, 0, 1, Width - 1, 1);
            }

            if (pen1 != null)
                pen1.Dispose();
            if (pen2 != null)
                pen2.Dispose();
         
            
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }



        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public LineControl()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;


            base.TabStop = false;
            FlatColor = Color.Silver;
        }



        /* properties */
        /// <summary>
        /// The appearance style of the line
        /// </summary>
        [DefaultValue(LineDrawStyle.Outset), Description("The appearance style of the line")]
        public LineDrawStyle DrawStyle
        {
            get
            {
                return drawStyle;
            }
            set
            {
                if (value != drawStyle)
                {
                    drawStyle = value;
                    Invalidate();
                }
            }
        }
        /// <summary>
        /// Override
        /// </summary>
        [Browsable(false)]
        public new int TabIndex
        {
            get
            {
                return base.TabIndex;
            }
            set
            {
                base.TabIndex = value;
            }
        }
        /// <summary>
        /// Override
        /// </summary>
        [Browsable(false)]
        public new bool TabStop
        {
            get
            {
                return false;
            }
            set
            {               
            }
        }
        /// <summary>
        /// Override
        /// </summary>
        [Browsable(false)]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
            }
        }
        /// <summary>
        /// Override
        /// </summary>
        [Browsable(false)]
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }
        /// <summary>
        /// The line color when DrawStyle is Flat
        /// </summary>
        [DefaultValue(typeof(Color), "Silver"), Description("The line color when DrawStyle is Flat")]
        public Color FlatColor { get; set; }

    }





}
