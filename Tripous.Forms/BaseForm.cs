using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WeifenLuo.WinFormsUI.Docking;

using Tripous.Logging;

namespace Tripous.Forms
{
    /// <summary>
    /// Base form
    /// </summary>
    public partial class BaseForm : Form, IBroadcasterListener
    {
        #region IBroadcasterListener implementation
        void IBroadcasterListener.HandleBroadcasterEvent(string EventName, IDictionary<string, object> Args)
        {
            if (!IsDisposed)
            {
                /* check carefully if Invoke() is required */
                bool IsInvokeRequired;
                try
                {
                    IsInvokeRequired = this.InvokeRequired;
                }
                catch /* it should be ObjectDisposedException */
                {
                    return;
                }


                if (IsInvokeRequired)   /* synchronize the call */
                {

                    try
                    {
                        IBroadcasterListener Listener = this as IBroadcasterListener;
                        this.Invoke(new BroadcasterDelegate(Listener.HandleBroadcasterEvent), EventName, Args);
                    }
                    catch (Exception e)  /* it should be ObjectDisposedException ONLY */
                    {
                        if (!(e is ObjectDisposedException))
                            Logger.Error(e);
                    }
                }
                else  /* it is synchronized */
                {
                    try
                    {
                        this.HandleBroadcasterEvent(EventName, Args);
                        Application.DoEvents();
                    }
                    catch (Exception e)
                    {
                        Logger.Error(e);
                    }
                }
            }
        }
        #endregion

        /* protected */
        /// <summary>
        /// Field
        /// </summary>
        protected string fTitle;

        /* overridables */
        /// <summary>
        /// Sets the ico of this form
        /// </summary>
        protected virtual void SetFormIcon()
        {
            Icon ico = Res.GetObject(Sys.AppIco) as Icon;
            if (ico != null)
                this.Icon = ico;
        }

        /// <summary>
        /// Called just before form initialization
        /// </summary>
        protected virtual void FormInitializeBefore()
        {
        }
        /// <summary>
        /// Called in order to initialize the form
        /// </summary>
        protected virtual void FormInitialize()
        {            
        }
        /// <summary>
        /// Called just after form initialization
        /// </summary>
        protected virtual void FormInitializeAfter()
        {
        }
 
        /// <summary>
        /// Processes the form options
        /// </summary>
        protected virtual void ProcessFormOptions()
        {
            if (Options != null && !string.IsNullOrWhiteSpace(Options.TextKey))
                this.Text = Res.GS(Options.TextKey, Options.TextKey);
        }
        /// <summary>
        /// Executes any first command on the form
        /// </summary>
        protected virtual void Start()
        {
        }

        /// <summary>
        /// Updates the user interface, title, enable-disable buttons etc.
        /// </summary>
        public virtual void UpdateUi()
        {
            if (!IsDisposed)
            {
                EnableCommands();
            }
        }
        /// <summary>
        /// Enables and disables buttons and menu items.
        /// </summary>
        protected virtual void EnableCommands()
        {
        }
 

        /* miscs */
        /// <summary>
        /// Passes any result to the caller of the form, if any. Useful with modal forms.
        /// </summary>
        protected virtual void PassResultBack()
        {
        }
        /// <summary>
        /// Returns the control that is last added to the container
        /// </summary>
        protected virtual Control FindFirstFocusableControl(Control Container)
        {

            if (Container != null)
            {
                List<Control> List = new List<Control>();

                Action<Control> Proc = null;

                Proc = delegate (Control C)
                {
                    foreach (Control Child in C.Controls)
                    {
                        List.Insert(0, Child);
                        Proc(Child);
                    }
                };

                Proc(Container);

                foreach (Control C in List)
                {
                    if (C.CanFocus)
                        return C;
                }
            }

            return null;
        }
        /// <summary>
        /// Handles a broadcaster event.
        /// </summary>
        protected virtual void HandleBroadcasterEvent(string EventName, IDictionary<string, object> Args)
        {
            switch (EventName)
            {
                case "NOT_EXISTED_EVENT_NAME": 
                    break;
            }
        }
        /// <summary>
        /// It is called by the OnKeyDown() method. 
        /// <para>Returns true if processes the key</para>
        /// </summary>
        protected virtual bool ProcessKeyDown(KeyEventArgs e)
        {
            return false;
        }
        /// <summary>
        /// It is called when the escape key is pressed. 
        /// <para>Returning true indicates that the key press is handled.</para>
        /// <para>NOTE: By default, when is a modal dialog, it sets <see cref="DialogResult"/> to Cancel, and closes the form.</para>
        /// </summary>
        protected virtual bool ProcessEscapeKey()
        {
            if (this.Modal)
            {
                this.DialogResult = DialogResult.Cancel;
                return true;
            }

            return false;
        }

