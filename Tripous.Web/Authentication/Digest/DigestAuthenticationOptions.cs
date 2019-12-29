using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Tripous.Web.Authentication.Digest
{

    /// <summary>
    /// Authentication options
    /// </summary>
    public class DigestAuthenticationOptions : AuthenticationSchemeOptions
    {
        /* private */
        string fRealm;

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public DigestAuthenticationOptions()
        {
        }

        /* properties */
        /// <summary>
        /// Gets or sets the realm sent in the WWW-Authenticate response header.
        /// <para>SEE: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/WWW-Authenticate </para>
        /// <para>The realm, which is a string, defines a protected space which requires authentication upon entrance. 
        /// A realm may cover all pages in a web application or just a group of pages. 
        /// The browser displays a dialog box requiring credentials for a particular realm.</para>
        /// <para>Here is how the specification defines realm. See: https://tools.ietf.org/html/rfc2617#page-3 </para>
        /// <para>
        /// The realm directive (case-insensitive) is required for all
        /// authentication schemes that issue a challenge.The realm value
        /// (case-sensitive), in combination with the canonical root URL(the
        /// absoluteURI for the server whose abs_path is empty; see section 5.1.2
        /// of[2]) of the server being accessed, defines the protection space.
        /// These realms allow the protected resources on a server to be
        /// partitioned into a set of protection spaces, each with its own
        /// authentication scheme and/or authorization database.The realm value
        /// is a string, generally assigned by the origin server, which may have
        /// additional semantics specific to the authentication scheme.Note that
        /// there may be multiple challenges with the same auth-scheme but different realms.
        /// </para>
        /// </summary>
        public string Realm
        {
            get { return fRealm; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && !value.All(c => c >= 32 && c <= 127))
                {
                    throw new ArgumentException("Realm must be an ASCII 127 string");
                }

                fRealm = value;
            }
        }
        /// <summary>
        /// This implementation requires HTTPS requests. When this property is set to false then it allows basic authentication on HTTP requests too. 
        /// <para>CAUTION: Basic authentication is insecure since it transmits passwords in cleartext. Use it with HTTPS only.</para>
        /// </summary>
        public bool RequireHTTPS { get; set; } = true;
        /// <summary>
        /// A secret string used in generating the nonce. Must be as good as a very strong password. 
        /// <para>NOTE: If empty then the handler generates a really strong password</para>
        /// </summary>
        public string NonceSecret { get; set; }
        /// <summary>
        /// Timeout in minutes for the nonce to live. 
        /// After that period the nonce expires and re-authentication is required.
        /// Zero value means nonce never expires.
        /// <para>NOTE: When the nonce expires, re-authentication is required.</para>
        /// </summary>
        public int NonceTimeoutMinutes { get; set; } = 2 * 60; 
    }
}
