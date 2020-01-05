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
    [Designer(typeof(UiGroupDesigner))]
    public partial class UiGroup : UserControl
    {
        bool fAutoTextOnTop = false;

        #region UiColumnCollection
        /// <summary>
        /// The collection of UiColumns
        /// </summary>
        public class UiColumnCollection : Collection<UiColumn>
        {

            /// <summary>
            /// Override
            /// </summary>
            protected override void InsertItem(int Index, UiColumn Item)
            {
                if (((Index >= 0) && (Index <= Count)) && (Item != null) && !Contains(Item))
                {
                    base.InsertItem(Index, Item);

                    if (!Owner.Controls.Contains(Item))
                        Owner.Controls.Add(Item);
                }
            }
            /// <summary>
            /// Override
            /// </summary>
            protected override void RemoveItem(int Index)
            {
                if ((Index >= 0) && (Index < Count))
                {
                    UiColumn Item = this[Index];                    
                    base.RemoveItem(Index);

                    if (Owner.Controls.Contains(Item))
                        Owner.Controls.Remove(Item);
                }
            }
            /// <summary>
            /// Override
            /// </summary>
            protected override void ClearItems()
            {
                UiColumn[] A = this.ToArray();
                foreach (var Item in A)
                {
                    this.Remove(Item);
                }
            }


            /// <summary>
            /// Constructor.
            /// </summary>
            public UiColumnCollection(UiGroup Owner)
            {
                if (Owner == null)
                {
                    throw new ArgumentNullException("Owner");
                }
    
                this.Owner = Owner;
            }

            /// <summary>
            /// Adds a UiColumn to the collection
            /// </summary>
            public UiColumn Add(string Name)
            {
                UiColumn UiColumn = new UiColumn();
                UiColumn.Name = Name;
                this.Add(UiColumn);
                return UiColumn;
            } 
            /// <summary>
            /// Adds UiColumns array to the collection.
            /// </summary>
            public void AddRange(UiColumn[] UiColumns)
            {
                if (UiColumns == null)
                {
                    throw new ArgumentNullException("UiColumns");
                }
                foreach (UiColumn UiColumn in UiColumns)
                {
                    this.Add(UiColumn);
                }
            }
            /// <summary>
            /// Finds a UiColumn by Name, if any, else null.
            /// </summary>
            public UiColumn Find(string Name)
            {
                foreach (UiColumn UiColumn in this)
                    if (string.Compare(Name, UiColumn.Name, StringComparison.InvariantCultureIgnoreCase) == 0)
                        return UiColumn;

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
            /// Gets the UiGroup of this collection
            /// </summary>
            public UiGroup Owner { get; private set; }
        }
        #endregion

        #region UiGroupControlCollection
        /// <summary>
        /// An override of the Control.ControlCollection
        /// </summary>
        protected class UiGroupControlCollection : Control.ControlCollection
        {
            private UiGroup owner;

            /// <summary>
            /// Constructor
            /// </summary>
            public UiGroupControlCollection(UiGroup Owner)
                : base(Owner)
            {
                this.owner = Owner;
            }

            /// <summary>
            /// Adds the specified control to the control collection
            /// </summary>
            public override void Add(Control value)
            {
                if (!Contains(value))
                {
                    bool Flag = (this.Count == 0 && value is Panel) || value is UiColumn;

                    if (!Flag)
                    {
                        throw new ArgumentException("A UiGroup can not be a parent of any other control except of a UiColumn");
                    }

                    base.Add(value);

                    ISite site = owner.Site;
                    if ((site != null) && (value.Site == null))
                    {
                        IContainer container = site.Container;
                        if (container != null)
                        {
                            container.Add(value);
                        }
                    }

                    if (!owner.Columns.Contains(value as UiColumn))
                        owner.Columns.Add(value as UiColumn);

                    owner.OnLayoutColumns();
                }
            }
            /// <summary>
            /// Removes the specified control from the control collection
            /// </summary>
            public override void Remove(Control value)
            {
                if (Contains(value))
                {
                    base.Remove(value);

                    if (owner.Columns.Contains(value as UiColumn))
                        owner.Columns.Remove(value as UiColumn);

                    owner.OnLayoutColumns();
                }             
            }
            /// <summary>
            /// Override
            /// </summary>
            public override void Clear()
            {
                List<Control> List = new List<Control>();

                foreach (Control C in this)
                    List.Add(C);
 
                foreach (var Item in List)
                {
                    this.Remove(Item);
                }
            }
        }
        #endregion


        /* private */
        const int DefaultHeight = 100;
        const int PlusHeight = 24;

        bool Layouting = false;
        ScreenMode LastScreenMode = ScreenMode.None;
 
        Dictionary<ScreenMode, int> Splits = new Dictionary<ScreenMode, int>()
        {
            { ScreenMode.XSmall, 1 },
            { ScreenMode.Small, 2 },
            { ScreenMode.Medium, 2 },
            { ScreenMode.Large, 3 },
        };


        void UpdateTitlePanelHeight()
        {
            if (TitleVisible)
            {
                Size Size = TextRenderer.MeasureText(lblTitle.Text, lblTitle.Font, new Size(pnlTitle.ClientSize.Width, 0), TextFormatFlags.SingleLine | TextFormatFlags.VerticalCenter);
                int H = Size.Height + pnlTitle.Padding.Top + pnlTitle.Padding.Bottom + 28;
                pnlTitle.Height = H;
            }
        }
        void OnLayoutColumns()
        {
            if (!Layouting && this.ScreenMode != ScreenMode.None)
            {
                Layouting = true;
                try
                {
                    if (this.Parent != null)
                    {
                        UpdateTitlePanelHeight();

                        UiColumn[] A = Columns.ToArray(); 
 
                        int ColumnsPerRow = Splits[this.ScreenMode];

                        int Y = TitleVisible? pnlTitle.Height: 0;

                        ////////////////////////////////////////////////////////
                        UiColumn Column;
                        int Count = 0;
                        int MaxHeight = 0;
                        int L = 0;
                        for (int i = 0; i < A.Length; i++)
                        {
                            Count++;
                            Column = A[i];

                            Column.Width = Convert.ToInt32(this.Width / ColumnsPerRow);
                            Column.Top = Y;
                            Column.Left = L;

                            MaxHeight = Math.Max(MaxHeight, Column.Height);

                            L += Column.Width;

                            if (Count == ColumnsPerRow)
                            {
                                Y += MaxHeight;
                                MaxHeight = 0;
                                Count = 0;
                                L = 0;
                            }
                        }

                        if (Count < ColumnsPerRow)
                        {
                            Y += MaxHeight;
                        }
                        ////////////////////////////////////////////////////////

                        Y = DesignMode ? Y + PlusHeight : Y;
                        this.Height = Y;
                    }
                }
                finally
                {
                    Layouting = false;
                }
            }
        }
        void OnColumnsChanged()
        {
            OnLayoutColumns();
        }
 
        void TitleVisibleChanged(object sender, EventArgs e)
        {
            OnLayoutColumns();
        }
        void TitleTextChanged(object sender, EventArgs e)
        {
            OnLayoutColumns();
        }
        void TitleFontChanged(object sender, EventArgs e)
        {
            OnLayoutColumns();
        } 
        void OnAutoTextOnTopChanged()
        {
            ApplyTextOnTop();
        }
        void OnScreenModeChanged()
        {
            foreach (var Column in Columns)
                Column.OnScreenModeChanged(this.ScreenMode);

            ApplyTextOnTop();
        }
        void ApplyTextOnTop()
        {
            if (AutoTextOnTop && ScreenMode != LastScreenMode)
            {
                foreach (var Column in Columns)
                {
                    foreach (var Row in Column.Rows)
                    {
                        Row.TextOnTop = ScreenMode == ScreenMode.XSmall? true: false;
                    }
                }
            }
        }

        /* overrides */
        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            OnLayoutColumns();
        }
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            ScreenMode Mode = Ui.GetScreenMode(this.Parent);
            if (Mode != this.ScreenMode)
            {
                this.LastScreenMode = this.ScreenMode;
                this.ScreenMode = Mode;
                OnScreenModeChanged();
            }

            OnLayoutColumns();
        }
        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            OnLayoutColumns();
        }
        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);
            OnLayoutColumns();
        }
        protected override Control.ControlCollection CreateControlsInstance()
        {
            return new UiGroupControlCollection(this);
        }

        protected override Size DefaultSize { get { return new Size(500, DefaultHeight); } }


        /* construction */
        public UiGroup()
        {
            this.Columns = new UiColumnCollection(this);
            base.Dock = DockStyle.Top;

            InitializeComponent();

            lblTitle.FontChanged += TitleFontChanged;
            lblTitle.TextChanged += TitleTextChanged;
            lblTitle.VisibleChanged += TitleVisibleChanged;
        }


        /// <summary>
        /// Clears all items from the collection.
        /// </summary>
        public void Clear()
        {
            Columns.Clear();
            OnColumnsChanged();
        }
        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public void Add(UiColumn Item)
        {
            Columns.Add(Item);
            OnLayoutColumns();
        }
        /// <summary>
        /// Removes an item from the collection
        /// </summary>
        public void Remove(UiColumn Item)
        {
            Columns.Remove(Item);
            OnLayoutColumns();
        }
        /// <summary>
        /// Returns the index of an item in the collection, if any, else -1
        /// </summary>
        public int IndexOf(UiColumn Item)
        {
            return Columns.IndexOf(Item);
        }
        /// <summary>
        /// Returns true if an item is contained in the collection
        /// </summary>
        public bool Contains(UiColumn Item)
        {
            return Columns.Contains(Item);
        }
        /// <summary>
        /// Used to change position of a column.
        /// </summary>
        public void Exchange(int IndexA, int IndexB)
        {
            if ((IndexA != IndexB) && ((IndexA >= 0) && (IndexA < Count)) && ((IndexB >= 0) && (IndexB < Count)))
            {
                UiColumn A = Columns[IndexA];
                UiColumn B = Columns[IndexB];

                Columns[IndexA] = B;
                Columns[IndexB] = A;

                OnColumnsChanged();
            }
        }


        /* properties */
        /// <summary>
        /// Returns the number of items in the collection
        /// </summary>
        [Browsable(false), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Count { get { return Columns.Count; } } 
        /// <summary>
        /// The collection of items.
        /// </summary>
        [ Description("The collection of items."), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] // 
        public UiColumnCollection Columns { get; }

        [DefaultValue("Title")]
        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }
        [DefaultValue(true)]
        public bool TitleVisible
        {
            get { return pnlTitle.Visible; }
            set { pnlTitle.Visible = value; }
        }
        public Font TitleFont
        {
            get { return lblTitle.Font; }
            set { lblTitle.Font = value; }
        }
        public Color TitleFontColor
        {
            get { return lblTitle.ForeColor; }
            set { lblTitle.ForeColor = value; }
        }
        public Color TitleBackColor
        {
            get { return lblTitle.BackColor; }
            set { lblTitle.BackColor = value; }
        }

        [Browsable(false), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ScreenMode ScreenMode { get; private set; }
        [DefaultValue(false)]
        public bool AutoTextOnTop
        {
            get { return fAutoTextOnTop; }
            set
            {
                if (fAutoTextOnTop != value)
                {
                    fAutoTextOnTop = value;
                    OnAutoTextOnTopChanged();
                }
            }
        }
        
        [Browsable(false), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override AnchorStyles Anchor
        {
            get { return base.Anchor; }
            set { }
        }
    }



    /// <summary>
    /// Control designer
    /// </summary>
    public class UiGroupDesigner : ParentControlDesigner
    {

        bool addingOnInitialize;
        bool disableDrawGrid;

        DesignerVerb verbAdd;
        DesignerVerb verbRemove;
        DesignerVerb verbMoveUp;
        DesignerVerb verbMoveDown;
        DesignerVerbCollection verbs;

        UiColumn SelectedColumn;

        /* private methods */
        void VerbAdd_Click(object sender, EventArgs e)
        {
            IDesignerHost DesignerHost = (IDesignerHost)this.GetService(typeof(IDesignerHost));
            if (DesignerHost != null)
            {
                DesignerTransaction Transaction = null;
                try
                {
                    try
                    {
                        Transaction = DesignerHost.CreateTransaction("Tripous_UiGroup_AddColumn");
                    }
                    catch (CheckoutException Ex)
                    {
                        if (Ex != CheckoutException.Canceled)
                        {
                            throw Ex;
                        }
                        return;
                    }


                    MemberDescriptor ControlsProp = TypeDescriptor.GetProperties(Group)["Controls"];
                    UiColumn Column = DesignerHost.CreateComponent(typeof(UiColumn)) as UiColumn;
                    if (!this.addingOnInitialize)
                    {
                        base.RaiseComponentChanging(ControlsProp);
                    }
 
                    Group.Add(Column);

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
        void VerbRemove_Click(object sender, EventArgs e)
        {
            if (Group != null && Group.Columns.Count != 0 && SelectedColumn != null)
            {
                MemberDescriptor ControlsProp = TypeDescriptor.GetProperties(Group)["Controls"];
 
                IDesignerHost DesignerHost = this.GetService(typeof(IDesignerHost)) as IDesignerHost;
                if (DesignerHost != null)
                {
                    DesignerTransaction Transaction = null;
                    try
                    {
                        try
                        {
                            Transaction = DesignerHost.CreateTransaction("Tripous_UiGroup_RemoveColumn");
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

                        DesignerHost.DestroyComponent(SelectedColumn);                        
                        Group.Remove(SelectedColumn);
                        SelectedColumn = null;
                        base.RaiseComponentChanged(ControlsProp, null, null);                        
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
        void VerbMoveUp_Click(object sender, EventArgs e)
        {
            MoveColumn(false);
        }
        void VerbMoveDown_Click(object sender, EventArgs e)
        {
            MoveColumn(true);
        }
        void MoveColumn(bool Down)
        {
            if (Group != null && Group.Columns.Count != 0 && SelectedColumn != null)
            {

                int Index = Group.IndexOf(SelectedColumn);
 
                if (Index < 0 || (Down && Index >= Group.Count - 1) || (!Down && Index <= 0))
                    return;

                int IndexB = Down ? Index + 1 : Index - 1;

                MemberDescriptor ControlsProp = TypeDescriptor.GetProperties(Group)["Controls"];

                IDesignerHost DesignerHost = this.GetService(typeof(IDesignerHost)) as IDesignerHost;
                if (DesignerHost != null)
                {
                    DesignerTransaction Transaction = null;
                    try
                    {
                        try
                        {
                            Transaction = DesignerHost.CreateTransaction("Tripous_UiGroup_MoveColumnUpOrDown");
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

                        Group.Exchange(Index, IndexB);
                        base.RaiseComponentChanged(ControlsProp, null, null);
                        Group.PerformLayout();
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

                SelectedColumn = null;
                UiColumn Column;
                foreach (object Item in SelectedComponents)
                { 
                    Column = UiColumn.ParentColumnOf(Item as Control);
                    if ((Column != null) && (Column.Parent == Group))
                    {
                        SelectedColumn = Column;
                        break;
                    }
                }
            }
        }
 
        void EnableCommands()
        {
            if (this.Control != null && this.verbRemove != null)
            {
                verbRemove.Enabled = Group != null && SelectedColumn != null;
                verbMoveUp.Enabled = Group != null && SelectedColumn != null && Group.IndexOf(SelectedColumn) > 0;
                verbMoveDown.Enabled = Group != null && SelectedColumn != null && Group.Count >= 2 && Group.IndexOf(SelectedColumn) <= Group.Count - 2;
            }
        }
        UiColumnDesigner GetSelectedColumnDesigner()
        {
            if (SelectedColumn != null)
            {
                IDesignerHost DesignerHost = GetService(typeof(IDesignerHost)) as IDesignerHost;
                if (DesignerHost != null)
                    return DesignerHost.GetDesigner(SelectedColumn) as UiColumnDesigner;
            }

            return null;
        }

        /* private properties */
        UiGroup Group { get { return Control as UiGroup; } }


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
            UiColumnDesigner Designer = this.GetSelectedColumnDesigner();
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
            UiColumnDesigner Designer = this.GetSelectedColumnDesigner();
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
            UiColumnDesigner Designer = this.GetSelectedColumnDesigner();
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
            Point P = Group.PointToClient(new Point(de.X, de.Y));
            if (!Group.ClientRectangle.Contains(P))
            {
                de.Effect = DragDropEffects.None;
            }
            else
            {
                UiColumnDesigner Designer = this.GetSelectedColumnDesigner();
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
            UiColumnDesigner Designer = this.GetSelectedColumnDesigner();
            if (Designer != null)
            {
                Designer.OnGiveFeedbackInternal(e);
            }
        }

        /// <summary>
        /// override
        /// </summary>
        public override void Initialize(IComponent component)
        {
            base.Initialize(component);
            
            //base.AutoResizeHandles = true;

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
        }
        /// <summary>
        /// override
        /// </summary>
        public override bool CanParent(Control control)
        {
            return ((control is UiColumn) && !this.Control.Contains(control));
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
                UiColumnDesigner Designer = this.GetSelectedColumnDesigner();
                if (Designer != null)
                {
                    return Designer.ParticipatesWithSnapLines;
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
                    this.verbRemove = new DesignerVerb("Remove Column", new EventHandler(this.VerbRemove_Click));
                    this.verbAdd = new DesignerVerb("Add Column", new EventHandler(this.VerbAdd_Click));
                    this.verbMoveUp = new DesignerVerb("Move Column Up", new EventHandler(this.VerbMoveUp_Click));
                    this.verbMoveDown = new DesignerVerb("Move Column Down", new EventHandler(this.VerbMoveDown_Click));

                    this.verbs = new DesignerVerbCollection();
                    this.verbs.Add(verbAdd);
                    this.verbs.Add(verbRemove);
                    this.verbs.Add(verbMoveUp);
                    this.verbs.Add(verbMoveDown);
                }

                EnableCommands();

                return this.verbs;
            }
        }
    }





}
