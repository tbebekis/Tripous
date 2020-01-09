using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tripous.Forms
{
    /// <summary>
    /// The state of a data-form indicates the UI the form is currently displaying
    /// </summary>
    public enum FormState
    {
        /// <summary>
        /// None
        /// </summary>
        None = 0,

        /// <summary>
        /// Home
        /// </summary>
        Home = 1,
        /// <summary>
        /// Find
        /// </summary>
        Find = 2,
        /// <summary>
        /// List
        /// </summary>
        List = 4,
        /// <summary>
        /// Insert
        /// </summary>
        Insert = 8,

        /// <summary>
        /// Edit
        /// </summary>
        Edit = 0x10,
    }
}
