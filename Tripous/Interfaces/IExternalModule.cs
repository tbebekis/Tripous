/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;

namespace Tripous
{
    /// <summary>
    /// Represents a dynamically loadable (plugin) external module (assembly).
    /// </summary>
    public interface IExternalModuleBase
    {
    }

    /// <summary>
    /// Represents a plug in external module (assembly), that is loaded dynamically by the application
    /// </summary>
    public interface IExternalModule: IExternalModuleBase
    {
        /* methods */
        /// <summary>
        /// Initializes the module.
        /// <para>Called by the application right just after loading the module.</para>
        /// </summary>
        void ModuleInitialize();
        /// <summary>
        /// Signals the module that the application initialization is done.
        /// </summary>
        void ApplicationInitialized();
        /// <summary>
        /// Signals the module that the application finalization is about to start.
        /// </summary>
        void ApplicationFinalizing();
        /// <summary>
        /// Finalizes the module.
        /// <para>Called by the application right just after the application is done its own finalization.</para>
        /// </summary>
        void ModuleFinalize();

        /// <summary>
        /// Signals the module to register its database schema
        /// </summary>
        void RegisterSchemas();
        /// <summary>
        /// Signals the module to register any Registry items may have (commands, brokers, forms, etc)
        /// </summary>
        void RegisterItems();
        /// <summary>
        /// Signals the module to register any ConfigProvider may have
        /// </summary>
        void RegisterConfigProviders();
 
        /// <summary>
        /// Delivers the Command to this external module (plugins) for execution.
        /// <para>If any external module executes the command, then it returns true. Else false.</para>
        /// <para>Args may contain additional parameteres.</para>
        /// </summary>
        bool ExecuteCommand(string Command, IDictionary<string, object> Args);

        /// <summary>
        /// Called by the system, passing information on an operation that may be executed by the module.
        /// </summary>
        void HandleModuleEvent(string EventName, IDictionary<string, object> Args);

        /* properties */
        /// <summary>
        /// Gets the name of the module
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Returns a short description about the external module.
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Returns true if this module has a settings dialog to display.
        /// <para>Defaults to false.</para>
        /// </summary>
        bool SupportsSettingsDialog { get; }
    }
}
