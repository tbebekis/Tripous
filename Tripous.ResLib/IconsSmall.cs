/*--------------------------------------------------------------------------------------        
                           Copyright © 2014 Theodoros Bebekis
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
    /// A list of button image constants
    /// </summary>
    static public partial class IconsSmall
    {

        static IconsHelper Helper;

        /* construction */
        /// <summary>
        /// Static constructor
        /// </summary>
        static IconsSmall()
        {
            Helper = new IconsHelper(typeof(IconsSmall), Names);
        }

        /* public */
        /// <summary>
        /// Initializes this assembly
        /// </summary>
        static public void Initialize()
        {

        }

        /// <summary>
        /// Returns true if ConstantFieldName is a Key in the Names dictionary
        /// </summary>
        static public bool ContainsImageKey(string ConstantFieldName)
        {
            return Helper.ContainsImageKey(ConstantFieldName);
        }
        /// <summary>
        /// Returns the resource path to the image, based on ConstantFieldName.
        /// <para>ConstantFieldName SHOULD be the name of the constant field in this class
        /// and a Key in the Names dictionary</para>
        /// </summary>
        static public string GetImageResourcePath(string ConstantFieldName)
        {
            return Helper.GetImageResourcePath(ConstantFieldName);
        }
        /// <summary>
        /// Returns the constant field name of a constant field in this class
        /// given the ImageResourcePath the constant points to.
        /// </summary>
        static public string GetConstantFieldName(string ImageResourcePath)
        {
            return Helper.GetConstantFieldName(ImageResourcePath);
        }

        /// <summary>
        /// Returns the names of all the constant fields in this class 
        /// pointing to image resouce paths
        /// </summary>
        static public string[] GetImageKeys()
        {
            return Helper.GetImageKeys();
        }
        /// <summary>
        /// Returns all image resource paths
        /// </summary>
        static public string[] GetImageResourcePaths()
        {
            return Helper.GetImageResourcePaths();
        }

        /// <summary>
        /// Returns an Image found in this assembly as an embedded resource.
        /// <para>Key should be the full path to that image,
        /// i.e. ProjectDefaultNamespace.ProjectFolder.ProjectSubFolder.Image.Ext</para>
        /// </summary>
        static public Image GetImage(string ImageResourcePath)
        {
            return Helper.GetImage(ImageResourcePath);
        }
        /// <summary>
        /// Returns a dictionary with all images. 
        /// </summary>
        static public Dictionary<string, Image> GetImages()
        {
            return Helper.GetImages();

        }

        /// <summary>
        /// Returns a copy of the internal dictionary, where each entry has as Key the Constant of the image and as Value the full resource path to the image.
        /// </summary>
        static public Dictionary<string, string> GetNamesDictionary()
        {
            Dictionary<string, string> Result = new Dictionary<string, string>();

            foreach (var Entry in Names)
                Result[Entry.Key] = Entry.Value;

            return Result;
        }

    }
}
