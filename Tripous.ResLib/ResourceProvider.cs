/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tripous.ResLib
{
    /// <summary>
    /// The Tripous.Forms resource provider
    /// </summary>
    [ResourceProviderAttribute()]
    internal class ResourceProvider : Tripous.ResourceProvider
    {
        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public ResourceProvider()
            : base(Tripous.ResLib.Properties.Resources.ResourceManager, "Tripous.ResLib")
        {
        }

        /* public */
        /// <summary>
        /// Returns a resource Image for the Key, if any, else null.
        /// <para>It searches all registered resource managers and the Images</para>
        /// </summary>
        public override Image GetImage(string Key)
        {
            Image Result = base.GetImage(Key);

            if (Result == null)
            {
                Result = Tripous.Icons32.GetImage(Key);
            }

            if (Result == null)
            {
                Result = Tripous.Icons8_32.GetImage(Key);
            }

            return Result;
        }

    }
}
