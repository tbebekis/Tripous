/*--------------------------------------------------------------------------------------        
                           Copyright © 2018 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.Drawing;

namespace Tripous
{
    /// <summary>
    /// Represents an object that provides resources such as string and images.
    /// <para>The class ResourceProvider provides a base implementation.</para>
    /// <para>Each Assembly may contain a ResourceProvider class
    /// decorated with the ResourceProviderAttribute. It can contain more than one though.</para>
    /// <para>External modules (plugins - see: ExternalModules class) may implement this interface.</para>
    /// <para>The ObjectStore loads automatically those classes marked with ResourceProviderAttribute
    /// and implementing this interface.</para>
    /// </summary>
    public interface IResourceProvider
    {
        /// <summary>
        /// Returns a resource string for the Key, if any, else null.
        /// </summary>
        string GetString(string Key);
        /// <summary>
        /// Returns a resource object for the Key, if any, else null.
        /// </summary>
        object GetObject(string Key);
        /// <summary>
        /// Returns a binary resource for the Key, if any, else null.
        /// </summary>
        byte[] GetBinary(string Key);
        /// <summary>
        /// Returns a resource Image for the Key, if any, else null.
        /// </summary>
        Image GetImage(string Name);


        /* properties */
        /// <summary>
        /// The name of this provider
        /// </summary>
        string Name { get; }
        /// <summary>
        /// True if Manager is not null
        /// </summary>
        bool HasManager { get; }
        /// <summary>
        /// The resource manager associated with this provider. Could be null.
        /// </summary>
        ResourceManager Manager { get; }
    }
}
