using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System.Text;
using System.Globalization;
using System.Net.Http.Headers;
using System.Security.Claims;

using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;

using Tripous.Identity;


namespace Tripous.Web.Authentication.Digest
{

    /// <summary>
    /// Authentication handler for the digest authentication scheme.
    /// <para>Created per request to handle authentication.</para>
    /// </summary>
    public class DigestAuthenticationHandler : AuthenticationHandler<DigestAuthenticationOptions>
    {
        /* private */
        const string SNonceTimeStampFormat = "yyyy-MM-dd HH:mm:ss.ffffffZ";
        IDigestAuthenticationHandlerService Service;

        /// <summary>
        /// Splits the <see cref="HeaderNames.Authorization"/> request header fields into a dictionary.
        /// </summary>
        static Dictionary<string, string> SplitAuthorizationHeader(string Header, string HttpMethod)
        {
            Dictionary<string, string> Result = new Dictionary<string, string>();
            Result.Add("method", HttpMethod);

            string[] Parts = Header.Split(',', StringSplitOptions.RemoveEmptyEntries);

            int Index;
            string Key;
            string Value;

            foreach (string S in Parts)
            {
                Index = S.IndexOf("=");
                Key = S.Substring(0, Index).Trim();
                Value = S.Substring(Index + 1).Trim();

                if (Value.StartsWith("\""))
                {
                    Value = Value.Substring(1, Value.Length - 2);
                }

                Result.Add(Key, Value);
            }

            return Result;
        }
        /// <summary>
        /// Generates and returns the nonce value.
        /// <para>SEE: https://tools.ietf.org/html/rfc7616#section-3.3 </para>
        /// </summary>
        static string GenerateNonceValue(string NonceSecret)
        {
            // NOTE: the RFC7616 suggests the following
            // timestamp H(timestamp ":" ETag ":" secret-data)
            string TimeStamp = DateTime.UtcNow.ToString(SNonceTimeStampFormat);
            string Result = $"{TimeStamp}:{NonceSecret}";
            Result = Result.ToMD5Hash();
            return Result;
        }
        /// <summary>
        /// Generates and returns the  <see cref="HeaderNames.WWWAuthenticate"/> response header.
        /// </summary>
        static string GenerateWWWAuthenticateHeader(string NonceValue, string Realm)
        {
            // formats and returns a header field
            Func<string, string, bool, string> Format = delegate (string Key, string Value, bool Quoted)
            {
                return Quoted ? $"{Key}=\"{Value}\"" : $"{Key}={Value}";
            };

            StringBuilder SB = new StringBuilder();

            SB.Append(DigestAuthentication.DefaultAuthenticationScheme);
            SB.Append(" ");
            SB.Append(Format("realm", Realm, true));
            SB.Append(",");
            SB.Append(Format("qop", "auth", true));
            SB.Append(",");
            SB.Append(Format("nonce", NonceValue, true));
            SB.Append(",");
            SB.Append(Format("algorithm", "MD5", false));

            string Result = SB.ToString();
            return Result;
        }

        /* overrides */
        /// <summary>
        /// Handles the authentication.
        /// <para>
        /// Authentication logic is implemented in this method by verifying the username and password received in the HTTP Authorization header.
        /// On successful authentication the method returns <see cref="AuthenticateResult.Success(AuthenticationTicket)"/> 
        /// which makes the request authenticated and sets the <see cref="HttpContext.User"/> to the currently logged in user.
        /// </para>
        /// </summary>
        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            DigestAuthenticationContext HandlerContext = null;

            DigestNonce Nonce;
            string Username = null;
            string Password = null;

            StringValues Values;

            string Realm;
            string NonceValue;
            string NonceCounter;
            string ClientNonce;
            string DigestUri;
            string ResponseValue;

            string HA1;
            string HA2;
            string HAResponseValue; 
 
