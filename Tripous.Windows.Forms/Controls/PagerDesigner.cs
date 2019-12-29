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
    /// A ControlDesigner for the Page control.
    /// </summary>
    public class PagerDesigner : ParentControlDesigner
    {
        private bool addingOnInitialize;
        private bool disableDrawGrid;
        private DesignerVerb verbRemove;
        //private bool isPagerSelected;
        private DesignerVerbCollection verbs;


        /* private methods */
        private void VerbAdd_Click(object sender, EventArgs e)
        {
            IDesignerHost DesignerHost = (IDesignerHost)this.GetService(typeof(IDesignerHost));
            if (DesignerHost != null)
            {
                DesignerTransaction Transaction = null;
                try
                {
                    try
                    {
                        Transaction = DesignerHost.CreateTransaction("Tripous_Pager_AddPage");
                    }
                    catch (CheckoutException Ex)
                    {
                        if (Ex != CheckoutException.Canceled)
                        {
                            throw Ex;
                        }
                        return;
                    }


                    MemberDescriptor ControlsProp = TypeDescriptor.GetProperties(Pager)["Controls"];
                    Page Page = DesignerHost.CreateComponent(typeof(Page)) as Page;
                    if (!this.addingOnInitialize)
                    {
                        base.RaiseComponentChanging(ControlsProp);
                    }

                    Page.Padding = new Padding(3);


                    string S = null;
                    PropertyDescriptor NameProp = TypeDescriptor.GetProperties(Page)["Name"];
                    if ((NameProp != null) && (NameProp.PropertyType == typeof(string)))
                    {
                        S = (string)NameProp.GetValue(Page);
                    }


                    if (S != null)
                    {
                        PropertyDescriptor TitleProp = TypeDescriptor.GetProperties(Page)["Title"];
                        if (TitleProp != null)
                        {
                            TitleProp.SetValue(Page, S);
                        }
                    }

                    Pager.Add(Page);

                    if (!this.addingOnInitialize)
                    {
                        base.RaiseComponentChanged(ControlsProp, null, null);
                    }
                }
                finally
                {
                    if (Transaction != null)
                    {
                        Transaction.Commit();
                    }
                }
            }
        }
        private void VerbRemove_Click(object sender, EventArgs e)
        {
            if ((Pager != null) && (Pager.Pages.Count != 0))
            {
                MemberDescriptor ControlsProp = TypeDescriptor.GetProperties(Pager)["Controls"];
                Page SelectedPage = Pager.SelectedPage;
                IDesignerHost DesignerHost = this.GetService(typeof(IDesignerHost)) as IDesignerHost;
                if (DesignerHost != null)
                {
                    DesignerTransaction Transaction = null;
                    try
                    {
                        try
                        {
                            Transaction = DesignerHost.CreateTransaction("Tripous_Pager_RemovePage");
                            base.RaiseComponentChanging(ControlsProp);
                        }
                        catch (CheckoutException Ex)
                        {
                            if (Ex != CheckoutException.Canceled)
                            {
                                throw Ex;
                            }
                            return;
                        }

                        DesignerHost.DestroyComponent(SelectedPage);
                        base.RaiseComponentChanged(ControlsProp, null, null);
                        Pager.Remove(SelectedPage);
                    }
                    finally
                    {
                        if (Transaction != null)
                        {
                            Transaction.Commit();
                        }
                    }
                }
            }
        }
        private void ComponentChangeService_ComponentChanged(object sender, ComponentChangedEventArgs e)
        {
            EnableCommands();
        }
        private void Pager_ControlAdded(object sender, ControlEventArgs e)
        {
            if ((e.Control != null) && !e.Control.IsHandleCreated)
            {
                IntPtr handle = e.Control.Handle;
            }
        }
        private void SelectionService_SelectionChanged(object sender, EventArgs e)
        {
            ISelectionService SelectionService = this.GetService(typeof(ISelectionService)) as ISelectionService;
            //this.isPagerSelected = false;
            if (SelectionService != null)
            {
                ICollection SelectedComponents = SelectionService.GetSelectedComponents();

                foreach (object Item in SelectedComponents)
                {
                    if (Item == Pager)
                    {
                        //this.isPagerSelected = true;
                    }
                    Page ParentPage = Page.ParentPageOf(Item as Control);
                    if ((ParentPage != null) && (ParentPage.Parent == Pager))
                    {
                        //this.isPagerSelected = false;
                        Pager.SelectedPage = ParentPage;
                        break;
                    }
                }
            }
        }
        private void Pager_SelectedPageChanged(object sender, EventArgs e)
        {
            ISelectionService SelectionService = this.GetService(typeof(ISelectionService)) as ISelectionService;
            if (SelectionService != null)
            {
                ICollection SelectedComponents = SelectionService.GetSelectedComponents();
                bool Flag = false;
                foreach (object Item in SelectedComponents)
                {
                    Page ParentPage = Page.ParentPageOf(Item as Control);
                    if (((ParentPage != null) && (ParentPage.Parent == Pager)) && (ParentPage == Pager.SelectedPage))
                    {
                        Flag = true;
                        break;
                    }
                }
                if (!Flag)
                {
                    SelectionService.SetSelectedComponents(new object[] { base.Component });
                }
            }

            MemberDescriptor SelectedPageProperty = TypeDescriptor.GetProperties(Pager)["SelectedPage"];
            RaiseComponentChanged(SelectedPageProperty, null, null);
        }
        private void EnableCommands()
        {
            if (this.verbRemove != null)
            {
                this.verbRemove.Enabled = this.Control.Controls.Count > 0;
            }
        }
        private PagerPageDesigner GetSelectedPageDesigner()
        {
            if (Pager.SelectedPage != null)
            {
                IDesignerHost DesignerHost = GetService(typeof(IDesignerHost)) as IDesignerHost;
                if (DesignerHost != null)
                    return DesignerHost.GetDesigner(Pager.SelectedPage) as PagerPageDesigner;
            }

            return null;
        }

        /* private properties */
        private Pager Pager { get { return Control as Pager; } }


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

                if (Pager != null)
                {
                    Pager.SelectedPageChanged -= new EventHandler(this.Pager_SelectedPageChanged);
                    Pager.ControlAdded -= new ControlEventHandler(this.Pager_ControlAdded);
                }
            }
            base.Dispose(disposing);
        }
        /// <summary>
        /// override
        /// </summary>
        protected override void OnPaintAdornments(PaintEventArgs pe)
        {
            this.disableDrawGrid = true;
            try
            {
                base.OnPaintAdornments(pe);
            }
            finally
            {
                this.disableDrawGrid = false;
            }
        }
        /// <summary>
        /// override
        /// </summary>
        protected override void OnDragDrop(DragEventArgs de)
        {
            PagerPageDesigner pageDesigner = this.GetSelectedPageDesigner();
            if (pageDesigner != null)
            {
                pageDesigner.OnDragDropInternal(de);
            }
        }
        /// <summary>
        /// override
        /// </summary>
        protected override void OnDragEnter(DragEventArgs de)
        {
            PagerPageDesigner pageDesigner = this.GetSelectedPageDesigner();
            if (pageDesigner != null)
            {
                pageDesigner.OnDragEnterInternal(de);
            }
        }
        /// <summary>
        /// override
        /// </summary>
        protected override void OnDragLeave(EventArgs e)
        {
            PagerPageDesigner pageDesigner = this.GetSelectedPageDesigner();
            if (pageDesigner != null)
            {
                pageDesigner.OnDragLeaveInternal(e);
            }
        }
        /// <summary>
        /// override
        /// </summary>
        protected override void OnDragOver(DragEventArgs de)
        {
            Point P = Pager.PointToClient(new Point(de.X, de.Y));
            if (!Pager.ClientRectangle.Contains(P))
            {
                de.Effect = DragDropEffects.None;
            }
            else
            {
                PagerPageDesigner pageDesigner = this.GetSelectedPageDesigner();
                if (pageDesigner != null)
                {
                    pageDesigner.OnDragOverInternal(de);
                }
            }
        }
        /// <summary>
        /// override
        /// </summary>
        protected override void OnGiveFeedback(GiveFeedbackEventArgs e)
        {
            PagerPageDesigner pageDesigner = this.GetSelectedPageDesigner();
            if (pageDesigner != null)
            {
                pageDesigner.OnGiveFeedbackInternal(e);
            }
        }

        /// <summary>
        /// override
        /// </summary>
        public override void Initialize(IComponent component)
        {
            base.Initialize(component);
            base.AutoResizeHandles = true;

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
            if (Pager != null)
            {
                Pager.SelectedPageChanged += new EventHandler(this.Pager_SelectedPageChanged);
                Pager.ControlAdded += new ControlEventHandler(this.Pager_ControlAdded);
            }
        }
        /// <summary>
        /// override
        /// </summary>
        public override void InitializeNewComponent(IDictionary defaultValues)
        {
            base.InitializeNewComponent(defaultValues);

            addingOnInitialize = true;
            try
            {

                this.VerbAdd_Click(this, EventArgs.Empty);
            }
            finally
            {
                addingOnInitialize = false;
            }

            MemberDescriptor ControlsProp = TypeDescriptor.GetProperties(base.Component)["Controls"];
            base.RaiseComponentChanging(ControlsProp);
            base.RaiseComponentChanged(ControlsProp, null, null);

            if (Pager != null)
                Pager.SelectedPageIndex = 0;
        }
        /// <summary>
        /// override
        /// </summary>
        public override bool CanParent(Control control)
        {
            return ((control is Page) && !this.Control.Contains(control));
        }

        /* property overrides */
        /// <summary>
        /// override
        /// </summary>
        protected override bool AllowControlLasso { get { return false; } }
        /// <summary>
        /// override
        /// </summary>
        protected override bool DrawGrid { get { return disableDrawGrid ? false : base.DrawGrid; } }


        /// <summary>
        /// override
        /// </summary>
        public override bool ParticipatesWithSnapLines
        {
            get
            {
                PagerPageDesigner pageDesigner = this.GetSelectedPageDesigner();
                if (pageDesigner != null)
                {
                    return pageDesigner.ParticipatesWithSnapLines;
                }
                return true;
            }
        }
        /// <summary>
        /// override
        /// </summary>
        public override DesignerVerbCollection Verbs
        {
            get
            {
                if (this.verbs == null)
                {
                    this.verbRemove = new DesignerVerb("Remove page", new EventHandler(this.VerbRemove_Click));

                    this.verbs = new DesignerVerbCollection();
                    this.verbs.Add(new DesignerVerb("Add page", new EventHandler(this.VerbAdd_Click)));
                    this.verbs.Add(this.verbRemove);
                }
                if (this.Control != null)
                {
                    this.verbRemove.Enabled = this.Control.Controls.Count > 0;
                }
                return this.verbs;
            }
        }
    }
}
