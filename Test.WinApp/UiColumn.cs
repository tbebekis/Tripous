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

    //[ToolboxItem(false), DesignTimeVisible(false), Designer(typeof(UiColumnDesigner))] 

    /// <summary>
    /// A UI column
    /// </summary>
    [Designer(typeof(UiColumnDesigner))]
    public class UiColumn: Panel
    {
        bool Layouting;

        #region UiColumnCollection
        /// <summary>
        /// The collection of UiColumns
        /// </summary>
        public class ControlRowCollection : Collection<IControlRow>
        {
 
            /// <summary>
            /// Override
            /// </summary>
            protected override void InsertItem(int Index, IControlRow Item)
            {
                if (((Index >= 0) && (Index <= Count)) && (Item != null) && !Contains(Item))
                {
                    base.InsertItem(Index, Item);

                    if (Item.Parent != Owner)
                        Owner.Controls.Add(Item as Control);
                }
            }
            /// <summary>
            /// Override
            /// </summary>
            protected override void RemoveItem(int Index)
            {
                if ((Index >= 0) && (Index < Count))
                {
                    Owner.Controls.Remove(this[Index] as Control);
                    base.RemoveItem(Index);
                }
            }
            /// <summary>
            /// Override
            /// </summary>
            protected override void ClearItems()
            {
                this.Owner.RemoveAll();
                base.ClearItems();
            }

            /// <summary>
            /// Constructor.
            /// </summary>
            public ControlRowCollection(UiColumn Owner)
            {
                if (Owner == null)
                {
                    throw new ArgumentNullException("Owner");
                }

                this.Owner = Owner;
            }

 
            /// <summary>
            /// Adds UiColumns array to the collection.
            /// </summary>
            public void AddRange(IControlRow[] ControlRows)
            {
                if (ControlRows == null)
                {
                    throw new ArgumentNullException("ControlRows");
                }
                foreach (IControlRow Item in ControlRows)
                {
                    this.Add(Item);
                }
            }
            /// <summary>
            /// Finds a UiColumn by Name, if any, else null.
            /// </summary>
            public IControlRow Find(string Name)
            {
                foreach (IControlRow Item in this)
                    if (string.Compare(Name, Item.Name, StringComparison.InvariantCultureIgnoreCase) == 0)
                        return Item;

                return null;
            }
            /// <summary>
            /// Returns the index of UiColumn with Name, if any, else -1.
            /// </summary>
            public int IndexOf(string Name)
            {
                return IndexOf(Find(Name));
            }

            /// <summary>
            /// Gets the owner of this collection
            /// </summary>
            public UiColumn Owner { get; private set; }
        }
        #endregion


        #region UiColumnControlCollection
        /// <summary>
        /// An override of the Control.ControlCollection
        /// </summary>
        protected class UiColumnControlCollection : Control.ControlCollection
        {
            private UiColumn owner;

            /// <summary>
            /// Constructor
            /// </summary>
            public UiColumnControlCollection(UiColumn Owner)
                : base(Owner)
            {
                this.owner = Owner;
            }

            /// <summary>
            /// Adds the specified control to the control collection
            /// </summary>
            public override void Add(Control value)
            {
                bool Flag = value is IControlRow;

                if (!Flag)
                {
                    throw new ArgumentException("A UiColumn can not be a parent of any other control except of a IControlRow");
                }

                base.Add(value);

                if (value is UiColumn)
                {
                    ISite site = owner.Site;
                    if ((site != null) && (value.Site == null))
                    {
                        IContainer container = site.Container;
                        if (container != null)
                        {
                            container.Add(value);
                        }
                    }

                    if (!owner.Rows.Contains(value as IControlRow))
                        owner.Rows.Add(value as IControlRow);
                    owner.OnLayoutRows();
                }
            }
            /// <summary>
            /// Removes the specified control from the control collection
            /// </summary>
            public override void Remove(Control value)
            {
                base.Remove(value);
                owner.OnLayoutRows();
            }
        }
        #endregion
 
        const int DefaultHeight = 30;


        /* protected */
        /// <summary>
        /// Called when rows need recalculation
        /// </summary>
        protected virtual void OnLayoutRows()
        {
            //if (!Layouting)
            {
                Layouting = true;
                try
                {
                    IControlRow[] A = Rows.ToArray();
                    int H = 0;
                    foreach (var Row in A)
                    {
                        H += Row.Height;
                    }

                    H = DesignMode ? H + DefaultHeight : H;

                    System.Diagnostics.Debug.WriteLine($"Count = {A.Length}");
                    this.Height = H;

                    if (Parent is UiColumnContainer)
                    {
                        (Parent as UiColumnContainer).PerformLayout();
                    }
                }
                finally
                {
                    Layouting = false;
                }
            }
        }
        /// <summary>
        /// Removes all pages from the column collection
        /// </summary>
        protected virtual void RemoveAll()
        {
            base.Controls.Clear();
            OnLayoutRows();
        }

        
        /* overrides */
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            if (Parent != null)
            {
                OnLayoutRows();
            }
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
            OnLayoutRows();
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            if (Parent != null && Parent is UiGroup)
            {
                Parent.PerformLayout();
            }
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);

            if (e.Control is IControlRow)
            {
                e.Control.Dock = DockStyle.Top;
            }
            
            OnLayoutRows();
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);
            OnLayoutRows();
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override Control.ControlCollection CreateControlsInstance()
        {
            return new UiColumnControlCollection(this);
        }

        /// <summary>
        /// Override
        /// </summary>
        protected override Size DefaultSize { get { return new Size(120, DefaultHeight); } }


        /* construction */
        /// <summary>
        /// Construtor
        /// </summary>
        public UiColumn()
        {
            this.Rows = new ControlRowCollection(this);
        }


        /// <summary>
        /// Returns the parent UiColumn of the specified Control, if any, else null.
        /// </summary>
        public static UiColumn ParentColumnOf(Control Control)
        {
            while (Control != null)
            {
                if (Control is UiColumn)
                    return Control as UiColumn;
                Control = Control.Parent;
            }

            return null;
        }


        /* properties */
        /// <summary>
        /// Returns the number of pages in the collection
        /// </summary>
        [Browsable(false), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Count { get { return Rows.Count; } }
        /// <summary>
        /// The collection of pages.
        /// </summary>
        [Description("The collection of pages."), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ControlRowCollection Rows { get; }

    }


    /// <summary>
    /// Control designer
    /// </summary>
    public class UiColumnDesigner : ParentControlDesigner
    {
        /* private */
        UiColumn Column { get { return Control as UiColumn; } }
        Pen GetBorderPen()
        {
            Color color = (this.Control.BackColor.GetBrightness() < 0.5) ? ControlPaint.Light(this.Control.BackColor) : ControlPaint.Dark(this.Control.BackColor);
            Pen pen = new Pen(color);
            pen.DashStyle = DashStyle.Dash;
            return pen;
        }
        void DrawBorder(Graphics graphics)
        {
            //*
            if ((Column != null) && Column.Visible)
            {
                using (Pen Pen = GetBorderPen())
                {
                    Rectangle R = Column.ClientRectangle;
                    R.Width--;
                    R.Height--;
                    graphics.DrawRectangle(Pen, R);
                }
            }
            //*/
        }
        IDesigner GetParentControlDesigner()
        {
            IDesignerHost DesignerHost = GetService(typeof(IDesignerHost)) as IDesignerHost;

            if ((Column != null) && (Column.Parent != null) && (DesignerHost != null))
                return DesignerHost.GetDesigner(Control.Parent);

            return null;
        }

        /* overrides */
        /// <summary>
        /// Called when the control that the designer is managing has painted its surface
        /// so the designer can paint any additional adornments on top of the control.
        /// </summary>
        protected override void OnPaintAdornments(PaintEventArgs pe)
        {
            if (Column != null)
            {
                if (Column.BorderStyle == BorderStyle.None)
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
        public UiColumnDesigner()
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
                    // base.SelectionRules & ~(SelectionRules.TopSizeable | SelectionRules.BottomSizeable);
                    return this.Control.Parent is UiGroup ? SelectionRules.BottomSizeable : SelectionRules.AllSizeable; 
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

                UiGroupDesigner ParentDesigner = GetParentControlDesigner() as UiGroupDesigner;

                if (ParentDesigner != null)
                {
                    foreach (DesignerVerb Verb in ParentDesigner.Verbs)
                        Result.Add(Verb);
                }

                return Result;
            }
        }
    }


}
