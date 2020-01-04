namespace Tripous.Forms
{
    partial class ListViewControlRow
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
            this.lv = new System.Windows.Forms.ListView();
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
            this.pnlControl.Controls.Add(this.lv);
            this.pnlControl.Size = new System.Drawing.Size(326, 170);
            // 
            // lv
            // 
            this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(2, 4);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(320, 162);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            // 
            // ListViewControlRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Name = "ListViewControlRow";
            this.Size = new System.Drawing.Size(466, 170);
            this.pnlText.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv;
    }
}
