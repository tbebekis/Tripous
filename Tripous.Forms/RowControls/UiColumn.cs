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

    //[ToolboxItem(false), DesignTimeVisible(false), Designer(typeof(UiColumnDesigner))] 

    /// <summary>
    /// A UI column
    /// </summary>
    [Designer(typeof(UiColumnControlDesigner))]
    public class UiColumn: Panel
    {
        bool Layouting;

        #region UiColumnCollection
        /// <summary>
        /// The collection of UiColumns
        /// </summary>
        public class ControlRowCollection : Collection<IUiControlRow>
        {
 
            /// <summary>
            /// Override
            /// </summary>
            protected override void InsertItem(int Index, IUiControlRow Item)
            {
                if (((Index >= 0) && (Index <= Count)) && (Item != null) && !Contains(Item))
                {
                    base.InsertItem(Index, Item);

                    if (!Owner.Controls.Contains(Item as Control))
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
                    IUiControlRow Item = this[Index];
                    base.RemoveItem(Index);

                    if (Owner.Controls.Contains(Item as Control))
                        Owner.Controls.Remove(Item as Control); 
                }
            }
            /// <summary>
            /// Override
            /// </summary>
            protected override void ClearItems()
            {
                IUiControlRow[] A = this.ToArray();
                foreach (var Item in A)
                {
                    this.Remove(Item);
                }
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
            /// Adds rows array to the collection.
            /// </summary>
            public void AddRange(IUiControlRow[] ControlRows)
            {
                if (ControlRows == null)
                {
                    throw new ArgumentNullException("ControlRows");
                }
                foreach (IUiControlRow Item in ControlRows)
                {
                    this.Add(Item);
                }
            }
            /// <summary>
            /// Finds a row by Name, if any, else null.
            /// </summary>
            public IUiControlRow Find(string Name)
            {
                foreach (IUiControlRow Item in this)
                    if (string.Compare(Name, Item.Name, StringComparison.InvariantCultureIgnoreCase) == 0)
                        return Item;

                return null;
            }
            /// <summary>
            /// Returns the index of a row with Name, if any, else -1.
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
            UiColumn owner;

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
                if (!Contains(value))
                {
                    bool Flag = value is IUiControlRow;

                    if (!Flag)
                    {
                        throw new ArgumentException("A UiColumn can not be a parent of any other control except of a IControlRow");
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

                    if (!owner.Rows.Contains(value as IUiControlRow))
                        owner.Rows.Add(value as IUiControlRow);

                    owner.OnLayoutRows();
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

                    if (owner.Rows.Contains(value as IUiControlRow))
                        owner.Rows.Remove(value as IUiControlRow);

                    owner.OnLayoutRows();
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
 
        const int DefaultHeight = 40;


        /* protected */
        /// <summary>
        /// Called when rows need recalculation
        /// </summary>
        protected virtual void OnLayoutRows()
        {
            if (!Layouting)
            {
                Layouting = true;
                try
                {
                    IUiControlRow[] A = Rows.ToArray();

                    int H = 0;
                    foreach (var Row in A)
                    {
                        H += Row.Height;
                    }

                    H = DesignMode ? H + DefaultHeight : H;

                    //System.Diagnostics.Debug.WriteLine($"Count = {A.Length}");
                    this.Height = H;

                    if (Parent is UiGroup)
                    {
                        (Parent as UiGroup).PerformLayout();
                    }
                }
                finally
                {
                    Layouting = false;
                }
            }
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

            if (e.Control is IUiControlRow)
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
        protected override Size DefaultSize { get { return new Size(200, DefaultHeight); } }


        /* construction */
        /// <summary>
        /// Construtor
        /// </summary>
        public UiColumn()
        {
            this.Rows = new ControlRowCollection(this);
        }

        /// <summary>
        /// Used to change position of a column.
        /// </summary>
        public void Exchange(int IndexA, int IndexB)
        {
            if ((IndexA != IndexB) && ((IndexA >= 0) && (IndexA < Count)) && ((IndexB >= 0) && (IndexB < Count)))
            {

                IUiControlRow A = Rows[IndexA];
                IUiControlRow B = Rows[IndexB];

                Rows[IndexA] = B;
                Rows[IndexB] = A;

                IndexA = this.Controls.GetChildIndex(A as Control);
                IndexB = this.Controls.GetChildIndex(B as Control);

                this.Controls.SetChildIndex(A as Control, IndexB);
                this.Controls.SetChildIndex(B as Control, IndexA);

                OnLayoutRows();
            }
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

        /// <summary>
        /// Called by a parent <see cref="UiGroup"/> when the size changing of that parent "changes screen mode".
        /// </summary>
        public virtual void OnScreenModeChanged(ScreenMode Mode)
        {
            foreach (var Row in Rows)
                Row.OnScreenModeChanged(Mode);
        }



        /* properties */
        /// <summary>
        /// Returns the number of items in the collection
        /// </summary>
        [Browsable(false), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Count { get { return Rows.Count; } }
        /// <summary>
        /// The collection of pages.
        /// </summary>
        [ Description("The collection of items."), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] // 
        public ControlRowCollection Rows { get; }

    }





}
