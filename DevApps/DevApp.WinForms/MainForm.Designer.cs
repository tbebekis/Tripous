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
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.Docker = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.MainMenu.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(800, 24);
            this.MainMenu.TabIndex = 3;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // StatusBar
            // 
            this.StatusBar.BackColor = System.Drawing.SystemColors.Control;
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.StatusBar.Location = new System.Drawing.Point(0, 428);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(800, 22);
            this.StatusBar.TabIndex = 5;
            this.StatusBar.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.SystemColors.Control;
            this.ToolBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolBar.Location = new System.Drawing.Point(0, 24);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(800, 25);
            this.ToolBar.TabIndex = 6;
            this.ToolBar.Text = "toolStrip1";
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
            this.Docker.Size = new System.Drawing.Size(800, 379);
            this.Docker.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Docker);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MainMenu);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.ShowInTaskbar = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DevApp.WinForms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusBar;
        public System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStrip ToolBar;
        private WeifenLuo.WinFormsUI.Docking.DockPanel Docker;
    }
}