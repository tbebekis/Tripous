using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Tripous;
using Tripous.Web;
 
namespace DevApp.Web
{

    /// <summary>
    /// The startup class. It actually delegates all "action" to <see cref="WApp"/> class
    /// </summary>
    public class Startup
    {
        /* private */
        IConfiguration Configuration;
        IWebHostEnvironment HostEnvironment;

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            this.Configuration = configuration;
            HostEnvironment = environment;

            WSys.SetConfiguration(Configuration);
            WSys.SetHostEnvironment(HostEnvironment);
        }

        /* public */
        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        public void ConfigureServices(IServiceCollection services)
        {
            WApp.ConfigureServices(services);  
        }
        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        public void Configure(IApplicationBuilder app, IOptionsMonitor<AppSettings> SettingsAccessor)
        {
            WApp.Configure(app, SettingsAccessor);
        }
    }
}
