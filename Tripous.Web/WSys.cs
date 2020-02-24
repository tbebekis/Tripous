using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Common;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

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
        /* private */
        static IHttpContextAccessor HttpContextAccessor;
 
        /* public - initialization */
        /// <summary>
        /// Sets the host environment <see cref="IHostEnvironment"/> value
        /// <para>Call it from inside the <code>Startup</code> constructor.</para>
        /// </summary>
        static public void SetHostEnvironment(IWebHostEnvironment Value)
        {
            HostEnvironment = Value;
        }
        /// <summary>
        /// Sets the configuration <see cref="IConfiguration"/> value
        /// <para>Call it from inside the <code>Startup</code> constructor.</para>
        /// </summary>
        static public void SetConfiguration(IConfiguration Value)
        {
            Configuration = Value;
        }
        /// <summary>
        /// Sets the service provider <see cref="IServiceProvider"/> value.
        /// <para>Call it from inside the <code>Startup.Configure()</code> method as <code>WSys.SetServiceProvider(app.ApplicationServices)</code> </para>
        /// </summary>
        static public void SetHttpContextAccessor(IServiceProvider ServiceProvider)
        {
            HttpContextAccessor = ServiceProvider.GetRequiredService<IHttpContextAccessor>();
            //HostEnvironment = (HostEnvironment ?? ServiceProvider.GetRequiredService<IHostEnvironment>()) as IWebHostEnvironment;
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
            return HttpContext.RequestServices.GetRequiredService<T>();
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



        /* properties */
        /// <summary>
        /// Returns the physical path of the \bin folder, e.g. C:\inetpub\wwwroot\bin
        /// </summary>
        static public string BinFolder { get { return AppContext.BaseDirectory; } }
        /// <summary>
        /// Returns the HttpContext
        /// </summary>
        static public HttpContext HttpContext { get { return HttpContextAccessor.HttpContext; } }
        /// <summary>
        /// Returns the HostingEnvironment
        /// </summary>
        static public IWebHostEnvironment HostEnvironment { get; private set; }
        /// <summary>
        /// Returns the Configuration
        /// </summary>
        static public IConfiguration Configuration { get; private set; }

    }
}
