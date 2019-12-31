using System;
using System.Collections.Generic;
using System.Text;



namespace Tripous.Model
{
    /// <summary>
    /// Helper
    /// </summary>
    static public class SystemCommands
    {
        /* system commands */
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_FILE = "CMD_FILE";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_LOGIN = "CMD_LOGIN";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_LOGOUT = "CMD_LOGOUT";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_APP_SYS_INFO = "CMD_APP_SYS_INFO";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_EXIT = "CMD_EXIT";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_VIEW = "CMD_VIEW";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_DASHBOARD_ITEMS_ADMIN = "CMD_DASHBOARD_ITEMS_ADMIN";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_DASHBOARDS_ADMIN = "CMD_DASHBOARDS_ADMIN";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_DASHBOARDS = "CMD_DASHBOARDS";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_TOOL_BAR = "CMD_TOOL_BAR";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_SIDE_BAR = "CMD_SIDE_BAR";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_SQL_MONITOR = "CMD_SQL_MONITOR";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_SYS_LOG = "CMD_SYS_LOG";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_SYNTAX_EDIT = "CMD_SYNTAX_EDIT";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_SCRIPT_EDIT = "CMD_SCRIPT_EDIT";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_HTML_EDIT = "CMD_HTML_EDIT";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_SYS_DOCS = "CMD_SYS_DOCS";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_GLOBAL_REPORTS_MENU = "CMD_GLOBAL_REPORTS_MENU";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_GLOBAL_PROJECTORS_MENU = "CMD_GLOBAL_PROJECTORS_MENU";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_GLOBAL_PIVOT_PROJECTORS_MENU = "CMD_GLOBAL_PIVOT_PROJECTORS_MENU";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_GLOBAL_REPORTS_ADMIN = "CMD_GLOBAL_REPORTS_ADMIN";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_GLOBAL_PROJECTORS_ADMIN = "CMD_GLOBAL_PROJECTORS_ADMIN";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_GLOBAL_PIVOT_PROJECTORS_ADMIN = "CMD_GLOBAL_PIVOT_PROJECTORS_ADMIN";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_COMMAND_SETS_EDIT = "CMD_COMMAND_SETS_EDIT";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_USER_SETTINGS = "CMD_USER_SETTINGS";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_APP_SETTINGS = "CMD_APP_SETTINGS";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_SYSTEM = "CMD_SYSTEM";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_ACCESS = "CMD_ACCESS";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_WINDOWS = "CMD_WINDOWS";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_WIN_CASCADE = "CMD_WIN_CASCADE";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_WIN_TILE_HORZ = "CMD_WIN_TILE_HORZ";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_WIN_TILE_VERT = "CMD_WIN_TILE_VERT";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_WIN_ARRANGE_ICONS = "CMD_WIN_ARRANGE_ICONS";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_WIN_CLOSE_ALL = "CMD_WIN_CLOSE_ALL";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_HELP = "CMD_HELP";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_ABOUT = "CMD_ABOUT";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_APP_CONFIGURATION = "CMD_APP_CONFIGURATION";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_ADMIN = "CMD_ADMIN";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_LOCATOR_LIST = "CMD_LOCATOR_LIST";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_SYS_COMPANY = "CMD_SYS_COMPANY";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_SYS_LANG = "CMD_SYS_LANG";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_SYS_STRRES = "CMD_SYS_STRRES";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CMD_SYS_SMTP_PROVIDERS = "CMD_SYS_SMTP_PROVIDERS";




