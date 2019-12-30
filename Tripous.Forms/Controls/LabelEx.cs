/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Tripous.Forms
{

    /// <summary>
    /// A Label
    /// </summary>
    [ToolboxBitmap(typeof(Label))]
    public class LabelEx : Label 
    {
        /* private */
        private void AdjustLeftPosition(int OldRightPosition)
        {
            if (AutoSize && Bf.Member(TextAlign, ContentAlignment.BottomRight | ContentAlignment.MiddleRight | ContentAlignment.TopRight))
                Left = Left - (Width - OldRightPosition);
        }
        /* overrides */
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);

            AdjustLeftPosition(ClientRectangle.Right);
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            AdjustLeftPosition(ClientRectangle.Right);
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);

            AdjustLeftPosition(ClientRectangle.Right);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public LabelEx()
            : base()
        {
            this.TextAlign = ContentAlignment.MiddleRight;
        }

         /* overrides */
        /// <summary>
        /// Override
        /// </summary>
        public override string Text
        {
            get { return base.Text; }
            set
            {
                bool firstTime = /*!this.DesignMode && */ (Parent != null) && string.IsNullOrEmpty(base.Text);

                int R = ClientRectangle.Right;

                base.Text = value;

                if (!firstTime)
                    AdjustLeftPosition(R);
            }
        }
        /// <summary>
        /// Override
        /// </summary>
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                int R = ClientRectangle.Right;
                base.Font = value;
                AdjustLeftPosition(R);
            }
        } 
        /// <summary>
        /// Override
        /// </summary>
        public override bool AutoSize
        {
            get { return base.AutoSize; }
            set
            {
                if (value != base.AutoSize)
                {
                    int R = ClientRectangle.Right;
                    base.AutoSize = value;
                    AdjustLeftPosition(R);
                }
            }
        }
 
    }
}
