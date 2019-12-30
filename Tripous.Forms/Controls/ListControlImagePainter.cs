/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tripous.Forms
{

    /// <summary>
    /// Helper class for painting Images to a ListBox or ComboBox
    /// <code>
    /// listBox1.BeginUpdate();
    /// listBox1.Items.AddRange(List.ToArray()); 
    /// ListControlImagePainter painter = new ListControlImagePainter(listBox1);
    /// listBox1.EndUpdate();
    /// </code>
    /// </summary>
    public class ListControlImagePainter
    {

        #region ListItem helper class
        /// <summary>
        /// A helper method for creating IImageContainer items with Text.
        /// </summary>
        public class ListItem : IImageContainer
        {
            /* construction */
            /// <summary>
            /// Constructor
            /// </summary>
            public ListItem(string Text, Image Image)
            {
                this.Text = Text;
                this.Image = Image;
            }

            /* public */
            /// <summary>
            /// Override
            /// </summary>
            public override string ToString()
            {
                return Text;
            }

            /* properties */
            /// <summary>
            /// The text of the item
            /// </summary>
            public string Text { get; private set; }
            /// <summary>
            /// The image of the item
            /// </summary>
            public Image Image { get; private set; }
        }
        #endregion


        static StringFormat SF = new StringFormat();
        Control control;
        IList Items;

        /* private */
        /// <summary>
        /// Returns an image for the item in Index of an DrawMode.OwnerDrawFixed control
        /// </summary>
        Image ImageOf(int Index)
        {
            if (Items[Index] is IImageContainer)
                return (Items[Index] as IImageContainer).Image;

            return null;
        }
        /// <summary>
        /// Returns the text to display for the item in Index of an DrawMode.OwnerDrawFixed control
        /// </summary>
        string TextOf(int Index)
        {
            return Items[Index] == null ? string.Empty : Items[Index].ToString();
        }
        /// <summary>
        /// Event handler for the control's MeasureItem event
        /// </summary>
        void MeasureItem(object sender, MeasureItemEventArgs e)
        {
            Image Image = ImageOf(e.Index);
            if (Image != null)
            {
                e.ItemHeight = Image.Height;
                e.ItemWidth = Image.Width;
            }
        }
        /// <summary>
        /// Event handler for the control's DrawItem event
        /// </summary>
        void DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            if ((e.Index >= 0) && (e.Index < Items.Count))
            {
                Image Image = ImageOf(e.Index);
                string S = TextOf(e.Index);

                int W = 0;
                Rectangle R = e.Bounds;

                if (Image != null)
                {
                    R.X += 5;
                    R.Y += 1;
                    R.Height -= 1;
                    R.Width = R.Height;

                    W = R.Width;

                    e.Graphics.DrawImage(Image, R);
                }

                R = e.Bounds;
                R.Offset(W + 5, 0);

                if (Image != null)
                {
                    R.Width -= Image.Height;
                }

                if (!string.IsNullOrEmpty(S))
                {
                    Brush brush = ((DrawItemState.Selected & e.State) == DrawItemState.Selected) ? Brushes.White : Brushes.Black;
                    RectangleF TextR = R;
                    e.Graphics.DrawString(S, e.Font, brush, TextR, SF);
                }

                if ((DrawItemState.Focus & e.State) == DrawItemState.Focus)
                    e.DrawFocusRectangle();
            }
        }


        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public ListControlImagePainter(ListBox Control)
        {
            this.control = Control;

            Items = Control.Items;

            Control.DrawItem += DrawItem;
            Control.MeasureItem += MeasureItem;
            Control.DrawMode = DrawMode.OwnerDrawVariable;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        public ListControlImagePainter(ComboBox Control)
        {
            this.control = Control;

            Items = Control.Items;
            Control.DrawItem += DrawItem;
            Control.MeasureItem += MeasureItem;
            Control.DrawMode = DrawMode.OwnerDrawVariable;
        }
        /// <summary>
        /// Static constructor
        /// </summary>
        static ListControlImagePainter()
        {
            SF.Alignment = StringAlignment.Near;
            SF.LineAlignment = StringAlignment.Center;

            SF.FormatFlags = StringFormatFlags.NoWrap ^ (StringFormatFlags.NoWrap & SF.FormatFlags);
        }


        /* static */
        /// <summary>
        /// Attaches a ListControlImagePainter instance to the specified Control.
        /// <para>Items should be a list of items where each item implements the
        /// IImageContainer interface and its ToString() returns the text to paint.
        /// </para>
        /// </summary>
        static public void Attach(ListBox Control, object[] Items)
        {
            Control.BeginUpdate();
            Control.Items.AddRange(Items);
            ListControlImagePainter painter = new ListControlImagePainter(Control);
            Control.EndUpdate();
        }
        /// <summary>
        /// Attaches a ListControlImagePainter instance to the specified Control.
        /// <para>Items should be a list of items where each item implements the
        /// IImageContainer interface and its ToString() returns the text to paint.
        /// </para>
        /// </summary>
        static public void Attach(ComboBox Control, object[] Items)
        {
            Control.BeginUpdate();
            Control.Items.AddRange(Items);
            ListControlImagePainter painter = new ListControlImagePainter(Control);
            Control.EndUpdate();
        }
        /// <summary>
        /// A helper method for creating IImageContainer items with Text.
        /// </summary>
        static public IImageContainer NewItem(string Text, Image Image)
        {
            return new ListItem(Text, Image);
        }
    }


}
