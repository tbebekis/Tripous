using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

using Microsoft.AspNetCore.Authentication;

namespace Tripous.Web.Authentication.Digest
{
    /// <summary>
    /// Authentication events
    /// </summary>
    public class DigestAuthenticationEvents
    {
        /* public */
        /// <summary>
        /// Calls the <see cref="OnAuthenticationFailed"/> delegate if any, else does nothing.
        /// </summary>
        public virtual Task AuthenticationFailed(DigestAuthenticationContext context)
        {
            return OnAuthenticationFailed != null ? OnAuthenticationFailed(context) : Task.CompletedTask;
        }
        /// <summary>
        /// Calls the <see cref="OnHandleClaims"/> if any, else provides a default handling.
        /// The default handling appends claims to the newly created and authenticated <see cref="ClaimsIdentity"/> 
        /// and defines an <see cref="AuthenticationProperties"/> to the passed in context.
        /// </summary>
        public virtual Task HandleClaims(DigestAuthenticationContext context)
        {
            if (OnHandleClaims != null)
            {
                return OnHandleClaims(context);
            }

            // append claims
            ClaimsIdentity Identity = context.Principal.Identity as ClaimsIdentity;

            if (Identity.FindFirst(ClaimTypes.NameIdentifier) == null)
                Identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, context.Username, ClaimValueTypes.String, context.Options.ClaimsIssuer));

            if (Identity.FindFirst(ClaimTypes.Name) == null)
                Identity.AddClaim(new Claim(ClaimTypes.Name, context.Username, ClaimValueTypes.String, context.Options.ClaimsIssuer));

            // context authentication properties
            if (context.Properties == null)
            {
                context.Properties = new AuthenticationProperties()
                {
                    IssuedUtc = DateTimeOffset.UtcNow
                };
            }

            return Task.CompletedTask;
        }

        /* properties */
        /// <summary>
        /// A delegate to be invoked when the authentication fails because an exception is thrown
        /// </summary>
        public Func<DigestAuthenticationContext, Task> OnAuthenticationFailed { get; set; }
        /// <summary>
        /// A delegate to be invoked after a succesful authentication  
        /// in order to append claims to the newly created and authenticated <see cref="ClaimsIdentity"/> 
        /// and define an <see cref="AuthenticationProperties"/> to the passed in context.
        /// <para>NOTE: If null then a default implementation is provided.</para>
        /// </summary>
        public Func<DigestAuthenticationContext, Task> OnHandleClaims { get; set; }
    }
}
