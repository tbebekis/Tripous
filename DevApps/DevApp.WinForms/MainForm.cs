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
using Tripous.Model;
using Tripous.Forms;

using DevApp.Lib;

namespace DevApp.WinForms
{

    /// <summary>
    /// Main form
    /// </summary>
    public partial class MainForm : BaseForm, ICommandHost, ICommandHandler
    {

        #region ICommandHost
        /// <summary>
        /// Signals the host that the command sets have changed,
        /// usually because the user has changed.
        /// </summary>
        void ICommandHost.CommandSetsChanged()
        {
            //RealizeCommandSets();
        }
        /// <summary>
        /// Signals the host that the selected command set has changed,
        /// either because the user selects another command set
        /// or because the user has changed.
        /// </summary>
        void ICommandHost.SelectedCommandSetChanged()
        {
            //RealizeCommandSet(CommandSets.Current.SelectedCommandSet);
        }
        /// <summary>
        /// Signals the host to create main and other menu items.
        /// </summary>
        void ICommandHost.CreateMenuItems()
        {
            if (MainMenuStrip != null)
            {
                MainMenuStrip.Items.Clear();

                Command MainRootCommand = Registry.MainRootCommand;
                CommandHostHelper.AddProcessorMenuItems(MainRootCommand, MainMenuStrip, false, false);

                if (MainMenuStrip.Items.ContainsKey("mnuWINDOWS"))
                {
                    MainMenuStrip.MdiWindowListItem = MainMenuStrip.Items["mnuWINDOWS"] as ToolStripMenuItem;
                }
            }
        }
        /* properties */
        /// <summary>
        /// Controls the visibility of the tool bar
        /// </summary>
        bool ICommandHost.ToolbarVisible
        {
            get { return ToolBar.Visible; }
            set
            {
                ToolBar.Visible = value;
                //UserSettings.Current.ToolbarVisible = value;
            }
        }

        #endregion


        /// <summary>
        /// Returns true if the specified Command is executed by this handler
        /// </summary>
        public bool CommandExecute(Command Cmd)
        {
            switch (Cmd.Name)
            {
                /* FILE */
                case SystemCommands.CMD_LOGIN: return true;
                case SystemCommands.CMD_LOGOUT: return true;
                case SystemCommands.CMD_APP_SYS_INFO: return true;
                case SystemCommands.CMD_EXIT: Close(); return true;

                /* VIEW */
                case SystemCommands.CMD_SQL_MONITOR:  return true;
                case SystemCommands.CMD_SYS_LOG:  return true;

                /* APP_CONFIGURATION */
                case SystemCommands.CMD_TOOL_BAR:  return true;

                /* SYSTEM */
                case SystemCommands.CMD_SYS_COMPANY:
                    BaseForm.ShowDocked(Cmd.Name); // EDW οκ, παίζει
                    return true;
                case SystemCommands.CMD_SYS_LANG: return true;
                case SystemCommands.CMD_SYS_SMTP_PROVIDERS: return true;

                /* HELP */
                case SystemCommands.CMD_ABOUT: return true;

                /* Application */
                default:
                    return ExecuteFormCommand(Cmd);

            }

            //return false;
        }
        /// <summary>
        /// Handles the property change of the specified command.
        /// </summary>
        public void CommandEnabledChanged(Command Cmd)
        {
        }
        /// <summary>
        /// Handles the property change of the specified command.
        /// </summary>
        public void CommandVisibleChanged(Command Cmd)
        {
        }

        bool ExecuteFormCommand(Command Cmd)
        {
            FormOptions O = FormOptions.Find(Cmd.Name);

            if (O != null)
            {
                BaseForm.ShowDocked(O);
                return true;
            }

            return false;
        }

        /* event handlers */
        void AnyClick(object sender, EventArgs ea)
        {
            /*
                         if (mnuShowDockedForm == sender)
                        {
                            BaseForm.ShowDocked(typeof(TestForm), "AntyxSoft");
                        }
                        else if (mnuShowModalForm == sender)
                        {
                            BaseForm.ShowModal(typeof(TestForm), "AntyxSoft");
                        }
                        else if (mnuExit == sender || btnExit == sender)
                        {
                            this.Close();
                        }
             */
        }
        void Docker_ActiveDocumentChanged(object sender, EventArgs e)
        {
            //ActiveEditor = Docker.ActiveDocument as EditorForm; 
        }

        /* private */
        void RegisterToolForms()
        {
            ToolForm.RegisterForm("MenuForm", typeof(MenuForm), ToolFormDefaultPosition.Left);
        }

        /* overrides */
        protected override void FormInitialize()
        {
            base.FormInitialize();

            Ui.MainForm = this;
            MainMenu.BackColor = App.BackColor;
            StatusBar.BackColor = App.BackColor;
            ToolBar.BackColor = App.BackColor;
            ToolBar.ImageScalingSize = App.ImageScalingSize;

            this.MainMenuStrip = this.MainMenu;

            //this.Icon = Eurolife.ActCalc.Properties.Resources.AppIco;

            //uShowDockedForm.Click += AnyClick;
            //mnuShowModalForm.Click += AnyClick;
            //mnuExit.Click += AnyClick;
            //btnExit.Click += AnyClick;

            Ui.Docker = this.Docker;

            this.Docker.ShowAutoHideContentOnHover = true;
            ThemeBase Theme = new VS2015BlueTheme(); // VS2015LightTheme  VS2015DarkTheme VS2015BlueTheme
            this.Docker.Theme = Theme;
            this.Docker.ActiveDocumentChanged += Docker_ActiveDocumentChanged;

            RegisterToolForms();
            ToolForm.LoadToolForms();

            (this as ICommandHost).CreateMenuItems();
            Registry.MainRootCommand.Handler = this;
        }

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /* public */
        /// <summary>
        /// Returns true if this form can close
        /// </summary>
        public override bool CanClose()
        {
            if (Ui.Waiting)
            {
                return false;
            }

            ToolForm.SaveToolForms();
            return true;
        }
    }
}