        /// <summary>
        /// Registration method
        /// </summary>
        static public void RegisterCommands()
        {
            Command P = Registry.MainRootCommand;
            Command Cn;

            /* FILE */
            Cn = P.AddContainer(CMD_FILE, CMD_FILE);
            if (SysConfig.UsersEnabled)
            {
                Cn.Add(CMD_LOGIN, CMD_LOGIN);
                Cn.Add(CMD_LOGOUT, CMD_LOGOUT);
            }                

            Cn.Add(CMD_APP_SYS_INFO, CMD_APP_SYS_INFO);

            Cn.Add(CMD_EXIT, CMD_EXIT);

            /* VIEW */
            Cn = P.AddContainer(CMD_VIEW, CMD_VIEW);
            /*
            Cn.Add(CMD_GLOBAL_REPORTS_MENU, CMD_GLOBAL_REPORTS_MENU);
            Cn.Add(CMD_GLOBAL_PROJECTORS_MENU, CMD_GLOBAL_REPORTS_MENU);
            Cn.Add(CMD_GLOBAL_PIVOT_PROJECTORS_MENU, CMD_GLOBAL_REPORTS_MENU);
            Cn.AddSeparator();
            if (Sys.Variables.ValueOf("UseDashboards", false))
            {
                Cn.Add(CMD_DASHBOARDS, CMD_DASHBOARDS);
                Cn.AddSeparator();
            }
            Cn.Add(CMD_SYS_DOCS, CMD_SYS_DOCS);
            Cn.AddSeparator();

            Cn.Add(CMD_SYNTAX_EDIT, CMD_SYNTAX_EDIT);
            Cn.Add(CMD_SCRIPT_EDIT, CMD_SCRIPT_EDIT);
            Cn.Add(CMD_HTML_EDIT, CMD_HTML_EDIT);
            Cn.AddSeparator();
            */
            Cn.Add(CMD_SQL_MONITOR, CMD_SQL_MONITOR);
            Cn.AddSeparator();
            Cn.Add(CMD_SYS_LOG, CMD_SYS_LOG);

            /* APP_CONFIGURATION */
            Cn = P.AddContainer(CMD_APP_CONFIGURATION, CMD_APP_CONFIGURATION);
            Cn.Add(CMD_TOOL_BAR, CMD_TOOL_BAR);
            Cn.Add(CMD_SIDE_BAR, CMD_SIDE_BAR);
            /*
            Cn.AddSeparator();
            Cn.Add(CMD_USER_SETTINGS, CMD_USER_SETTINGS);
            Cn.Add(CMD_APP_SETTINGS, CMD_APP_SETTINGS);
            Cn.AddSeparator();
            Cn.Add(CMD_GLOBAL_REPORTS_ADMIN, CMD_GLOBAL_REPORTS_ADMIN);
            Cn.Add(CMD_GLOBAL_PROJECTORS_ADMIN, CMD_GLOBAL_PROJECTORS_ADMIN);
            Cn.Add(CMD_GLOBAL_PIVOT_PROJECTORS_ADMIN, CMD_GLOBAL_PIVOT_PROJECTORS_ADMIN);
            if (Sys.Variables.ValueOf("UseDashboards", false))
            {
                Cn.AddSeparator();
                Cn.Add(CMD_DASHBOARD_ITEMS_ADMIN, CMD_DASHBOARD_ITEMS_ADMIN);
                Cn.Add(CMD_DASHBOARDS_ADMIN, CMD_DASHBOARDS_ADMIN);
                Cn.AddSeparator();
            }
            Cn.Add(CMD_COMMAND_SETS_EDIT, CMD_COMMAND_SETS_EDIT);
            Cn.AddSeparator();
            Cn.Add(CMD_LOCATOR_LIST, CMD_LOCATOR_LIST);
            */

            /* SYSTEM */
            Cn = P.AddContainer(CMD_SYSTEM, CMD_SYSTEM);
            Cn.Add(CMD_SYS_COMPANY, CMD_SYS_COMPANY);
            Cn.AddSeparator();
 
            Cn.Add(CMD_SYS_LANG, CMD_SYS_LANG);
            //Cn.Add(CMD_SYS_STRRES, CMD_SYS_STRRES);
            Cn.AddSeparator();
            Cn.Add(CMD_SYS_SMTP_PROVIDERS, CMD_SYS_SMTP_PROVIDERS);
 
            /* WINDOWS */
            Cn = P.AddContainer(CMD_WINDOWS, CMD_WINDOWS);
            Cn.Add(CMD_WIN_CASCADE, CMD_WIN_CASCADE);
            Cn.Add(CMD_WIN_TILE_HORZ, CMD_WIN_TILE_HORZ);
            Cn.Add(CMD_WIN_TILE_VERT, CMD_WIN_TILE_VERT);
            Cn.Add(CMD_WIN_ARRANGE_ICONS, CMD_WIN_ARRANGE_ICONS);
            Cn.Add(CMD_WIN_CLOSE_ALL, CMD_WIN_CLOSE_ALL);
            Cn.AddSeparator();

            /* HELP */
            Cn = P.AddContainer(CMD_HELP, CMD_HELP);
            Cn.Add(CMD_ABOUT, CMD_ABOUT);

            string[] DesktopExclude = { CMD_LOGOUT };
            string[] WebExclude = { CMD_EXIT, CMD_WINDOWS, CMD_WIN_CASCADE, CMD_WIN_TILE_HORZ, CMD_WIN_TILE_VERT, CMD_WIN_ARRANGE_ICONS, CMD_WIN_CLOSE_ALL };

            List<Command> List = P.GetFlatList();
            foreach (var Item in List)
            {
                if (DesktopExclude.ContainsText(Item.Name))
                {
                    Item.UiMode = (UiMode)Bf.Subtract(Item.UiMode, UiMode.Desktop);
                }
                if (WebExclude.ContainsText(Item.Name))
                {
                    Item.UiMode = (UiMode)Bf.Subtract(Item.UiMode, UiMode.Web);
                }
            }
        }
    }
}
