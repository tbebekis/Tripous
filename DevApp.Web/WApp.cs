using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

using Tripous;
using Tripous.Data;
using Tripous.Model;
using Tripous.Web;

using DevApp.Lib;

namespace DevApp.Web
{
    /// <summary>
    /// Represents this application
    /// </summary>
    static class WApp
    {
        /* event handlers */
        /// <summary>
        /// The host has fully started.
        /// <para>Perform post-startup activities here</para>
        /// </summary>
        static void OnStarted()
        {
            Sys.LogInfo("OnStarted");

            Start();
        }
        /// <summary>
        /// The host is performing a graceful shutdown. Requests may still be processing. Shutdown blocks until this event completes.
        /// <para>Perform on-stopping activities here</para>
        /// </summary>
        static void OnStopping()
        {
            Sys.LogInfo("OnStopping");
        }
        /// <summary>
        /// The host is completing a graceful shutdown. All requests should be processed. Shutdown blocks until this event completes.
        /// <para>Perform post-stopped activities here</para>
        /// </summary>
        static void OnStopped()
        {
            Sys.LogInfo("OnStopped");
        }


        /// <summary>
        /// Sets-up the SysConfig
        /// </summary>
        static void InitializeSysConfig()
        {
            Platform.IsWeb = true;

            SysConfig.ApplicationMode = ApplicationMode.Web;
            SysConfig.CompanyId = null;

            SysConfig.SolutionName = "Tripous";
            SysConfig.ApplicationName = SysConfig.AppExeName;
            SysConfig.ApplicationTitle = SysConfig.ApplicationName;

            SysConfig.ObjectStoreExcludedAssemblies.AddRange(new string[] { });
            SysConfig.ObjectStoreAutoInvokeInitializers = false;

            SysConfig.DateFormat = DateTimeFormatType.Date;
            SysConfig.DateTimeFormat = DateTimeFormatType.DateTime24;
            SysConfig.TimeFormat = DateTimeFormatType.Time24;

            SysConfig.MainAssembly = typeof(WApp).Assembly;
            SysConfig.GuidOids = true;
            SysConfig.VariablesPrefix = ":@";
            SysConfig.CompanyFieldName = "CompanyId";
            SysConfig.SqlConnectionsFileName = "SqlConnections.json";
            SysConfig.EnKey1 = "tripous";
            SysConfig.SelectSqlRowsLimit = 400;
            SysConfig.MachineIdRequired = false;
        }
        /// <summary>
        /// Starts the application.
        /// </summary>
        static void Start()
        {
 

            try
            {
                // 1. preparation, e.g. create folders etc.
                InitializeSysConfig();
                Tripous.Logging.Logger.AddFileListener();
                ObjectStore.Initialize();
                Db.Initialize();
                Bm.Initialize();

                AppLib.LoadExternalModules();

                // 2. initialize databases            
                //DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
                AppLib.ConnectDatabases();
                AppLib.CreateDatabases();

                // 3. register and execute database schemas 
                AppLib.RegisterSchemas();
                //ExternalModules.RegisterSchemas();
                AppLib.ExecuteSchemas();
                // AppLib.SetupCompanyId();

                // 4. register config and config providers
                //AppLib.RegisterConfigProviders();
                //ExternalModules.RegisterConfigProviders();
                //LoadConfig();

                // 5. register model
                //SysCodeProducers.Register();
                //AppLib.RegisterCodeProducers();
                AppLib.RegisterBrokers();
                AppLib.RegisterLocators();
                //ExternalModules.RegisterModuleItems();

                // 6. initial data
                AppLib.InsertInitialData();

 
            }
            catch (Exception ex)
            {
                Sys.LogError(ex);
                throw;
            }
        }

        /// <summary>
        /// Configure services
        /// </summary>
        static public void ConfigureServices(IServiceCollection services)
        {
        }
        /// <summary>
        /// Configure application
        /// </summary>
        static public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime appLifetime)
        {
            WSys.SetHostEnvironment(env);
            WSys.SetServiceProvider(app.ApplicationServices);

            appLifetime.ApplicationStarted.Register(WApp.OnStarted);
            appLifetime.ApplicationStopping.Register(WApp.OnStopping);
            appLifetime.ApplicationStopped.Register(WApp.OnStopped);
        }

    }
}
