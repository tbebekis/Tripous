using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

using Microsoft.AspNetCore.Authentication;

namespace Tripous.Web.Authentication.Basic
{
    /// <summary>
    /// Helper
    /// </summary>
    static public class BasicAuthentication
    {
        /// <summary>
        /// The default authentication scheme.
        /// </summary>
        public const string DefaultAuthenticationScheme = "Basic";

        /* AuthenticationBuilder extension methods */
        /// <summary>
        /// Adds basic authentication
        /// </summary>
        static public AuthenticationBuilder AddBasic(this AuthenticationBuilder builder)
        {
            return builder.AddBasic(BasicAuthentication.DefaultAuthenticationScheme);
        }
        /// <summary>
        /// Adds basic authentication
        /// </summary>
        static public AuthenticationBuilder AddBasic(this AuthenticationBuilder builder, string authenticationScheme)
        {
            return builder.AddBasic(authenticationScheme, configureOptions: null);
        }
        /// <summary>
        /// Adds basic authentication
        /// </summary>
        static public AuthenticationBuilder AddBasic(this AuthenticationBuilder builder, Action<BasicAuthenticationOptions> configureOptions)
        {
            return builder.AddBasic(BasicAuthentication.DefaultAuthenticationScheme, configureOptions);
        }
        /// <summary>
        /// Adds basic authentication
        /// </summary>
        static public AuthenticationBuilder AddBasic(this AuthenticationBuilder builder, string authenticationScheme, Action<BasicAuthenticationOptions> configureOptions)
        {
            return builder.AddScheme<BasicAuthenticationOptions, BasicAuthenticationHandler>(authenticationScheme, configureOptions);
        }
    }
}
