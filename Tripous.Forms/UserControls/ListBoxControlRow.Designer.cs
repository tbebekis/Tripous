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
            this.pnlText.Size = new System.Drawing.Size(140, 130);
            // 
            // lblText
            // 
            this.lblText.Size = new System.Drawing.Size(131, 16);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.ListControl);
            this.pnlControl.Location = new System.Drawing.Point(140, 0);
            this.pnlControl.Size = new System.Drawing.Size(260, 130);
            // 
            // lboBox
            // 
            this.ListControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListControl.FormattingEnabled = true;
            this.ListControl.Location = new System.Drawing.Point(4, 4);
            this.ListControl.Name = "lboBox";
            this.ListControl.Size = new System.Drawing.Size(252, 122);
            this.ListControl.TabIndex = 0;
            // 
            // ListBoxDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Name = "ListBoxDataControl";
            this.Size = new System.Drawing.Size(400, 130);
            this.pnlText.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListControl;
    }
}
