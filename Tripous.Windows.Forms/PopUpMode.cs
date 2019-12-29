/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;

namespace Tripous.Windows.Forms
{
    /// <summary>
    /// Indicates the mode of the pop up form
    /// </summary>
    [Flags]
    public enum PopUpMode
    {
        /// <summary>
        /// Undefined
        /// </summary>
        None = 0,
        /// <summary>
        /// A custom type form
        /// </summary>
        Custom = 1,
        /// <summary>
        /// A list box form
        /// </summary>
        List = 2,
        /// <summary>
        /// A check list box form
        /// </summary>
        CheckList = 4,
        /// <summary>
        /// A select date form
        /// </summary>
        Date = 8,
        /// <summary>
        /// A grid container form
        /// </summary>
        Grid = 0x10,
        /// <summary>
        /// A multiline text box container form
        /// </summary>
        Memo = 0x20,
        /// <summary>
        /// A picture box container form
        /// </summary>
        Image = 0x40,
        /// <summary>
        /// A form that displays the content of a blob field
        /// </summary>
        Blob = 0x80,
        /// <summary>
        /// A form that contains a TreeView
        /// </summary>
        TreeView = 0x100,
    }
}
