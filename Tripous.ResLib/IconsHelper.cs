/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Drawing;

namespace Tripous 
{
    /// <summary>
    /// Internal helper class
    /// </summary>
    internal class IconsHelper
    {
        Type Type;
        Dictionary<string, string> Names;


        /// <summary>
        /// Constructor.
        /// <para>Type is the type of owner static class.</para>
        /// <para>Names is tha array of icon names of the owner.</para>
        /// </summary>
        public IconsHelper(Type Type, Dictionary<string, string> Names)
        {
            this.Type = Type;
            this.Names = Names;
        }


        /// <summary>
        /// Returns true if ConstantFieldName is a Key in the Names dictionary
        /// </summary>
        public bool ContainsImageKey(string ConstantFieldName)
        {
            if (!string.IsNullOrWhiteSpace(ConstantFieldName))
            {
                foreach (var Item in Names)
                {
                    if (string.Compare(Item.Key, ConstantFieldName, StringComparison.InvariantCultureIgnoreCase) == 0)
                        return true;
                }

            }
            return false;
        }
        /// <summary>
        /// Returns the resource path to the image, based on ConstantFieldName.
        /// <para>ConstantFieldName SHOULD be the name of the constant field in this class
        /// and a Key in the Names dictionary</para>
        /// </summary>
        public string GetImageResourcePath(string ConstantFieldName)
        {
            if (!string.IsNullOrWhiteSpace(ConstantFieldName))
            {
                foreach (var Item in Names)
                {
                    if (string.Compare(Item.Key, ConstantFieldName, StringComparison.InvariantCultureIgnoreCase) == 0)
                        return Item.Value;
                }

            }
            return string.Empty;
        }
        /// <summary>
        /// Returns the constant field name of a constant field in this class
        /// given the ImageResourcePath the constant points to.
        /// </summary>
        public string GetConstantFieldName(string ImageResourcePath)
        {
            if (!string.IsNullOrWhiteSpace(ImageResourcePath))
            {
                foreach (var Item in Names)
                {
                    if (string.Compare(Item.Value, ImageResourcePath, StringComparison.InvariantCultureIgnoreCase) == 0)
                        return Item.Key;
                }

            }
            return string.Empty;
        }

        /// <summary>
        /// Returns the names of all the constant fields in this class 
        /// pointing to image resouce paths
        /// </summary>
        public string[] GetImageKeys()
        {
            List<string> List = new List<string>();
            foreach (var Item in Names)
                List.Add(Item.Key);
            return List.ToArray();
        }
        /// <summary>
        /// Returns all image resource paths
        /// </summary>
        public string[] GetImageResourcePaths()
        {
            List<string> List = new List<string>();
            foreach (var Item in Names)
                List.Add(Item.Value);
            return List.ToArray();
        }

        /// <summary>
        /// Returns an Image found in this assembly as an embedded resource.
        /// <para>Key should be the full path to that image,
        /// i.e. ProjectDefaultNamespace.ProjectFolder.ProjectSubFolder.Image.Ext</para>
        /// </summary>
        public Image GetImage(string ImageResourcePath)
        {
            Stream stream = null;
            try
            {
                stream = this.Type.Assembly.GetManifestResourceStream(ImageResourcePath);
                if (stream != null)
                    return Image.FromStream(stream);
            }
            catch
            {
            }

            return null;
        }
        /// <summary>
        /// Returns a dictionary with all images. 
        /// </summary>
        public Dictionary<string, Image> GetImages()
        {
            Image Image;
            Dictionary<string, Image> Result = new Dictionary<string, Image>();
            foreach (var Item in Names)
            {
                Image = GetImage(Item.Value);
                if (Image != null)
                {
                    Result[Item.Key] = Image;
                }
            }

            return Result;

        }
    }
}
