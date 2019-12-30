namespace Tripous.Forms
{
    partial class PopUpForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUpForm));
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlButtons = new System.Windows.Forms.StatusStrip();
            this.btnOK = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCancel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClear = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnLoad = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSave = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlParent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOK,
            this.btnCancel,
            this.btnClear,
            this.btnLoad,
            this.btnSave});
            resources.ApplyResources(this.pnlButtons, "pnlButtons");
            this.pnlButtons.Name = "pnlButtons";
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.btnOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOK.LinkColor = System.Drawing.SystemColors.WindowText;
            this.btnOK.Name = "btnOK";
            this.btnOK.Click += new System.EventHandler(this.AnyCommand);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCancel.LinkColor = System.Drawing.SystemColors.WindowText;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Click += new System.EventHandler(this.AnyCommand);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnClear.LinkColor = System.Drawing.SystemColors.WindowText;
            this.btnClear.Name = "btnClear";
            this.btnClear.Click += new System.EventHandler(this.AnyCommand);
            // 
            // btnLoad
            // 
            resources.ApplyResources(this.btnLoad, "btnLoad");
            this.btnLoad.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.btnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLoad.LinkColor = System.Drawing.SystemColors.WindowText;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Click += new System.EventHandler(this.AnyCommand);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.LinkColor = System.Drawing.SystemColors.WindowText;
            this.btnSave.Name = "btnSave";
            this.btnSave.Click += new System.EventHandler(this.AnyCommand);
            // 
            // pnlParent
            // 
            resources.ApplyResources(this.pnlParent, "pnlParent");
            this.pnlParent.Name = "pnlParent";
            // 
            // PopUpForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlParent);
            this.Controls.Add(this.pnlButtons);
            this.Name = "PopUpForm";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.StatusStrip pnlButtons;
        private System.Windows.Forms.ToolStripStatusLabel btnOK;
        private System.Windows.Forms.ToolStripStatusLabel btnCancel;
        private System.Windows.Forms.ToolStripStatusLabel btnClear;
        private System.Windows.Forms.ToolStripStatusLabel btnLoad;
        private System.Windows.Forms.ToolStripStatusLabel btnSave;
        private System.Windows.Forms.Panel pnlParent;

    }
}