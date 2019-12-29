using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication;

namespace Tripous.Web.Authentication.Digest
{
 

    /// <summary>
    /// Context for digest authentication events
    /// </summary>
    public class DigestAuthenticationContext : ResultContext<DigestAuthenticationOptions>
    {
        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">The HttpContext the validate context applies too.</param>
        /// <param name="scheme">The scheme used when the authentication handler was registered.</param>
        /// <param name="options">The <see cref="DigestAuthenticationOptions"/> for the <see cref="DigestAuthenticationHandler"/> handler which uses this class.</param>
        public DigestAuthenticationContext(HttpContext context, AuthenticationScheme scheme, DigestAuthenticationOptions options)
            : base(context, scheme, options)
        {
        }

        /* properties */
        /// <summary>
        /// The user name to validate.
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Used when an exception is thrown
        /// </summary>
        public Exception Exception { get; set; }
    }
}
