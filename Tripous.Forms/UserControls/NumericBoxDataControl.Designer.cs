namespace Tripous.Forms
{
    partial class NumericBoxDataControl
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
            this.edtNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pnlText.SuspendLayout();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.Size = new System.Drawing.Size(131, 16);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.edtNumericUpDown);
            this.pnlControl.Location = new System.Drawing.Point(140, 0);
            this.pnlControl.Size = new System.Drawing.Size(260, 28);
            // 
            // edtNumericUpDown
            // 
            this.edtNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtNumericUpDown.Location = new System.Drawing.Point(4, 4);
            this.edtNumericUpDown.Name = "edtNumericUpDown";
            this.edtNumericUpDown.Size = new System.Drawing.Size(252, 20);
            this.edtNumericUpDown.TabIndex = 0;
            // 
            // NumericBoxDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Name = "NumericBoxDataControl";
            this.pnlText.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edtNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown edtNumericUpDown;
    }
}
