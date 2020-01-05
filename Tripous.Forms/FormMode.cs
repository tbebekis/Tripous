/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;


namespace Tripous.Forms
{


    /// <summary>
    /// Indicates the mode of a data form.
    /// </summary>
    [Flags]
    public enum FormMode
    {
        /// <summary>
        /// None
        /// </summary>
        None = 0,
        /// <summary>
        /// Indicates a "list" form. A list form has just a single "part" where displays a read-write grid.
        /// </summary>
        List = 1,
        /// <summary>
        /// Indicates a "master list" form. A master list form provides two "parts": A list or browser which displays a
        /// a read-only grid and an "entry" part where data bound controls are placed.
        /// <para>NOTE: Those two parts are bound to the SAME DataTable object.</para>
        /// </summary>
        ListMaster = 2,
        /// <summary>
        /// Indicates a "master" form. A master form provides two "parts": A list or browser which displays a
        /// a read-only grid and an "entry" part where data bound controls are placed.
        /// <para>NOTE: Those two parts are bound to DIFFERENT DataTable objects.</para>
        /// </summary>
        Master = 4,

    }
}
