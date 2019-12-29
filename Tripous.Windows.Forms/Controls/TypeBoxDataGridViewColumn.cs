/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Tripous.Windows.Forms
{


    /// <summary>
    /// A IDataGridViewEditingControl for the TypeBoxDataGridViewColumn.
    /// <para>
    /// Usefull information on creating custom columns at 
    /// http://www.theogray.com/blog/2009/06/custom-datagridviewcolumn-idatagridvieweditingcont
    /// </para>
    /// </summary>
    [ToolboxItem(false)]
    [DesignTimeVisible(false)]
    public class TypeBoxEditingControl : TypeBox, IDataGridViewEditingControl
    {

        private DataGridView dataGridView;
        private int rowIndex;
        private bool valueChanged;

        private bool isEntered;

        private void NotifyDataGridViewOfValueChange()
        {
            this.valueChanged = true;
            this.dataGridView.NotifyCurrentCellDirty(true);
        }

        /// <summary>
        /// Returns true if the button MUST be visible
        /// </summary>
        protected override bool CanDisplayButton { get { return base.CanDisplayButton && isEntered; } }

        /// <summary>
        /// Returns the column associated to this editing control
        /// </summary>
        protected virtual TypeBoxDataGridViewColumn Column
        {
            get
            {
                if (EditingControlDataGridView != null)
                    if (EditingControlDataGridView.CurrentCell != null)
                        if (EditingControlDataGridView.CurrentCell.OwningColumn != null)
                            if (EditingControlDataGridView.CurrentCell.OwningColumn is TypeBoxDataGridViewColumn)
                                return EditingControlDataGridView.CurrentCell.OwningColumn as TypeBoxDataGridViewColumn;
                return null;
            }
        }

        /* overrides */
        /// <summary>
        /// Override
        /// </summary>
        protected override void LayoutButton()
        {
            if (!CanDisplayButton)
            {
                button.Visible = false;
                button.Parent = null;
            }
            else
            {
                DataGridView Grid = EditingControlDataGridView;
                if ((Grid != null) && (this.Parent != null))
                {
                    button.BackColor = SystemColors.ButtonFace;
                    button.Parent = this.Parent;
                    button.Visible = true;
                    button.Height = this.Parent.Height;
                    button.Width = this.Parent.Height;

                    button.BringToFront();

                    this.Width = this.Parent.Width - button.Width - 6;

                    button.Top = 0;
                    button.Left = this.Parent.Width - button.Width;
                }
            }
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnValueChanged()
        {
            base.OnValueChanged();
            NotifyDataGridViewOfValueChange();
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            NotifyDataGridViewOfValueChange();
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (Visible)
                PerformLayout();
            else
                button.Parent = null;
        }
        /// <summary>
        /// Returns the drop-down width
        /// </summary>
        protected override int DropDownWidth
        {
            get
            {
                DataGridView Grid = EditingControlDataGridView;
                if ((Grid != null) && (this.Parent != null))
                    return this.Parent.Width;

                return base.DropDownWidth;
            }
        }
        /// <summary>
        /// Returns the drop down Location
        /// </summary>
        protected override Point DropDownLocation
        {
            get
            {
                DataGridView Grid = EditingControlDataGridView;
                if ((Grid != null) && (this.Parent != null))
                {
                    Point P = this.Parent.PointToScreen(new Point(0, 0));
                    P.Y += this.Parent.Height;
                    //P.X -= 2;
                    return P;
                }

                return base.DropDownLocation;

            }
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnEnter(EventArgs e)
        {
            isEntered = true;
            base.OnEnter(e);
            LayoutButton();
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnLeave(EventArgs e)
        {
            isEntered = false;
            base.OnLeave(e);
        }

        /* constuction */
        /// <summary>
        /// Constructor.
        /// </summary>
        public TypeBoxEditingControl()
        {
        }

        /* methods */
        /// <summary>
        /// Changes the control's user interface (UI) to be consistent with the specified cell style.
        /// </summary>
        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.ForeColor = dataGridViewCellStyle.ForeColor;
            this.BackColor = dataGridViewCellStyle.BackColor;
        }
        /// <summary>
        /// Retrieves the formatted value of the cell.
        /// </summary>
        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            return this.Text;
        }
        /// <summary>
        /// Prepares the currently selected cell for editing.
        /// </summary>
        public void PrepareEditingControlForEdit(bool selectAll)
        {
            if (Column != null)
                DataType = Column.DataType;
            if (selectAll)
                base.SelectAll();
            else
                base.SelectionStart = this.Text.Length;
        }
        /// <summary>
        /// Determines whether the specified key is a regular input key that the editing
        /// control should process or a special key that the System.Windows.Forms.DataGridView
        /// should process.
        /// </summary>
        public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
        {
            return dataGridViewWantsInputKey;
        }

        /* properties */
        /// <summary>
        /// Gets or sets the System.Windows.Forms.DataGridView that contains the cell.
        /// </summary>
        public DataGridView EditingControlDataGridView
        {
            get { return dataGridView; }
            set { dataGridView = value; }
        }
        /// <summary>
        /// Gets or sets the formatted value of the cell being modified by the editor.
        /// </summary>
        public object EditingControlFormattedValue
        {
            //*
            get { return this.Text; }
            set
            {
                if (value is string)
                    AsString = (string)value;
                else
                    Value = value;
            }
            //*/
            /*
            get 
            {
                if ((Value != null) && (Value != DBNull.Value) && (typeConverter != null) && (typeConverter.CanConvertFrom(Value.GetType())))
                    return typeConverter.ConvertToString(Value);
                
                return string.Empty; 
            }
            set
            {
                if (value is string)
                {
                    if (typeConverter != null)
                        Value = typeConverter.ConvertFromString(value as string);
                }
                else
                {
                    Value = value;
                }          
            }
            //*/
        }
        /// <summary>
        ///  Gets or sets the index of the hosting cell's parent row.
        /// </summary>
        public int EditingControlRowIndex
        {
            get { return rowIndex; }
            set { rowIndex = value; }
        }
        /// <summary>
        /// Gets or sets a value indicating whether the value of the editing control differs from the value of the hosting cell.
        /// </summary>
        public bool EditingControlValueChanged
        {
            get { return valueChanged; }
            set { valueChanged = value; }
        }
        /// <summary>
        /// Gets the cursor used when the mouse pointer is over the System.Windows.Forms.DataGridView.EditingPanel but not over the editing control.
        /// </summary>
        public Cursor EditingPanelCursor { get { return base.Cursor; } }
        /// <summary>
        /// Gets or sets a value indicating whether the cell contents need to be repositioned whenever the value changes.
        /// </summary>
        public bool RepositionEditingControlOnValueChange { get { return false; } }

    }


    /// <summary>
    /// A cell class for the TypeBoxDataGridViewColumn column.
    /// </summary>
    public class TypeBoxCell : DataGridViewTextBoxCell
    {
        /* construction */
        /// <summary>
        /// Constructor.
        /// </summary>
        public TypeBoxCell()
            : base()
        {
        }

        /* properties */
        /// <summary>
        /// Returns the type of the cell's hosted editing control.
        /// </summary>
        public override Type EditType { get { return typeof(TypeBoxEditingControl); } }

        /*
        public override System.Type ValueType
        {
            get
            {
                TypeBoxDataGridViewColumn Column = this.OwningColumn as TypeBoxDataGridViewColumn;
                if (Column != null)
                    return Column.DataType;

                return base.ValueType;
            }
        }
        //*/
    }




    /// <summary>
    /// A DataGridViewColumn to host a TypeBox
    /// </summary>
    public class TypeBoxDataGridViewColumn : DataGridViewColumn
    {
        private Type dataType;

        /* constructor */
        /// <summary>
        /// Constructor
        /// </summary>
        public TypeBoxDataGridViewColumn()
        {
            base.CellTemplate = new TypeBoxCell();
        }

        /// <summary>
        /// Clones the column.
        /// </summary>
        public override object Clone()
        {
            TypeBoxDataGridViewColumn Result = base.Clone() as TypeBoxDataGridViewColumn;
            Result.DataType = dataType;
            return Result;
        }

        /// <summary>
        /// Returns a string representation of this instance
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();

            SB.Append(GetType().Name);
            SB.Append(" { Name=");
            SB.Append(this.Name);
            SB.Append(", Index=");
            SB.Append(base.Index.ToString(CultureInfo.CurrentCulture));
            SB.Append(" }");
            return SB.ToString();
        }

        /* properties */
        /// <summary>
        /// Gets or sets the template used to model cell appearance.
        /// </summary>
        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                if (value != null && !(value is TypeBoxCell))
                    throw new InvalidCastException("Must be a TypeBoxCell");

                base.CellTemplate = value;
            }
        }
        /// <summary>
        /// Gets or sets the data type
        /// </summary>
        public Type DataType
        {
            get { return dataType; }
            set { dataType = value; }
        }
    }
}
