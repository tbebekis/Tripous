using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

using Microsoft.AspNetCore.Authentication;

namespace Tripous.Web.Authentication.Basic
{
    /// <summary>
    /// Authentication events
    /// </summary>
    public class BasicAuthenticationEvents
    {
        /* public */
        /// <summary>
        /// Calls the <see cref="OnAuthenticationFailed"/> delegate if any, else does nothing.
        /// </summary>
        public virtual Task AuthenticationFailed(BasicAuthenticationContext context)
        {
            return OnAuthenticationFailed != null? OnAuthenticationFailed(context): Task.CompletedTask;
        }
        /// <summary>
        /// Calls the <see cref="OnValidateCredentials"/> delegate if any, else throws an exception.
        /// <para>The user has to provide a handler function here.
        /// The provided function validates user credentials and in case of success it constructs a <see cref="ClaimsPrincipal"/> instance,
        /// attaches the principal to <see cref="BasicAuthenticationContext"/>.Principal and calls <see cref="BasicAuthenticationContext"/>.Success .</para>
        /// <para>WARNING: if no handler is provided an exception is thrown.</para>
        /// </summary>
        public virtual Task ValidateCredentials(BasicAuthenticationContext context)
        {
            if (OnValidateCredentials != null)
            {
                return OnValidateCredentials(context);
            }
                

            throw new ApplicationException("Can not validate basic authentication credentials. No handler function is provided.");            
        }
        /// <summary>
        /// Calls the <see cref="OnHandleClaims"/> if any, else provides a default handling.
        /// The default handling appends claims to the newly created and authenticated <see cref="ClaimsIdentity"/> 
        /// and defines an <see cref="AuthenticationProperties"/> to the passed in context.
        /// </summary>
        public virtual Task HandleClaims(BasicAuthenticationContext context)
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
        public Func<BasicAuthenticationContext, Task> OnAuthenticationFailed { get; set; }
        /// <summary>
        /// A delegate to be invoked when the credentials need validation.
        /// <para>The user has to provide a handler function here.
        /// The provided function validates user credentials and in case of success it constructs a <see cref="ClaimsPrincipal"/> instance,
        /// attaches the principal to <see cref="BasicAuthenticationContext"/>.Principal and calls <see cref="BasicAuthenticationContext"/>.Success .</para>
        /// <para>WARNING: if no handler is provided an exception is thrown.</para>
        /// </summary>
        public Func<BasicAuthenticationContext, Task> OnValidateCredentials { get; set; }
        /// <summary>
        /// A delegate to be invoked after a succesful call to <see cref="OnValidateCredentials"/> 
        /// in order to append claims to the newly created and authenticated <see cref="ClaimsIdentity"/> 
        /// and define an <see cref="AuthenticationProperties"/> to the passed in context.
        /// <para>NOTE: If null then a default implementation is provided.</para>
        /// </summary>
        public Func<BasicAuthenticationContext, Task> OnHandleClaims { get; set; }



    }
}
