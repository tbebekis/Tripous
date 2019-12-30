/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
 

namespace Tripous.Forms
{
    /// <summary>
    /// Indicates the mode of a TextBoxEx control
    /// </summary>
    [Flags]
    public enum TextBoxMode
    {
        /// <summary>
        /// None
        /// </summary>
        None = 0,
        /// <summary>
        /// Custom
        /// </summary>
        Custom = 1,
        /// <summary>
        /// Date
        /// </summary>
        Date = 2,
        /// <summary>
        /// FileName
        /// </summary>
        FileName = 4,
        /// <summary>
        /// Folder
        /// </summary>
        Folder = 8,
        /// <summary>
        /// Date and Time
        /// </summary>
        DateTime = 0x10,
        /// <summary>
        /// Time only
        /// </summary>
        Time = 0x20,
        /// <summary>
        /// Memo
        /// </summary>
        Memo = 0x40,
    }



}
