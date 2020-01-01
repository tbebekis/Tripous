using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using Tripous;
using Tripous.Logging;
using Tripous.Forms;

namespace DevApp.WinForms
{

    /// <summary>
    /// Program, startup class.
    /// </summary>
    static class Program
    {
        /* private */
        /// <summary>
        /// this is of a little use because it actually is a notification about an exception, NOT a catcher. 
        /// <para>WARNING: An unhandled exception in ANY thread terminates the application. </para>
        /// </summary>
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                if ((e.ExceptionObject is Exception) && !e.IsTerminating)
                {
                    Logger.Error(e.ExceptionObject as Exception);
                }
                else
                {
                    Logger.Error(e.ExceptionObject.ToString());
                }
            }
            catch
            {
            }
        }
        /// <summary>
        /// Global exception catcher for unhandled exceptions thrown by the primary (UI) thread.
        /// </summary>
        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                Ui.OnUnhandledExceptionThrown(e.Exception);
                Logger.Error(e.Exception);
                Ui.ErrorBox(Sys.ExceptionText(e.Exception));
            }
            catch
            {
            }
        }
 

        /* construction */
        /// <summary>
        /// Static constructor. Setups unhandled exception event handlers.
        /// </summary>
        static Program()
        {
            Application.ThreadException += Application_ThreadException;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
        }

        /* main */
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            App.Start();


            //Application.Run(new MainForm());
        }
    }
}
