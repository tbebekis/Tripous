/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Tripous.Windows.Forms
{


    /// <summary>
    /// A TextBox
    /// </summary>
    [ToolboxBitmap(typeof(TextBox))]
    public class TextBoxEx : TextBox
    {

        private PictureBoxButton button;
        private TextBoxMode mode;
        private string lastFolder;
        private PopUpForm popUpForm;

        /* private */
        void PopUpForm_CloseBefore(object sender, EventArgs e)
        {
            if (popUpForm.PopUpResult)
            {
                if (Mode == TextBoxMode.Date)
                    this.Text = popUpForm.Calendar.SelectionStart.ToShortDateString();
                else if (Mode == TextBoxMode.Memo)
                    this.Text = popUpForm.Memo.Text;
            }

            popUpForm = null;
        }
        void button_Click(object sender, EventArgs e)
        {

            bool NotClickable = ((Mode == TextBoxMode.Custom) && !CustomButtonClickable && !Enabled)
                                || ((Mode != TextBoxMode.Custom) && (!Enabled || ReadOnly));

            if (NotClickable)
                return;


            switch (Mode)
            {

                case TextBoxMode.Date:
                    if (popUpForm != null)
                        popUpForm.Close();
                    else
                    {
                        DateTime Date = Sys.StrToDate(this.Text, DateTime.Today);
                        popUpForm = PopUpForm.Date(Date);
                        popUpForm.CloseBefore += new EventHandler(PopUpForm_CloseBefore);
                        popUpForm.Associate = this;
                        popUpForm.DropDown();
                    }

                    break;

                case TextBoxMode.Memo:
                    if (popUpForm != null)
                        popUpForm.Close();
                    else
                    {
                        popUpForm = PopUpForm.MemoText(this.Text);
                        popUpForm.CloseBefore += new EventHandler(PopUpForm_CloseBefore);
                        popUpForm.Associate = this;
                        popUpForm.DropDown();
                    }
                    break;

                case TextBoxMode.Folder:
                    string Folder = this.Text;
                    if (FileBox.GetFolder(ref Folder, lastFolder, true))
                    {
                        this.Text = Folder;
                        lastFolder = Folder;
                    }
                    break;

                case TextBoxMode.FileName:
                    string FileName = this.Text;
                    if (FileBox.Open(ref FileName))
                        this.Text = FileName;
                    break;

                case TextBoxMode.Custom:
                    if (ButtonClicked != null)
                        ButtonClicked(this, EventArgs.Empty);
                    break;
            }

        }

        /// <summary>
        /// Layouts the button
        /// </summary>
        void LayoutButton()
        {
            if ((button == null) || (button.Parent == null))
                return;

            switch (this.BorderStyle)
            {
                case BorderStyle.Fixed3D:
                    button.Width = Height - 1;
                    button.Height = Height - 3;
                    button.Top = 0;
                    button.Left = Width - (button.Width + 3);
                    break;
                case BorderStyle.FixedSingle:
                    button.Width = Height - 1;
                    button.Height = Height - 2;
                    button.Top = 1;
                    button.Left = Width - (button.Width + 1);
                    break;
                case BorderStyle.None:
                    button.Width = Height - 1;
                    button.Height = Height - 1;
                    button.Top = 0;
                    button.Left = Width - (button.Width + 1);
                    break;
            }

            button.Visible = Bf.Member(mode, TextBoxMode.Date | TextBoxMode.FileName | TextBoxMode.Folder | TextBoxMode.Memo | TextBoxMode.Custom);
        }

        /* overrides */
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            LayoutButton();
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnLostFocus(EventArgs e)
        {
            if ((Mode == TextBoxMode.Date) && Enabled && !ReadOnly && !string.IsNullOrEmpty(this.Text))
            {
                this.Text = Sys.NormalizeDateTime(this.Text);
            }

            base.OnLostFocus(e);
        }
 

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public TextBoxEx()
            : base()
        {
            button = new PictureBoxButton();
 
            //button.FlatAppearance.BorderColor = SystemColors.Control;
            //button.FlatStyle = FlatStyle.Flat;
            button.BackColor = SystemColors.Control;
            button.Visible = false;
            button.Click += new EventHandler(button_Click);
            button.Parent = this;
            button.Image = Tripous.Windows.Forms.Properties.Resources.i16_bullet_arrow_down; // Res.GetImage(Icons16.Bullet_Arrow_Down);
   
            CustomButtonClickable = true;

            LayoutButton();
        }


        /* properties */ 
        /// <summary>
        /// Gets or sets the mode of the control.
        /// </summary>
        [DefaultValue(TextBoxMode.None), Description("Gets or sets the mode of the control.")]
        public TextBoxMode Mode
        {
            get { return mode; }
            set
            {
                if (mode == value)
                    return;

                mode = value;
                LayoutButton();
            }
        }
        /// <summary>
        /// When true and in Custom mode, the button remains clickable, even when ReadOnly is true.
        /// </summary>
        [DefaultValue(true), Browsable(true), Description("When true and in Custom mode, the button remains clickable, even when ReadOnly is true.")]
        public bool CustomButtonClickable { get; set; }

        /* events */
        /// <summary>
        /// Occurs when the Mode is set to Custom and button is pressed.
        /// </summary>
        public event EventHandler ButtonClicked;
 
    }

 
}
