namespace Tripous.Forms
{
    partial class GridControlRow
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
            this.GridControl = new System.Windows.Forms.DataGridView();
            this.pnlText.SuspendLayout();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlText
            // 
            this.pnlText.Size = new System.Drawing.Size(140, 170);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.GridControl);
            this.pnlControl.Size = new System.Drawing.Size(327, 170);
            // 
            // GridControl
            // 
            this.GridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridControl.Location = new System.Drawing.Point(2, 6);
            this.GridControl.Name = "GridControl";
            this.GridControl.Size = new System.Drawing.Size(321, 158);
            this.GridControl.TabIndex = 0;
            // 
            // GridControlRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Name = "GridControlRow";
            this.Size = new System.Drawing.Size(467, 170);
            this.pnlText.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridControl;
    }
}
