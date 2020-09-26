using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Common;
using System.Net;
using System.Text.RegularExpressions;

using Microsoft.Net.Http.Headers;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Http.Extensions;

using Microsoft.Extensions.Primitives;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

using Tripous;
using Tripous.Data;
 

namespace Tripous.Web
{
    /// <summary>
    /// Helper
    /// </summary>
    static public class WSys
    {
        static IServiceProvider fRootServiceProvider;

        /* private */
        /// <summary>
        /// FROM: https://stackoverflow.com/questions/13086856/mobile-device-detection-in-asp-net
        /// </summary>
        static Regex MobileCheck = new Regex(@"(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|mobile.+firefox|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows ce|xda|xiino", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Compiled);
        /// <summary>
        /// FROM: https://stackoverflow.com/questions/13086856/mobile-device-detection-in-asp-net
        /// </summary>
        static Regex MobileVersionCheck = new Regex(@"1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Compiled);
        /// <summary>
        /// FROM: https://stackoverflow.com/questions/7576508/how-to-detect-crawlers-in-asp-net-mvc
        /// </summary>
        static Regex CrawlerCheck = new Regex(@"bot|crawler|baiduspider|80legs|ia_archiver|voyager|curl|wget|yahoo! slurp|mediapartners-google", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Compiled);
 
        

        /* construction */
        /// <summary>
        /// Static constructor
        /// </summary>
        static WSys()
        {
        }



        /* IServiceCollection */
        /// <summary>
        /// Returns a service specified by a type argument. If the service is not registered an exception is thrown.
        /// <para>WARNING: "Scoped" services can NOT be resolved from the "root" service provider. </para>
        /// <para>There are two solutions to the "Scoped" services problem:</para>
        /// <para> ● Use <c>HttpContext.RequestServices</c>, a valid solution since we use a "Scoped" service provider to create the service,  </para>
        /// <para> ● or add <c> .UseDefaultServiceProvider(options => options.ValidateScopes = false)</c> in the <c>CreateHostBuilder</c>() of the Program class</para>
        /// <para>see: https://github.com/dotnet/runtime/issues/23354 and https://devblogs.microsoft.com/dotnet/announcing-ef-core-2-0-preview-1/ </para>
        /// </summary>
        public static T GetService<T>()
        {
            return HttpContext != null? HttpContext.RequestServices.GetRequiredService<T>(): RootServiceProvider.GetRequiredService<T>();
        }
        /// <summary>
        /// Replaces one service with another
        /// </summary>
        static public void ReplaceService(IServiceCollection Services, Type Original, Type Replacer, ServiceLifetime LifeTime = ServiceLifetime.Scoped)
        {
            var descriptor = new ServiceDescriptor(Original, Replacer, LifeTime);
            Services.Replace(descriptor);
        }

        /// <summary>
        /// <para>After calling this method the <see cref="Db.Connections"/> is loaded from the appsettings.json file with Sql database connection information. </para>
        /// </summary>
        static public void AddSqlStores(this IServiceCollection Services, IConfiguration Configuration, string SectionName = "SqlConnections")
        {
            List<SqlConnectionInfo> Connections = new List<SqlConnectionInfo>();
            IConfigurationSection ConnectionsSection = Configuration.GetSection(SectionName);
            // services.Configure<List<SqlConnectionInfo>>(ConnectionsSection); // do we need to register settings with the DI?
            ConnectionsSection.Bind(Connections);

            Db.Connections = Connections;
        }

        /* miscs */
        /// <summary>
        /// Returns a query string value by a specified key
        /// </summary>
        static public string GetQueryValue(string Key)
        {
            string Result = null;

            if (WSys.IsRequestAvailable)
            {
                var SV = WSys.HttpContext.Request.Query[Key];
                if (!StringValues.IsNullOrEmpty(SV))
                    Result = SV.ToString();
            }

            return Result;
        }
        /// <summary>
        /// Returns the value of a query string parameter.
        /// <para>NOTE: When a parameter is included more than once, e.g. ?page=1&amp;page=2 then the result will be 1,2 hence this function returns an array.</para>
        /// </summary>
        static public string[] GetQueryValueArray(string Key)
        {
            if (HttpContext != null)
            {
                if (HttpContext.Request.Query.ContainsKey(Key))
                    return HttpContext.Request.Query[Key].ToArray();
            }

            return new string[0];
        }

        /// <summary>
        /// Returns the referrer Url if any, else null.
        /// <para>NOTE: The HTTP referer is an optional HTTP header field that identifies the address of the webpage which is linked to the resource being requested. 
        /// By checking the referrer, the new webpage can see where the request originated</para>
        /// </summary>
        static public string GetReferrerUrl(HttpRequest R = null)
        {
            if (R == null && WSys.IsRequestAvailable)
                R = WSys.HttpRequest;

            if (R != null)
                return R.Headers[HeaderNames.Referer];

            return null;
        }
        /// <summary>
        /// Returns the client IP address, that is the IP address of the visitor, if any, else null
        /// </summary>
        static public string GetClientIpAddress(HttpRequest R = null)
        {
            string Result = null;

            if (R == null && WSys.IsRequestAvailable)
                R = WSys.HttpRequest;

            if (R != null)
            {
                // first try to get the IP address from the X-Forwarded-For header
                // SEE: https://en.wikipedia.org/wiki/X-Forwarded-For
                var SV = R.Headers["X-Forwarded-For"];
                if (!StringValues.IsNullOrEmpty(SV))
                    Result = SV.FirstOrDefault();

                // next try the remote IP address
                if (string.IsNullOrWhiteSpace(Result) && R.HttpContext.Connection.RemoteIpAddress != null)
                    Result = R.HttpContext.Connection.RemoteIpAddress.ToString();
            }

            // check to see if it is the IPv6 Loopback address
            if (!string.IsNullOrWhiteSpace(Result) && Result.Equals(IPAddress.IPv6Loopback.ToString(), StringComparison.InvariantCultureIgnoreCase))
                Result = IPAddress.Loopback.ToString();

            // remove the port if there
            if (!string.IsNullOrWhiteSpace(Result) && Result.Contains(':'))
                Result = Result.Split(':').FirstOrDefault();

            return Result;
        }

        /// <summary>
        /// Returns the domain name of the server and the TCP port number on which the server is listening. 
        /// The port number may be omitted if the port is the standard port for the service requested. 
        /// </summary>
        static public string GetHostDomainName(HttpRequest R = null)
        {
            string Result = null;

            if (R == null && WSys.IsRequestAvailable)
                R = WSys.HttpRequest;

            if (R != null)
            {
                Result = R.Headers[HeaderNames.Host];
            }

            return Result;
        }

        /// <summary>
        /// Returns the scheme of the current request, i.e. https or http
        /// </summary>
        static public string GetRequestProtocol(HttpRequest R = null)
        {
            return IsHttps(R) ? Uri.UriSchemeHttps : Uri.UriSchemeHttp;
        }

        /// <summary>
        /// Returns the raw Url path and full query string of a specified request
        /// <note>SEE: https://stackoverflow.com/questions/28120222/get-raw-url-from-microsoft-aspnet-http-httprequest </note>
        /// </summary>
        static public string GetRawUrl(HttpRequest R = null)
        {
            string Result = null;

            if (R == null && WSys.IsRequestAvailable)
                R = WSys.HttpRequest;

            Result = R.HttpContext.Features.Get<IHttpRequestFeature>()?.RawTarget;

            // if is empty create it manually
            if (string.IsNullOrWhiteSpace(Result))
                Result = $"{R.PathBase}{R.Path}{R.QueryString}";

            return Result;
        }
        /// <summary>
        /// Returns the raw Url path and full query string of a specified request, url-encoded.
        /// <note>SEE: https://stackoverflow.com/questions/28120222/get-raw-url-from-microsoft-aspnet-http-httprequest </note>
        /// </summary>
        static public string GetRawUrlEncoded(HttpRequest R = null)
        {
            return GetRawUrl(R).UrlEncode();
        }
        /// <summary>
        /// Returns the combined components of the request URL in a fully escaped form suitable for use in HTTP headers and other HTTP operations.
        /// </summary>
        static public string GetFullUrlEncoded(HttpRequest R = null)
        {
            if (R == null && WSys.IsRequestAvailable)
                R = WSys.HttpRequest;

            return R.GetEncodedUrl();
        }
        /// <summary>
        /// Returns the combined components of the request URL in a fully un-escaped form (except for the QueryString) suitable only for display. 
        /// <para>This format should not be used in HTTP headers or other HTTP operations.</para>
        /// </summary>
        static public string GetFullDisplayUrl(HttpRequest R = null)
        {
            if (R == null && WSys.IsRequestAvailable)
                R = WSys.HttpRequest;

            return R.GetEncodedUrl();
        }

        /// <summary>
        /// Returns true if the RequestScheme is https.
        /// </summary>
        static public bool IsHttps(HttpRequest R = null)
        {
            if (R == null && WSys.IsRequestAvailable)
                R = WSys.HttpRequest;

            if (R != null)
            {
                return R.Headers["X-Forwarded-Proto"].ToString().Equals("https", StringComparison.OrdinalIgnoreCase)
                    || R.IsHttps;
            }

            return false;
        }
        /// <summary>
        /// Gets whether the specified HTTP request URI references the local host.
        /// </summary>
        /// <param name="R">HTTP request</param>
        /// <returns>True, if HTTP request URI references to the local host</returns>
        static public bool IsLocalRequest(HttpRequest R = null)
        {
            if (R == null && WSys.IsRequestAvailable)
                R = WSys.HttpRequest;

            if (R != null)
            {
                // SEE: https://stackoverflow.com/questions/35240586/in-asp-net-core-how-do-you-check-if-request-is-local/
                ConnectionInfo CI = R.HttpContext.Connection;
                if (CI.RemoteIpAddress != null)
                {
                    return CI.LocalIpAddress != null ? CI.RemoteIpAddress.Equals(CI.LocalIpAddress) : IPAddress.IsLoopback(CI.RemoteIpAddress);
                }
            }


            return true;
        }
        /// <summary>
        /// Returns true if a specified request is an ajax request
        /// </summary>
        static public bool IsAjax(HttpRequest R = null)
        {
            if (R == null && WSys.IsRequestAvailable)
                R = WSys.HttpRequest;

            return R != null ? R.Headers["X-Requested-With"] == "XMLHttpRequest" : false;
        }

        /* properties */
        /// <summary>
        /// Returns the base url of this application.
        /// <para>CAUTION: There should be a valid HttpContext in order to be able to return the base url.</para>
        /// </summary>
        static public string BaseUrl
        { 
            get 
            {
                if (HttpContext != null)
                {
                    string Scheme = HttpContext.Request.Scheme;
                    string Host = HttpContext.Request.Host.Host;
                    string Port = HttpContext.Request.Host.Port != 80 && HttpContext.Request.Host.Port != 443 ? $":{HttpContext.Request.Host.Port}" : "";

                    return $"{Scheme}://{Host}{Port}";
                }

                return string.Empty;                
            } 
        }
 
        /// <summary>
        /// The physical "root path", i.e. the root folder of the application
        /// <para> e.g. C:\MyApp</para>
        /// </summary>
        static public string RootPath { get { return HostEnvironment.ContentRootPath; } }
        /// <summary>
        /// The physical "web root" path, i.e. the path to the "wwwroot" folder
        /// <para>e.g. C:\MyApp\wwwwroot</para>
        /// </summary>
        static public string WebRootPath { get { return HostEnvironment.WebRootPath; } }
        /// <summary>
        /// The physical path of the \bin folder
        /// <para>e.g. C:\MyApp\bin\Debug\netcoreapp3.0\  </para>
        /// <para>e.g. C:\inetpub\wwwroot\bin\</para>
        /// </summary>
        static public string BinPath { get { return AppContext.BaseDirectory; } }

        /// <summary>
        /// Gets or sets the root <see cref="IServiceProvider"/>
        /// </summary>
        static public IServiceProvider RootServiceProvider
        {
            get { return fRootServiceProvider; }
            set
            {
                fRootServiceProvider = value;
                if (fRootServiceProvider != null)
                {
                    HttpContextAccessor = RootServiceProvider.GetRequiredService<IHttpContextAccessor>();
                }
            }
        }
        /// <summary>
        /// Gets or sets the <see cref="IHttpContextAccessor"/>
        /// </summary>
        static public IHttpContextAccessor HttpContextAccessor { get; set; }
        /// <summary>
        /// Returns the HttpContext
        /// </summary>
        static public HttpContext HttpContext { get { return HttpContextAccessor != null? HttpContextAccessor.HttpContext: null; } }
        /// <summary>
        /// Returns the current HTTP request, if any, else null.
        /// </summary>
        static public HttpRequest HttpRequest
        {
            get
            {
                try
                {
                    return HttpContextAccessor != null && HttpContextAccessor.HttpContext != null? HttpContextAccessor.HttpContext.Request: null;
                }
                catch
                {                    
                }

                return null;
            }
        }
        /// <summary>
        /// Returns true if an HTTP Request is currently available
        /// </summary>
        static public bool IsRequestAvailable { get { return HttpRequest != null; } }
 
        /// <summary>
        /// Gets or sets the <see cref="IWebHostEnvironment"/>
        /// </summary>
        static public IWebHostEnvironment HostEnvironment { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="IConfiguration"/>
        /// </summary>
        static public IConfiguration Configuration { get; set; }
        /// <summary>
        /// True when is development environment.
        /// </summary>
        static public bool IsDevelopment { get { return HostEnvironment.IsDevelopment(); } }
        /// <summary>
        /// Returns true if we are dealing with a mobile device/browser
        /// <para>FROM: https://stackoverflow.com/questions/13086856/mobile-device-detection-in-asp-net </para>
        /// </summary>
        static public bool IsMobile
        {
            get
            {
                if (HttpContext != null)
                {
                    string S = HttpContext.Request.Headers[Microsoft.Net.Http.Headers.HeaderNames.UserAgent].ToString();
                    return S.Length >= 4 && (MobileCheck.IsMatch(S) || MobileVersionCheck.IsMatch(S.Substring(0, 4)));
                }

                return false;
            }
        }
        /// <summary>
        /// Returns true if we are dealing with a search endine bot.
        /// <para>FROM: https://stackoverflow.com/questions/7576508/how-to-detect-crawlers-in-asp-net-mvc  </para>
        /// </summary>
        static public bool IsCrawler
        {
            get
            {
                if (HttpContext != null)
                {
                    string S = HttpContext.Request.Headers[Microsoft.Net.Http.Headers.HeaderNames.UserAgent].ToString();
                    return S.Length >= 4 && CrawlerCheck.IsMatch(S);
                }

                return false;
            }
        }
    }
}
