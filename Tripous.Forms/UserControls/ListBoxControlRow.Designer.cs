namespace Tripous.Forms
{
    partial class ListBoxControlRow
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
            this.ListControl = new System.Windows.Forms.ListBox();
            this.pnlText.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlText
            // 
            this.pnlText.Size = new System.Drawing.Size(140, 170);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.ListControl);
            this.pnlControl.Size = new System.Drawing.Size(326, 170);
            // 
            // ListControl
            // 
            this.ListControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListControl.FormattingEnabled = true;
            this.ListControl.ItemHeight = 17;
            this.ListControl.Location = new System.Drawing.Point(2, 5);
            this.ListControl.Name = "ListControl";
            this.ListControl.Size = new System.Drawing.Size(321, 157);
            this.ListControl.TabIndex = 0;
            // 
            // ListBoxControlRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Name = "ListBoxControlRow";
            this.Size = new System.Drawing.Size(466, 170);
            this.pnlText.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListControl;
    }
}
