/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System.Data;
using System.Linq;


namespace Tripous
{


    /// <summary>
    /// Handles the external plug in modules
    /// </summary>
    static public class ExternalModules
    {

        /* private */
        static List<Assembly> fAssemblyList = new List<Assembly>();
        static List<IExternalModule> fModuleList = new List<IExternalModule>();


        /* public */
        /// <summary>
        /// Creates and returns a module (external plugin) from an assembly
        /// <para>An external module is loaded only if its mode equals to or contains the <see cref="SysConfig.ApplicationMode" /></para>
        /// </summary>
        static IExternalModule CreateModuleFrom(Assembly A)
        {
            Type AttributeType = typeof(ExternalModuleAttribute);
            Type InterfaceType = typeof(IExternalModule);
            ExternalModuleAttribute Attr;

            try
            {
                Type[] Types = A.GetTypesSafe();

                foreach (Type T in Types)
                {
                    try
                    {
                        if (T.IsClass && T.IsDefined(AttributeType, false) && T.ImplementsInterface(InterfaceType))
                        {
                            Attr = Attribute.GetCustomAttribute(T, AttributeType, false) as ExternalModuleAttribute;
                            if (Bf.Member(SysConfig.ApplicationMode, Attr.Mode))
                            {
                                return T.Create() as IExternalModule;
                            }   
                        }
                    }
                    catch
                    {
                    }
                }
            }
            catch
            {
            }

            return null;
        }

        /// <summary>
        /// Loads the external modules, if any.
        /// </summary>
        static public void LoadModules(string Prefix = "EM_", string Folder = "")
        {
            if (!Initialized)
            {
                if (string.IsNullOrWhiteSpace(Folder))
                    Folder = SysConfig.ExternalModulesFolder;

                Assembly[] List = TypeFinder.LoadAssemblies(Prefix, Folder);

                IExternalModule ExternalModule;
                foreach (Assembly A in List)
                {
                    fAssemblyList.Add(A);
                    ExternalModule = CreateModuleFrom(A);
                    if (ExternalModule != null)
                        fModuleList.Add(ExternalModule);
                }
            }
        }


        /// <summary>
        /// Initializes the modules
        /// <para>Called by the application right just after loading the module.</para>
        /// </summary>
        static public void InitializeModules()
        {
            if (!Initialized)
            {

                foreach (IExternalModule Module in fModuleList)
                    Module.ModuleInitialize();

                Initialized = true;
            }
        }
        /// <summary>
        /// Finalizes the modules
        /// </summary>
        static public void FinalizeModules()
        {
            if (Initialized)
            {
                foreach (IExternalModule Module in fModuleList)
                    Module.ModuleFinalize();

                fModuleList.Clear();
            }
        }
        /// <summary>
        /// Call external modules to register their database schemas
        /// </summary>
        static public void RegisterSchemas()
        {
            foreach (IExternalModule Module in fModuleList)
                Module.RegisterSchemas();
        }
        /// <summary>
        /// Calls the modules to register any Registry item may have
        /// </summary>
        static public void RegisterModuleItems()
        {
            foreach (IExternalModule Module in fModuleList)
                Module.RegisterItems();
        }
        /// <summary>
        /// Calls the modules to register any config provider may have
        /// </summary>
        static public void RegisterConfigProviders()
        {
            foreach (IExternalModule Module in fModuleList)
                Module.RegisterConfigProviders();
        }
        /// <summary>
        /// Informs external modules that the application initialization is done.
        /// </summary>
        static public void ApplicationInitialized()
        {
            foreach (IExternalModule Module in fModuleList)
                Module.ApplicationInitialized();
        }
        /// <summary>
        /// Informs external modules that the application finalization is about to start.
        /// </summary>
        static public void ApplicationFinalizing()
        {
            foreach (IExternalModule Module in fModuleList)
                Module.ApplicationFinalizing();
        }



 

        /// <summary>
        /// Delivers the Command to this external module (plugins) for execution.
        /// <para>If any external module executes the command, then it returns true. Else false.</para>
        /// <para>Args, if not null, may contain additional parameteres.</para>
        /// </summary>
        static public bool ExecuteCommand(string Command, IDictionary<string, object> Args = null)
        {
            if (Args == null)
                Args = new Dictionary<string, object>();

            foreach (IExternalModule Module in fModuleList)
            {
                if (Module.ExecuteCommand(Command, Args))
                    return true;
            }

            return false;
        }
        /// <summary>
        /// Handles a "module event" described by Args,
        /// by calling HandleModuleEvent(Args) on each module.
        /// </summary>
        static public void HandleModuleEvent(string EventName, IDictionary<string, object> Args)
        {
            foreach (IExternalModule Module in fModuleList)
                Module.HandleModuleEvent(EventName, Args);
        }


        /// <summary>
        /// Returns true if an IExternalModule with Name exists in the internal list
        /// </summary>
        static public bool Contains(string Name)
        {
            return fModuleList.FirstOrDefault(Item => Sys.IsSameText(Item.Name, Name)) != null;
        }
        /// <summary>
        /// Returns the module collection as an array
        /// </summary>
        static public IExternalModule[] ToArray()
        {
            return fModuleList.ToArray();
        }
        /// <summary>
        /// Returns the assemblies of the loaded modules
        /// </summary>
        static public Assembly[] GetAssemblies()
        {
            return fAssemblyList.ToArray();
        }

        /// <summary>
        /// Returns the content of this class as a DataTable
        /// <para>Returned Columns: Name, Description, FullName, OBJECT</para>
        /// </summary>
        static public DataTable ModulesToTable()
        {
            DataTable Result = new DataTable("ExternalModules");
            Result.Columns.Add("Name", typeof(string));
            Result.Columns.Add("Description", typeof(string));
            Result.Columns.Add("FullName", typeof(string));
            Result.Columns.Add("OBJECT", typeof(object));

            DataRow Row;
            foreach (IExternalModule Item in fModuleList)
            {
                Row = Result.NewRow();

                Row["Name"] = Item.Name;
                Row["Description"] = Item.Description;
                Row["FullName"] = Item.GetType().FullName;
                Row["OBJECT"] = Item;

                Result.Rows.Add(Row);
            }

            return Result;
        }

        /// <summary>
        /// True after the InitializeModules() is called
        /// </summary>
        static public bool Initialized { get; private set; }
    }

}
