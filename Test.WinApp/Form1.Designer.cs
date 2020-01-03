namespace Test.WinApp
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiColumn1 = new Tripous.Forms.UiColumn();
            this.pictureBoxControlRow1 = new Tripous.Forms.PictureBoxControlRow();
            this.uiColumn1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiColumn1
            // 
            this.uiColumn1.Controls.Add(this.pictureBoxControlRow1);
            this.uiColumn1.Location = new System.Drawing.Point(212, 78);
            this.uiColumn1.Name = "uiColumn1";
            this.uiColumn1.Size = new System.Drawing.Size(460, 30);
            this.uiColumn1.TabIndex = 0;
            // 
            // pictureBoxControlRow1
            // 
            this.pictureBoxControlRow1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pictureBoxControlRow1.Caption = "Text";
            this.pictureBoxControlRow1.DataField = null;
            this.pictureBoxControlRow1.DataSourceName = null;
            this.pictureBoxControlRow1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxControlRow1.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxControlRow1.Name = "pictureBoxControlRow1";
            this.pictureBoxControlRow1.ReadOnly = false;
            this.pictureBoxControlRow1.Required = false;
            this.pictureBoxControlRow1.Size = new System.Drawing.Size(460, 130);
            this.pictureBoxControlRow1.Split = 35;
            this.pictureBoxControlRow1.Stacked = false;
            this.pictureBoxControlRow1.TabIndex = 2;
            this.pictureBoxControlRow1.Value = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(993, 767);
            this.Controls.Add(this.uiColumn1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.uiColumn1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private Tripous.Forms.UiColumn uiColumn1;
        private Tripous.Forms.PictureBoxControlRow pictureBoxControlRow1;
    }
}

