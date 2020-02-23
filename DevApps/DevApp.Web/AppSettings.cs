using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Tripous;
using Tripous.Web;

namespace DevApp.Web
{
    /// <summary>
    /// Application settings, coming from appsettings.json
    /// </summary>
    public class AppSettings
    {
 
        /// <summary>
        /// HSTS settings
        /// <para>SEE: https://en.wikipedia.org/wiki/HTTP_Strict_Transport_Security </para>
        /// </summary>
        public HSTSSettings HSTS { get; set; } = new HSTSSettings();

    }

}
