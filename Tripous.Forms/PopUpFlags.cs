/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;

namespace Tripous.Forms
{
    /// <summary>
    /// Flags used with a pop up form.
    /// </summary>
    [Flags]
    public enum PopUpFlags
    {
        /// <summary>
        /// Indicates a sizable form
        /// </summary>
        Sizable = 1,
        /// <summary>
        /// Indicates that the grid should have row headers
        /// </summary>
        GridRowHeader = 2,
        /// <summary>
        /// Indicates the the grid should have column titles.
        /// </summary>
        GridTitles = 4,
    }
}
