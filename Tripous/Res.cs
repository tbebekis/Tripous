﻿/*--------------------------------------------------------------------------------------        
                           Copyright © 2018 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Collections;
using System.Resources;
using System.Globalization;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Data;
using System.Xml;



namespace Tripous
{






    /// <summary>
    /// Provides access to the resources of any ResourceManager registered by calling the Add method.
    /// </summary>
    static public class Res
    {


        /// <summary>
        /// Field
        /// </summary>
        static private List<IResourceProvider> list = new List<IResourceProvider>();



        /* static constructor */
        /// <summary>
        /// Static constructor.
        /// </summary>
        static Res()
        {
        }


        /* public */
        /// <summary>
        /// Adds Provider to the internal resource providers list.
        /// </summary>
        static public void Add(IResourceProvider Provider)
        {
            if (!list.Contains(Provider) && !string.IsNullOrWhiteSpace(Provider.Name))
            {
                if (list.FirstOrDefault(item => item.Name.IsSameText(Provider.Name)) == null)
                    list.Insert(0, Provider);
            }
        }
        /// <summary>
        /// Creaetes a resource provider based on the specified arguments and
        /// adds that provider to the internal provider list.
        /// </summary>
        static public void Add(ResourceManager Manager, string Name)
        {
            if ((Manager != null) && !string.IsNullOrWhiteSpace(Name))
            {
                Add(new ResourceProvider(Manager, Name));
            }
        }


        /* strings */
        /// <summary>
        /// Returns a resource string for the Key, if any, else Default.
        /// </summary>
        static public string GetString(string Key, string Default)
        {
            string Result;

            foreach (IResourceProvider rd in list)
            {
                Result = rd.GetString(Key);
                if (Result != null)
                    return Result;
            }

            //return Tripous.Data.StrRes.GetString(Key, Default);
            return Default;
        }
        /// <summary>
        /// Returns a resource string for the Key, if any, else Default.
        /// </summary>
        static public string GS(string Key, string Default)
        {
            return GetString(Key, Default);
        }
        /// <summary>
        /// Returns a resource string for the Key, if any, else string.Empty.
        /// </summary>
        static public string GS(string Key)
        {
            return GetString(Key, string.Empty);
        }
        /// <summary>
        /// Returns a resource string for the Key, if any, else Key as Default.
        /// </summary>
        static public string GS2(string Key)
        {
            return GetString(Key, Key);
        }



        /* non-strings */
        /// <summary>
        /// Returns a resource object for the Key, if any, else null.
        /// </summary>
        static public object GetObject(string Key)
        {
            object Result;
            foreach (ResourceProvider rd in list)
            {
                Result = rd.GetObject(Key);
                if (Result != null)
                    return Result;
            }

            return null;
        }
        /// <summary>
        /// Returns a binary resource for the Key, if any, else null.
        /// </summary>
        static public byte[] GetBinary(string Key)
        {
            byte[] Data;
            foreach (ResourceProvider rd in list)
            {
                Data = rd.GetBinary(Key);
                if (Data != null)
                    return Data;
            }

            return null;
        }
        /// <summary>
        /// Returns a resource Image for the Key, if any, else null.
        /// </summary>
        static public Image GetImage(string Key)
        {
            Image Data;
            foreach (ResourceProvider rd in list)
            {
                Data = rd.GetImage(Key);
                if (Data != null)
                    return Data;
            }

            return null;
        }
        /// <summary>
        /// Returns a resource Bitmap for the Key, if any, else null.
        /// </summary>
        static public Bitmap GetBitmap(string Key)
        {
            return GetImage(Key) as Bitmap;
        }
        /// <summary>
        /// Converts an xml file created using DataTable.WriteXml() and saved as a resource under Key, 
        /// back to a DataTable again.
        /// </summary>
        static public DataTable GetDataTable(string Key)
        {
            DataTable Table = new DataTable("");

            string XmlText = GetObject(Key) as string;

            if (!string.IsNullOrEmpty(XmlText))
            {
                XmlDocument Doc = new XmlDocument();
                Doc.LoadXml(XmlText);        

                using (MemoryStream MS = new MemoryStream())
                {
                    Doc.Save(MS);
                    MS.Position = 0;

                    Table.ReadXml(MS);
                    Table.AcceptChanges();
                }
            }

            return Table;

        }


        /* miscs */
        /// <summary>
        /// Saves data designated by Key to FileName
        /// </summary>
        static public bool SaveToFile(string Key, string FileName)
        {

            if (!File.Exists(FileName))
            {
                object ResData = GetObject(Key);
                if (ResData != null)
                {
                    if (ResData.GetType() == typeof(System.String))
                    {
                        using (StreamWriter SW = new StreamWriter(FileName))
                        {
                            SW.Write(ResData);
                        }
                    }
                    else if (ResData.GetType() == typeof(byte[]))
                    {
                        byte[] Bytes = (byte[])ResData;

                        using (FileStream stream = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.Read))
                        {
                            stream.Write(Bytes, 0, Bytes.Length);
                        }
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        if (!File.Exists(FileName))
                            Thread.Sleep(500);
                        else
                            break;
                    }

                }


            }

            return File.Exists(FileName);

        }

        /* url data */
        /// <summary>
        /// Returns the image url data of the image specified by ResKey 
        /// </summary>
        static public string UrlData(string ResKey)
        {
            // <%@ Import Namespace="Tripous"  %>
            // <%@ Import Namespace="BmtCell.Lib"  %>/ 
            // <Image Url="<%$ Code: App.UrlData(Icons32.Table_Sheet) %>"> </Image>
            System.Drawing.Image icon = Res.GetImage(ResKey);
            return UrlData(icon);
        }
        /// <summary>
        /// Returns the image url data of the image specified by icon 
        /// </summary>
        static public string UrlData(System.Drawing.Image icon)
        {
            if (icon != null)
            {

                string Mime = icon.Mime();
                //icon = icon.Resize(24, 24);
                string S = "data:{0};base64,{1}";
                S = string.Format(S, Mime, Sys.ImageToBase64(icon));
                return S;
            }
            return string.Empty;
        }

    }

}