        /* overrides */
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnShown(EventArgs e)
        {
            if (!DesignMode)
            {
                if (!Initialized)
                {
                    Broadcaster.Add(this);

                    SetFormIcon();

                    ProcessFormOptions();
                    FormInitializeBefore();
                    FormInitialize();
                    Initialized = true;
                    FormInitializeAfter();
                    Start();
                }
            }
                
            base.OnShown(e);
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = !CanClose();
            base.OnFormClosing(e);
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            PassResultBack();

            if (DockForm != null)
            {
                if (!DockForm.InClosing)
                {
                    IsClosing = true;
                    DockForm.Close();
                }
            }

            Broadcaster.Remove(this);
            base.OnFormClosed(e);
            
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnTextChanged(EventArgs e)
        {
            if (DockForm != null)
            {
                DockForm.Text = this.Text;
            }

            base.OnTextChanged(e);
        }
        /// <summary>
        /// Raises KeyDown event
        /// </summary>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (!DesignMode)
            {
                if (ProcessKeyDown(e))
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }

            base.OnKeyDown(e);
        }
        /// <summary>
        /// Processes a dialog box key
        /// </summary>
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (!DesignMode)
            {
                if (keyData.CodeIs(Keys.Escape) && ProcessEscapeKey())
                {
                    return true;
                }
            }

            return base.ProcessDialogKey(keyData);
        }


        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public BaseForm()
        {
            InitializeComponent();
        }

        /* public */
        /// <summary>
        /// Returns true if this form can close
        /// </summary>
        public virtual bool CanClose()
        {
            return !Ui.Waiting;
        }

        /* static */
        /// <summary>
        /// Returns all open forms
        /// </summary>
        static public BaseForm[] GetOpenForms()
        {
            List<BaseForm> Result = new List<BaseForm>();

            foreach (Form F in Application.OpenForms)
            {
                if (F is BaseForm)
                    Result.Add(F as BaseForm);
            }

            return Result.ToArray();
        }
        /// <summary>
        /// Creates and returns a form
        /// </summary>
        static public BaseForm Create(FormOptions Options, Action<BaseForm> AfterCreateFunc = null)
        {
            Type T = Options.FormClass; 
            if (T == null)
                Sys.Error("Can not create a Form. Form Type is not defined or found");

            BaseForm Result = Activator.CreateInstance(T) as BaseForm;
            Result.Owner = Ui.MainForm;
            Result.Options = Options;
 
            AfterCreateFunc?.Invoke(Result);

            return Result;
        }

        /// <summary>
        /// Creates and shows a form as a modal dialog and returns true if the <see cref="DialogResult"/> is OK.
        /// </summary>
        static public bool ShowModal(string FormUniqueId, Action<BaseForm> AfterCreateFunc = null)
        {
            FormOptions Options = FormOptions.Get(FormUniqueId);
            return ShowModal(Options, AfterCreateFunc);
        }
        /// <summary>
        /// Creates and shows a form as a modal dialog and returns true if the <see cref="DialogResult"/> is OK.
        /// </summary>
        static public bool ShowModal(FormOptions Options, Action<BaseForm> AfterCreateFunc = null)
        {
            bool Result = false;
            Options.AsModal = true;

            using (BaseForm F = Create(Options, AfterCreateFunc))
            {
                Result = F.ShowDialog() == DialogResult.OK;
            }

            return Result;
        }
        /// <summary>
        /// Creates and shows a form as a modal dialog and returns true if the <see cref="DialogResult"/> is OK.
        /// </summary>
        static public bool ShowModal(Type FormClass, string TextKey = "", Action<BaseForm> AfterCreateFunc = null)
        {
            return ShowModal(new FormOptions(FormClass, TextKey), AfterCreateFunc);
        }
 

