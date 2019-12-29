using System;
using System.Collections.Generic;
using System.Text;

namespace Tripous
{
    /// <summary>
    /// For marking classes implementing the <see cref="IExternalModule" /> interface.
    /// <para>The loader examines classes marked with this attribute in order to decide what to load.</para>
    /// <para>An external module is loaded only if its mode equals to or contains the <see cref="SysConfig.ApplicationMode" /></para>
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ExternalModuleAttribute : Attribute
    {
        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public ExternalModuleAttribute(ApplicationMode Mode)
            : this(Mode, string.Empty)
        {
        }
        /// <summary>
        /// Constructor
        /// </summary>
        public ExternalModuleAttribute(ApplicationMode Mode, string Category)
        {
            this.Mode = Mode;
            this.Category = Category;
        }

        /* properties */
        /// <summary>
        /// The mode of an ExternalModule.
        /// <para>An external module is loaded only if its mode equals to or contains the <see cref="SysConfig.ApplicationMode" /></para>
        /// </summary>
        public ApplicationMode Mode { get; set; }
        /// <summary>
        /// A category
        /// </summary>
        public string Category { get; set; }
    }
}
