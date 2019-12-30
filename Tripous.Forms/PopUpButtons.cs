/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
 

namespace Tripous.Forms
{


    /// <summary>
    /// Indicates what buttons to be used with the pop up form
    /// </summary>
    [Flags]
    public enum PopUpButtons
    {
        /// <summary>
        /// The OK button
        /// </summary>
        OK = 1,
        /// <summary>
        /// The Cancel button
        /// </summary>
        Cancel = 2,
        /// <summary>
        /// The Clear button
        /// </summary>
        Clear = 4,
        /// <summary>
        /// The Save button
        /// </summary>
        Save = 8,
        /// <summary>
        /// The Load button
        /// </summary>
        Load = 0x10,
    }










}
