/*--------------------------------------------------------------------------------------        
                           Copyright © 2018 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tripous
{
    /// <summary>
    /// Classes marked with this attribute MUST implement the IResourceProvider interface
    /// and provide a parameterless constructor.
    /// <para>The ObjectStore, in the loading phase, invokes the constructor
    /// and passes the created IResourceProvider instance to the Res static class. </para>
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class ResourceProviderAttribute : Attribute
    {
        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public ResourceProviderAttribute()
        {
        }
    }
}
