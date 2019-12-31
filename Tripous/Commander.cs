/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Data;
using System.Diagnostics;


namespace Tripous
{

    /// <summary>
    /// Executes commands by calling registered command handlers.
    /// <para>Registers automatically any class implementing the <see cref="ICommandHandler"/> interface.
    /// </para>
    /// </summary>
    static public class Commander
    {
        
        static private List<Assembly> Assemblies = new List<Assembly>();
        static private List<ICommandHandler> Handlers = new List<ICommandHandler>();

        /* construction */
        /// <summary>
        /// Static constructor
        /// </summary>
        static Commander()
        {
            Assembly[] Items = TypeFinder.GetDomainAssemblies(true);

            foreach (Assembly Assembly in Items)
            {
                Register(Assembly);
            }
        }

        /* public */
        /// <summary>
        /// Registers Assembly by creating ICommandExecutor instances
        /// of all classes contained into Assembly implementing the <see cref="ICommandHandler"/> interface.
        /// </summary>
        static public void Register(Assembly Assembly)
        {
            if (!Assemblies.Contains(Assembly))
            {
                Assemblies.Add(Assembly);
                Type[] Types = Assembly.GetTypesSafe();

                foreach (Type T in Types)
                {
                    try
                    {
                        if (T.IsClass && T.ImplementsInterface(typeof(ICommandHandler)))
                        {
                            Register(Activator.CreateInstance(T) as ICommandHandler);
                        }
                    }
                    catch (Exception Ex)
                    {
                        Debug.WriteLine("{0}: {1}", Ex.GetType().Name, Ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Executes a specified command by sending the command to the proper handler, if any.
        /// </summary>
        static public void Execute(Command Command)
        { 
            foreach (ICommandHandler Hanlder in Handlers)
            {
                if (Hanlder.Execute(Command))
                    return;
            }
        }
        /// <summary>
        /// Handles the property change of the specified command.
        /// </summary>
        static public void EnabledChanged(Command Command)
        {
            foreach (ICommandHandler Hanlder in Handlers)
            {
                Hanlder.EnabledChanged(Command);
            }
        }
        /// <summary>
        /// Handles the property change of the specified command.
        /// </summary>
        static public void VisibleChanged(Command Command)
        {
            foreach (ICommandHandler Hanlder in Handlers)
            {
                Hanlder.VisibleChanged(Command);
            }
        }


        /// <summary>
        /// Adds a command handler to the internal list of command handlers
        /// </summary>
        static public void Register(ICommandHandler Hanlder)
        {
            if (!Handlers.Contains(Hanlder))
            {
                Handlers.Add(Hanlder);
            }
        }
        /// <summary>
        /// Removes a previously registered command handler from the internal list of command handlers
        /// </summary>
        static public void Remove(ICommandHandler Hanlder)
        {
            Handlers.Remove(Hanlder);
        }
    }



}
