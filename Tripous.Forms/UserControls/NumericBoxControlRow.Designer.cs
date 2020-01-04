namespace Tripous.Forms
{
    partial class NumericBoxControlRow
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
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.edtNumericUpDown);
            this.pnlControl.Padding = new System.Windows.Forms.Padding(1, 4, 2, 0);
            // 
            // edtNumericUpDown
            // 
            this.edtNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtNumericUpDown.Location = new System.Drawing.Point(1, 4);
            this.edtNumericUpDown.Name = "edtNumericUpDown";
            this.edtNumericUpDown.Size = new System.Drawing.Size(323, 25);
            this.edtNumericUpDown.TabIndex = 0;
            // 
            // NumericBoxControlRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Name = "NumericBoxControlRow";
            this.pnlText.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edtNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown edtNumericUpDown;
    }
}
