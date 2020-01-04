namespace Tripous.Forms
{
    partial class PictureBoxControlRow
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
            this.picBox = new Tripous.Forms.PictureBoxEx();
            this.pnlText.SuspendLayout();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlText
            // 
            this.pnlText.Margin = new System.Windows.Forms.Padding(0);
            this.pnlText.Size = new System.Drawing.Size(140, 170);
            // 
            // lblText
            // 
            this.lblText.Size = new System.Drawing.Size(103, 21);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.picBox);
            this.pnlControl.Size = new System.Drawing.Size(327, 170);
            // 
            // picBox
            // 
            this.picBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(3, 4);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(320, 162);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // PictureBoxControlRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Name = "PictureBoxControlRow";
            this.Size = new System.Drawing.Size(467, 170);
            this.pnlText.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBoxEx picBox;
    }
}
