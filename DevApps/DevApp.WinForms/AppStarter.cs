using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

using Tripous;
using Tripous.Data;
using Tripous.Model;
using Tripous.Forms;

using DevApp.Lib;

namespace DevApp.WinForms
{

    /// <summary>
    /// Application initializer/finalizer
    /// </summary>
    class AppStarter : AppStarterBase
    {

        /* preparation */
        /// <summary>
        /// Initializes any libraries that are dependencies of this appliation
        /// </summary>
        protected override void InitializeLibraries()
        {
            AppStarter.InitializeSysConfig();

            //DevApp.Lib.Forms.FormLib.Initialize();
            Tripous.Logging.Logger.AddFileListener();
            Tripous.Icons32.Initialize();
            ObjectStore.Initialize();
            Db.Initialize();
            Bm.Initialize();

            AppLib.Initialize();
        }

        /* databases */
        /// <summary>
        /// Initializes the data sub-system
        /// </summary>
        protected override void InitializeDatabases()
        {
            base.InitializeDatabases();

            // 2. initialize databases            
            //DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
            AppLib.ConnectDatabases();
            AppLib.CreateDatabases();

            // 3. register and execute database schemas 
            AppLib.RegisterSchemas();
            //ExternalModules.RegisterSchemas();
            AppLib.ExecuteSchemas();
            AppLib.SetupCompanyId();
        }
 
        /* login */
        /// <summary>
        /// Performs the login operation in the application initialization phase, if needed,
        /// and returns true on success
        /// </summary>
        protected override bool PerformStartupLogin()
        {
            MessageBox.Show("This is the login dialog");
            return true;
        }

        /* login */
        /// <summary>
        /// Initializes the model sub-system
        /// </summary>
        protected override void RegisterModel()
        {
            SystemModel.Register();

            AppLib.RegisterLocators();
            AppLib.RegisterBrokers();
        }
 
        /* ui */
        /// <summary>
        /// Initializes the user interface sub-system
        /// </summary>
        protected override void InitializeUi()
        {
        }
        /// <summary>
        /// Displays the main form
        /// </summary>
        protected override void ShowMainForm()
        {
            Application.Run(new MainForm());
        }



        /* construction */
        /// <summary>
        /// Construction
        /// </summary>
        public AppStarter()
        {
        }


        /* static */
        /// <summary>
        /// Initializes the <see cref="SysConfig"/> static class.
        /// </summary>
        static public void InitializeSysConfig()
        {
            Platform.IsDesktop = true;

            SysConfig.ApplicationMode = ApplicationMode.Desktop;

            SysConfig.SolutionName = "Tripous";
            SysConfig.ApplicationName = SysConfig.AppExeName;
            SysConfig.ApplicationTitle = SysConfig.ApplicationName;

            SysConfig.ObjectStoreExcludedAssemblies.AddRange(new string[] { });
            SysConfig.ObjectStoreAutoInvokeInitializers = false;

            SysConfig.DateFormat = DateTimeFormatType.Date;
            SysConfig.DateTimeFormat = DateTimeFormatType.DateTime24;
            SysConfig.TimeFormat = DateTimeFormatType.Time24;

            SysConfig.AppDataFolder = Path.GetFullPath(@"..\..\..\Data");

            SysConfig.MainAssembly = typeof(AppStarter).Assembly;
            SysConfig.GuidOids = true;
            SysConfig.VariablesPrefix = ":@";
            SysConfig.CompanyFieldName = "CompanyId";
            SysConfig.SqlConnectionsFileName = "SqlConnections.json";
            SysConfig.EnKey1 = "tripous";
            SysConfig.SelectSqlRowsLimit = 400;
            SysConfig.MachineIdRequired = false;

            SysConfig.UsersEnabled = false;
        }

    }
}
