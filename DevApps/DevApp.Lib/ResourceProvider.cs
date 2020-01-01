using System;
using System.Collections.Generic;
using System.Text;

using Tripous;

namespace DevApp.Lib
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
