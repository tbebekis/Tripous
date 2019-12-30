using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using WeifenLuo.WinFormsUI.Docking;

using Tripous;
using Tripous.Logging;
using Tripous.Data;
using Tripous.Windows.Forms;


namespace DevApp.WinForms
{
    /// <summary>
    /// Main form
    /// </summary>
    public partial class MainForm : Form, IBroadcasterListener
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

        void AnyClick(object sender, EventArgs ea)
        {
            if (mnuSave == sender)
            {
                BaseForm.ShowDocked(typeof(TestForm), "AntyxSoft");
            }
            else if (mnuSaveAll == sender)
            {
                BaseForm.ShowModal(typeof(TestForm), "AntyxSoft");
            }
        }

        /// <summary>
        /// Handles a broadcaster event.
        /// </summary>
        void HandleBroadcasterEvent(string EventName, IDictionary<string, object> Args)
        {
            switch (EventName)
            {
                case "NOT_EXISTED_EVENT_NAME":
                    break;
            }
        }
        void Docker_ActiveDocumentChanged(object sender, EventArgs e)
        {
            //ActiveEditor = Docker.ActiveDocument as EditorForm; 
        }

        void Test()
        {
 
        }
        void FormInitialize()
        {
            Ui.MainForm = this;
            MainMenu.BackColor = App.BackColor;
            StatusBar.BackColor = App.BackColor;
            ToolBar.BackColor = App.BackColor;
            ToolBar.ImageScalingSize = App.ImageScalingSize;

            //this.Icon = Eurolife.ActCalc.Properties.Resources.AppIco;

            mnuSave.Click += AnyClick;
            mnuSaveAll.Click += AnyClick;

            Ui.Docker = this.Docker;

            this.Docker.ShowAutoHideContentOnHover = true;
            ThemeBase Theme = new VS2015BlueTheme(); // VS2015LightTheme  VS2015DarkTheme VS2015BlueTheme
            this.Docker.Theme = Theme;
            this.Docker.ActiveDocumentChanged += Docker_ActiveDocumentChanged;

            RegisterToolForms();
            ToolForm.LoadToolForms();
        }
        void RegisterToolForms()
        {
            ToolForm.RegisterForm("MenuForm", typeof(MenuForm), ToolFormDefaultPosition.Left);
        }

        /* overrides */
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnShown(EventArgs e)
        {
            Broadcaster.Add(this);
            base.OnShown(e);

            if (!DesignMode)
                FormInitialize();
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (Ui.Waiting)
            {
                e.Cancel = true;
            }
            else
            {
                ToolForm.SaveToolForms();
            }

            base.OnFormClosing(e);
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Broadcaster.Remove(this);
            base.OnFormClosed(e);
        }

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
    }
}
