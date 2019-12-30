namespace DevApp.WinForms
{
    partial class TestForm
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
            this.btnSetText = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.edtSetText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSetText
            // 
            this.btnSetText.Location = new System.Drawing.Point(171, 155);
            this.btnSetText.Name = "btnSetText";
            this.btnSetText.Size = new System.Drawing.Size(75, 23);
            this.btnSetText.TabIndex = 0;
            this.btnSetText.Text = "Set Text";
            this.btnSetText.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(35, 139);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // edtSetText
            // 
            this.edtSetText.Location = new System.Drawing.Point(275, 156);
            this.edtSetText.Name = "edtSetText";
            this.edtSetText.Size = new System.Drawing.Size(100, 20);
            this.edtSetText.TabIndex = 2;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edtSetText);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSetText);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetText;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox edtSetText;
    }
}