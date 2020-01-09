using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tripous.Forms
{
    /// <summary>
    /// The action of a data-form, as a result of a button or mouse item click, or any other cause.
    /// </summary>
    [Flags]
    public enum FormAction
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
        /// <summary>
        /// Delete
        /// </summary>
        Delete = 0x20,
        /// <summary>
        /// Save
        /// </summary>
        Save = 0x40,

        /// <summary>
        /// Cancel
        /// </summary>
        Cancel = 0x80,
        /// <summary>
        /// OK
        /// </summary>
        OK = 0x100,
        /// <summary>
        /// Close
        /// </summary>
        Close = 0x200,

        /// <summary>
        /// Custom1
        /// </summary>
        Custom1 = 0x300,
        /// <summary>
        /// Custom2
        /// </summary>
        Custom2 = 0x800,
        /// <summary>
        /// Custom3
        /// </summary>
        Custom3 = 0x1000,
        /// <summary>
        /// Custom4
        /// </summary>
        Custom4 = 0x2000,

    }


    /// <summary>
    /// Helper
    /// </summary>
    static public class FormActionHelper
    {
        /// <summary>
        /// Constant
        /// </summary>
        static public readonly FormAction All = (FormAction)Bf.All(typeof(FormAction));

        /// <summary>
        /// Returns a state set, to be used as FormOption.InvalidSates, where AllowOnly is the only allowed DataFormStates.
        /// </summary>
        static public FormAction GetInvalid(FormAction AllowOnly)
        {
            return (FormAction)Bf.Subtract(FormActionHelper.All, AllowOnly);
        }
    }
}
