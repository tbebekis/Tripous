using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Common;


using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;
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
        static public void SetHostEnvironment(IHostEnvironment Value)
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
        static public void SetServiceProvider(IServiceProvider Value)
        {
            ServiceProvider = Value;
            HttpContextAccessor = ServiceProvider.GetRequiredService<IHttpContextAccessor>();
            HostEnvironment = HostEnvironment ?? ServiceProvider.GetRequiredService<IHostEnvironment>();
        }



        /* IServiceCollection */
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
        /// <summary>
        /// Replaces one service with another
        /// </summary>
        static public void ReplaceService(IServiceCollection Services, Type Original, Type Replacer, ServiceLifetime LifeTime = ServiceLifetime.Scoped)
        {
            var descriptor = new ServiceDescriptor(Original, Replacer, LifeTime);
            Services.Replace(descriptor);
        }

        /* properties */
        /// <summary>
        /// Returns the service provider
        /// </summary>
        static public IServiceProvider ServiceProvider { get; private set; }
        /// <summary>
        /// Returns the HttpContext
        /// </summary>
        static public HttpContext HttpContext { get { return HttpContextAccessor.HttpContext; } }
        /// <summary>
        /// Returns the HostingEnvironment
        /// </summary>
        static public IHostEnvironment HostEnvironment { get; private set; }
        /// <summary>
        /// Returns the Configuration
        /// </summary>
        static public IConfiguration Configuration { get; private set; }
    }
}
