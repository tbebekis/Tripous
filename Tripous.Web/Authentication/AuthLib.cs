using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using System.Security.Claims;


using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication;

namespace Tripous.Web.Authentication
{
    /// <summary>
    /// Helper. Represents this library.
    /// </summary>
    static public class AuthLib
    {
        /// <summary>
        /// Constant
        /// </summary>
        public const string SLetters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        /// <summary>
        /// Constant
        /// </summary>
        public const string SDigits = "0123456789";
        /// <summary>
        /// Constant
        /// </summary>
        public const string SPunctuation = @"!@#$%^*()_-+=[{]};:>|./?"; // exclude & and < 
        /// <summary>
        /// Constant
        /// </summary>
        public const string SPasswordCharSet = SLetters + SDigits + SPunctuation;

        /// <summary>
        /// Constant
        /// </summary>
        public const string SNoRealm = "Realm is not defined for an Authentication Scheme: {0}";
        /// <summary>
        /// Constant
        /// </summary>
        public const string SNoAuthorizationHeader = "HTTP Authorization header is missing.";
        /// <summary>
        /// Constant
        /// </summary>
        public const string SInvalidAuthorizationType = "Invalid Authorization Scheme. Expected: {0}, Found: {1}.";
        /// <summary>
        /// Constant
        /// </summary>
        public const string SRequiredAuthorizationHeaderField = "A required HTTP Authorization header is missing.";
        /// <summary>
        /// Constant
        /// </summary>
        public const string SInvalidAuthenticationAttempt = "Invalid Authentication attempt.";
        /// <summary>
        /// Constant
        /// </summary>
        public const string SAuthenticationExpired = "Authentication is expired. Please login again.";
        /// <summary>
        /// Constant
        /// </summary>
        public const string SInvalidCredentials = "Invalid credentials.";
        /// <summary>
        /// Constant
        /// </summary>
        public const string SNoSecureProtocol = "Invalid HTTP Protocol. Expected: HTTPS, Found: HTTP.";
        /// <summary>
        /// Constant
        /// </summary>
        public const string SNoCredentials = "No credentials";

        /// <summary>
        /// Creates an authenticated <see cref="ClaimsIdentity"/> identity and the <see cref="ClaimsPrincipal"/> principal and assigns the context's Principal property.
        /// <para>No claims are added to the identity.</para>
        /// <para>Returns the newly created identity for the client code to add any needed claims to it.</para>
        /// <para>NOTE: It calls ResultContext.Success too, so after this call, the context is a ResultContext.Result.Succeeded one. </para>
        /// </summary>
        static public ClaimsIdentity CreateAuthenticatedIdentity<TOptions>(this ResultContext<TOptions> context) where TOptions : AuthenticationSchemeOptions
        {
            // NOTE: setting the second parameter actually authenticates the identity (IsAuthenticated returns true)
            ClaimsIdentity Identity = new ClaimsIdentity(new Claim[] { }, context.Scheme.Name);
            context.Principal = new ClaimsPrincipal(Identity);
            context.Success();
            return Identity;
        }
    }
}
