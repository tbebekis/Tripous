namespace Tripous.Forms
{
    partial class CheckBoxControlRow
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
            this.chBox = new System.Windows.Forms.CheckBox();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.pnlText = new System.Windows.Forms.Panel();
            this.lblText = new System.Windows.Forms.Label();
            this.pnlControl.SuspendLayout();
            this.pnlText.SuspendLayout();
            this.SuspendLayout();
            // 
            // chBox
            // 
            this.chBox.AutoSize = true;
            this.chBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.chBox.Location = new System.Drawing.Point(5, 5);
            this.chBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chBox.Name = "chBox";
            this.chBox.Padding = new System.Windows.Forms.Padding(6, 1, 0, 0);
            this.chBox.Size = new System.Drawing.Size(28, 15);
            this.chBox.TabIndex = 0;
            this.chBox.UseVisualStyleBackColor = true;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.chBox);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControl.Location = new System.Drawing.Point(6, 2);
            this.pnlControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.pnlControl.Size = new System.Drawing.Size(33, 37);
            this.pnlControl.TabIndex = 1;
            // 
            // pnlText
            // 
            this.pnlText.Controls.Add(this.lblText);
            this.pnlText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlText.Location = new System.Drawing.Point(39, 2);
            this.pnlText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlText.Name = "pnlText";
            this.pnlText.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.pnlText.Size = new System.Drawing.Size(501, 37);
            this.pnlText.TabIndex = 3;
            // 
            // lblText
            // 
            this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText.Location = new System.Drawing.Point(0, 1);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(501, 36);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Text";
            // 
            // CheckBoxControlRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlText);
            this.Controls.Add(this.pnlControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CheckBoxControlRow";
            this.Padding = new System.Windows.Forms.Padding(6, 2, 4, 4);
            this.Size = new System.Drawing.Size(544, 43);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.pnlText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chBox;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.Label lblText;
    }
}
