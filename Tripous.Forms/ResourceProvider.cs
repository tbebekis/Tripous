using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tripous.Forms
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
