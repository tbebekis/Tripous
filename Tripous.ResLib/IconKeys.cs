/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Reflection;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Tripous
{

    /// <summary>
    /// A helper class for resolving image constant names.
    /// <para>This class maintains a dictionary where 
    /// a Key is the name of a constant string field from one of the static image classes, 
    /// and Value is the constant value,
    /// that is the image resource name.</para>
    /// </summary>
    static public class IconKeys
    {
        /// <summary>
        /// The default ico
        /// </summary>
        static public readonly System.Drawing.Image DefaultIco = Res.GetImage(Icons32.Application);
        static ResourceKeyResolver Resolver = new ResourceKeyResolver();

        internal class ResourceKeyResolver : IResourceKeyResolver
        {
            /// <summary>
            /// Returns the resource path of a specified key, if any, else null.
            /// </summary>
            public string KeyToResourcePath(string Key)
            {
                return IconKeys.Resolve(Key);
            }
            /// <summary>
            /// Returns the key of a resource specified by a resource path, if any, else null.
            /// </summary>
            public string ResourcePathToKey(string ResourcePath)
            {
                return IconKeys.FindConstantName(ResourcePath);
            }
        }

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        static IconKeys()
        {
        }

        /* public */
        /// <summary>
        /// Returns an image resouce name.
        /// <para>ConstantName is the name of a constant string field from one of the three image classes.</para>
        /// <para>The function returns the value of the constant field.</para>
        /// </summary>
        static public string Resolve(string ConstantName)
        {
            if (!string.IsNullOrWhiteSpace(ConstantName))
            {
                string Section = string.Empty;
                string Key = string.Empty;

                string[] Parts = ConstantName.Split('.');
                if (Parts.Length == 1)
                {
                    Section = typeof(Icons32).Name;
                    Key = ConstantName;
                }
                else if (Parts.Length == 2)
                {
                    Section = Parts[0];
                    Key = Parts[1];
                }

                if (!string.IsNullOrWhiteSpace(Section) && !string.IsNullOrWhiteSpace(Key))
                {
                    if (Section.IsSameText(typeof(Icons32).Name))
                    {
                        return Icons32.GetImageResourcePath(Key);
                    }
                    else if (Section.IsSameText(typeof(Icons8_32).Name))
                    {
                        return Icons8_32.GetImageResourcePath(Key);
                    }
                    else if (Section.IsSameText(typeof(IconsSmall).Name))
                    {
                        return IconsSmall.GetImageResourcePath(Key);
                    }
                }
 
            }

            return string.Empty;
        }
        /// <summary>
        /// Does the opposite of the Resolve()
        /// </summary>
        static public string FindConstantName(string ImageResourcePath)
        {
            string Result = string.Empty;

            if (!string.IsNullOrWhiteSpace(ImageResourcePath))
            {
                Result = Icons32.GetConstantFieldName(ImageResourcePath);
                if (string.IsNullOrWhiteSpace(Result))
                    Result = Icons8_32.GetConstantFieldName(ImageResourcePath);
                if (string.IsNullOrWhiteSpace(Result))
                    Result = IconsSmall.GetConstantFieldName(ImageResourcePath);
            }

            return Result;
        }
        /// <summary>
        /// Creates and returns a JObject containing an Ico 
        /// </summary>
        static public JObject CreateIcon(string Key, string ImageResourcePath)
        {
            Image Ico = Icons32.GetImage(ImageResourcePath);
            if (Ico == null)
            {
                Ico = DefaultIco;
            }

            return JsonImageList.CreateIcon(Key, Ico);
        }

        /// <summary>
        /// Creates an ico (image) list with all images (pairs, 32x32 and 16x16)
        /// </summary>
        static public JsonImageList CreateIconList()
        {
            return CreateIconList(Icons32.GetImageResourcePaths()); 
        }
        /// <summary>
        /// Creates an ico (image) list where each entry contains an image (32x32)
        /// </summary>
        static public JsonImageList CreateIconList(string[] ImageResourcePaths)
        {
            string Key;
            JsonImageList List = new JsonImageList();

            foreach (string ImageResourcePath in ImageResourcePaths)
            {
                Key = FindConstantName(ImageResourcePath);
                List.Add(Key, CreateIcon(Key, ImageResourcePath));
            }

            return List; 
        }
        /// <summary>
        /// Creates an ico (image) list where each entry contains an image (32x32)
        /// </summary>
        static public JsonImageList CreateIconListByKeys(string[] Keys)
        {
            string ImageResourcePath;
            JsonImageList List = new JsonImageList();

            foreach (string Key in Keys)
            {
                ImageResourcePath = Icons32.GetImageResourcePath(Key);
                List.Add(Key, CreateIcon(Key, ImageResourcePath));
            }

            return List; 
        }
        /// <summary>
        /// Creates an ico (image) list with a single each entry containing an image (32x32)
        /// </summary>
        static public JsonImageList CreateIconListByKey(string Key)
        {
            return CreateIconListByKeys(new string[] { Key });
        }

        /// <summary>
        /// Assignes the two methods to Sys
        /// </summary>
        [Initializer]
        static public void ImageKeysInitializer()
        {
            ResourceKeyResolvers.Add(Resolver);
        }
    }
}
