using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Tripous
{
    /// <summary>
    /// Helper for splitting a url into KP-LF segments, i.e. clients - sub-site - library - filename
    /// </summary>
    public class UrlSplitter
    {

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public UrlSplitter(string Url)
        {
            this.Uri = new Uri(Url);

            if (Uri.Segments.Length > 3)
            {
                FileName = Uri.Segments[Uri.Segments.Length - 1];
                Library = Uri.Segments[Uri.Segments.Length - 2].TrimEnd('/', ' ');
                Web = Uri.Segments[Uri.Segments.Length - 3].TrimEnd('/', ' ');
                RootWeb = Uri.Segments[Uri.Segments.Length - 4].TrimEnd('/', ' ');


                FileName = Uri.UnescapeDataString(FileName);
                string Ext = Path.GetExtension(FileName); // extension contains the leading period too "."
                FileName = Path.GetFileNameWithoutExtension(FileName);

                // for file names like KPARTNERS-1695187220-1 (1).docx
                if (FileName.Contains("(") && FileName.EndsWith(")"))
                {
                    int IndexA = FileName.IndexOf('(');

                    FileName = FileName.Substring(0, IndexA);
                    FileName = FileName.Trim();
                }

                if (!string.IsNullOrWhiteSpace(Ext))
                {
                    FileName = FileName + Ext;
                }

            }
        }

        /* properties */
        /// <summary>
        /// The url as Uri
        /// </summary>
        public Uri Uri { get; private set; }
        /// <summary>
        /// RootWeb, e.g. clients
        /// </summary>
        public string RootWeb { get; private set; }
        /// <summary>
        /// Web or sub-site, e.g. C03310
        /// </summary>
        public string Web { get; private set; }
        /// <summary>
        /// Library, e.g. Drafts or Documents
        /// </summary>
        public string Library { get; private set; }
        /// <summary>
        /// File name, e.g. KPARTNERS-1695187220-1.docx
        /// </summary>
        public string FileName { get; private set; }

    }
}
