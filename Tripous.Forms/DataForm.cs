using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripous.Forms
{
    public partial class DataForm : BaseForm
    {
        protected FormState fFormState = FormState.None;
        protected bool Saving;
 
        protected DataGridView gridList;
        protected Panel pnlItem;
        protected Panel pnlFind;


        /* event handlers */
        void AnyClick(object sender, EventArgs ea)
        {
            if (btnFind == sender)
            {
                Find();
            }
            else if(btnList == sender)
            {
                DataList();
            }
            else if (btnInsert == sender)
            {
                DataInsert();
            }
            else if (btnEdit == sender)
            {
                DataEdit();
            }
            else if (btnDelete == sender)
            {
                DataDelete();
            }
            else if (btnSave == sender)
            {
                DataSave();
            }
            else if (btnCancel == sender)
            {
                if (IsListMode)
                {
                    if (Modal)
                    {
                        this.DialogResult = DialogResult.Cancel;
                    }
                    else
                    {
                        Close();
                    }
                }
                else if (IsMasterForm)
                {
                    if (Modal)
                    {
                        if (Bf.In(FormState, FormState.List | FormState.Find))
                        {
                            this.DialogResult = DialogResult.Cancel;
                        }
                        else if (Bf.In(FormState, FormState.Insert | FormState.Edit))
                        {
                            DataCancelEdit();
                        }                        
                    }
                    else
                    {
                        if (Bf.In(FormState, FormState.List | FormState.Find))
                        {
                            Close();
                        }
                        else if (Bf.In(FormState, FormState.Insert | FormState.Edit))
                        {
                            DataCancelEdit();
                        }
                    }
                }               
            }
            else if (btnOK == sender)
            {
                if (IsListMode)
                {
                    ListSave();

                    if (Modal)
                    {
                        this.DialogResult = DialogResult.Cancel;
                    }
                    else
                    {
                        Close();
                    }
                }
                else if (IsMasterForm)
                {
                    if (Modal)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        Close();
                    } 
                }
            }
            else if (btnClose == sender)
            {
                Close();
            }

            if (!IsDisposed)
            {
                UpdateUi();
            }

        }
        void Grid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataEdit();
        }

        protected virtual FormState FormState
        {
            get { return fFormState; }
            set
            {
                if (value != fFormState)
                {
                    fFormState = value;
                    FormStateChanged();
                }
            }
        }

        /* overridables */
        protected virtual void DataList()
        {
            if (!Saving && Bf.In(FormState, FormState.Insert | FormState.Edit))
            {
                if (!DataCancelEdit())
                    return;
            }

            ListSelect();
            this.FormState = FormState.List;
        }

        protected virtual void DataInsert()
        {
            ItemInsert();
            this.FormState = FormState.Insert;
            ItemInserted();            
        }
        protected virtual void DataEdit(object oId = null)
        {
            if (oId == null)
                oId = ListGetCurrentId();

            if (!Sys.IsNull(oId))
            {
                ItemLoad(oId);
                this.FormState = FormState.Edit;
                ItemLoaded();
            }
        }
        protected virtual void DataDelete()
        {
            if (Ui.YesNoBox("Delete item?"))
            {
                ItemDelete();
            }
        }
        protected virtual void DataSave()
        {
            CheckSave();

            Saving = true;
            try
            {
                ItemSave();               
            }
            finally
            {
                Saving = false;
            }

            this.FormState = FormState.Edit;
            ItemSaved();
        }
        protected virtual bool DataCancelEdit()
        {
            if (ItemHasChanges())
            {
                if (!Ui.YesNoBox("Cancel changes?"))
                    return false;

                ItemCancelChanges();
            }
  
            return true;
        }

        protected virtual void Find()
        {
            this.FormState = FormState.Find;
        }

        protected virtual void ListSelect()
        {
        }
        protected virtual void ListSave()
        {
        }
        protected virtual object ListGetCurrentId()
        {
            object Result = null;

            DataRow Row = gridList.CurrentDataRow();
            if (Row != null)
            {
                DataColumn Column = Row.Table.FindColumn(Options.KeyField);
                if (Column != null)
                {
                    Result = Row[Column]; 
                }
            }

            return Result;
        }

        protected virtual void ItemBind()
        {
        }
        protected virtual bool ItemHasChanges()
        {
            return false;
        }
        protected virtual void ItemLoad(object oId)
        {
        }
        protected virtual void ItemLoaded()
        {
        } 
        protected virtual void ItemCancelChanges()
        {
        }
        protected virtual void ItemInsert()
        {
        }
        protected virtual void ItemInserted()
        {
        }
        protected virtual void ItemSave()
        {
        }
        protected virtual void ItemSaved()
        {
        }
        protected virtual void ItemDelete()
        {
        }
        protected virtual void CheckSave()
        {
        }
 
        protected virtual void CreateListGrid()
        {
            gridList = new DataGridView();
            gridList.Visible = false;
            gridList.Dock = DockStyle.Fill;
            gridList.Parent = this;
        }
        protected virtual void CreateItemPanel()
        {
            pnlItem = new Panel();
            pnlItem.Visible = false;
            pnlItem.Dock = DockStyle.Fill;
            pnlItem.Parent = this;
        }
        protected virtual void CreateFindPanel()
        {
            pnlFind = new Panel();
            pnlFind.Visible = false;
            pnlFind.Dock = DockStyle.Fill;
            pnlFind.Parent = this;
        }

        protected virtual ToolStripButton AddButton(string ButtonName, string Text, Image Image, EventHandler Click)
        {
            return Ui.CreateToolStripButton(ButtonName, ToolStripItemDisplayStyle.Image, Text, Image, Click, ToolBar.Items) as ToolStripButton;
        }
        protected virtual void FormStateChanged()
        {
            switch (FormState)
            {
                case FormState.None:
                    break;
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
                case FormState.Delete:
                    break;
                case FormState.Find:
                    gridList.Visible = false;
                    pnlItem.Visible = false;
                    pnlFind.Visible = true;

                    pnlFind.BringToFront();
                    break;
            }

            UpdateUi();
        }
 
        /* overrides */
        protected override void FormInitializeBefore()
        {
 
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

            CreateListGrid();
            CreateItemPanel();
            CreateFindPanel();
        }
        protected override void Start()
        {
            if (Options != null)
            {
                switch (Options.StartState)
                {
                    case FormState.List:
                        DataList();
                        break;
                    case FormState.Edit:
                        DataEdit(Options.Id);
                        break;
                    case FormState.Insert:
                        DataInsert();
                        break;
                }
            }
        }
        /// <summary>
        /// It is called when the escape key is pressed. 
        /// <para>Returning true indicates that the key press is handled.</para>
        /// <para>NOTE: By default, when is a modal dialog, it sets <see cref="DialogResult"/> to Cancel, and closes the form.</para>
        /// </summary>
        protected override bool ProcessEscapeKey()
        {
            if (!Modal && this.FormState == FormState.List)
            {
                this.Close();
                return true;
            }

            return base.ProcessEscapeKey();
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
                btnFind.Enabled = Options != null && !Bf.In(FormState.Find, Options.InvalidStates);
                btnList.Enabled = Options != null && !Bf.In(FormState.List, Options.InvalidStates);
                
                btnInsert.Enabled = Options != null && !Bf.In(FormState.Insert, Options.InvalidStates) && !Bf.In(FormState, FormState.Insert | FormState.Edit) && FormMode != FormMode.List;
                btnEdit.Enabled = Options != null && !Bf.In(FormState.Insert, Options.InvalidStates) && !Bf.In(FormState, FormState.Insert | FormState.Edit) && FormMode != FormMode.List;
                btnDelete.Enabled = Options != null && !Bf.In(FormState.Delete, Options.InvalidStates) && FormMode == FormMode.List && gridList != null && gridList.RowCount > 0;
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

        /* construction */
        public DataForm()
        {
            InitializeComponent();
        }

 
 
    }


 
}
