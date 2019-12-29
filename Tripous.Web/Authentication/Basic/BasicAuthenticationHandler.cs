using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System.Text;
using System.Net.Http.Headers;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using Microsoft.Extensions.Primitives;


namespace Tripous.Web.Authentication.Basic
{
    /// <summary>
    /// Authentication handler for the basic authentication scheme.
    /// <para>Created per request to handle authentication.</para>
    /// </summary>
    public class BasicAuthenticationHandler : AuthenticationHandler<BasicAuthenticationOptions>
    {
        
        const string SNoCredentialsDelimiter = "Invalid credentials, missing delimiter.";
        const string SCanNotDecodeCredentials = "Can not decode credentials. An exception is thrown with message: {0}";

        /* overrides */
        /// <summary>
        /// Handles the authentication.
        /// <para>
        /// Basic authentication logic is implemented in this method by verifying the username and password received in the HTTP Authorization header.
        /// Verification is done by calling <see cref="BasicAuthenticationEvents.ValidateCredentials(BasicAuthenticationContext)"/> . 
        /// On successful authentication the method returns <see cref="AuthenticateResult.Success(AuthenticationTicket)"/> 
        /// which makes the request authenticated and sets the <see cref="HttpContext.User"/> to the currently logged in user.
        /// </para>
        /// </summary>
        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            BasicAuthenticationContext HandlerContext = null;
            string Credentials = null;
            string Username = null;
            string Password = null;
            StringValues Values;   
 
            try
            {
                // ●  get the authorization header
                if (!Request.Headers.TryGetValue(HeaderNames.Authorization, out Values))
                {
                    return AuthenticateResult.Fail(AuthLib.SNoAuthorizationHeader);
                }

                // ●  check for the right authentication scheme
                AuthenticationHeaderValue HeaderValue = AuthenticationHeaderValue.Parse(Values);
                if (string.Compare(BasicAuthentication.DefaultAuthenticationScheme, HeaderValue.Scheme, StringComparison.OrdinalIgnoreCase) != 0)
                {
                    return AuthenticateResult.Fail(string.Format(AuthLib.SInvalidAuthorizationType, BasicAuthentication.DefaultAuthenticationScheme, HeaderValue.Scheme));
                }

                // ●  process authorization header - get Base64 encoded credentials
                if (string.IsNullOrWhiteSpace(HeaderValue.Parameter))
                {
                    Logger.LogInformation(AuthLib.SNoCredentials);
                    return AuthenticateResult.Fail(AuthLib.SNoCredentials);
                }

                Credentials = HeaderValue.Parameter.Trim();

                // ●  decode credentials
                try
                {
                    Credentials = Encoding.UTF8.GetString(Convert.FromBase64String(Credentials));
                }
                catch (Exception ex)
                {
                    return AuthenticateResult.Fail(string.Format(SCanNotDecodeCredentials, ex.Message));
                }

                int Index = Credentials.IndexOf(':');
                if (Index == -1)
                {                    
                    Logger.LogInformation(SNoCredentialsDelimiter);
                    return AuthenticateResult.Fail(SNoCredentialsDelimiter);
                }

                Username = Credentials.Substring(0, Index);
                Password = Credentials.Substring(Index + 1);
 
                HandlerContext = new BasicAuthenticationContext(Context, Scheme, Options)
                {
                    Username = Username,
                    Password = Password
                };

                // ●  validate credentials, 
                await Events.ValidateCredentials(HandlerContext);

                // ●  returns the authentication result
                if (HandlerContext.Result != null && HandlerContext.Result.Succeeded && HandlerContext.Principal != null)
                {
                    await Events.HandleClaims(HandlerContext);

                    AuthenticationTicket ticket = new AuthenticationTicket(HandlerContext.Principal, HandlerContext.Properties, Scheme.Name);
                    return AuthenticateResult.Success(ticket);
                }

                if (HandlerContext.Result != null && HandlerContext.Result.Failure != null)
                {
                    return AuthenticateResult.Fail(HandlerContext.Result.Failure);
                }

                return AuthenticateResult.NoResult();
            }
            catch (Exception ex)
            {
                HandlerContext = HandlerContext ?? new BasicAuthenticationContext(Context, Scheme, Options)
                {
                    Username = Username,
                };
                
                HandlerContext.Exception = ex;                

                await Events.AuthenticationFailed(HandlerContext);

                if (HandlerContext.Result != null)
                {
                    return HandlerContext.Result;
                }

                return AuthenticateResult.Fail(ex);
 
                //throw;
            }
        }
        /// <summary>
        /// Handles the challenge.
        /// <para>SEE: https://searchsecurity.techtarget.com/definition/challenge-response-system</para>
        /// <para>SEE: https://en.wikipedia.org/wiki/Challenge-response_authentication </para>
        /// </summary>
        protected override Task HandleChallengeAsync(AuthenticationProperties properties)
        {
            if (!Request.IsHttps && Options.RequireHTTPS)
            {                
                Logger.LogInformation(AuthLib.SNoSecureProtocol);
                Response.StatusCode = StatusCodes.Status500InternalServerError;
                byte[] Buffer = Encoding.UTF8.GetBytes(AuthLib.SNoSecureProtocol);
                Response.Body.Write(Buffer, 0, Buffer.Length);
            }
            else
            {
                Response.StatusCode = StatusCodes.Status401Unauthorized;
                if (!Options.SuppressWWWAuthenticateHeader)
                {
                    string S = BasicAuthentication.DefaultAuthenticationScheme + $" realm=\"{Options.Realm}\"";                    
                    Response.Headers[HeaderNames.WWWAuthenticate] = S;      //Response.Headers.Append(HeaderNames.WWWAuthenticate, S);
                }
            }

            return Task.CompletedTask;
        }
        /// <summary>
        /// Creates and returns the <see cref="BasicAuthenticationEvents"/> object.
        /// </summary>
        protected override Task<object> CreateEventsAsync()
        { 
            return Task.FromResult<object>(new BasicAuthenticationEvents());
        }
        /// <summary>
        /// Called after options/events have been initialized for the handler to finish initializing itself.
        /// </summary>
        protected override Task InitializeHandlerAsync()
        {
            base.InitializeHandlerAsync();

            if (string.IsNullOrWhiteSpace(Options.Realm))
            {
                throw new ApplicationException(string.Format(AuthLib.SNoRealm, Scheme.Name));
            } 

            return Task.CompletedTask;
        }

        /* properties */
        /// <summary>
        /// The events object. The authentication handlers calls events while processing the authentication.
        /// </summary>
        protected new BasicAuthenticationEvents Events
        {
            get { return base.Events as BasicAuthenticationEvents; }
            set { base.Events = value; }
        }

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public BasicAuthenticationHandler(IOptionsMonitor<BasicAuthenticationOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock) 
            : base(options, logger, encoder, clock)
        {
        }
    }

}
