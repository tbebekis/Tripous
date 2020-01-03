namespace Tripous.Forms
{
    partial class DateBoxControlRow
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
            this.edtDateTimePicker = new Tripous.Forms.DateTimePickerEx();
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
            this.pnlControl.Controls.Add(this.edtDateTimePicker);
            this.pnlControl.Location = new System.Drawing.Point(140, 0);
            this.pnlControl.Size = new System.Drawing.Size(260, 28);
            // 
            // edtDateTimePicker
            // 
            this.edtDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.edtDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtDateTimePicker.Format = Tripous.DateTimeFormatType.Date;
            this.edtDateTimePicker.Location = new System.Drawing.Point(4, 4);
            this.edtDateTimePicker.Name = "edtDateTimePicker";
            this.edtDateTimePicker.NullValue = "[select a date]";
            this.edtDateTimePicker.Size = new System.Drawing.Size(252, 20);
            this.edtDateTimePicker.TabIndex = 0;
            this.edtDateTimePicker.Value = new System.DateTime(2020, 1, 2, 16, 57, 32, 787);
            // 
            // DateBoxDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Name = "DateBoxDataControl";
            this.pnlText.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePickerEx edtDateTimePicker;
    }
}
