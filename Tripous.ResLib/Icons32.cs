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
    /// A list of button image constants
    /// </summary>
    static public partial class Icons32
    {
        /// <summary>
        /// Constant
        /// </summary>
        public const string DataList = Application_View_Columns;
        /// <summary>
        /// Constant
        /// </summary>
        public const string DataFind = Find;

        /// <summary>
        /// Constant
        /// </summary>
        public const string DataFirst = Resultset_First;
        /// <summary>
        /// Constant
        /// </summary>
        public const string DataPrior = Resultset_Previous;
        /// <summary>
        /// Constant
        /// </summary>
        public const string DataNext = Resultset_Next;
        /// <summary>
        /// Constant
        /// </summary>
        public const string DataLast = Resultset_Last;


        /// <summary>
        /// Constant
        /// </summary>
        public const string DataEdit = Table_Edit;
        /// <summary>
        /// Constant
        /// </summary>
        public const string DataInsert = Table_Add;
        /// <summary>
        /// Constant
        /// </summary>
        public const string DataDelete = Table_Delete;
        /// <summary>
        /// Constant
        /// </summary>
        public const string DataSave = Table_Save;
        /// <summary>
        /// Constant
        /// </summary>
        public const string DataCancel = Cross;


        /// <summary>
        /// Constant
        /// </summary>
        public const string FormCancel = Cancel;
        /// <summary>
        /// Constant
        /// </summary>
        public const string FormOK = Accept;
        /// <summary>
        /// Constant
        /// </summary>
        public const string FormExit = Door_Out;

        static IconsHelper Helper;

        /* construction */
        /// <summary>
        /// Static constructor
        /// </summary>
        static Icons32()
        {
            Helper = new IconsHelper(typeof(Icons32), Names);
        }


        /* public */
        /// <summary>
        /// Initializes this assembly
        /// </summary>
        static public void Initialize()
        {

            Names["DataList"] = Application_View_Columns;
            Names["DataFind"] = Find;

            Names["DataFirst"] = Resultset_First;
            Names["DataPrior"] = Resultset_Previous;
            Names["DataNext"] = Resultset_Next;
            Names["DataLast"] = Resultset_Last;

            Names["DataEdit"] = Table_Edit;
            Names["DataInsert"] = Table_Add;
            Names["DataDelete"] = Table_Delete;
            Names["DataSave"] = Table_Save;
            Names["DataCancel"] = Cross;

            Names["FormCancel"] = Cancel;
            Names["FormOK"] = Accept;
            Names["FormExit"] = Door_Out;

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
