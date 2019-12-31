using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tripous;
using Tripous.Forms;

namespace DevApp.WinForms
{

    /// <summary>
    /// Application initializer/finalizer
    /// </summary>
    class AppStarter : AppStarterBase
    {
        /* overrides */
        protected override bool PerformInitializationLogin()
        {
            MessageBox.Show("This is the login dialog");
            return true;
        }
        /// <summary>
        /// Displays the main form
        /// </summary>
        protected override void ShowMainForm()
        {
            Application.Run(new MainForm());
        }


        public AppStarter()
        {
        }


        static public void InitializeSysConfig()
        {
            Platform.IsDesktop = true;

            SysConfig.ApplicationMode = ApplicationMode.Desktop;
            SysConfig.CompanyId = null;

            SysConfig.SolutionName = "Tripous";
            SysConfig.ApplicationName = SysConfig.AppExeName;
            SysConfig.ApplicationTitle = SysConfig.ApplicationName;

            SysConfig.ObjectStoreExcludedAssemblies.AddRange(new string[] { });
            SysConfig.ObjectStoreAutoInvokeInitializers = false;

            SysConfig.DateFormat = DateTimeFormatType.Date;
            SysConfig.DateTimeFormat = DateTimeFormatType.DateTime24;
            SysConfig.TimeFormat = DateTimeFormatType.Time24;

            SysConfig.MainAssembly = typeof(AppStarter).Assembly;
            SysConfig.GuidOids = true;
            SysConfig.VariablesPrefix = ":@";
            SysConfig.CompanyFieldName = "CompanyId";
            SysConfig.SqlConnectionsFileName = "SqlConnections.json";
            SysConfig.EnKey1 = "tripous";
            SysConfig.SelectSqlRowsLimit = 400;
            SysConfig.MachineIdRequired = false;

            SysConfig.UsersEnabled = true;
        }

    }
}
