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

#pragma warning disable CS1591

    public partial class DataForm : BaseForm
    {
        /* protected */
        protected FormState fFormState = FormState.None;
        protected bool Saving;

        /* form state */
        protected virtual FormState FormState
        {
            get { return fFormState; }
            set
            {
                if (value != fFormState)
                {
                    fFormState = value;
                    FormStateChanged();
                    UpdateUi();
                }
            }
        }
        protected virtual void FormStateChanged()
        { 
        }
 
        /* form actions */
        protected virtual void Execute(FormAction Value)
        {
            if (!IsDisposed && !Executing(Value))
            {
                object oId;
                switch (Value)
                {
                    case FormAction.Home:
                        ExecuteHome();
                        break;
                    case FormAction.Find:
                        ExecuteFind();
                        break;

                    case FormAction.List:
                        ExecuteList();
                        break;
                    case FormAction.Insert:
                        ExecuteInsert();
                        break;
                    case FormAction.Edit:
                        oId = GetCurrentListId();
                        if (!Sys.IsNull(oId))
                            ExecuteEdit(oId);
                        break;
                    case FormAction.Delete:
                        oId = GetCurrentListId();
                        if (!Sys.IsNull(oId))
                            ExecuteDelete(oId);
                        break;
                    case FormAction.Save:
                        ExecuteSave();
                        break;
                    case FormAction.Cancel:
                        if (IsListMode)
                        {
                            if (Modal)
                                this.DialogResult = DialogResult.Cancel;
                            else
                                Close();
                        }
                        else if (IsMasterForm)
                        {
                            if (Bf.In(FormState, FormState.List | FormState.Home | FormState.Find))
                            {
                                if (Modal)
                                    this.DialogResult = DialogResult.Cancel;
                                else
                                    Close();
                            }
                            else if (Bf.In(FormState, FormState.Insert | FormState.Edit))
                            {
                                ExecuteCancelEdit();
                            }                             
                        }
                        break;
                    case FormAction.OK:
                        if (IsListMode)
                            ListSave();

                        if (Modal)
                            this.DialogResult = DialogResult.Cancel;
                        else
                            Close();
 
                        break;
                    case FormAction.Close:
                        Close();
                        break;
 
                    case FormAction.Custom1:
                    case FormAction.Custom2:
                    case FormAction.Custom3:
                    case FormAction.Custom4:
                        ExecuteCustom(Value);
                        break;
                }

                if (!IsDisposed)
                {
                    Executed(Value);
                    UpdateUi();
                }
            }

        }
        protected virtual bool Executing(FormAction Value)
        {
            return false;
        }
        protected virtual void Executed(FormAction Value)
        {

        }
 
        protected virtual void ExecuteHome()
        {
            this.FormState = FormState.Home;
        }
        protected virtual void ExecuteFind()
        {
            this.FormState = FormState.Find;
        }

        protected virtual void ExecuteList()
        {
            if (!Saving && Bf.In(FormState, FormState.Insert | FormState.Edit))
            {
                if (!ExecuteCancelEdit())
                    return;
            }

            ListSelect();
            this.FormState = FormState.List;
        }
        protected virtual void ExecuteInsert()
        {
            ItemInsert();
            this.FormState = FormState.Insert;
        }
        protected virtual void ExecuteEdit(object oId = null)
        {
            if (oId == null)
                oId = GetCurrentListId();

            if (!Sys.IsNull(oId))
            {
                ItemLoad(oId);
                this.FormState = FormState.Edit;
            }
        }
        protected virtual void ExecuteDelete(object oId = null)
        {
            if (oId == null)
                oId = GetCurrentListId();

            if (!Sys.IsNull(oId))
            {
                if (Ui.YesNoBox("Delete item?"))
                {
                    ItemDelete(oId);
                }
            }

        }
        protected virtual void ExecuteSave()
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
        }
        protected virtual bool ExecuteCancelEdit()
        {
            if (ItemHasChanges())
            {
                if (!Ui.YesNoBox("Cancel changes?"))
                    return false;

                ItemCancelChanges();
            }

            return true;
        }
        protected virtual void ExecuteCustom(FormAction Value)
        {
        }

        /* list */
        protected virtual void ListSelect()
        {
        }
        protected virtual void ListSave()
        {
        }
        protected virtual object GetCurrentListId()
        {
            return null;
        }

        /* item */
        protected virtual void ItemInsert()
        {
        }
        protected virtual void ItemLoad(object oId)
        {
        }
        protected virtual void ItemDelete(object oId)
        {
        }
        protected virtual void ItemSave()
        {
        }
        protected virtual void CheckSave()
        {
        }
        protected virtual bool ItemHasChanges()
        {
            return false;
        }
        protected virtual void ItemCancelChanges()
        {
        }

        protected virtual void ItemBind()
        {
        }
 
        protected virtual void CreateListGrid()
        { 
        }
        protected virtual void CreateItemPanel()
        {
        }
        protected virtual void CreateFindPanel()
        {
        }
 
        /* overrides */
        protected override void FormInitializeBefore()
        {
            base.FormInitializeBefore();

            CreateListGrid();
            CreateItemPanel();
            CreateFindPanel();
        }
        protected override void Start()
        {
            if (Options != null && Bf.In(Options.StartAction, FormAction.List | FormAction.Edit | FormAction.Insert))
            {
                Execute(Options.StartAction);
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
 
        /* construction */
        public DataForm()
        {
            InitializeComponent();
        }
    }
}
