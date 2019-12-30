namespace DevApp.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewCSCalcs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewCSFuncs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewVBCalcs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewVBFuncs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuViewCalcExecution = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewFuncExecution = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuOutputWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOutputFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutputFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuildAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExecute = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.Docker = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.MainMenu.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(754, 24);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSave,
            this.mnuSaveAll,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(115, 22);
            this.mnuSave.Text = "Save";
            // 
            // mnuSaveAll
            // 
            this.mnuSaveAll.Name = "mnuSaveAll";
            this.mnuSaveAll.Size = new System.Drawing.Size(115, 22);
            this.mnuSaveAll.Text = "Save All";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(112, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(115, 22);
            this.mnuExit.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewCSCalcs,
            this.mnuViewCSFuncs,
            this.mnuViewVBCalcs,
            this.mnuViewVBFuncs,
            this.toolStripMenuItem2,
            this.mnuViewCalcExecution,
            this.mnuViewFuncExecution,
            this.toolStripMenuItem3,
            this.mnuOutputWindow,
            this.mnuOutputFolder});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // mnuViewCSCalcs
            // 
            this.mnuViewCSCalcs.Name = "mnuViewCSCalcs";
            this.mnuViewCSCalcs.Size = new System.Drawing.Size(189, 22);
            this.mnuViewCSCalcs.Text = "C# Calculations";
            // 
            // mnuViewCSFuncs
            // 
            this.mnuViewCSFuncs.Name = "mnuViewCSFuncs";
            this.mnuViewCSFuncs.Size = new System.Drawing.Size(189, 22);
            this.mnuViewCSFuncs.Text = "C# Functions";
            // 
            // mnuViewVBCalcs
            // 
            this.mnuViewVBCalcs.Name = "mnuViewVBCalcs";
            this.mnuViewVBCalcs.Size = new System.Drawing.Size(189, 22);
            this.mnuViewVBCalcs.Text = "VB Calculations";
            // 
            // mnuViewVBFuncs
            // 
            this.mnuViewVBFuncs.Name = "mnuViewVBFuncs";
            this.mnuViewVBFuncs.Size = new System.Drawing.Size(189, 22);
            this.mnuViewVBFuncs.Text = "VB Functions";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(186, 6);
            // 
            // mnuViewCalcExecution
            // 
            this.mnuViewCalcExecution.Name = "mnuViewCalcExecution";
            this.mnuViewCalcExecution.Size = new System.Drawing.Size(189, 22);
            this.mnuViewCalcExecution.Text = "Calculation Execution";
            // 
            // mnuViewFuncExecution
            // 
            this.mnuViewFuncExecution.Name = "mnuViewFuncExecution";
            this.mnuViewFuncExecution.Size = new System.Drawing.Size(189, 22);
            this.mnuViewFuncExecution.Text = "Function Execution";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(186, 6);
            // 
            // mnuOutputWindow
            // 
            this.mnuOutputWindow.Name = "mnuOutputWindow";
            this.mnuOutputWindow.Size = new System.Drawing.Size(189, 22);
            this.mnuOutputWindow.Text = "Output Window";
            // 
            // mnuOutputFolder
            // 
            this.mnuOutputFolder.Name = "mnuOutputFolder";
            this.mnuOutputFolder.Size = new System.Drawing.Size(189, 22);
            this.mnuOutputFolder.Text = "Output Folder";
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.SystemColors.Control;
            this.ToolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnSaveAll,
            this.toolStripSeparator1,
            this.btnOutputFolder,
            this.toolStripSeparator4,
            this.btnBuildAll,
            this.toolStripSeparator2,
            this.btnExecute,
            this.toolStripSeparator3,
            this.btnExit});
            this.ToolBar.Location = new System.Drawing.Point(0, 24);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(754, 25);
            this.ToolBar.TabIndex = 3;
            this.ToolBar.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "Save";
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(23, 22);
            this.btnSaveAll.Text = "Save All";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnOutputFolder
            // 
            this.btnOutputFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOutputFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutputFolder.Name = "btnOutputFolder";
            this.btnOutputFolder.Size = new System.Drawing.Size(23, 22);
            this.btnOutputFolder.Text = "Output Folder";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBuildAll
            // 
            this.btnBuildAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuildAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuildAll.Name = "btnBuildAll";
            this.btnBuildAll.Size = new System.Drawing.Size(23, 22);
            this.btnBuildAll.Text = "Build All";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnExecute
            // 
            this.btnExecute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(23, 22);
            this.btnExecute.Text = "Execute";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 22);
            this.btnExit.Text = "Exit";
            // 
            // StatusBar
            // 
            this.StatusBar.BackColor = System.Drawing.SystemColors.Control;
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.StatusBar.Location = new System.Drawing.Point(0, 424);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(754, 22);
            this.StatusBar.TabIndex = 4;
            this.StatusBar.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // Docker
            // 
            this.Docker.BackColor = System.Drawing.SystemColors.Control;
            this.Docker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Docker.DockBottomPortion = 140D;
            this.Docker.DockLeftPortion = 260D;
            this.Docker.DockRightPortion = 280D;
            this.Docker.DockTopPortion = 140D;
            this.Docker.Location = new System.Drawing.Point(0, 49);
            this.Docker.Name = "Docker";
            this.Docker.Size = new System.Drawing.Size(754, 375);
            this.Docker.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 446);
            this.Controls.Add(this.Docker);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.MainMenu);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "DevApp.WinForms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAll;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuViewCSCalcs;
        private System.Windows.Forms.ToolStripMenuItem mnuViewCSFuncs;
        private System.Windows.Forms.ToolStripMenuItem mnuViewVBCalcs;
        private System.Windows.Forms.ToolStripMenuItem mnuViewVBFuncs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuViewCalcExecution;
        private System.Windows.Forms.ToolStripMenuItem mnuViewFuncExecution;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuOutputWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuOutputFolder;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnSaveAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnOutputFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnBuildAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnExecute;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.StatusStrip StatusBar;
        public System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private WeifenLuo.WinFormsUI.Docking.DockPanel Docker;
    }
}

