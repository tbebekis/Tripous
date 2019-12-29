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
    /// <para>This is the base implementation.</para>
    /// <para>Each Assembly may contain a ResourceProvider class
    /// decorated with the ResourceProviderAttribute. It can contain more than one though.</para>
    /// <para>NOTE: see ResourceProviderTripous for an example derived class.</para>
    /// </summary>
    public class ResourceProvider : IResourceProvider
    {
        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public ResourceProvider(ResourceManager Manager, string Name)
        {
            if (Manager == null)
                throw new ArgumentNullException("Manager");
            if (string.IsNullOrWhiteSpace(Name))
                throw new ArgumentNullException("Name");

            this.Manager = Manager;
            this.Name = Name;
        }

        /* overrides */
        /// <summary>
        /// Returns a string that describes this object
        /// </summary>
        public override string ToString()
        {
            return Name;
        }

        /* public */
        /// <summary>
        /// Returns a resource string for the Key, if any, else null.
        /// </summary>
        public virtual string GetString(string Key)
        {
            try
            {
                return HasManager ? Manager.GetString(Key) : null;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Returns a resource object for the Key, if any, else null.
        /// </summary>
        public virtual object GetObject(string Key)
        {
            try
            {
                return HasManager ? Manager.GetObject(Key) : null;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Returns a binary resource for the Key, if any, else null.
        /// </summary>
        public virtual byte[] GetBinary(string Key)
        {
            try
            {
                return GetObject(Key) as byte[];
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Returns a resource Image for the Key, if any, else null.
        /// <para>It searches all registered resource managers and the Images</para>
        /// </summary>
        public virtual Image GetImage(string Key)
        {
            try
            {
                return GetObject(Key) as Image;
            }
            catch
            {
                return null;
            }
        }
         

        /* properties */
        /// <summary>
        /// The name of this provider
        /// </summary>
        public virtual string Name { get; protected set; }
        /// <summary>
        /// True if Manager is not null
        /// </summary>
        public virtual bool HasManager { get { return Manager != null; } }
        /// <summary>
        /// The resource manager associated with this provider. Could be null.
        /// </summary>
        public virtual ResourceManager Manager { get; protected set; }
    }
}
