using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Data;

using Newtonsoft.Json;

using Tripous.Data;


namespace Tripous.Web
{

    /// <summary>
    /// Language information.  Represents a language this application supports, i.e. provides localized resources for.
    /// </summary>
    public class LanguageItem
    {
 

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public LanguageItem()
        {
        }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="Id">The id, if any, else null or empty string</param>
        /// <param name="Name">The language name</param>
        /// <param name="Code">The two letter code of the language, e.g en, el, it, fr, etc.</param>
        /// <param name="CultureCode">The culture code associated to this language, e.g.  e.g en-US, el-GR, etc.</param>
        /// <param name="FlagImage">The image file name, i.e. flag_greece.png</param>
        public LanguageItem(string Id, string Name, string Code, string CultureCode, string FlagImage = "")
        {
            this.Id = Id;
            this.Name = Name;
            this.Code = Code;
            this.CultureCode = CultureCode;            
            this.FlagImage = FlagImage;
        }
        /// <summary>
        /// Constructor. The specified <see cref="DataRow"/> must have the schema of the <see cref="SysTables.Lang"/> table.
        /// </summary>
        public LanguageItem(DataRow Row)
            : this(Row.AsString("Id"),
                  Row.AsString("Name"),
                  Row.AsString("SeoCode"),
                  Row.AsString("CultureCode"),
                  Row.AsString("FlagImage"))
        {
        }


        /* public */
        /// <summary>
        /// Returns a string representation of this instance
        /// </summary>
        public override string ToString()
        {
            return $"{CultureCode} - {Name}";
        }
 
        /* properties */
        /// <summary>
        /// The id, if any, else null or empty string
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The language name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The two letter code of the language, e.g en, el, it, fr, etc.
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// The culture code associated to this language, e.g.  e.g en-US, el-GR, etc.
        /// </summary>
        public string CultureCode { get; set; }
        /// <summary>
        /// The image file name, i.e. flag_greece.png
        /// </summary>
        public string FlagImage { get; set; }

        /// <summary>
        /// The <see cref="CultureInfo"/> instance associated to this language
        /// </summary>
        [JsonIgnore]
        public CultureInfo Culture { get { return new CultureInfo(CultureCode); } }

 
    }
}
