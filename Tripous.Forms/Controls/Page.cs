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
    /// Represents a page in the <see cref="Pager"/>
    /// </summary>
#if !NET_CF
    [ToolboxItemAttribute(false), DesignTimeVisibleAttribute(false), Designer(typeof(Tripous.Forms.PagerPageDesigner))]
#endif
    public class Page : Panel
    {
        private bool checkingParent;
        private string title;
 
 

        /* overrides */
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnParentChanged(EventArgs e)
        {
            if (!checkingParent)
            {
                checkingParent = true;
                try
                {
                    if ((Parent != null) && !(Parent is Pager))
                    {
                        Parent = null;
                        throw new ArgumentException("Only a Pager can be parent of a Page");
                    }
                }
                finally
                {
                    checkingParent = false;
                }
            }

            base.OnParentChanged(e);
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Rectangle R = ClientRectangle;
            R.Offset(1, 1);
            R.Height -= 2;
            R.Width -= 2;

            using (Pen Pen = new Pen(Colorist.Dark(this.BackColor)))
                e.Graphics.DrawRectangle(Pen, R);
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            Invalidate();
        }

        /* constructor */
        /// <summary>
        /// Constructor
        /// </summary>
        public Page()
        {
        }

        /* methods */
        /// <summary>
        /// Returns the parent Page of the specified Control, if any, else null.
        /// </summary>
        public static Page ParentPageOf(Control Control)
        {
            while (Control != null)
            {
                if (Control is Page)
                    return Control as Page;
                Control = Control.Parent;
            }

            return null;
        }

        /// <summary>
        /// Returns a string representation of this instance
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return !string.IsNullOrEmpty(Title) ? Title : base.ToString();
        }

        /* properties */
        /// <summary>
        /// Returns the pager of this page
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public Pager Pager
        {
            get { return Parent as Pager; }
            set
            {
                if (Pager != value)
                {
                    if (Pager != null)
                        Pager.Pages.Remove(this);

                    if (value != null)
                        value.Pages.Add(this);
                }
            }
        }
        /// <summary>This member is not meaningful for this control.</summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public override AnchorStyles Anchor
        {
            get
            {
                return base.Anchor;
            }
            set
            {
                base.Anchor = value;
            }
        }
#if !NET_CF
        /// <summary>This member is not meaningful for this control.</summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public override bool AutoSize
        {
            get
            {
                return base.AutoSize;
            }
            set
            {
                base.AutoSize = value;
            }
        }
        /// <summary>This member is not meaningful for this control.</summary>
        [Localizable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public override AutoSizeMode AutoSizeMode
        {
            get
            {
                //return  AutoSizeMode.GrowOnly;
                return base.AutoSizeMode;
            }
            set
            {
                base.AutoSizeMode = value;
            }
        }
        /// <summary>This member is not meaningful for this control.</summary>
        [DefaultValue(typeof(Size), "0, 0"), EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public override Size MaximumSize
        {
            get
            {
                return base.MaximumSize;
            }
            set
            {
                base.MaximumSize = value;
            }
        }
        /// <summary>This member is not meaningful for this control.</summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public override Size MinimumSize
        {
            get
            {
                return base.MinimumSize;
            }
            set
            {
                base.MinimumSize = value;
            }
        }
#endif
        /// <summary>This member is not meaningful for this control.</summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public override DockStyle Dock
        {
            get { return base.Dock; }
            set { base.Dock = value; }
        }
        /// <summary>This member is not meaningful for this control.</summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public new Point Location
        {
            get { return base.Location; }
            set { base.Location = value; }
        }
        /// <summary>This member is not meaningful for this control.</summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public new Size Size
        {
            get
            {
                return base.Size;
            }
            set
            {
                base.Size = value;
            }
        }
        /// <summary>
        /// Gets or sets the Text of the page which is displayed in a tab button.
        /// </summary>
        [Browsable(true), Localizable(true), Description("Gets or sets the Text of the page which is displayed in a tab button.")]
        public string Title
        {
            get { return string.IsNullOrWhiteSpace(title) ? string.Empty : title; }
            set
            {
                if ((value != null) && (value != title))
                {
                    title = value;
                    if (TitleChanged != null)
                        TitleChanged(this, EventArgs.Empty);
                }
            }
        }
        /// <summary>
        /// Gets or sets the index of this page in the Pager.
        /// </summary>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Index
        {
            get { return Pager == null ? -1 : Pager.IndexOf(this); }
            set
            {
                if ((Pager != null) && (value != Index))
                {
                    Pager.Exchange(Index, value);
                }
            }
        }

        /* events */
        /// <summary>
        /// Occurs when the title changes.
        /// </summary>
        public event EventHandler TitleChanged;
    }

}
