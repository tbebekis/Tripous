using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WeifenLuo.WinFormsUI.Docking;

using Tripous;
using Tripous.Logging;
using Tripous.Data;
using Tripous.Windows.Forms;

namespace DevApp.WinForms
{
    public partial class TestForm : BaseForm
    {
        void AnyClick(object sender, EventArgs ea)
        {
            if (btnClose == sender)
            {
                this.Close();
            }
            else if (btnSetText == sender)
            {
                if (!string.IsNullOrWhiteSpace(edtSetText.Text))
                {
                    this.Text = edtSetText.Text;
                }
            }
        }

        protected override void FormInitialize()
        {
            base.FormInitialize();

            btnClose.Click += AnyClick;
            btnSetText.Click += AnyClick;
        }
        public TestForm()
        {
            InitializeComponent();
        }
    }
}
