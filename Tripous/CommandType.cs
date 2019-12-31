using System;
using System.Collections.Generic;
using System.Text;

namespace Tripous
{
    /// <summary>
    /// Determines the "type" of a command object.
    /// </summary>
    [Flags]
    public enum CommandType
    {        
        /// <summary>
        /// Command is a container for other commands. It acts just like a drop-down menu item.
        /// </summary>
        Container = 0,
        /// <summary>
        /// Command is a separator command, used just for display purposes
        /// </summary>
        Separator = 1,
        /// <summary>
        /// A command. Command's name is used by the system in finding what to execute.
        /// </summary>
        Command = 2,
        /// <summary>
        /// Command's name is the Name of a function or the command provides script source code for execution.
        /// </summary>
        Func = 4, 
    }

 
}
