using System;
using System.Collections.Generic;
using System.Text;

namespace Tripous
{
    /// <summary>
    /// Resolves resource paths that are registered under a key.
    /// </summary>
    public interface IResourceKeyResolver
    {
        /// <summary>
        /// Returns the resource path of a specified key, if any, else null.
        /// </summary>
        string KeyToResourcePath(string Key);
        /// <summary>
        /// Returns the key of a resource specified by a resource path, if any, else null.
        /// </summary>
        string ResourcePathToKey(string ResourcePath);
    }


    /// <summary>
    /// Resolves resource paths that are registered under a key.
    /// </summary>
    static public class ResourceKeyResolvers
    {
        static object syncLock = new LockObject();
        static List<IResourceKeyResolver> Resolvers = new List<IResourceKeyResolver>();

        /// <summary>
        /// Registers a resolver
        /// </summary>
        static public void Add(IResourceKeyResolver Resolver)
        {
            lock (syncLock)
            {
                if (!Resolvers.Contains(Resolver))
                    Resolvers.Add(Resolver);
            }            
        }
        /// <summary>
        /// Unregisters a resolver
        /// </summary>
        static public void Remove(IResourceKeyResolver Resolver)
        {
            lock (syncLock)
            {
                Resolvers.Remove(Resolver);
            }
        }


        /// <summary>
        /// Returns the resource path of a specified key, if any, else null.
        /// </summary>
        static public string KeyToResourcePath(string Key)
        {
            string Result = null;

            lock (syncLock)
            {
                foreach (var Resolver in Resolvers)
                {
                    Result = Resolver.KeyToResourcePath(Key);
                    if (!string.IsNullOrWhiteSpace(Result))
                        return Result;
                }
            }

            return Result;
        }
        /// <summary>
        /// Returns the key of a resource specified by a resource path, if any, else null.
        /// </summary>
        static public string ResourcePathToKey(string Key)
        {
            string Result = null;

            lock (syncLock)
            {
                foreach (var Resolver in Resolvers)
                {
                    Result = Resolver.ResourcePathToKey(Key);
                    if (!string.IsNullOrWhiteSpace(Result))
                        return Result;
                }
            }

            return Result;
        }
    }
}
