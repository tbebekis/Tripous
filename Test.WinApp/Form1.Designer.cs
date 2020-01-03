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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textDataControl1 = new Tripous.Forms.TextDataControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiColumnPanel4 = new Tripous.Forms.UiColumnPanel();
            this.uiColumnPanel3 = new Tripous.Forms.UiColumnPanel();
            this.uiColumnPanel2 = new Tripous.Forms.UiColumnPanel();
            this.uiColumnPanel1 = new Tripous.Forms.UiColumnPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uiColumnPanel4);
            this.panel1.Controls.Add(this.uiColumnPanel3);
            this.panel1.Controls.Add(this.uiColumnPanel2);
            this.panel1.Controls.Add(this.uiColumnPanel1);
            this.panel1.Controls.Add(this.textDataControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 120);
            this.panel1.TabIndex = 8;
            // 
            // textDataControl1
            // 
            this.textDataControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.textDataControl1.Caption = "Text";
            this.textDataControl1.DataField = null;
            this.textDataControl1.DataSourceName = null;
            this.textDataControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textDataControl1.Location = new System.Drawing.Point(0, 0);
            this.textDataControl1.Name = "textDataControl1";
            this.textDataControl1.ReadOnly = false;
            this.textDataControl1.Required = false;
            this.textDataControl1.Size = new System.Drawing.Size(1197, 28);
            this.textDataControl1.Split = 35;
            this.textDataControl1.Stacked = false;
            this.textDataControl1.TabIndex = 1;
            this.textDataControl1.Value = "";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1197, 655);
            this.panel2.TabIndex = 10;
            // 
            // uiColumnPanel4
            // 
            this.uiColumnPanel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.uiColumnPanel4.Location = new System.Drawing.Point(614, 80);
            this.uiColumnPanel4.Name = "uiColumnPanel4";
            this.uiColumnPanel4.Size = new System.Drawing.Size(120, 30);
            this.uiColumnPanel4.TabIndex = 5;
            // 
            // uiColumnPanel3
            // 
            this.uiColumnPanel3.BackColor = System.Drawing.Color.SeaGreen;
            this.uiColumnPanel3.Location = new System.Drawing.Point(444, 80);
            this.uiColumnPanel3.Name = "uiColumnPanel3";
            this.uiColumnPanel3.Size = new System.Drawing.Size(120, 30);
            this.uiColumnPanel3.TabIndex = 4;
            // 
            // uiColumnPanel2
            // 
            this.uiColumnPanel2.BackColor = System.Drawing.Color.Goldenrod;
            this.uiColumnPanel2.Location = new System.Drawing.Point(258, 80);
            this.uiColumnPanel2.Name = "uiColumnPanel2";
            this.uiColumnPanel2.Size = new System.Drawing.Size(120, 30);
            this.uiColumnPanel2.TabIndex = 3;
            // 
            // uiColumnPanel1
            // 
            this.uiColumnPanel1.BackColor = System.Drawing.Color.Gray;
            this.uiColumnPanel1.Location = new System.Drawing.Point(76, 80);
            this.uiColumnPanel1.Name = "uiColumnPanel1";
            this.uiColumnPanel1.Size = new System.Drawing.Size(120, 30);
            this.uiColumnPanel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 775);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Panel panel1;
        private Tripous.Forms.TextDataControl textDataControl1;
        private Tripous.Forms.UiColumnPanel uiColumnPanel4;
        private Tripous.Forms.UiColumnPanel uiColumnPanel3;
        private Tripous.Forms.UiColumnPanel uiColumnPanel2;
        private Tripous.Forms.UiColumnPanel uiColumnPanel1;
        private System.Windows.Forms.Panel panel2;
    }
}

