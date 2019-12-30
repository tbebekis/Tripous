using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tripous.Windows.Forms
{
    [Flags]
    public enum FormState
    {
        None = 0,
        List = 1,
        Insert = 2,
        Edit = 4,
        Delete = 8,
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
