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

using Tripous.Data;

namespace Tripous.Forms
{

    /// <summary>
    /// An editing control for the memo column
    /// </summary>
    public class DataGridViewImageEditingControl : DataGridViewButtonedEditingControl
    {
        /* overrides */
        /// <summary>
        /// Override
        /// </summary>
        protected override void ButtonClicked()
        {
            DataRow Row = EditingControlDataGridView.CurrentDataRow();
            if (Row != null)
            {
                Rectangle R = EditingControlDataGridView.GetCellDisplayRectangle(Column.Index, EditingControlRowIndex, false);

                Point P = EditingControlDataGridView.PointToScreen(new Point(R.Left, R.Top + R.Height));

                PopUpForm form = PopUpForm.Blob(Row, Column.DataPropertyName, BlobType.Image);
                form.UseSpecifiedBounds = true;
                form.SpecifiedBounds = new Rectangle(P, new Size(form.StdMinWidth, form.StdMinHeight));
                form.DropDown();
            }
        }
 

        /* constuction */
        /// <summary>
        /// Constructor.
        /// </summary>
        public DataGridViewImageEditingControl()
        { 
        }
 
    }






    /// <summary>
    /// A cell for a memo column
    /// </summary>
    public class DataGridViewImageCellEx : DataGridViewTextBoxCell
    {

        /* overrides */
        /// <summary>
        /// Override
        /// </summary>
        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            if ((paintParts & DataGridViewPaintParts.ContentForeground) == DataGridViewPaintParts.ContentForeground)
            {
                if ((this.FormattedValue != null) && !string.IsNullOrWhiteSpace(this.FormattedValue.ToString()))
                    formattedValue = "[image]";
                else
                    formattedValue = string.Empty;
            }

            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
        }
        
        
        /* construction */
        /// <summary>
        /// Constructor.
        /// </summary>
        public DataGridViewImageCellEx()
        {
        }

        /* properties */
        /// <summary>
        /// Returns the type of the cell's hosted editing control.
        /// </summary>
        public override Type EditType { get { return typeof(DataGridViewImageEditingControl); } }
        /// <summary>
        ///  Gets the type of the formatted value associated with the cell.
        /// </summary>
        public override Type FormattedValueType { get { return typeof(string); } }

    }







    /// <summary>
    /// A DataGridViewImageColumn with a button
    /// </summary>
    public class DataGridViewImageColumnEx : DataGridViewImageColumn
    {
        delegate void ReplaceCellType(int iRowIndex);

        bool isCellReplaced = false;
        DataGridView dgv;
        bool nullImageDisabled = true;
        object defaultNullValue;

        /* private */
        /*  
                void CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
                {
                    if (!this.ReadOnly && !DataGridView.ReadOnly && DataGridView.Enabled && (e.ColumnIndex == this.Index) && (e.Button == MouseButtons.Right))
                    {
                        DataRow Row = DataGridView.CurrentDataRow();
                        if (Row != null)
                        {
                            Rectangle R = dgv.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                            Point P = DataGridView.PointToScreen(new Point(R.Left, R.Top + R.Height));

                            PopUpForm form = PopUpForm.Blob(Row, DataPropertyName, PopUpBlobType.Image);
                            form.UseSpecifiedBounds = true;
                            form.SpecifiedBounds = new Rectangle(P, new Size(form.StdMinWidth, form.StdMinHeight));
                            form.DropDown();                    
                        }
                    }
                } 
         */
        void DataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.Index)
            {
                ReplaceCellType method = new ReplaceCellType(OnReplaceCellType);

                this.DataGridView.BeginInvoke(method, e.RowIndex);
                isCellReplaced = false;
            } 
        }
        void OnReplaceCellType(int RowIndex)
        {
            if (isCellReplaced == false)
            {
                DataGridViewImageCellEx cell = new DataGridViewImageCellEx();
                DataGridView.Rows[RowIndex].Cells[DataGridView.CurrentCell.ColumnIndex] = cell;
                isCellReplaced = true;
            }
        } 

        /* overrides */
        /// <summary>
        ///  Called when the band is associated with a different System.Windows.Forms.DataGridView.
        /// </summary>
        protected override void OnDataGridViewChanged()
        {
            if (dgv != null)
                dgv.CellEnter -= DataGridView_CellEnter;

            base.OnDataGridViewChanged();

            dgv = null;
            dgv = this.DataGridView;

            if (dgv != null)
                dgv.CellEnter += DataGridView_CellEnter;
        }



        /* construction */
        /// <summary>
        /// Constructor.
        /// </summary>
        public DataGridViewImageColumnEx()
            : this(false)
        {
        }
        /// <summary>
        /// Constructor.
        /// </summary>
        public DataGridViewImageColumnEx(bool valuesAreIcons)
            : base(valuesAreIcons)
        {
            defaultNullValue = DefaultCellStyle.NullValue;
            DefaultCellStyle.NullValue = null;
        }


        /* public */
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
            SB.Append(base.Index.ToString(System.Globalization.CultureInfo.CurrentCulture));
            SB.Append(" }");
            return SB.ToString();
        }
        

        /* properties */
        /// <summary>
        /// When true, the default, no null image is displayed
        /// </summary>
        [DefaultValue(true), Description("When true, the default, no null image is displayed")]
        public bool IsNullImageDisabled
        {
            get { return nullImageDisabled; }
            set
            {
                if (value != nullImageDisabled)
                {
                    DefaultCellStyle.NullValue = value ? null : defaultNullValue;
                }
            }
        }
    }





}













