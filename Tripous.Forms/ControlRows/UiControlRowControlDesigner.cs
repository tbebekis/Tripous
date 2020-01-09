using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms.Design;
using System.Windows.Forms.Design.Behavior;
using System.ComponentModel.Design;
using System.Drawing.Drawing2D;

namespace Tripous.Forms
{

    /// <summary>
    /// Control designer
    /// </summary>
    public class UiControlRowControlDesigner : ControlDesigner
    {  
        
        /* private */
        bool Initializing;

        DesignerVerbCollection verbs;
        DesignerVerb verbMoveRowDown;
        DesignerVerb verbMoveRowUp;

        IUiControlRow Widget { get { return Control as IUiControlRow; } }

        /* event handlers */
        void ExecTrans(Action<IDesignerHost> Proc)
        {
            if (Widget != null && Proc != null)
            {
                IDesignerHost DesignerHost = (IDesignerHost)this.GetService(typeof(IDesignerHost));
                if (DesignerHost != null)
                {

                    using (DesignerTransaction Trans = DesignerHost.CreateTransaction())
                    {
                        try
                        {
                            MemberDescriptor ControlsProp = TypeDescriptor.GetProperties(Widget)["Controls"];

                            if (!Initializing)
                            {
                                base.RaiseComponentChanging(ControlsProp);
                            }

                            Proc(DesignerHost);

                            if (!Initializing)
                            {
                                base.RaiseComponentChanged(ControlsProp, null, null);
                            }

                            Trans.Commit();
                        }
                        catch
                        {
                            Trans.Cancel();
                            throw;
                        }
                    }
                }
            }
        }
        void AnyClick(object sender, EventArgs e)
        {
            if (verbMoveRowUp == sender || verbMoveRowDown == sender)
            {
                UiColumn ParentWidget = Widget.Parent as UiColumn;
                UiColumnControlDesigner ParentDesigner = GetParentControlDesigner() as UiColumnControlDesigner;
                if (ParentWidget != null && ParentDesigner != null)
                {
                    bool Down = verbMoveRowDown == sender;
                    ParentDesigner.MoveChild(this.Widget, Down);
                }
            }
        }

        /* private */
        void EnableCommands()
        {
            if (this.Control != null && verbMoveRowUp != null)
            {
                //verbRemove.Enabled = Widget != null && SelectedChild != null;

                IList ParentList = Widget != null && (Widget.Parent as UiColumn) != null ? (Widget.Parent as UiColumn).Rows : null;
                verbMoveRowUp.Enabled = ParentList != null && ParentList.IndexOf(this.Widget) > 0;
                verbMoveRowDown.Enabled = ParentList != null && ParentList.IndexOf(this.Widget) <= ParentList.Count - 2;
            }
        }
        IDesigner GetParentControlDesigner()
        {
            IDesignerHost DesignerHost = GetService(typeof(IDesignerHost)) as IDesignerHost;

            if ((Widget != null) && (Widget.Parent != null) && (DesignerHost != null))
                return DesignerHost.GetDesigner(Control.Parent);

            return null;
        }

        /* overrides */
        /// <summary>
        /// override
        /// </summary>
        protected override void OnPaintAdornments(PaintEventArgs pe)
        {
            //base.OnPaintAdornments(pe);
            ControlPaint.DrawFocusRectangle(pe.Graphics, this.Control.ClientRectangle);
        }

        /* constructor */
        /// <summary>
        /// Constructor
        /// </summary>
        public UiControlRowControlDesigner()
        {
        }

        /* internal - to be called by the parent Designer */
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

        /* public overrides */
        /// <summary>
        /// override
        /// </summary>
        public override void Initialize(IComponent component)
        {
            base.Initialize(component);

            base.AutoResizeHandles = true;

            // verbs
            verbs = new DesignerVerbCollection();
 
            verbMoveRowUp = new DesignerVerb("Move Row Up", AnyClick);
            verbMoveRowDown = new DesignerVerb("Move Row Down", AnyClick);
            verbs.Add(verbMoveRowUp);
            verbs.Add(verbMoveRowDown);
        }
        /// <summary>
        /// override
        /// </summary>
        public override void InitializeNewComponent(IDictionary defaultValues)
        {
            base.InitializeNewComponent(defaultValues);

            // initially add a column
            Initializing = true;
            try
            {
                // nothing initially
            }
            finally
            {
                Initializing = false;
            }

        }
        /// <summary>
        /// Indicates if this designer's control can be parented by the control of the
        /// specified designer.
        /// </summary>
        public override bool CanBeParentedTo(IDesigner parentDesigner)
        {
            return ((parentDesigner != null) && (parentDesigner.Component is UiColumn));
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
                    return this.Control.Parent is UiColumn ? SelectionRules.None : SelectionRules.AllSizeable;
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
                EnableCommands();
                return verbs;
            }
        }

    }
}
