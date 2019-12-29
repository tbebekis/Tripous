/*--------------------------------------------------------------------------------------        
                           Copyright © 2014 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Text;
 

namespace Tripous
{
    /// <summary>
    /// Represents a code page
    /// </summary>
    public class CodePage
    {
        static List<CodePage> List;

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public CodePage(EncodingInfo Info)
        {
            this.Info = Info;
        }

        /* static */
        /// <summary>
        /// Returns the full list of code pages
        /// </summary>
        static public CodePage[] GetAll()
        {
            if (List == null)
            {
                List = new List<CodePage>();

                EncodingInfo[] Infos = Encoding.GetEncodings();
                foreach (var Item in Infos)
                    List.Add(new CodePage(Item));
            }

            return List.ToArray();
        }

        /* overrides */
        /// <summary>
        /// Returns a string representation of this instance
        /// suitable for combo boxes, etc.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0,-24}  {1}", Info.Name, Info.DisplayName);
        }

        /* properties */
        /// <summary>
        /// The EncodingInfo this CodePage instance represents
        /// </summary>
        public EncodingInfo Info { get; private set; }
    }
}