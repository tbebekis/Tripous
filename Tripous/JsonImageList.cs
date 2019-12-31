/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

 

namespace Tripous
{
    /// <summary>
    /// A list of images for json serialization
    /// </summary>
    public class JsonImageList
    {
        JObject list;

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public JsonImageList()
        {
            list = new JObject();
        }

        /* static */
        /// <summary>
        /// Creates and returns a JObject containing and "Image", that is and image where Width may not equals to Height
        /// <para>ENTRY FORMAT: {"Mime": "image/png", "Width": 200, "Height": 100, "Data": [Data Url here ] }</para>
        /// </summary>
        static public JObject CreateImage(string Name, Image Image)
        {
            JObject JO = new JObject();
            dynamic jImage = JO;

            jImage.Mime = ImageUtls.MimeOf(Image);
            jImage.Width = Image.Width;
            jImage.Height = Image.Height;
            jImage.Data = Sys.ImageToBase64(Image, false);

            return JO;
        }
        /// <summary>
        /// Creates and returns a JObject containing and "Ico", that is an image where Width equals to Height
        /// <para>ENTRY FORMAT: {"Mime": "image/png", "Size": 32, "Data": [Data Url here ] }</para>
        /// </summary>
        static public JObject CreateIcon(string Name, Image Ico)
        {
            JObject JO = new JObject();
            dynamic jIco = JO;

            jIco.Mime = ImageUtls.MimeOf(Ico);
            jIco.Size = Ico.Width;
            jIco.Data = Sys.ImageToBase64(Ico, false);

            return JO;
        }


        /* public */
        /// <summary>
        /// JO must contain an image 
        /// <para>ENTRY FORMAT for general image: {"Mime": "image/png", "Width": 200, "Height": 100, "Data": [Data Url here ] }</para>
        /// <para>ENTRY FORMAT for icon: {"Mime": "image/png", "Size": 32, "Data": [Data Url here ] }</para>
        /// </summary>
        public void Add(string Name, JObject JO)
        {
            list[Name] = JO;
        }
        /// <summary>
        /// Adds and "Image" (that is and image where Width may not equals to Height) to the list under Name
        /// <para>ENTRY FORMAT: {"Mime": "image/png", "Width": 200, "Height": 100, "Data": [Data Url here ] }</para>
        /// </summary>
        public void AddImage(string Name, Image Image)
        {
            list[Name] = CreateImage(Name, Image);
        }
        /// <summary>
        /// Adds an "Ico" (that is an image where Width equals to Height) to the list under Name
        /// <para>ENTRY FORMAT:{"Mime": "image/png", "Size": 32, "Data": [Data Url here ] }</para>
        /// </summary>
        public void AddIcon(string Name, Image Ico)
        {
            list[Name] = CreateIcon(Name, Ico);
        }




        /// <summary>
        /// Returns the json text
        /// </summary>
        public string ToJson()
        {
            return list.ToString();
        }
    }
}
