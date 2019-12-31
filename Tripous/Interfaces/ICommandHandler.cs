﻿/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;

namespace Tripous
{
    /// <summary>
    /// Represents an object that handles command execution.
    /// </summary>
    public interface ICommandHandler
    {
        /// <summary>
        /// Returns true if the specified Command is executed by this handler
        /// </summary>
        bool Execute(Command Command);
        /// <summary>
        /// Handles the property change of the specified command.
        /// </summary>
        void EnabledChanged(Command Command);
        /// <summary>
        /// Handles the property change of the specified command.
        /// </summary>
        void VisibleChanged(Command Command);
    }

}
