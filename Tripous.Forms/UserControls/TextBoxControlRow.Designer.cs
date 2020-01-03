namespace Tripous.Forms
{
    partial class TextBoxControlRow
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
            this.edtText = new System.Windows.Forms.TextBox();
            this.pnlText.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.Size = new System.Drawing.Size(131, 16);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.edtText);
            this.pnlControl.Location = new System.Drawing.Point(140, 0);
            this.pnlControl.Size = new System.Drawing.Size(260, 28);
            // 
            // edtText
            // 
            this.edtText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edtText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtText.Location = new System.Drawing.Point(4, 4);
            this.edtText.Name = "edtText";
            this.edtText.Size = new System.Drawing.Size(252, 20);
            this.edtText.TabIndex = 0;
            // 
            // TextDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Name = "TextDataControl";
            this.pnlText.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox edtText;
    }
}
