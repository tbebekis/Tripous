using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

using Microsoft.AspNetCore.Authentication;

namespace Tripous.Web.Authentication.Digest
{
    /// <summary>
    /// Helper
    /// </summary>
    public static class DigestAuthentication
    {
        /// <summary>
        /// The default authentication scheme.
        /// </summary>
        public const string DefaultAuthenticationScheme = "Digest";
 
        /* AuthenticationBuilder extension methods */
        /// <summary>
        /// Adds authentication scheme
        /// </summary>
        static public AuthenticationBuilder AddDigest(this AuthenticationBuilder builder)
        {
            return builder.AddDigest(DigestAuthentication.DefaultAuthenticationScheme);
        }
        /// <summary>
        /// Adds authentication scheme
        /// </summary>
        static public AuthenticationBuilder AddDigest(this AuthenticationBuilder builder, string authenticationScheme)
        {
            return builder.AddDigest(authenticationScheme, configureOptions: null);
        }
        /// <summary>
        /// Adds authentication scheme
        /// </summary>
        static public AuthenticationBuilder AddDigest(this AuthenticationBuilder builder, Action<DigestAuthenticationOptions> configureOptions)
        {
            return builder.AddDigest(DigestAuthentication.DefaultAuthenticationScheme, configureOptions);
        }
        /// <summary>
        /// Adds authentication scheme
        /// </summary>
        static public AuthenticationBuilder AddDigest(this AuthenticationBuilder builder, string authenticationScheme, Action<DigestAuthenticationOptions> configureOptions)
        {
            return builder.AddScheme<DigestAuthenticationOptions, DigestAuthenticationHandler>(authenticationScheme, configureOptions);
        }
    }
}
