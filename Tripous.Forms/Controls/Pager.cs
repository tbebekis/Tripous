/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
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

namespace Tripous.Forms
{


    /// <summary>
    /// A TabControl-like control.
    /// <para>Allows to completely hide the tab bar without the need to remove 
    /// the pages from the control.</para>
    /// </summary>
#if !NET_CF
    [Designer(typeof(Tripous.Forms.PagerDesigner))]
    [ToolboxBitmap(typeof(TabControl))]
#endif
    public class Pager : Control
    {
        /// <summary>
        /// The collection of pages
        /// </summary>
        public class PageCollection : Collection<Page>
        {
            private Pager pager;

            /// <summary>
            /// Override
            /// </summary>
            protected override void InsertItem(int Index, Page Item)
            {
                if (((Index >= 0) && (Index <= Count)) && (Item != null) && !Contains(Item))
                {
                    base.InsertItem(Index, Item);

                    if (Item.Parent != pager)
                        this.pager.Controls.Add(Item);
                }
            }
            /// <summary>
            /// Override
            /// </summary>
            protected override void RemoveItem(int Index)
            {
                if ((Index >= 0) && (Index < Count))
                {
                    this.pager.Controls.Remove(this[Index]);
                    base.RemoveItem(Index);
                }
            }
            /// <summary>
            /// Override
            /// </summary>
            protected override void ClearItems()
            {
                this.pager.RemoveAll();
                base.ClearItems();
            }

            /// <summary>
            /// Constructor.
            /// </summary>
            public PageCollection(Pager Owner)
            {
                if (Owner == null)
                {
                    throw new ArgumentNullException("Owner");
                }
                this.pager = Owner;
            }

            /// <summary>
            /// Adds a page to the collection
            /// </summary>
            public Page Add(string Text)
            {
                Page Page = new Page();
                Page.Title = Text;
                this.Add(Page);
                return Page;
            }
            /// <summary>
            /// Adds a page to the collection. Key becomes the Name of the Page and must be a valid identifier.
            /// </summary>
            public Page Add(string Key, string Text)
            {
                Page Page = new Page();
                Page.Name = Key;
                Page.Title = Text;
                this.Add(Page);
                return Page;
            }
            /// <summary>
            /// Adds Pages array to the collection.
            /// </summary>
            public void AddRange(Page[] Pages)
            {
                if (Pages == null)
                {
                    throw new ArgumentNullException("Pages");
                }
                foreach (Page Page in Pages)
                {
                    this.Add(Page);
                }
            }
            /// <summary>
            /// Finds a Page by Name, if any, else null.
            /// </summary>
            public Page Find(string Name)
            {
                foreach (Page Page in this)
                    if (string.Compare(Name, Page.Name, StringComparison.InvariantCultureIgnoreCase) == 0)
                        return Page;

                return null;
            }
            /// <summary>
            /// Returns the index of Page with Name, if any, else -1.
            /// </summary>
            public int IndexOf(string Name)
            {
                return IndexOf(Find(Name));
            }

            /// <summary>
            /// Gets the Pager of this collection
            /// </summary>
            public Pager Owner { get { return pager; } }
        }

        /// <summary>
        /// An override of the Control.ControlCollection
        /// </summary>
        protected class PagerControlCollection : Control.ControlCollection
        {
            private Pager owner;

            /// <summary>
            /// Constructor
            /// </summary>
            public PagerControlCollection(Pager Owner)
                : base(Owner)
            {
                this.owner = Owner;
            }

            /// <summary>
            /// Adds the specified control to the control collection
            /// </summary>
            public override void Add(Control value)
            {
                if (value != null)
                {
                    if (!(value is Page))
                        throw new ArgumentException("A Pager can not be a parent of any other control except of a Page");
                }

                base.Add(value);

                if (value is Page)
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

                    owner.LayoutPage(value as Page);
                    if (!owner.Pages.Contains(value as Page))
                        owner.Pages.Add(value as Page);
                    owner.OnPagesChanged();
                    owner.SelectedPage = value as Page;
                }
            }
            /// <summary>
            /// Removes the specified control from the control collection
            /// </summary>
            public override void Remove(Control value)
            {
                base.Remove(value);

                if (value is Page)
                {
                    if (owner.pages.Contains(value as Page))
                    {
                        bool flag = owner.SelectedPage == value;
                        int PageIndex = owner.Pages.IndexOf(value as Page);
                        if (flag)
                        {
                            if (PageIndex > 0)
                                owner.SelectedPage = owner.Pages[PageIndex - 1];
                            else if ((PageIndex == 0) && (owner.Count > 1))
                                owner.SelectedPage = owner.Pages[PageIndex + 1];
                            else
                                owner.SelectedPage = null;
                        }

                        owner.OnPagesChanged();
                    }
                }
            }
        }



 
        private PageCollection pages;
        private Page selectedPage;


        /* overrides */
#if !NET_CF
        /// <summary>
        /// Override
        /// </summary>
        protected override Size DefaultSize { get { return new Size(300, 250); } }
#endif
        /// <summary>
        /// Override
        /// </summary>
        protected override Control.ControlCollection CreateControlsInstance()
        {
            return new PagerControlCollection(this);
        }
#if !NET_CF
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
            LayoutPages();
        }
