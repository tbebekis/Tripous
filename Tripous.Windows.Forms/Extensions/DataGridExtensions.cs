/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/
 
using System;
using System.Windows.Forms;
using System.Data;
 

namespace Tripous.Windows.Forms
{

    /// <summary>
    /// Extensions
    /// </summary>
    static public class DataGridExtensions
    {
        /// <summary>
        /// Gets the currency manager of the Grid
        /// </summary>
        static public CurrencyManager GetManager(this DataGrid Grid)
        {
            if (Grid.DataSource != null)
            {
                if (Grid.DataSource is BindingSource)
                    return (Grid.DataSource as BindingSource).CurrencyManager;
 
                if (!string.IsNullOrEmpty(Grid.DataMember))
                    if (Grid.BindingContext.Contains(Grid.DataSource, Grid.DataMember))
                        return Grid.BindingContext[Grid.DataSource, Grid.DataMember] as CurrencyManager;
 

                if (Grid.BindingContext.Contains(Grid.DataSource))
                    return Grid.BindingContext[Grid.DataSource] as CurrencyManager;
            }

            return null;
        }
        /// <summary>
        /// Gets the DataTable of the Grid
        /// </summary>
        static public DataTable GetDataTable(this DataGrid Grid)
        { 
            return Ui.DataTableOf(Grid.DataSource, Grid.DataMember); 
        }
        /// <summary>
        /// Returns the current DataRow of Grid, if any, else null.
        /// </summary>
        static public DataRow CurrentRow(this DataGrid Grid)
        {
            if (Grid != null)
            {
                CurrencyManager Manager = Grid.ManagerOf();
                if (Manager != null)
                    return Manager.CurrentRow();
            }

            return null;
        }

        /// <summary>
        /// Creates and returns a DataView based on the passed Table. The DataView becomes the Datasource of the Grid.
        /// <para>It also creates columns for the Grid based on Table columns. </para>
        /// </summary>
        static public DataView PrepareFrom(this DataGrid Grid, DataTable Table, bool ReadOnly)
        {

            DataView Result = new DataView(Table);

            if (ReadOnly)
            {
                Result.AllowDelete = false;
                Result.AllowEdit = false;
                Result.AllowNew = false;
            }

            DataGridTableStyle TableStyle = new DataGridTableStyle();
            TableStyle.MappingName = Table.TableName;

            DataGridTextBoxColumn TextBoxColumn = null;

            foreach (DataColumn Column in Table.Columns)
            {
                if (Column.IsVisible())
                {
                    TextBoxColumn = new DataGridTextBoxColumn();
                    TextBoxColumn.MappingName = Column.ColumnName;
                    TextBoxColumn.HeaderText = Column.Caption;
                    TextBoxColumn.Width = Column.GetWidth();
                    TableStyle.GridColumnStyles.Add(TextBoxColumn);
                }
            }

            if (Grid.TableStyles.Contains(TableStyle.MappingName))
                Grid.TableStyles.Remove(Grid.TableStyles[TableStyle.MappingName]);

            Grid.TableStyles.Add(TableStyle);
            Grid.DataSource = Result;

            return Result;
        }
        /// <summary>
        /// Creates and returns a DataView based on the passed Table. The DataView becomes the Datasource of the Grid.
        /// <para>It also creates columns for the Grid based on Table columns. </para>
        /// </summary>
        static public DataView PrepareFrom(this DataGrid Grid, DataTable Table, bool ReadOnly, string[] VisibleFields, int[] ColumnWidths)
        {
            if ((VisibleFields != null) && (ColumnWidths != null) && (VisibleFields.Length == ColumnWidths.Length))
            {
                for (int i = 0; i < VisibleFields.Length; i++)
                {
                    if (Table.Columns.Contains(VisibleFields[i]))
                    {
                        Table.Columns[VisibleFields[i]].IsVisible(true);
                        Table.Columns[VisibleFields[i]].SetWidth(ColumnWidths[i]);
                    }
                }
            }

            return PrepareFrom(Grid, Table, ReadOnly);
        }

        /// <summary>
        /// Returns the DataGridTableStyle of the Grid for the TableName
        /// </summary>
        static public DataGridTableStyle ColumnsOf(this DataGrid Grid, string TableName)
        {
            if ((Grid != null) && !string.IsNullOrEmpty(TableName) && Grid.TableStyles.Contains(TableName))
                return Grid.TableStyles[TableName];
            return null;
        }
        /// <summary>
        /// Returns the DataGridColumnStyle for the FieldName for the TableName DataGridTableStyle of the Grid
        /// </summary>
        static public DataGridColumnStyle ColumnOf(this DataGrid Grid, string TableName, string FieldName)
        {
            if ((Grid != null) && !string.IsNullOrEmpty(TableName) && !string.IsNullOrEmpty(FieldName))
            {
                DataGridTableStyle TableStyle = ColumnsOf(Grid, TableName);
                if ((TableStyle != null) && TableStyle.GridColumnStyles.Contains(FieldName))
                    return TableStyle.GridColumnStyles[FieldName];
            }

            return null;
        }
        /// <summary>
        /// Returns true if the Grid has a defined DataGridTableStyle for the TableName
        /// </summary>
        static public bool HasColumns(this DataGrid Grid, string TableName)
        {
            return ColumnsOf(Grid, TableName) != null;
        }
        /// <summary>
        /// Returns true if the Grid has a defined DataGridColumnStyle for the TableName and FieldName.
        /// </summary>
        static public bool HasColumn(this DataGrid Grid, string TableName, string FieldName)
        {
            return ColumnOf(Grid, TableName, FieldName) != null;
        }
    }
}
 