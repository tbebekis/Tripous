using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripous.Forms.Standard
{

#pragma warning disable CS1591

    public partial class DataFormStandard : DataForm
    {
 
        protected DataGridView gridList;
        protected Panel pnlItem;
        protected Panel pnlFind;


        /* event handlers */
        void AnyClick(object sender, EventArgs ea)
        {
            if (sender is ToolStripItem)
            {
                ToolStripItem Item = sender as ToolStripItem;
                FormAction Value = (FormAction)Item.Tag;
                Execute(Value);
            }
        }
        void Grid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ExecuteEdit();
        }


        /* overrides */
        protected override void FormStateChanged()
        {
            if (gridList != null)
            {
                switch (FormState)
                {
                    case FormState.List:
                        gridList.Visible = true;
                        pnlItem.Visible = false;
                        pnlFind.Visible = false;

                        gridList.BringToFront();
                        break;
                    case FormState.Insert:
                    case FormState.Edit:
                        gridList.Visible = false;
                        pnlItem.Visible = true;
                        pnlFind.Visible = false;

                        pnlItem.BringToFront();
                        break;
                    case FormState.Find:
                        gridList.Visible = false;
                        pnlItem.Visible = false;
                        pnlFind.Visible = true;

                        pnlFind.BringToFront();
                        break;
                }
            } 
        }
 
        protected override object GetCurrentListId()
        {
            object Result = null;

            if (gridList != null)
            {
                DataRow Row = gridList.CurrentDataRow();
                if (Row != null)
                {
                    DataColumn Column = Row.Table.FindColumn(Options.KeyField);
                    if (Column != null)
                    {
                        Result = Row[Column];
                    }
                }
            }

            return Result;
        }
        protected override void CreateListGrid()
        {
            gridList = new DataGridView();
            gridList.Visible = false;
            gridList.Dock = DockStyle.Fill;
            gridList.Parent = this;
        }
        protected override void CreateItemPanel()
        {
            pnlItem = new Panel();
            pnlItem.Visible = false;
            pnlItem.Dock = DockStyle.Fill;
            pnlItem.Parent = this;
        }
        protected override void CreateFindPanel()
        {
            pnlFind = new Panel();
            pnlFind.Visible = false;
            pnlFind.Dock = DockStyle.Fill;
            pnlFind.Parent = this;
        }
 
        /* overrides */
        protected override void FormInitializeBefore()
        {
            btnFind.Tag = FormAction.Find;
            btnList.Tag = FormAction.List;
            btnInsert.Tag = FormAction.Insert;
            btnEdit.Tag = FormAction.Edit;
            btnDelete.Tag = FormAction.Delete;
            btnSave.Tag = FormAction.Save;
            btnCancel.Tag = FormAction.Cancel;
            btnClose.Tag = FormAction.Close;
            btnOK.Tag = FormAction.OK;


            btnFind.Click += AnyClick;

            btnList.Click += AnyClick;
            btnInsert.Click += AnyClick;
            btnEdit.Click += AnyClick;
            btnDelete.Click += AnyClick;
            btnSave.Click += AnyClick;

            btnCancel.Click += AnyClick;
            btnClose.Click += AnyClick;
            btnOK.Click += AnyClick;

            base.FormInitializeBefore();
 
        }
 
        /// <summary>
        /// Enables and disables buttons and menu items.
        /// </summary>
        protected override void EnableCommands()
        {
            if (!IsDisposed)
            {
                base.EnableCommands();

                if (btnHome == null)
                    return;

                // visible ===============================================================
                btnHome.Visible = true;
                btnFind.Visible = IsMasterForm;
                edtFind.Visible = btnFind.Visible;
                btnList.Visible = IsMasterForm;

                btnInsert.Visible = IsMasterForm;
                btnEdit.Visible = IsMasterForm;
                btnDelete.Visible = true;
                btnInsert.Visible = IsMasterForm;

                btnCancel.Visible = true;                       // btnCancel - visible with all form modes
                btnOK.Visible = IsListForm || Modal;
                btnClose.Visible = IsMasterMode && !Modal;      // btnClose - visible with non-list master forms

                // enable ================================================================
                btnHome.Enabled = btnHome.HasDropDownItems;
                btnFind.Enabled = Options != null && !Bf.In(FormAction.Find, Options.InvalidActions);
                btnList.Enabled = Options != null && !Bf.In(FormAction.List, Options.InvalidActions);
                
                btnInsert.Enabled = Options != null && !Bf.In(FormAction.Insert, Options.InvalidActions) && !Bf.In(FormState, FormState.Insert | FormState.Edit) && FormMode != FormType.List;
                btnEdit.Enabled = Options != null && !Bf.In(FormAction.Insert, Options.InvalidActions) && !Bf.In(FormState, FormState.Insert | FormState.Edit) && FormMode != FormType.List;
                btnDelete.Enabled = Options != null && !Bf.In(FormAction.Delete, Options.InvalidActions) && FormMode == FormType.List && gridList != null && gridList.RowCount > 0;
                btnSave.Enabled = (IsMasterForm && Bf.In(FormState, FormState.Insert | FormState.Edit)) || (IsListMode && FormState == FormState.List);
 
                // List state and Modal: cancels the form
                // List state and List forms: closes the form without saving
                // Edit states: cancels edits and returns to List state
                btnCancel.Enabled = IsListMode
                    || (IsMasterForm && Bf.In(FormState, FormState.Insert | FormState.Edit))
                    || (IsMasterForm && Bf.In(FormState, FormState.List | FormState.Find));

                // btnOK - accessible in List state only, with list forms and all modal forms
                // List state and Modal: saves any edits, closes the form with OK and returns the current row               
                btnOK.Enabled = IsListForm || (Modal && FormState == FormState.List);
 
                // List state: closes the form                
                btnClose.Enabled = IsMasterMode && Bf.In(FormState, FormState.List | FormState.Find);
            }       

            
        }

        protected virtual ToolStripButton AddButton(string ButtonName, string Text, Image Image, EventHandler Click)
        {
            return Ui.CreateToolStripButton(ButtonName, ToolStripItemDisplayStyle.Image, Text, Image, Click, ToolBar.Items) as ToolStripButton;

        }
        
        /* construction */
        public DataFormStandard()
        {
            InitializeComponent();
        }

 
 
    }


 
}
