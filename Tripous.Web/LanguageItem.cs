using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Tripous.Web
{

    /// <summary>
    /// Language information.  Represents a language this application supports, i.e. provides localized resources for.
    /// </summary>
    public class LanguageItem
    {
        /* construction */
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="Id">The id, if any, else null or empty string</param>
        /// <param name="Name">The language name</param>
        /// <param name="Code">The two letter code of the language, e.g en, el, it, fr, etc.</param>
        /// <param name="CultureCode">The culture code associated to this language, e.g.  e.g en-US, el-GR, etc.</param>
        public LanguageItem(string Id, string Name, string Code, string CultureCode)
        {
            this.Id = Id;
            this.Name = Name;
            this.Code = Code;
            this.CultureCode = CultureCode;
            this.Culture = new CultureInfo(CultureCode);
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
        public string Id { get; private set; }
        /// <summary>
        /// The language name
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// The two letter code of the language, e.g en, el, it, fr, etc.
        /// </summary>
        public string Code { get; private set; }
        /// <summary>
        /// The culture code associated to this language, e.g.  e.g en-US, el-GR, etc.
        /// </summary>
        public string CultureCode { get; private set; }
        /// <summary>
        /// The <see cref="CultureInfo"/> instance associated to this language
        /// </summary>
        public CultureInfo Culture { get; private set; }
    }
}
