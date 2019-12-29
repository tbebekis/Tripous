using System;
 

namespace Tripous.Logging
{
    /// <summary>
    /// The level of log info to issue, display, or persist
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// None
        /// </summary>
        None = 0,
        /// <summary>
        /// Trace
        /// </summary>
        Trace = 1,
        /// <summary>
        /// Debug
        /// </summary>
        Debug = 2,
        /// <summary>
        /// Info
        /// </summary>
        Info = 3,
        /// <summary>
        /// Warn
        /// </summary>
        Warn = 4,
        /// <summary>
        /// Error
        /// </summary>
        Error = 5,
        /// <summary>
        /// Fatal
        /// </summary>
        Fatal = 6,

    }
}
