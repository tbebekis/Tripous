using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication;
 

namespace Tripous.Web.Authentication.Basic
{

    /// <summary>
    /// Context for basic authentication events
    /// </summary>
    public class BasicAuthenticationContext : ResultContext<BasicAuthenticationOptions>
    {
        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">The HttpContext the validate context applies too.</param>
        /// <param name="scheme">The scheme used when the authentication handler was registered.</param>
        /// <param name="options">The <see cref="BasicAuthenticationOptions"/> for the <see cref="BasicAuthenticationHandler"/> handler which uses this class.</param>
        public BasicAuthenticationContext(HttpContext context, AuthenticationScheme scheme, BasicAuthenticationOptions options)
            : base(context, scheme, options)
        {
        }



        /* properties */
        /// <summary>
        /// The user name to validate.
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// The password to validate.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Used when an exception is thrown
        /// </summary>
        public Exception Exception { get; set; }
    }
}
