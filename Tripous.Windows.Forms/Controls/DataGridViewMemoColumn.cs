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

namespace Tripous.Windows.Forms
{








    /// <summary>
    /// An editing control for the memo column
    /// </summary>
    public class DataGridViewMemoEditingControl : DataGridViewButtonedEditingControl
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

                PopUpForm form = PopUpForm.Blob(Row, Column.DataPropertyName, BlobType.Text);
                form.UseSpecifiedBounds = true;
                form.SpecifiedBounds = new Rectangle(P, new Size(form.StdMinWidth, form.StdMinHeight));
                form.DropDown();
            }
        }

        

        /* constuction */
        /// <summary>
        /// Constructor.
        /// </summary>
        public DataGridViewMemoEditingControl()
        {
        }

    }






    /// <summary>
    /// A cell for a memo column
    /// </summary>
    public class DataGridViewMemoCell : DataGridViewTextBoxCell
    {

        /* construction */
        /// <summary>
        /// Constructor.
        /// </summary>
        public DataGridViewMemoCell()
        {
        }
 
        /* properties */
        /// <summary>
        /// Returns the type of the cell's hosted editing control.
        /// </summary>
        public override Type EditType { get { return typeof(DataGridViewMemoEditingControl); } }
        /// <summary>
        ///  Gets the type of the formatted value associated with the cell.
        /// </summary>
        public override Type FormattedValueType { get { return typeof(string); } }
 
    }








    /// <summary>
    /// A memo column
    /// </summary>
    public class DataGridViewMemoColumn: DataGridViewColumn
    {

        /* construction */
        /// <summary>
        /// Constructor.
        /// </summary>
        public DataGridViewMemoColumn()
        {
            CellTemplate = new DataGridViewMemoCell();
        }


        /* properties */
        /// <summary>
        /// Gets or sets the template used to model cell appearance.
        /// </summary>
        public override DataGridViewCell CellTemplate
        {
            get { return base.CellTemplate; } 
            set
            {
                if (value != null && !value.GetType().IsAssignableFrom(typeof(DataGridViewMemoCell)))
                    throw new InvalidCastException("Must be a DataGridViewMemoCell");

 
                base.CellTemplate = value;
            }
        }
    }
}
