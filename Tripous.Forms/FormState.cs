using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tripous.Forms
{
    /// <summary>
    /// The state of a data-form
    /// </summary>
    [Flags]
    public enum FormState
    {
        /// <summary>
        /// None
        /// </summary>
        None = 0,
        /// <summary>
        /// List
        /// </summary>
        List = 1,
        /// <summary>
        /// Insert
        /// </summary>
        Insert = 2,
        /// <summary>
        /// Edit
        /// </summary>
        Edit = 4,
        /// <summary>
        /// Delete
        /// </summary>
        Delete = 8,
        /// <summary>
        /// Find
        /// </summary>
        Find = 0x10,
    }


    /// <summary>
    /// Helper
    /// </summary>
    static public class FormStates
    {
        /// <summary>
        /// Constant
        /// </summary>
        static public readonly FormState All = (FormState)Bf.All(typeof(FormState));

        /// <summary>
        /// Returns a state set, to be used as FormOption.InvalidSates, where AllowOnly is the only allowed DataFormStates.
        /// </summary>
        static public FormState GetInvalid(FormState AllowOnly)
        {
            return (FormState)Bf.Subtract(FormStates.All, AllowOnly);
        }
    }
}
