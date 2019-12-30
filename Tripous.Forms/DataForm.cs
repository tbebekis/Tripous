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
        protected Panel pnlFind = new Panel();
        protected DataGridView Grid = new DataGridView();

        /* event handlers */
        void AnyClick(object sender, EventArgs ea)
        {
            if (btnList == sender)
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
            else if (btnFind == sender)
            {
                Find();
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
        protected virtual void DataEdit()
        {
            object oId = ListGetCurrentId();
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
        }

        protected virtual void ListSelect()
        {
        }

        protected virtual object ListGetCurrentId()
        {
            object Result = null;

            DataRow Row = Grid.CurrentDataRow();
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
                    Grid.Visible = true;
                    Grid.Dock = DockStyle.Fill;
                    Grid.BringToFront();
                    break;
                case FormState.Insert:
                case FormState.Edit:
                    Grid.Visible = false;
                    break;
                case FormState.Delete:
                    break;
                case FormState.Find:
                    break;
            }

            UpdateUi();
        }
 
        /* overrides */
        protected override void FormInitializeBefore()
        {
            base.FormInitializeBefore();

            pnlFind.Visible = false;
            pnlFind.Dock = DockStyle.Fill;
            pnlFind.Parent = this;

            Grid.Visible = false;
            Grid.Dock = DockStyle.Fill;
            Grid.Parent = this;
        }


        /* construction */
        public DataForm()
        {
            InitializeComponent();
        }

 
 
    }


 
}
