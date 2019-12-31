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
    static public class IconsSmall
    {
      

        #region Constants

        /// <summary>
        /// Constant
        /// </summary>
        public const string Application_Blue = "Tripous.ResLib.Icons_Small.Application_Blue.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Application_List_Blue = "Tripous.ResLib.Icons_Small.Application_List_Blue.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Arrow_Down = "Tripous.ResLib.Icons_Small.Arrow_Down.bmp";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Arrow_Down_2 = "Tripous.ResLib.Icons_Small.Arrow_Down_2.bmp";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Arrow_Down_Black = "Tripous.ResLib.Icons_Small.Arrow_Down_Black.gif";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Arrow_Down_Blue = "Tripous.ResLib.Icons_Small.Arrow_Down_Blue.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Arrow_Down_Green = "Tripous.ResLib.Icons_Small.Arrow_Down_Green.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Arrow_Left = "Tripous.ResLib.Icons_Small.Arrow_Left.bmp";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Arrow_Left_Black = "Tripous.ResLib.Icons_Small.Arrow_Left_Black.gif";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Arrow_Left_Blue = "Tripous.ResLib.Icons_Small.Arrow_Left_Blue.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Arrow_Left_Down_Blue = "Tripous.ResLib.Icons_Small.Arrow_Left_Down_Blue.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Arrow_Left_Green = "Tripous.ResLib.Icons_Small.Arrow_Left_Green.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Arrow_Left_Up = "Tripous.ResLib.Icons_Small.Arrow_Left_Up.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Arrow_Right = "Tripous.ResLib.Icons_Small.Arrow_Right.bmp";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Arrow_Right_Black = "Tripous.ResLib.Icons_Small.Arrow_Right_Black.gif";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Arrow_Right_Blue = "Tripous.ResLib.Icons_Small.Arrow_Right_Blue.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Arrow_Right_Down_Blue = "Tripous.ResLib.Icons_Small.Arrow_Right_Down_Blue.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Arrow_Right_Green = "Tripous.ResLib.Icons_Small.Arrow_Right_Green.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Arrow_Right_Up_Blue = "Tripous.ResLib.Icons_Small.Arrow_Right_Up_Blue.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Arrow_Up = "Tripous.ResLib.Icons_Small.Arrow_Up.bmp";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Arrow_Up_Black = "Tripous.ResLib.Icons_Small.Arrow_Up_Black.gif";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Arrow_Up_Blue = "Tripous.ResLib.Icons_Small.Arrow_Up_Blue.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Arrow_Up_Green = "Tripous.ResLib.Icons_Small.Arrow_Up_Green.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Binocular_Black = "Tripous.ResLib.Icons_Small.Binocular_Black.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Calendar = "Tripous.ResLib.Icons_Small.Calendar.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Clip = "Tripous.ResLib.Icons_Small.Clip.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Clip_2 = "Tripous.ResLib.Icons_Small.Clip_2.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Close_Red = "Tripous.ResLib.Icons_Small.Close_Red.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Cross = "Tripous.ResLib.Icons_Small.Cross.bmp";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Cross_Green = "Tripous.ResLib.Icons_Small.Cross_Green.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Cross_Red_2 = "Tripous.ResLib.Icons_Small.Cross_Red_2.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Disk_Black = "Tripous.ResLib.Icons_Small.Disk_Black.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Disk_Purple = "Tripous.ResLib.Icons_Small.Disk_Purple.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Email = "Tripous.ResLib.Icons_Small.Email.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Folder = "Tripous.ResLib.Icons_Small.Folder.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Funnel = "Tripous.ResLib.Icons_Small.Funnel.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Gear = "Tripous.ResLib.Icons_Small.Gear.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Home_1 = "Tripous.ResLib.Icons_Small.Home_1.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Home_2 = "Tripous.ResLib.Icons_Small.Home_2.gif";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Lightning = "Tripous.ResLib.Icons_Small.Lightning.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Magnifier = "Tripous.ResLib.Icons_Small.Magnifier.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Minus_Red = "Tripous.ResLib.Icons_Small.Minus_Red.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Minus_Red_2 = "Tripous.ResLib.Icons_Small.Minus_Red_2.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Month_Calendar = "Tripous.ResLib.Icons_Small.Month_Calendar.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Optons = "Tripous.ResLib.Icons_Small.Optons.gif";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Pencil = "Tripous.ResLib.Icons_Small.Pencil.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Pin_Down = "Tripous.ResLib.Icons_Small.Pin_Down.bmp";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Pin_Down_Red = "Tripous.ResLib.Icons_Small.Pin_Down_Red.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Pin_Left = "Tripous.ResLib.Icons_Small.Pin_Left.bmp";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Pin_Left_Down = "Tripous.ResLib.Icons_Small.Pin_Left_Down.bmp";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Pin_Left_Down_Red = "Tripous.ResLib.Icons_Small.Pin_Left_Down_Red.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Rss_Feed = "Tripous.ResLib.Icons_Small.Rss_Feed.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Sticky_Note = "Tripous.ResLib.Icons_Small.Sticky_Note.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Tree_Collapse = "Tripous.ResLib.Icons_Small.Tree_Collapse.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Tree_Collapse_2 = "Tripous.ResLib.Icons_Small.Tree_Collapse_2.gif";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Tree_Expand = "Tripous.ResLib.Icons_Small.Tree_Expand.png";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Tree_Expand_2 = "Tripous.ResLib.Icons_Small.Tree_Expand_2.gif";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Wait_1 = "Tripous.ResLib.Icons_Small.Wait_1.gif";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Wait_2 = "Tripous.ResLib.Icons_Small.Wait_2.gif";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Wait_3 = "Tripous.ResLib.Icons_Small.Wait_3.gif";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Wait_4 = "Tripous.ResLib.Icons_Small.Wait_4.gif";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Wait_5 = "Tripous.ResLib.Icons_Small.Wait_5.gif";
        #endregion

        #region Names Array

        private static readonly Dictionary<string, string> Names = new Dictionary<string, string> {
            {"Application_Blue", "Tripous.ResLib.Icons_Small.Application_Blue.png"},
            {"Application_List_Blue", "Tripous.ResLib.Icons_Small.Application_List_Blue.png"},
            {"Arrow_Down", "Tripous.ResLib.Icons_Small.Arrow_Down.bmp"},
            {"Arrow_Down_2", "Tripous.ResLib.Icons_Small.Arrow_Down_2.bmp"},
            {"Arrow_Down_Black", "Tripous.ResLib.Icons_Small.Arrow_Down_Black.gif"},
            {"Arrow_Down_Blue", "Tripous.ResLib.Icons_Small.Arrow_Down_Blue.png"},
            {"Arrow_Down_Green", "Tripous.ResLib.Icons_Small.Arrow_Down_Green.png"},
            {"Arrow_Left", "Tripous.ResLib.Icons_Small.Arrow_Left.bmp"},
            {"Arrow_Left_Black", "Tripous.ResLib.Icons_Small.Arrow_Left_Black.gif"},
            {"Arrow_Left_Blue", "Tripous.ResLib.Icons_Small.Arrow_Left_Blue.png"},
            {"Arrow_Left_Down_Blue", "Tripous.ResLib.Icons_Small.Arrow_Left_Down_Blue.png"},
            {"Arrow_Left_Green", "Tripous.ResLib.Icons_Small.Arrow_Left_Green.png"},
            {"Arrow_Left_Up", "Tripous.ResLib.Icons_Small.Arrow_Left_Up.png"},
            {"Arrow_Right", "Tripous.ResLib.Icons_Small.Arrow_Right.bmp"},
            {"Arrow_Right_Black", "Tripous.ResLib.Icons_Small.Arrow_Right_Black.gif"},
            {"Arrow_Right_Blue", "Tripous.ResLib.Icons_Small.Arrow_Right_Blue.png"},
            {"Arrow_Right_Down_Blue", "Tripous.ResLib.Icons_Small.Arrow_Right_Down_Blue.png"},
            {"Arrow_Right_Green", "Tripous.ResLib.Icons_Small.Arrow_Right_Green.png"},
            {"Arrow_Right_Up_Blue", "Tripous.ResLib.Icons_Small.Arrow_Right_Up_Blue.png"},
            {"Arrow_Up", "Tripous.ResLib.Icons_Small.Arrow_Up.bmp"},
            {"Arrow_Up_Black", "Tripous.ResLib.Icons_Small.Arrow_Up_Black.gif"},
            {"Arrow_Up_Blue", "Tripous.ResLib.Icons_Small.Arrow_Up_Blue.png"},
            {"Arrow_Up_Green", "Tripous.ResLib.Icons_Small.Arrow_Up_Green.png"},
            {"Binocular_Black", "Tripous.ResLib.Icons_Small.Binocular_Black.png"},
            {"Calendar", "Tripous.ResLib.Icons_Small.Calendar.png"},
            {"Clip", "Tripous.ResLib.Icons_Small.Clip.png"},
            {"Clip_2", "Tripous.ResLib.Icons_Small.Clip_2.png"},
            {"Close_Red", "Tripous.ResLib.Icons_Small.Close_Red.png"},
            {"Cross", "Tripous.ResLib.Icons_Small.Cross.bmp"},
            {"Cross_Green", "Tripous.ResLib.Icons_Small.Cross_Green.png"},
            {"Cross_Red_2", "Tripous.ResLib.Icons_Small.Cross_Red_2.png"},
            {"Disk_Black", "Tripous.ResLib.Icons_Small.Disk_Black.png"},
            {"Disk_Purple", "Tripous.ResLib.Icons_Small.Disk_Purple.png"},
            {"Email", "Tripous.ResLib.Icons_Small.Email.png"},
            {"Folder", "Tripous.ResLib.Icons_Small.Folder.png"},
            {"Funnel", "Tripous.ResLib.Icons_Small.Funnel.png"},
            {"Gear", "Tripous.ResLib.Icons_Small.Gear.png"},
            {"Home_1", "Tripous.ResLib.Icons_Small.Home_1.png"},
            {"Home_2", "Tripous.ResLib.Icons_Small.Home_2.gif"},
            {"Lightning", "Tripous.ResLib.Icons_Small.Lightning.png"},
            {"Magnifier", "Tripous.ResLib.Icons_Small.Magnifier.png"},
            {"Minus_Red", "Tripous.ResLib.Icons_Small.Minus_Red.png"},
            {"Minus_Red_2", "Tripous.ResLib.Icons_Small.Minus_Red_2.png"},
            {"Month_Calendar", "Tripous.ResLib.Icons_Small.Month_Calendar.png"},
            {"Optons", "Tripous.ResLib.Icons_Small.Optons.gif"},
            {"Pencil", "Tripous.ResLib.Icons_Small.Pencil.png"},
            {"Pin_Down", "Tripous.ResLib.Icons_Small.Pin_Down.bmp"},
            {"Pin_Down_Red", "Tripous.ResLib.Icons_Small.Pin_Down_Red.png"},
            {"Pin_Left", "Tripous.ResLib.Icons_Small.Pin_Left.bmp"},
            {"Pin_Left_Down", "Tripous.ResLib.Icons_Small.Pin_Left_Down.bmp"},
            {"Pin_Left_Down_Red", "Tripous.ResLib.Icons_Small.Pin_Left_Down_Red.png"},
            {"Rss_Feed", "Tripous.ResLib.Icons_Small.Rss_Feed.png"},
            {"Sticky_Note", "Tripous.ResLib.Icons_Small.Sticky_Note.png"},
            {"Tree_Collapse", "Tripous.ResLib.Icons_Small.Tree_Collapse.png"},
            {"Tree_Collapse_2", "Tripous.ResLib.Icons_Small.Tree_Collapse_2.gif"},
            {"Tree_Expand", "Tripous.ResLib.Icons_Small.Tree_Expand.png"},
            {"Tree_Expand_2", "Tripous.ResLib.Icons_Small.Tree_Expand_2.gif"},
            {"Wait_1", "Tripous.ResLib.Icons_Small.Wait_1.gif"},
            {"Wait_2", "Tripous.ResLib.Icons_Small.Wait_2.gif"},
            {"Wait_3", "Tripous.ResLib.Icons_Small.Wait_3.gif"},
            {"Wait_4", "Tripous.ResLib.Icons_Small.Wait_4.gif"},
            {"Wait_5", "Tripous.ResLib.Icons_Small.Wait_5.gif"},
            };

        #endregion


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

    }
}