#endif
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

#if NET_CF
            using (Brush Brush = new SolidBrush(BackColor))
                e.Graphics.FillRectangle(Brush, Bounds);
#endif
        }




        /// <summary>
        /// Triggers the Resise event
        /// </summary>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            LayoutPages();
            Invalidate();
        }

        /* protected */
        /// <summary>
        /// Removes all pages from the page collection
        /// </summary>
        protected virtual void RemoveAll()
        {
            base.Controls.Clear(); 
        }
        /// <summary>
        /// Called whenever the page collection changes in order to layout the pages
        /// and refresh the tab bar. It also triggers the PagesChanged event.
        /// </summary>
        protected virtual void OnPagesChanged()
        {
            if (PagesChanged != null)
                PagesChanged(this, EventArgs.Empty);
        }
        /// <summary>
        /// Layouts the pages according to the visibility of the tab bar.
        /// </summary>
        protected virtual void LayoutPages()
        {
            foreach (Page Page in pages)
               LayoutPage(Page);
        } 
        /// <summary>
        /// Layouts Page. It actually sets Page bounds.
        /// </summary>
        internal virtual void LayoutPage(Page Page)
        {
            Page.Bounds = new Rectangle(0, 0, Width, Height);

            if (this.Parent != null)
                Page.Invalidate();
        }

        /* constructor */
        /// <summary>
        /// Constructor.
        /// </summary>
        public Pager()
        {
            pages = new PageCollection(this);
#if !NET_CF
            this.UpdateStyles();
#endif
#if NET_CF
            this.Size = new Size(240, 200);
#endif
        }

        /* methods */
        /// <summary>
        /// Clears all pages from the collection.
        /// </summary>
        public void Clear()
        {
            pages.Clear();
        }
        /// <summary>
        /// Adds Page to the collection
        /// </summary>
        public void Add(Page Page)
        {
            pages.Add(Page);
        }
        /// <summary>
        /// Removes Page from the collection
        /// </summary>
        public void Remove(Page Page)
        {
            pages.Remove(Page);
        }
        /// <summary>
        /// Returns the index of Page in the collection, if any, else -1
        /// </summary>
        public int IndexOf(Page Page)
        {
            return pages.IndexOf(Page);
        }
        /// <summary>
        /// Returns true if Page is contained in the collection
        /// </summary>
        public bool Contains(Page Page)
        {
            return pages.Contains(Page);
        }
        /// <summary>
        /// Used to change position of a page.
        /// </summary>
        public void Exchange(int IndexA, int IndexB)
        {
            if ((IndexA != IndexB) && ((IndexA >= 0) && (IndexA < Count)) && ((IndexB >= 0) && (IndexB < Count)))
            {
                Page A = pages[IndexA];
                Page B = pages[IndexB];

                pages[IndexA] = B;
                pages[IndexB] = A;

                OnPagesChanged();
            }
        }

        /* properties */
        /// <summary>
        /// Returns the number of pages in the collection
        /// </summary>
        [Browsable(false), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Count { get { return pages.Count; } }
        /// <summary>
        /// Gets or sets the selected page
        /// </summary>
#if !NET_CF
        [Description("Gets or sets the selected page"), Editor(typeof(PagerSelectedPageEditor), typeof(System.Drawing.Design.UITypeEditor))]
#endif
        public Page SelectedPage
        {
            get { return selectedPage; }
            set
            {
                if ((value != null) && (value.Parent == this) && (value != selectedPage))
                {
                    if (SelectedPageChanging != null)
                        SelectedPageChanging(this, EventArgs.Empty);

                    if (selectedPage != null)
                        selectedPage.Visible = false;

                    selectedPage = value;

                    if (selectedPage != null)
                        selectedPage.Visible = true;

                    if (SelectedPageChanged != null)
                        SelectedPageChanged(this, EventArgs.Empty);
                }
            }
        }
        /// <summary>
        /// Gets or sets the SelectedPage index
        /// </summary>
        [Description("Gets or sets the SelectedPage index"), Browsable(false), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedPageIndex
        {
            get { return pages.IndexOf(selectedPage); }
            set
            {
                if ((value >= 0) && (value < pages.Count))
                    SelectedPage = pages[value];
            }
        }
        /// <summary>
        /// The collection of pages.
        /// </summary>
        [Description("The collection of pages."), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PageCollection Pages { get { return pages; } }
        /// <summary>
        /// Gets or sets the background color
        /// </summary>
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                if (value != base.BackColor)
                {
                    base.BackColor = value;
                }
            }
        }

        /* events */
        /// <summary>
        /// Occurs when SelectedPage is about to change.
        /// </summary>
        [Description("Occurs when SelectedPage is about to change.")]
        public event EventHandler SelectedPageChanging;
        /// <summary>
        /// Occurs when SelectedPage is changed.
        /// </summary>
        [Description("Occurs when SelectedPage is changed.")]
        public event EventHandler SelectedPageChanged;
        /// <summary>
        /// Occurs when the pages collection is changed as a result of adding or removing a page or clearing the pages..
        /// </summary>
        [Description("Occurs when the pages collection is changed as a result of adding or removing a page or clearing the pages.")]
        public event EventHandler PagesChanged;
    }


}
