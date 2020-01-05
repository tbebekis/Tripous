using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripous.Forms
{

    /// <summary>
    /// A list data form that uses an <see cref="SqlBroker"/>
    /// </summary>
    public partial class DataFormSqlBrokerList : DataFormSqlBroker
    {
        /// <summary>
        /// Processes form options
        /// </summary>
        protected override void ProcessFormOptions()
        {
            base.ProcessFormOptions();

            if (Options != null)
            {
                Options.InvalidStates |= FormState.Insert | FormState.Edit | FormState.Delete | FormState.Find;
            }
        }


        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public DataFormSqlBrokerList()
        {
            InitializeComponent();
        }

        /* properties */
        /// <summary>
        /// Returns the form mode
        /// </summary>
        public override FormMode FormMode { get { return FormMode.List; } }
    }
}
