/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tripous
{

    /// <summary>
    /// Represents an object that can display commands. Usually the main form.
    /// </summary>
    public interface ICommandHost
    {
        /* methods */
        /// <summary>
        /// Signals the host that the command sets have changed,
        /// usually because the user has changed.
        /// </summary>
        void CommandSetsChanged();
        /// <summary>
        /// Signals the host that the selected command set has changed,
        /// either because the user selects another command set
        /// or because the user has changed.
        /// </summary>
        void SelectedCommandSetChanged();
        /// <summary>
        /// Signals the host to create main and other menu items.
        /// </summary>
        void CreateMenuItems();

        /* properties */
        /// <summary>
        /// Controls the visibility of the tool bar
        /// </summary>
        bool ToolbarVisible { get; set; }
 
    }
}