        /// <summary>
        /// Creates and shows a form as a docked one.
        /// <para>Actually it first creates a <see cref="DockContent"/> form and sets the <see cref="BaseForm"/> as a child. </para>
        /// </summary>
        static public void ShowDocked(string FormUniqueId, Action<BaseForm> AfterCreateFunc = null)
        {
            FormOptions Options = FormOptions.Get(FormUniqueId);
            ShowDocked(Options, AfterCreateFunc);
        }
        /// <summary>
        /// Creates and shows a form as a docked one.
        /// <para>Actually it first creates a <see cref="DockContent"/> form and sets the <see cref="BaseForm"/> as a child. </para>
        /// </summary>
        static public void ShowDocked(FormOptions Options, Action<BaseForm> AfterCreateFunc = null)
        {
            if (Ui.Docker == null)
                Sys.Error("Can not create Tool Forms. No DockerPanel is defined");

            ParentDockForm DockForm = new ParentDockForm();
            BaseForm F = Create(Options, AfterCreateFunc);
            F.DockForm = DockForm;

            DockForm.ChildForm = F;
            DockForm.Show(Ui.Docker, DockState.Document);

            F.TopLevel = false;
            F.FormBorderStyle = FormBorderStyle.None;
            F.Parent = DockForm;
            F.Dock = DockStyle.Fill;
            F.Visible = true; 
        }
        /// <summary>
        /// Creates and shows a form as a docked one.
        /// <para>Actually it first creates a <see cref="DockContent"/> form and sets the <see cref="BaseForm"/> as a child. </para>
        /// </summary>
        static public void ShowDocked(Type FormClass, string TextKey = "", Action<BaseForm> AfterCreateFunc = null)
        {
            ShowDocked(new FormOptions(FormClass, TextKey), AfterCreateFunc);
        }



        /* properties */
        /// <summary>
        /// True when initialized
        /// </summary>
        [Browsable(false), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]        
        public bool Initialized { get; private set; }
        /// <summary>
        /// The form options
        /// </summary>
        [Browsable(false), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]       
        public virtual FormOptions Options { get; protected set; }
        /// <summary>
        /// The parent container form, which is a <see cref="DockContent"/> form.
        /// </summary>
        [Browsable(false), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]        
        public ParentDockForm DockForm { get; private set; }
        /// <summary>
        /// True when this is the main form.
        /// </summary>
        [Browsable(false), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]        
        public bool IsMainForm { get { return Ui.MainForm == this; } }

        /// <summary>
        /// Returns the form mode
        /// </summary>
        [Browsable(false), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual FormType FormMode { get { return FormType.None; } }
        /// <summary>
        /// Indicates a "list" form. A list form has just a single "part" where displays a read-write grid.
        /// </summary>
        [Browsable(false), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsListMode { get { return this.FormMode == FormType.List; } }
        /// <summary>
        /// Indicates a "master" form. A master form provides two "parts": A list or browser which displays a
        /// a read-only grid and an "entry" part where data bound controls are placed.
        /// <para>NOTE: Those two parts are bound to DIFFERENT DataTable objects.</para>
        /// </summary>
        [Browsable(false), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMasterMode { get { return this.FormMode == FormType.Master; } }
        /// <summary>
        /// Indicates a "master list" form. A master list form provides two "parts": A list or browser which displays a
        /// a read-only grid and an "entry" part where data bound controls are placed.
        /// <para>NOTE: Those two parts are bound to the SAME DataTable object.</para>
        /// </summary>
        [Browsable(false), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsListMasterMode { get { return this.FormMode == FormType.ListMaster; } }
        /// <summary>
        /// Returns true if the form is in FormMode.List mode or in FormMode.ListMaster mode.
        /// </summary>
        [Browsable(false), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsListForm { get { return IsListMode || IsListMasterMode; } }
        /// <summary>
        /// Returns true if the form is in FormMode.Master mode or in FormMode.ListMaster mode.
        /// </summary>
        [Browsable(false), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMasterForm { get { return IsMasterMode || IsListMasterMode; } }
        /// <summary>
        /// Returns true if this is a fixed-list (no row insert-delete allowed) form.
        /// </summary>
        [Browsable(false), ReadOnly(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual bool IsFixedListForm { get { return false; } }

        internal bool IsClosing { get; private set; }

    }
}