            try
            {
                // ●  get the authorization header
                if (!Request.Headers.TryGetValue(HeaderNames.Authorization, out Values))
                {
                    return AuthenticateResult.Fail(AuthLib.SNoAuthorizationHeader);
                }

                // ●  check for the right authentication scheme
                AuthenticationHeaderValue HeaderValue = AuthenticationHeaderValue.Parse(Values);
                if (string.Compare(DigestAuthentication.DefaultAuthenticationScheme, HeaderValue.Scheme, StringComparison.OrdinalIgnoreCase) != 0)
                {
                    return AuthenticateResult.Fail(string.Format(AuthLib.SInvalidAuthorizationType, DigestAuthentication.DefaultAuthenticationScheme, HeaderValue.Scheme));
                }

                // ●  process authorization header - split the header fields
                Dictionary<string, string> HeaderDic = SplitAuthorizationHeader(HeaderValue.Parameter, Request.Method);

                Username = HeaderDic["username"];
                Realm = HeaderDic["realm"];
                NonceValue = HeaderDic["nonce"];
                NonceCounter = HeaderDic["nc"];
                ClientNonce = HeaderDic["cnonce"];
                DigestUri = HeaderDic["uri"];                
                ResponseValue = HeaderDic["response"];

                // ●  check all required header fields are present
                string[] HeaderFields = new[] {
                    Username,
                    Realm,
                    NonceValue,
                    NonceCounter,
                    ClientNonce,
                    DigestUri,
                    ResponseValue
                };

                foreach (string v in HeaderFields)
                {
                    if (string.IsNullOrWhiteSpace(v))
                    {
                        return AuthenticateResult.Fail(AuthLib.SRequiredAuthorizationHeaderField);
                    }
                }

                // ●  load the Nonce from database or any other persistent medium
                Nonce = Service.Load(NonceValue);
                if (Nonce == null)
                {
                    return AuthenticateResult.Fail(AuthLib.SInvalidAuthenticationAttempt);
                } 

                // ●  expiration check
                if (Options.NonceTimeoutMinutes > 0)
                {
                    if (DateTime.UtcNow > Nonce.ExpiresUtc)
                    {
                        Service.Remove(NonceValue);
                        return AuthenticateResult.Fail(AuthLib.SAuthenticationExpired);
                    }
                }

                // ●  Realm and Nonce counter check
                int iNonceCounter = int.Parse(NonceCounter);
                if (Options.Realm != Realm || Nonce.Counter >= iNonceCounter)
                {
                    return AuthenticateResult.Fail(AuthLib.SInvalidAuthenticationAttempt);
                }

                // ●  load the password from database or any other persistent medium
                Password = Service.LoadPassword(Username);
                if (string.IsNullOrWhiteSpace(Password))
                {
                    return AuthenticateResult.Fail(AuthLib.SInvalidAuthenticationAttempt);
                }

                Nonce.Value = NonceValue;
                Nonce.Username = Username;
                Nonce.Counter = iNonceCounter;
                
                

                // ●  Response Value check
                // HA1 = MD5(username:realm:password)
                HA1 = $"{Username}:{Realm}:{Password}";
                HA1 = HA1.ToMD5Hash();

                // HA2 = MD5(method:digestURI), when the qop directive's value is "auth" or is unspecified
                HA2 = $"{Request.Method}:{DigestUri}";
                HA2 = HA2.ToMD5Hash();

                // response = MD5(HA1:nonce:nonceCount:cnonce:qop:HA2)
                HAResponseValue = $"{HA1}:{NonceValue}:{NonceCounter}:{ClientNonce}:auth:{HA2}";
                HAResponseValue = HAResponseValue.ToMD5Hash();

                // validate authentication request (by actually validating credentials)
                if (string.CompareOrdinal(ResponseValue, HAResponseValue) != 0)
                {
                    return AuthenticateResult.Fail(AuthLib.SInvalidCredentials);
                }

                // ●  OK, the authentication request is valid
                HandlerContext = new DigestAuthenticationContext(Context, Scheme, Options)
                {
                    Username = Username,
                };

                Service.Save(Nonce);

                // ●  create the identity and authenticate it
                HandlerContext.CreateAuthenticatedIdentity();

                // ●  return the authentication result
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
                HandlerContext = HandlerContext ?? new DigestAuthenticationContext(Context, Scheme, Options)
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
        /// <para>SEE: https://en.wikipedia.org/wiki/Challenge-response_authentication /> </para>
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
                int NonceTimeoutMinutes = Options.NonceTimeoutMinutes <= 0 ? 15 : Options.NonceTimeoutMinutes;

                string NonceValue = GenerateNonceValue(Options.NonceSecret);
                DigestNonce Nonce = new DigestNonce()
                {
                    Value = NonceValue,
                    Username = "",
                    Counter = 0,
                    ExpiresUtc = DateTime.UtcNow.AddMinutes(NonceTimeoutMinutes)
                };

                Service.Save(Nonce);

                Response.StatusCode = StatusCodes.Status401Unauthorized;
                string S = GenerateWWWAuthenticateHeader(NonceValue, Options.Realm);               
                Response.Headers[HeaderNames.WWWAuthenticate] = S;           //Response.Headers.Append(HeaderNames.WWWAuthenticate, S);
            }

            return Task.CompletedTask;
        }
        /// <summary>
        /// Creates and returns the <see cref="Tripous.Web.Authentication.Basic.BasicAuthenticationEvents"/> object.
        /// </summary>
        protected override Task<object> CreateEventsAsync()
        {
            return Task.FromResult<object>(new DigestAuthenticationEvents());
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

            if (string.IsNullOrWhiteSpace(Options.NonceSecret))
            {
                Options.NonceSecret = Sys.GeneratePassword(10);
            }

            return Task.CompletedTask;
        }

        /* properties */
        /// <summary>
        /// The events object. The authentication handlers calls events while processing the authentication.
        /// </summary>
        protected new DigestAuthenticationEvents Events
        {
            get { return base.Events as DigestAuthenticationEvents; }
            set { base.Events = value; }
        }

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public DigestAuthenticationHandler(IDigestAuthenticationHandlerService DigestService, IOptionsMonitor<DigestAuthenticationOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock)
            : base(options, logger, encoder, clock)
        {
            this.Service = DigestService;

        }
    }
}
