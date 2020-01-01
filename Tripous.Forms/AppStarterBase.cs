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

        /* preparation */
        /// <summary>
        /// Initializes any libraries that are dependencies of this appliation
        /// </summary>
        protected virtual void InitializeLibraries()
        {
        }
        /// <summary>
        /// Prepares the initialization
        /// </summary>
        protected virtual void PrepareStart()
        {
            //CreateFolders();
            //EnsureMachineId();
            //ExternalModulesLoad();              /* load and initialize any plugins first */
        }
        /// <summary>
        /// Performs the login operation in the application initialization phase, if needed,
        /// and returns true on success
        /// </summary>
        protected virtual bool PerformStartupLogin()
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
        protected virtual void InitializeDatabases()
        {
        }
        /// <summary>
        /// Initializes the model sub-system
        /// </summary>
        protected virtual void RegisterModel()
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
        protected virtual void ApplicationStarted()
        {
        }
        /// <summary>
        /// Notification
        /// </summary>
        protected virtual void ExternalModulesApplicationStarted()
        {
        }
        /// <summary>
        /// Notification
        /// </summary>
        protected virtual void ExternalModulesApplicationStopping()
        {
        }
        /// <summary>
        /// Notification
        /// </summary>
        protected virtual void ApplicationStopping()
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
        public virtual void Start()
        {
            if (!IsStarted)
            {
                IsStarting = true;
                try
                {                    

                    /* preparation ================================================================ */
                    Wait.Loading();
                    try
                    {
                        InitializeLibraries();
                        PrepareStart();
                    }
                    finally
                    {
                        Wait.Close();
                    }


                    /* databases ======================================================================== */
                    InitializeDatabases();


                    /* login ======================================================================= */
                    if (SysConfig.UsersEnabled)
                    {
                        if (!PerformStartupLogin())
                        {
                            return;
                        }
                    }


                    /* initializers ================================================================= */
                    InvokeInitializers();


                    /* model ======================================================================== */
                    RegisterModel();


                    /* ui ========================================================================== */
                    ShowMainForm();
                    InitializeUi();

                    IsStarted = true;
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
                    IsStarting = false;
                }
 
                ApplicationStarted();
                ExternalModulesApplicationStarted();
            }
        }
        /// <summary>
        /// Finalizes the application
        /// </summary>
        public virtual void Stop()
        {
            if (IsStarted && !IsStopped)
            {
                IsStopping = true;

                Wait.Show(Res.GS("TerminatingApplication", "Terminating"));
                try
                {
                    ExternalModulesApplicationStopping();
                    ApplicationStopping();
                    SaveUserSettings();
                    TerminateThreadStarter();

                    IsStopped = true;

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
                    IsStopping = false;
                    Wait.Close();
                }

            }
        }
        /// <summary>
        /// Should be called by the main form in order to signal that the main ui is ready
        /// </summary>
        public virtual void MainUiIsReady()
        {
        }


        /* properties */
        /// <summary>
        /// True when initialized
        /// </summary>
        public bool IsStarted { get; private set; }
        /// <summary>
        /// True when initializing
        /// </summary>
        public bool IsStarting { get; private set; }
        /// <summary>
        /// True when finalized
        /// </summary>
        public bool IsStopped { get; private set; }
        /// <summary>
        /// True when finalizing
        /// </summary>
        public bool IsStopping { get; private set; }

        /// <summary>
        /// Singleton instance
        /// </summary>
        static public AppStarterBase Instance { get; private set; }
    }
}
