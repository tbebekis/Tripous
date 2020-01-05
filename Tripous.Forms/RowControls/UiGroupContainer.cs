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
    /// A container for <see cref="UiGroup"/> containers.
    /// <para>Just to provide vertical scroll only.</para>
    /// </summary>
    [Designer(typeof(UiGroupContainerControlDesigner))]
    public class UiGroupContainer: Panel
    {
        #region UiColumnCollection
        /// <summary>
        /// The collection of UiColumns
        /// </summary>
        public class UiGroupCollection : Collection<UiGroup>
        {

            /// <summary>
            /// Override
            /// </summary>
            protected override void InsertItem(int Index, UiGroup Item)
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
                UiGroup[] A = this.ToArray();
                foreach (var Item in A)
                {
                    this.Remove(Item);
                }
            }


            /// <summary>
            /// Constructor.
            /// </summary>
            public UiGroupCollection(UiGroupContainer Owner)
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
            public UiGroup Add(string Name)
            {
                UiGroup Item = new UiGroup();
                Item.Name = Name;
                this.Add(Item);
                return Item;
            }
            /// <summary>
            /// Adds UiColumns array to the collection.
            /// </summary>
            public void AddRange(UiGroup[] Items)
            {
                if (Items == null)
                {
                    throw new ArgumentNullException("Items");
                }
                foreach (UiGroup Item in Items)
                {
                    this.Add(Item);
                }
            }
            /// <summary>
            /// Finds a group by Name, if any, else null.
            /// </summary>
            public UiGroup Find(string Name)
            {
                foreach (UiGroup Item in this)
                    if (string.Compare(Name, Item.Name, StringComparison.InvariantCultureIgnoreCase) == 0)
                        return Item;

                return null;
            }
            /// <summary>
            /// Returns the index of group with Name, if any, else -1.
            /// </summary>
            public int IndexOf(string Name)
            {
                return IndexOf(Find(Name));
            }

            /// <summary>
            /// Gets the owner of this collection
            /// </summary>
            public UiGroupContainer Owner { get; private set; }
        }
        #endregion


        #region UiGroupContainerControlCollection
        /// <summary>
        /// An override of the Control.ControlCollection
        /// </summary>
        protected class UiGroupContainerControlCollection : Control.ControlCollection
        {
            UiGroupContainer owner;

            /// <summary>
            /// Constructor
            /// </summary>
            public UiGroupContainerControlCollection(UiGroupContainer Owner)
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
                   
                    bool Flag = value is UiGroup;

                    if (!Flag)
                    {
                        throw new ArgumentException("A UiGroupContainer can not be a parent of any other control except of a UiGroup");
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

                    if (!owner.Groups.Contains(value as UiGroup))
                        owner.Groups.Add(value as UiGroup);

                    owner.OnLayoutGroups();
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

                    if (owner.Groups.Contains(value as UiGroup))
                        owner.Groups.Remove(value as UiGroup);

                    owner.OnLayoutGroups();
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


        protected override Control.ControlCollection CreateControlsInstance()
        {
            return new UiGroupContainerControlCollection(this);
        }

        void OnLayoutGroups()
        {

        }
 


        #endregion
        /// <summary>
        /// Constructor
        /// </summary>
        public UiGroupContainer()
        {
            this.Groups = new UiGroupCollection(this);

            base.AutoScroll = true;
            base.HorizontalScroll.Enabled = false;
            base.HorizontalScroll.Visible = false;
        }

        /// <summary>
        /// Used to change position of a column.
        /// </summary>
        public void Exchange(int IndexA, int IndexB)
        {
            if ((IndexA != IndexB) && ((IndexA >= 0) && (IndexA < Count)) && ((IndexB >= 0) && (IndexB < Count)))
            {
                UiGroup A = Groups[IndexA];
                UiGroup B = Groups[IndexB];

                Groups[IndexA] = B;
                Groups[IndexB] = A;

                IndexA = this.Controls.GetChildIndex(A);
                IndexB = this.Controls.GetChildIndex(B);

                this.Controls.SetChildIndex(A, IndexB);
                this.Controls.SetChildIndex(B, IndexA);

                OnLayoutGroups();
            }
        }

        /// <summary>
        /// Prohibit changing the property
        /// </summary>
        public override bool AutoScroll
        {
            get { return base.AutoScroll; }
            set { }
        }

        /* properties */
        /// <summary>
        /// Returns the number of items in the collection
        /// </summary>
        [Browsable(false), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Count { get { return Groups.Count; } }
        /// <summary>
        /// The collection of pages.
        /// </summary>
        [Description("The collection of items."), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] // 
        public UiGroupCollection Groups { get; }
    }
}
