using System;
using System.Collections.Generic;
using System.Text;

namespace Tripous.Model
{
    /// <summary>
    /// The Project resource provider
    /// </summary>
    [ResourceProviderAttribute()]
    internal class ResourceProvider : Tripous.ResourceProvider
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ResourceProvider()
            : base(Properties.Resources.ResourceManager, typeof(ResourceProvider).Namespace)
        {
        }
    }
}
