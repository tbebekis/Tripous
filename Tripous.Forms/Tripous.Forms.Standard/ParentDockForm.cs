using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using WeifenLuo.WinFormsUI.Docking;

namespace Tripous.Forms
{
    /// <summary>
    /// A container for forms
    /// </summary>
    public partial class ParentDockForm : DockContent
    {
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (ChildForm != null)
            {
                if (!ChildForm.IsClosing)
                {
                    if (ChildForm.CanClose())
                    {
                        InClosing = true;
                        ChildForm.Close();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }                  
 
            }
 
            base.OnFormClosing(e);
        }

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public ParentDockForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The child form
        /// </summary>
        public BaseForm ChildForm { get; set; }
        internal bool InClosing { get; set; }

    }
}
