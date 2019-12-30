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
using Tripous.Forms;

namespace DevApp.WinForms
{
    public partial class MainForm : BaseForm
    {
        /* event handlers */
        void AnyClick(object sender, EventArgs ea)
        {
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

            //this.Icon = Eurolife.ActCalc.Properties.Resources.AppIco;

            mnuShowDockedForm.Click += AnyClick;
            mnuShowModalForm.Click += AnyClick;
            mnuExit.Click += AnyClick;
            btnExit.Click += AnyClick;

            Ui.Docker = this.Docker;

            this.Docker.ShowAutoHideContentOnHover = true;
            ThemeBase Theme = new VS2015BlueTheme(); // VS2015LightTheme  VS2015DarkTheme VS2015BlueTheme
            this.Docker.Theme = Theme;
            this.Docker.ActiveDocumentChanged += Docker_ActiveDocumentChanged;

            RegisterToolForms();
            ToolForm.LoadToolForms();
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
