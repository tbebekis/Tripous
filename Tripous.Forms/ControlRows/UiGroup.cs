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
 

namespace Tripous.Forms
{
    /// <summary>
    /// A container of <see cref="UiColumn"/> controls
    /// </summary>
    [Designer(typeof(UiGroupControlDesigner))]
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
                    Control Item = this[Index] as Control;                    
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
                    // we have a Panel as Caption to the group, at Index 0
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

                    if (value is UiColumn)
                    {
                        if (!owner.Columns.Contains(value as UiColumn))
                            owner.Columns.Add(value as UiColumn);
                    }

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
                Size Size = TextRenderer.MeasureText(lblCaption.Text, lblCaption.Font, new Size(pnlTitle.ClientSize.Width, 0), TextFormatFlags.SingleLine | TextFormatFlags.VerticalCenter);
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

            lblCaption.FontChanged += TitleFontChanged;
            lblCaption.TextChanged += TitleTextChanged;
            lblCaption.VisibleChanged += TitleVisibleChanged;
        }

        /// <summary>
        /// Returns the parent UiColumn of the specified Control, if any, else null.
        /// </summary>
        public static UiGroup ParentOf(Control Control)
        {
            while (Control != null)
            {
                if (Control is UiGroup)
                    return Control as UiGroup;
                Control = Control.Parent;
            }

            return null;
        }

        /// <summary>
        /// Clears all items from the collection.
        /// </summary>
        public void Clear()
        {
            Columns.Clear();
            OnLayoutColumns();
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

                IndexA = this.Controls.GetChildIndex(A);
                IndexB = this.Controls.GetChildIndex(B);

                this.Controls.SetChildIndex(A, IndexB);
                this.Controls.SetChildIndex(B, IndexA);

                OnLayoutColumns();
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

        [DefaultValue("Caption")]
        public string Caption
        {
            get { return lblCaption.Text; }
            set { lblCaption.Text = value; }
        }
        [DefaultValue(true)]
        public bool TitleVisible
        {
            get { return pnlTitle.Visible; }
            set { pnlTitle.Visible = value; }
        }
        public Font TitleFont
        {
            get { return lblCaption.Font; }
            set { lblCaption.Font = value; }
        }
        public Color TitleFontColor
        {
            get { return lblCaption.ForeColor; }
            set { lblCaption.ForeColor = value; }
        }
        public Color TitleBackColor
        {
            get { return lblCaption.BackColor; }
            set { lblCaption.BackColor = value; }
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







}
