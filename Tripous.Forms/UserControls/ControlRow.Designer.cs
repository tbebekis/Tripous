namespace Tripous.Forms
{
    partial class ControlRow
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
            this.pnlText.Size = new System.Drawing.Size(140, 33);
            this.pnlText.TabIndex = 1;
            // 
            // lblText
            // 
            this.lblText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblText.Location = new System.Drawing.Point(9, 7);
            this.lblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText.Name = "lblText";
            this.lblText.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.lblText.Size = new System.Drawing.Size(126, 21);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Text";
            // 
            // pnlControl
            // 
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(140, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(326, 33);
            this.pnlControl.TabIndex = 2;
            // 
            // ControlRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlText);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "ControlRow";
            this.Size = new System.Drawing.Size(466, 33);
            this.pnlText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlText;
        protected System.Windows.Forms.Label lblText;
        protected System.Windows.Forms.Panel pnlControl;
    }
}
