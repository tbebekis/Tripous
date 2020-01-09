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
    public class UiGroupContainerControlDesigner : ParentControlDesigner
    {
        bool Initializing;
        bool fDisableDrawGrid;

        DesignerVerbCollection verbs;
        DesignerVerb verbAdd;
        DesignerVerb verbRemove;
 

        UiGroup SelectedChild;

        UiGroupContainer Widget { get { return Control as UiGroupContainer; } }

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
            if (Widget == null)
                return;

            if (verbAdd == sender)
            {
                ExecTrans((DesignerHost) => {
                    Control Child = DesignerHost.CreateComponent(typeof(UiGroup)) as Control;
                    Widget.Controls.Add(Child as UiGroup);
                });
            }
            else if (verbRemove == sender)
            {
                if (Widget.Groups.Count != 0 && SelectedChild != null)
                {
                    ExecTrans((DesignerHost) => {
                        DesignerHost.DestroyComponent(SelectedChild);
                        Widget.Controls.Remove(SelectedChild);
                        SelectedChild = null;
                    });
                }
            }
 
        }



        /* private */
        void ComponentChangeService_ComponentChanged(object sender, ComponentChangedEventArgs e)
        {
            EnableCommands();
        }
        void SelectionService_SelectionChanged(object sender, EventArgs e)
        {
            ISelectionService SelectionService = this.GetService(typeof(ISelectionService)) as ISelectionService;

            if (SelectionService != null)
            {
                ICollection SelectedComponents = SelectionService.GetSelectedComponents();

                SelectedChild = null;
                UiGroup Child;
                foreach (object Item in SelectedComponents)
                {
                    Child = UiGroup.ParentOf(Item as Control);
                    if ((Child != null) && (Child.Parent == Widget))
                    {
                        SelectedChild = Child;
                        break;
                    }
                }
            }
        }
        void EnableCommands()
        {
            if (this.Control != null && this.verbRemove != null)
            {
                verbRemove.Enabled = Widget != null && SelectedChild != null;
            }
        }

        UiGroupControlDesigner GetSelectedChildDesigner()
        {
            if (SelectedChild != null)
            {
                IDesignerHost DesignerHost = GetService(typeof(IDesignerHost)) as IDesignerHost;
                if (DesignerHost != null)
                    return DesignerHost.GetDesigner(SelectedChild) as UiGroupControlDesigner;
            }

            return null;
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ISelectionService SelectionService = this.GetService(typeof(ISelectionService)) as ISelectionService;
                if (SelectionService != null)
                {
                    SelectionService.SelectionChanged -= new EventHandler(this.SelectionService_SelectionChanged);
                }

                IComponentChangeService ComponentChangeService = this.GetService(typeof(IComponentChangeService)) as IComponentChangeService;
                if (ComponentChangeService != null)
                {
                    ComponentChangeService.ComponentChanged -= new ComponentChangedEventHandler(this.ComponentChangeService_ComponentChanged);
                }
            }

            base.Dispose(disposing);
        }
        /// <summary>
        /// override
        /// </summary>
        protected override void OnPaintAdornments(PaintEventArgs pe)
        {
            this.fDisableDrawGrid = true;
            try
            {
                //base.OnPaintAdornments(pe);
                ControlPaint.DrawFocusRectangle(pe.Graphics, this.Control.ClientRectangle);
            }
            finally
            {
                this.fDisableDrawGrid = false;
            }
        }

        /// <summary>
        /// override
        /// </summary>
        protected override void OnDragDrop(DragEventArgs de)
        {
            UiGroupControlDesigner Designer = this.GetSelectedChildDesigner();
            if (Designer != null)
            {
                Designer.OnDragDropInternal(de);
            }
        }
        /// <summary>
        /// override
        /// </summary>
        protected override void OnDragEnter(DragEventArgs de)
        {
            UiGroupControlDesigner Designer = this.GetSelectedChildDesigner();
            if (Designer != null)
            {
                Designer.OnDragEnterInternal(de);
            }
        }
        /// <summary>
        /// override
        /// </summary>
        protected override void OnDragLeave(EventArgs e)
        {
            UiGroupControlDesigner Designer = this.GetSelectedChildDesigner();
            if (Designer != null)
            {
                Designer.OnDragLeaveInternal(e);
            }
        }
        /// <summary>
        /// override
        /// </summary>
        protected override void OnDragOver(DragEventArgs de)
        {
            Point P = Widget.PointToClient(new Point(de.X, de.Y));
            if (!Widget.ClientRectangle.Contains(P))
            {
                de.Effect = DragDropEffects.None;
            }
            else
            {
                UiGroupControlDesigner Designer = this.GetSelectedChildDesigner();
                if (Designer != null)
                {
                    Designer.OnDragOverInternal(de);
                }
            }
        }
        /// <summary>
        /// override
        /// </summary>
        protected override void OnGiveFeedback(GiveFeedbackEventArgs e)
        {
            UiGroupControlDesigner Designer = this.GetSelectedChildDesigner();
            if (Designer != null)
            {
                Designer.OnGiveFeedbackInternal(e);
            }
        }

        /* properties */
        /// <summary>
        /// override
        /// </summary>
        protected override bool AllowControlLasso { get { return false; } }
        /// <summary>
        /// override
        /// </summary>
        protected override bool DrawGrid { get { return fDisableDrawGrid ? false : base.DrawGrid; } }


        /* constructor */
        /// <summary>
        /// Constructor
        /// </summary>
        public UiGroupContainerControlDesigner()
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

        /* public */
        /// <summary>
        /// override
        /// </summary>
        public override void Initialize(IComponent component)
        {
            base.Initialize(component);

            base.AutoResizeHandles = true;

            // verbs
            this.verbAdd = new DesignerVerb("Add Group", new EventHandler(AnyClick));
            this.verbRemove = new DesignerVerb("Remove Group", new EventHandler(AnyClick));

            this.verbs = new DesignerVerbCollection();
            this.verbs.Add(verbAdd);
            this.verbs.Add(verbRemove);

            // services
            ISelectionService SelectionService = this.GetService(typeof(ISelectionService)) as ISelectionService;
            if (SelectionService != null)
            {
                SelectionService.SelectionChanged += new EventHandler(this.SelectionService_SelectionChanged);
            }
            IComponentChangeService ComponentChangeService = this.GetService(typeof(IComponentChangeService)) as IComponentChangeService;
            if (ComponentChangeService != null)
            {
                ComponentChangeService.ComponentChanged += new ComponentChangedEventHandler(this.ComponentChangeService_ComponentChanged);
            }

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
                this.AnyClick(verbAdd, EventArgs.Empty);

                MemberDescriptor ControlsProp = TypeDescriptor.GetProperties(base.Component)["Controls"];
                base.RaiseComponentChanging(ControlsProp);
                base.RaiseComponentChanged(ControlsProp, null, null);
            }
            finally
            {
                Initializing = false;
            }

        }
        /// <summary>
        /// override
        /// </summary>
        public override bool CanParent(Control control)
        {
            return ((control is UiGroup) && !this.Control.Contains(control));
        }
        /// <summary>
        /// Indicates if this designer's control can be parented by the control of the
        /// specified designer.
        /// </summary>
        public override bool CanBeParentedTo(IDesigner parentDesigner)
        {
            return (parentDesigner != null);
        }

        /// <summary>
        /// Moves a child up or down, eventually changing the Z-Order
        /// </summary>
        public void MoveChild(UiGroup Child, bool Down)
        {
            if (Child != null)
            {
                int Index = this.Widget.Groups.IndexOf(Child);

                if (Index < 0 || (Down && Index >= Widget.Groups.Count - 1) || (!Down && Index <= 0))
                {
                    return;
                }

                int IndexB = Down ? Index + 1 : Index - 1;

                ExecTrans((DesignerHost) => {
                    Widget.Exchange(Index, IndexB);
                });
            }
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
                    return SelectionRules.AllSizeable;
                }

                return base.SelectionRules;
            }
        }
        /// <summary>
        /// override
        /// </summary>
        public override DesignerVerbCollection Verbs
        {
            get
            {
                EnableCommands();
                return this.verbs;
            }
        }
        /// <summary>
        /// override
        /// </summary>
        public override bool ParticipatesWithSnapLines
        {
            get
            {
                ControlDesigner Designer = this.GetSelectedChildDesigner();
                if (Designer != null)
                {
                    return Designer.ParticipatesWithSnapLines;
                }
                return true;
            }
        }

    }
}
