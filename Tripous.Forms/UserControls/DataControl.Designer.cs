namespace Tripous.Forms
{
    partial class DataControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlText = new System.Windows.Forms.Panel();
            this.lblText = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.pnlText.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlText
            // 
            this.pnlText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlText.Controls.Add(this.lblText);
            this.pnlText.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlText.Location = new System.Drawing.Point(0, 0);
            this.pnlText.Name = "pnlText";
            this.pnlText.Padding = new System.Windows.Forms.Padding(3, 7, 6, 6);
            this.pnlText.Size = new System.Drawing.Size(120, 28);
            this.pnlText.TabIndex = 1;
            // 
            // lblText
            // 
            this.lblText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblText.Location = new System.Drawing.Point(3, 7);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(111, 16);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Text";
            // 
            // pnlControl
            // 
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(120, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Padding = new System.Windows.Forms.Padding(4);
            this.pnlControl.Size = new System.Drawing.Size(280, 28);
            this.pnlControl.TabIndex = 2;
            // 
            // DataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlText);
            this.Name = "DataControl";
            this.Size = new System.Drawing.Size(400, 28);
            this.pnlText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlText;
        protected System.Windows.Forms.Label lblText;
        protected System.Windows.Forms.Panel pnlControl;
    }
}
