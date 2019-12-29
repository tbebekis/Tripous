/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.Design.Behavior;

namespace Tripous.Windows.Forms
{


    /// <summary>
    /// The ControlDesigner of the Pager control. It displays the Add and Remove page verbs.
    /// </summary>
    public class PagerPageDesigner : ScrollableControlDesigner
    {
        /* private */
        private Page Page { get { return Control as Page; } }
        private Pen GetBorderPen()
        {
            Color color = (this.Control.BackColor.GetBrightness() < 0.5) ? ControlPaint.Light(this.Control.BackColor) : ControlPaint.Dark(this.Control.BackColor);
            Pen pen = new Pen(color);
            pen.DashStyle = DashStyle.Dash;
            return pen;
        }
        private void DrawBorder(Graphics graphics)
        {
            //*
            if ((Page != null) && Page.Visible)
            {
                using (Pen Pen = GetBorderPen())
                {
                    Rectangle R = Page.ClientRectangle;
                    R.Width--;
                    R.Height--;
                    graphics.DrawRectangle(Pen, R);
                }
            }
            //*/
        }
        private PagerDesigner GetParentControlDesigner()
        {
            IDesignerHost DesignerHost = GetService(typeof(IDesignerHost)) as IDesignerHost;

            if ((Page != null) && (Page.Parent != null) && (DesignerHost != null))
                return DesignerHost.GetDesigner(Control.Parent) as PagerDesigner;

            return null;
        }

        /* overrides */
        /// <summary>
        /// Called when the control that the designer is managing has painted its surface
        /// so the designer can paint any additional adornments on top of the control.
        /// </summary>
        protected override void OnPaintAdornments(PaintEventArgs pe)
        {
            if (Page != null)
            {
                if (Page.BorderStyle == BorderStyle.None)
                    this.DrawBorder(pe.Graphics);
            }
            base.OnPaintAdornments(pe);
        }
        /// <summary>
        /// Provides an opportunity to change the current mouse cursor.
        /// </summary>
        protected override ControlBodyGlyph GetControlGlyph(GlyphSelectionType selectionType)
        {
            this.OnSetCursor();
            return new ControlBodyGlyph(Rectangle.Empty, Cursor.Current, this.Control, this);
        }
        /// <summary>
        /// Indicates if this designer's control can be parented by the control of the
        /// specified designer.
        /// </summary>
        public override bool CanBeParentedTo(IDesigner parentDesigner)
        {
            return ((parentDesigner != null) && (parentDesigner.Component is Pager));
        }

        /* constructor */
        /// <summary>
        /// Constructor
        /// </summary>
        public PagerPageDesigner()
        {
            base.AutoResizeHandles = true;
        }

        /* internal - to be called by the PagerDesigner */
        internal void OnDragDropInternal(DragEventArgs de)
        {
            this.OnDragDrop(de);
        }
        internal void OnDragEnterInternal(DragEventArgs de)
        {
            this.OnDragEnter(de);
        }
        internal void OnDragLeaveInternal(EventArgs e)
        {
            this.OnDragLeave(e);
        }
        internal void OnDragOverInternal(DragEventArgs e)
        {
            this.OnDragOver(e);
        }
        internal void OnGiveFeedbackInternal(GiveFeedbackEventArgs e)
        {
            this.OnGiveFeedback(e);
        }

        /* properties */
        /// <summary>
        /// Gets the selection rules that indicate the movement capabilities of a component.
        /// </summary>
        public override SelectionRules SelectionRules
        {
            get
            {
                if (Control != null)
                {
                    SelectionRules Result = base.SelectionRules;
                    if (this.Control.Parent is Pager)
                        Result &= ~SelectionRules.AllSizeable;
                    return Result;
                }

                return base.SelectionRules;
            }
        }
        /// <summary>
        /// Gets the collection of verbs to be associated with the designer.
        /// </summary>
        public override DesignerVerbCollection Verbs
        {
            get
            {
                DesignerVerbCollection Result = new DesignerVerbCollection();

                foreach (DesignerVerb Verb in base.Verbs)
                    Result.Add(Verb);

                PagerDesigner parentDesigner = GetParentControlDesigner();

                if (parentDesigner != null)
                {
                    foreach (DesignerVerb Verb in parentDesigner.Verbs)
                        Result.Add(Verb);
                }

                return Result;
            }
        }
    }

}
