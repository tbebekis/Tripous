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
    public class UiColumnControlDesigner : ParentControlDesigner
    {
        /* private */
        bool Initializing;
        bool fDisableDrawGrid;

        DesignerVerbCollection verbs;
        DesignerVerb verbMoveColumnDown;
        DesignerVerb verbMoveColumnUp;

        IUiControlRow SelectedChild;
 
        UiColumn Widget { get { return Control as UiColumn; } }

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
            DesignerVerb Verb = sender as DesignerVerb;
            if (Verb.Text.StartsWith("Add ", StringComparison.InvariantCultureIgnoreCase))
            {
                string Key = Verb.Text;
                if (Key.Length > "Add ".Length)
                    Key = Key.Remove(0, "Add ".Length);

                if (UiControlRows.Types.ContainsKey(Key))
                {
                    ExecTrans((DesignerHost) => {
                        Type T = UiControlRows.Types[Key];
                        Control Child = DesignerHost.CreateComponent(T) as Control;
                        Widget.Controls.Add(Child);
                        Child.BringToFront();
                    });
                }
            }
            else if (verbMoveColumnUp == sender || verbMoveColumnDown == sender)
            {
                UiGroup ParentWidget = Widget.Parent as UiGroup;
                UiGroupControlDesigner ParentDesigner = GetParentControlDesigner() as UiGroupControlDesigner;
                if (ParentWidget != null && ParentDesigner != null)
                {
                    bool Down = verbMoveColumnDown == sender;
                    ParentDesigner.MoveChild(this.Widget, Down);
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
                IUiControlRow Child;
                foreach (object Item in SelectedComponents)
                {
                    Child = UiControlRow.ParentRowOf(Item as Control);
                    if ((Child != null) && ((Child as Control).Parent == Widget))
                    {
                        SelectedChild = Child;
                        break;
                    }
                }
            }
        }
        void EnableCommands()
        {
            if (this.Control != null && verbMoveColumnUp != null)
            {
                //verbRemove.Enabled = Widget != null && SelectedChild != null;

                IList ParentList = Widget != null && (Widget.Parent as UiGroup) != null ? (Widget.Parent as UiGroup).Columns : null;
                verbMoveColumnUp.Enabled = ParentList != null && ParentList.IndexOf(this.Widget) > 0;
                verbMoveColumnDown.Enabled = ParentList != null && ParentList.IndexOf(this.Widget) <= ParentList.Count - 2;
            }
        }

        UiControlRowControlDesigner GetSelectedChildDesigner()
        {
            if (SelectedChild != null)
            {
                IDesignerHost DesignerHost = GetService(typeof(IDesignerHost)) as IDesignerHost;
                if (DesignerHost != null)
                    return DesignerHost.GetDesigner(SelectedChild as Control) as UiControlRowControlDesigner;
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
        /// Called when the control that the designer is managing has painted its surface
        /// so the designer can paint any additional adornments on top of the control.
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
            UiControlRowControlDesigner Designer = this.GetSelectedChildDesigner();
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
            UiControlRowControlDesigner Designer = this.GetSelectedChildDesigner();
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
            UiControlRowControlDesigner Designer = this.GetSelectedChildDesigner();
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
                UiControlRowControlDesigner Designer = this.GetSelectedChildDesigner();
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
            UiControlRowControlDesigner Designer = this.GetSelectedChildDesigner();
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
        public UiColumnControlDesigner()
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

            foreach (var Entry in UiControlRows.Types)            
            {
                DesignerVerb Verb = new DesignerVerb("Add " + Entry.Key, AnyClick);
                verbs.Add(Verb);
            }

            verbMoveColumnUp = new DesignerVerb("Move Column Up", AnyClick);
            verbMoveColumnDown = new DesignerVerb("Move Column Down", AnyClick);
            verbs.Add(verbMoveColumnUp);
            verbs.Add(verbMoveColumnDown);            

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
                // nothing initially
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
            return ((control is IUiControlRow) && !this.Control.Contains(control));
        }
        /// <summary>
        /// Indicates if this designer's control can be parented by the control of the
        /// specified designer.
        /// </summary>
        public override bool CanBeParentedTo(IDesigner parentDesigner)
        {
            return ((parentDesigner != null) && (parentDesigner.Component is UiGroup));
        }

        /// <summary>
        /// Moves a child up or down, eventually changing the Z-Order
        /// </summary>
        public void MoveChild(IUiControlRow Child, bool Down)
        {
            if (Child != null)
            {
                int Index = this.Widget.Rows.IndexOf(Child);

                if (Index < 0 || (Down && Index >= Widget.Rows.Count - 1) || (!Down && Index <= 0))
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
                    return this.Control.Parent is UiGroup ? SelectionRules.None : SelectionRules.AllSizeable;
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
