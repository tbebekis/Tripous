using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tripous.Logging;

namespace Tripous.Forms
{

    /// <summary>
    /// Application initializer/finalizer
    /// </summary>
    public class AppStarterBase: IBroadcasterListener 
    {
        void IBroadcasterListener.HandleBroadcasterEvent(string EventName, IDictionary<string, object> Args)
        {
            this.HandleEvent(EventName, Args);
        }

        /* overridables */
        /// <summary>
        /// Terminates the application
        /// </summary>
        protected virtual void ExitApplication(Exception FatalException = null)
        {
            if (FatalException != null)
                Ui.ErrorBox(Sys.ExceptionText(FatalException));
            Application.Exit();
        }
        /// <summary>
        /// It represents a general event handler method for events coming from an IBroadcaster object.
        /// <para>The Args may contain an EventName element which will be the "name" of the event.</para>
        /// <para>If the Args contain a "Sender" argument, then the Value of that argument is the sender
        /// of the event.</para>
        /// </summary>
        protected virtual void HandleEvent(string EventName, IDictionary<string, object> Args)
        { 
        }

        /// <summary>
        /// Prepares the initialization
        /// </summary>
        protected virtual void InitializePrepare()
        {
            //CreateFolders();
            //EnsureMachineId();
            //ExternalModulesLoad();              /* load and initialize any plugins first */
        }
        /// <summary>
        /// Performs the login operation in the application initialization phase, if needed,
        /// and returns true on success
        /// </summary>
        protected virtual bool PerformInitializationLogin()
        {
            return false;
        }
        /// <summary>
        /// Invokes initializers
        /// </summary>
        public virtual void InvokeInitializers()
        {
            if (!SysConfig.ObjectStoreAutoInvokeInitializers)
            {
                Wait.Loading();
                try
                {
                    ObjectStore.InvokeInitializers();
                }
                finally
                {
                    Wait.Close();
                }
            }
        }

        /* layer initialization */
        /// <summary>
        /// Initializes the data sub-system
        /// </summary>
        protected virtual void InitializeData()
        {
        }
        /// <summary>
        /// Initializes the model sub-system
        /// </summary>
        protected virtual void InitializeModel()
        {
        }
        /// <summary>
        /// Initializes the user interface sub-system
        /// </summary>
        protected virtual void InitializeUi()
        {
        }
        /// <summary>
        /// Displays the main form
        /// </summary>
        protected virtual void ShowMainForm()
        {
        }

        /* notifications */
        /// <summary>
        /// Notification
        /// </summary>
        protected virtual void ApplicationInitialized()
        {
        }
        /// <summary>
        /// Notification
        /// </summary>
        protected virtual void ExternalModulesApplicationInitialized()
        {
        }
        /// <summary>
        /// Notification
        /// </summary>
        protected virtual void ExternalModulesApplicationFinalizing()
        {
        }
        /// <summary>
        /// Notification
        /// </summary>
        protected virtual void ApplicationFinalizing()
        {
        }
        /// <summary>
        /// Notification
        /// </summary>
        protected virtual void SaveUserSettings()
        {
        }
        /// <summary>
        /// Notification
        /// </summary>
        protected virtual void TerminateThreadStarter()
        {
        }
        /// <summary>
        /// Notification
        /// </summary>
        protected virtual void ExternalModulesUnLoad()
        {
        }

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public AppStarterBase()
        {
            if (Instance != null)
                Sys.Error("Application Starter is already created.");
            Instance = this;

            Broadcaster.Add(this);
        }
 
        /* public */
        /// <summary>
        /// Initializes the application
        /// </summary>
        public virtual void ApplicationInitialize()
        {
            if (!Initialized)
            {
                Initializing = true;
                try
                {

                    /* preparation ================================================================ */
                    Wait.Loading();
                    try
                    {
                        InitializePrepare();
                    }
                    finally
                    {
                        Wait.Close();
                    }


                    /* data ======================================================================== */
                    InitializeData();


                    /* login ======================================================================= */
                    if (SysConfig.UsersEnabled)
                    {
                        if (!PerformInitializationLogin())
                        {
                            return;
                        }
                    }


                    /* initializers ================================================================= */
                    InvokeInitializers();


                    /* model ======================================================================== */
                    InitializeModel();


                    /* ui ========================================================================== */
                    ShowMainForm();
                    InitializeUi();

                    Initialized = true;
                }
                catch (Exception Ex)
                {

                    string Source = this.GetType().Name;
                    string ScopeId = "ApplicationInitialize";
                    string EventId = "";
                    LogLevel Level = LogLevel.Fatal;
                    string Text = "A fatal error occured"; 
                    string Folder = SysConfig.AppDataFolder;
                    LogInfo LI = new LogInfo(Source, ScopeId, EventId, Level, Ex, Text);

                    LI.SaveToFile(Folder);
                    Logger.Log(LI);

                    ExitApplication(Ex);
                }
                finally
                {
                    Initializing = false;
                }
 
                ApplicationInitialized();
                ExternalModulesApplicationInitialized();
            }
        }
        /// <summary>
        /// Finalizes the application
        /// </summary>
        public virtual void ApplicationFinalize()
        {
            if (Initialized && !Finalized)
            {
                Finalizing = true;

                Wait.Show(Res.GS("TerminatingApplication", "Terminating"));
                try
                {
                    ExternalModulesApplicationFinalizing();
                    ApplicationFinalizing();
                    SaveUserSettings();
                    TerminateThreadStarter();

                    Finalized = true;

                    ExternalModulesUnLoad();
                }
                catch (Exception Ex)
                {
                    string Source = this.GetType().Name;
                    string ScopeId = "ApplicationFinalize";
                    string EventId = "";
                    LogLevel Level = LogLevel.Fatal;
                    string Text = "A fatal error occured";
                    string Folder = SysConfig.AppDataFolder;
                    LogInfo LI = new LogInfo(Source, ScopeId, EventId, Level, Ex, Text);

                    LI.SaveToFile(Folder);
                    Logger.Log(LI);
                }
                finally
                {
                    Finalizing = false;
                    Wait.Close();
                }

            }
        }
        /// <summary>
        /// Should be called by the main form in order to signal that the main ui is ready
        /// </summary>
        public virtual void ApplicationMainUiIsReady()
        {
        }


        /* properties */
        /// <summary>
        /// True when initialized
        /// </summary>
        public bool Initialized { get; private set; }
        /// <summary>
        /// True when initializing
        /// </summary>
        public bool Initializing { get; private set; }
        /// <summary>
        /// True when finalized
        /// </summary>
        public bool Finalized { get; private set; }
        /// <summary>
        /// True when finalizing
        /// </summary>
        public bool Finalizing { get; private set; }

        /// <summary>
        /// Singleton instance
        /// </summary>
        static public AppStarterBase Instance { get; private set; }
    }
}
