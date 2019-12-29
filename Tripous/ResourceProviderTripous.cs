/*--------------------------------------------------------------------------------------        
                           Copyright © 2018 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;


namespace Tripous
{
    /// <summary>
    /// The Tripous main resource provider
    /// </summary>
    [ResourceProviderAttribute()]
    internal class ResourceProviderTripous : Tripous.ResourceProvider
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ResourceProviderTripous()
            : base(Tripous.Properties.Resources.ResourceManager, "Tripous")
        {
        }
    }
}
