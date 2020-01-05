using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripous.Forms
{
    /// <summary>
    /// A container for <see cref="UiGroup"/> containers.
    /// <para>Just to provide vertical scroll only.</para>
    /// </summary>
    public class UiGroupContainer: Panel
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public UiGroupContainer()
        {
            base.AutoScroll = true;
            base.HorizontalScroll.Enabled = false;
            base.HorizontalScroll.Visible = false;
        }


        /// <summary>
        /// Prohibit changing the property
        /// </summary>
        public override bool AutoScroll
        {
            get { return base.AutoScroll; }
            set { }
        }
 
    }
}
