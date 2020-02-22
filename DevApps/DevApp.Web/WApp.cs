using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Globalization;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;

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
    static public class WApp
    {
        static SqlStore fDefaultStore;

        /* event handlers */
        /// <summary>
        /// The host has fully started.
        /// <para>Perform post-startup activities here</para>
        /// </summary>
        static void OnStarted()
        {
            Sys.LogInfo("OnStarted"); 
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

        /* private */
        /// <summary>
        /// Loads the active languages from the database table.
        /// <para>It also extracts language flag images from resources and saves it to wwwroot/images, if not already there.</para>
        /// </summary>
        static void LoadLanguages()
        {
            Dictionary<string, string> ImageNames = null;
            string ImagesFolder = Path.Combine(HostEnvironment.WebRootPath, "images");
            string ImagePath;
            string ImageResourcePath;
            Image Image;
            
            // nested function to find the resource path of flag image of a language
            Func<string, string> GetImageResourcePath = (ImageFileName) =>
            {
                foreach (var Entry in ImageNames)
                {
                    if (Entry.Value.EndsWith(ImageFileName, StringComparison.InvariantCultureIgnoreCase))
                        return Entry.Value;
                }

                return string.Empty;
            };            
            
            // load active languages from database
            string SqlText = $"select * from {SysTables.Lang} where IsActive = 1 order by DisplayOrder";
            DataTable Table = DefaultStore.Select(SqlText);
            
            // create language items and handle flag images
            if (Table.Rows.Count > 0)
            {
               ImageNames = Icons32.GetNamesDictionary();

                LanguageItem LI;
                foreach (DataRow Row in Table.Rows)
                {
                    LI = new LanguageItem(Row);
                    Languages.Add(LI);

                    if (!string.IsNullOrWhiteSpace(LI.FlagImage))
                    {
                        ImagePath = Path.Combine(ImagesFolder, LI.FlagImage);
                        if (!File.Exists(ImagePath))
                        {
                            ImageResourcePath = GetImageResourcePath(LI.FlagImage);
                            if (!string.IsNullOrWhiteSpace(ImageResourcePath))
                            {
                                Image = Icons32.GetImage(ImageResourcePath);
                                if (Image != null)
                                {
                                    Image.Save(ImagePath);
                                }
                            }
                        } 
                    }
                }
            }  

            
        }

        /// <summary>
        /// Sets-up the SysConfig
        /// </summary>
        static void InitializeSysConfig()
        {
            Platform.IsWeb = true;

            SysConfig.ApplicationMode = ApplicationMode.Web;

            SysConfig.SolutionName = "Tripous";
            SysConfig.ApplicationName = SysConfig.AppExeName;
            SysConfig.ApplicationTitle = SysConfig.ApplicationName;

            SysConfig.ObjectStoreExcludedAssemblies.AddRange(new string[] { });
            SysConfig.ObjectStoreAutoInvokeInitializers = false;

            SysConfig.DateFormat = DateTimeFormatType.Date;
            SysConfig.DateTimeFormat = DateTimeFormatType.DateTime24;
            SysConfig.TimeFormat = DateTimeFormatType.Time24;

            SysConfig.AppDataFolder = Path.GetFullPath(@"..\..\..\Data");

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
        /// Initializes the application
        /// </summary>
        static void InitializeApplication()
        {
            try
            {
                // 1. initialize libraries
                WApp.InitializeSysConfig();

                //DevApp.Lib.Forms.FormLib.Initialize();
                Tripous.Logging.Logger.AddFileListener();
                //Tripous.Icons32.Initialize();
                ObjectStore.Initialize();
                Db.Initialize();
                Bm.Initialize();

                AppLib.Initialize();


                // 2. prepare application start
                //CreateFolders();
                //EnsureMachineId();
                //ExternalModulesLoad();              /* load and initialize any plugins first */

                // 3. initialize databases            
                //DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
                AppLib.ConnectDatabases();
                AppLib.CreateDatabases();



                // 4. register and execute database schemas 
                AppLib.RegisterSchemas();
                //ExternalModules.RegisterSchemas();
                AppLib.ExecuteSchemas();
                // AppLib.SetupCompanyId();

                // 5. register config and config providers
                //AppLib.RegisterConfigProviders();
                //ExternalModules.RegisterConfigProviders();
                //LoadConfig();

                // 6. register model
                //SysCodeProducers.Register();
                //AppLib.RegisterCodeProducers();
                AppLib.RegisterBrokers();
                AppLib.RegisterLocators();
                //ExternalModules.RegisterModuleItems();

                // 7. initial data
                AppLib.InsertInitialData();
            }
            catch (Exception ex)
            {
                Sys.LogError(ex);
                throw;
            }
        }

        /// <summary>
        /// Configures the request culture provider.
        /// <para>SEE: https://teonotebook.wordpress.com/2020/02/22/asp-net-core-3-0-mvc-request-localization-or-how-to-set-the-culture-of-a-user-session/ </para>
        /// </summary>
        static void ConfigureRequestCultureProvider(IServiceCollection services)
        { 
            LanguageItem[] LangItems = WApp.LanguageItems;

            // UseRequestLocalization initializes a RequestLocalizationOptions object. 
            // On every request the list of RequestCultureProvider in the RequestLocalizationOptions is enumerated 
            // and the first provider that can successfully determine the request culture is used.
            // SEE: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/localization#localization-middleware
            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new RequestCulture(LangItems[0].CultureCode);
                options.SupportedCultures = LangItems.Select(item => item.GetCulture()).ToList();
                options.SupportedUICultures = options.SupportedUICultures;

                //options.RequestCultureProviders.Clear();

                // use the built-in CustomRequestCultureProvider which accepts a proper lambda
                options.RequestCultureProviders.Insert(0, new CustomRequestCultureProvider(async (HttpContext) => {
                    await Task.Yield();
                    return new ProviderCultureResult(Session.Language.CultureCode);
                }));

            });
        }

        /* internal */
        /// <summary>
        /// Configure services before
        /// <para>Called from ConfigureServices()</para>
        /// </summary>
        static internal void ConfigureServicesBefore(IServiceCollection services, IWebHostEnvironment HostEnvironment)
        {
            WApp.HostEnvironment = HostEnvironment;
            WSys.SetHostEnvironment(HostEnvironment);            
        }
        /// <summary>
        /// Initializes the application. Should be called from ConfigureServices() just before adding the MVC service.
        /// </summary>
        static internal void ConfigureServices(IServiceCollection services, IWebHostEnvironment HostEnvironment)
        {
            InitializeApplication();

            // further initialization
            ConfigureRequestCultureProvider(services);
        }
        /// <summary>
        /// Configure services after
        /// <para>Called from ConfigureServices()</para>
        /// </summary>
        static internal void ConfigureServicesAfter(IServiceCollection services, IWebHostEnvironment HostEnvironment)
        {
        }
 
        /// <summary>
        /// Configure application before
        /// <para>Called from Configure()</para>
        /// </summary>
        static internal void ConfigureBefore(IApplicationBuilder app, IHostApplicationLifetime appLifetime)
        {
            WSys.SetServiceProvider(app.ApplicationServices);

            appLifetime.ApplicationStarted.Register(WApp.OnStarted);
            appLifetime.ApplicationStopping.Register(WApp.OnStopping);
            appLifetime.ApplicationStopped.Register(WApp.OnStopped);

            //ConfigureLocalization(app);
        }
        /// <summary>
        /// Configure application. Should be called from Configure() just before calling UseMvc() or UseEndpoints().
        /// </summary>
        static internal void Configure(IApplicationBuilder app, IHostApplicationLifetime appLifetime)
        {
            // UseRequestLocalization initializes a RequestLocalizationOptions object. 
            // On every request the list of RequestCultureProvider in the RequestLocalizationOptions is enumerated 
            // and the first provider that can successfully determine the request culture is used.
            // SEE: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/localization#localization-middleware
            app.UseRequestLocalization();
        }
        /// <summary>
        /// Configure application after
        /// <para>Called from Configure()</para>
        /// </summary>
        static internal void ConfigureAfter(IApplicationBuilder app, IHostApplicationLifetime appLifetime)
        {
           
        }

        /* properties */
        /// <summary>
        /// Hosting environment
        /// </summary>
        static public IWebHostEnvironment HostEnvironment { get; private set; }
        /// <summary>
        /// Gets or sets the absolute path to the directory that contains the application content files.
        /// </summary>
        static public string ContentRootPath { get { return HostEnvironment.ContentRootPath; } }
        /// <summary>
        /// Gets or sets the absolute path to the directory that contains the web-servable application content files.
        /// </summary>
        static public string WebRootPath { get { return HostEnvironment.WebRootPath; } }
        /// <summary>
        /// The default <see cref="SqlStore"/>
        /// </summary>
        static public SqlStore DefaultStore
        {
            get
            {
                if (fDefaultStore == null)
                    fDefaultStore = SqlStores.CreateDefaultSqlStore();
                return fDefaultStore;
            }
        }
        /// <summary>
        /// The available languages
        /// </summary>
        static public LanguageItem[] LanguageItems
        {
            get
            {
                LanguageItem[] Result = Languages.Items;
                if (Result.Length == 0)
                    LoadLanguages();
                return Languages.Items;
            }
        }
        /// <summary>
        /// Gets or sets the language of the current session. A two letter language code, e.g en, el, it, fr, etc.
        /// </summary>
        static public string Language
        {
            get
            {
                var Lang = Session.Language;
                return Lang.Code;
            }
            set
            {
                if (value != Language)
                {
                    var Lang = Languages.Find(value);
                    if (Lang != null)
                        Session.Language = Lang;
                }
            }
        }
        /// <summary>
        ///  The culture code of the current session. A culture code, e.g en-US, el-GR, etc.
        /// </summary>
        static public string CultureCode { get { return Session.Language.CultureCode; } }
    }
}
