/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

 


namespace Tripous.Forms
{
 


    /// <summary>
    /// An editing control with a right docked button, suitable for creating drop-down-like columns
    /// </summary>
    public class DataGridViewButtonedEditingControl : Control, IDataGridViewEditingControl
    {
        Button button;

        /* private */
        /// <summary>
        /// Event handler
        /// </summary>
        void Button_Click(object sender, EventArgs e)
        {
            if (CanClick)
            {
                ButtonClicked();
            }
        }


        /* overridables */
        /// <summary>
        /// Creates and returns the button
        /// </summary>
        protected virtual Button CreateButton()
        {
            Button  Result = new Button();
            Result.BackgroundImage = Tripous.Forms.Properties.Resources.i16_bullet_arrow_down; //  Res.GetImage(Icons16.Bullet_Arrow_Down);
            Result.BackgroundImageLayout = ImageLayout.Zoom;
            Result.FlatStyle = FlatStyle.Flat;

            return Result;            
        }
        /// <summary>
        /// Handles the button click event
        /// </summary>
        protected virtual void ButtonClicked()
        {
            /*  
                            DataRow Row = EditingControlDataGridView.CurrentDataRow();
                            if (Row != null)
                            {
                                Rectangle R = EditingControlDataGridView.GetCellDisplayRectangle(Column.Index, EditingControlRowIndex, false);

                                Point P = EditingControlDataGridView.PointToScreen(new Point(R.Left, R.Top + R.Height));

                                PopUpForm form = PopUpForm.Blob(Row, Column.DataPropertyName, PopUpBlobType.Image);
                                form.UseSpecifiedBounds = true;
                                form.SpecifiedBounds = new Rectangle(P, new Size(form.StdMinWidth, form.StdMinHeight));
                                form.DropDown();
                            } 
             */
        }

        /// <summary>
        /// Returns the column associated to this editing control
        /// </summary>
        protected virtual DataGridViewColumn Column
        {
            get
            {
                if ((EditingControlDataGridView != null) && (EditingControlDataGridView.CurrentCell != null))
                    return EditingControlDataGridView.CurrentCell.OwningColumn;

                return null;
            }
        }
        /// <summary>
        /// True if ButtonClicked can be called.
        /// </summary>
        protected virtual bool CanClick { get { return this.Enabled && !EditingControlDataGridView.ReadOnly && EditingControlDataGridView.Enabled; } }

        /* overrides */
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);

            if (button == null)
            {
                button = CreateButton();

                button.Dock = DockStyle.Right;
                button.Parent = this;
                button.Text = string.Empty;

                button.Click += new EventHandler(Button_Click);
            }

            button.FlatAppearance.BorderColor = button.Parent.BackColor;
            button.Height = this.Height;
            button.Width = this.Height;
        }


        /* constuction */
        /// <summary>
        /// Constructor.
        /// </summary>
        public DataGridViewButtonedEditingControl()
        {
        }

        /* public */
        /// <summary>
        /// Changes the control's user interface (UI) to be consistent with the specified cell style.
        /// </summary>
        public virtual void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.ForeColor = dataGridViewCellStyle.ForeColor;
            this.BackColor = dataGridViewCellStyle.BackColor;
        }
        /// <summary>
        /// Determines whether the specified key is a regular input key that the editing
        /// control should process or a special key that the System.Windows.Forms.DataGridView
        /// should process.
        /// </summary>
        public virtual bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
        {
            return true;
        }
        /// <summary>
        /// Retrieves the formatted value of the cell.
        /// </summary>
        public virtual object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            return EditingControlFormattedValue;
        }
        /// <summary>
        /// Prepares the currently selected cell for editing.
        /// </summary>
        public virtual void PrepareEditingControlForEdit(bool selectAll)
        {
        }


        /* properties */
        /// <summary>
        /// Gets or sets the System.Windows.Forms.DataGridView that contains the cell.
        /// </summary>
        public virtual DataGridView EditingControlDataGridView { get; set; }
        /// <summary>
        /// Gets or sets the formatted value of the cell being modified by the editor.
        /// </summary>
        public virtual object EditingControlFormattedValue { get; set; }
        /// <summary>
        ///  Gets or sets the index of the hosting cell's parent row.
        /// </summary>
        public virtual int EditingControlRowIndex { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the value of the editing control differs from the value of the hosting cell.
        /// </summary>
        public virtual bool EditingControlValueChanged { get; set; }
        /// <summary>
        /// Gets the cursor used when the mouse pointer is over the System.Windows.Forms.DataGridView.EditingPanel but not over the editing control.
        /// </summary>
        public virtual Cursor EditingPanelCursor { get { return this.Cursor; } }
        /// <summary>
        /// Gets or sets a value indicating whether the cell contents need to be repositioned whenever the value changes.
        /// </summary>
        public virtual bool RepositionEditingControlOnValueChange { get { return false; } }
    }





}
