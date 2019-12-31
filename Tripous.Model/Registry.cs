/*--------------------------------------------------------------------------------------        
                           Copyright © 2018 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Tripous.Model
{

    /// <summary>
    /// Represents the registry of the tripous business model. 
    /// </summary>
    static public class Registry
    {
        /// <summary>
        /// A list of registered descriptors
        /// </summary>
        static public SqlBrowserDescriptors Browsers { get; private set; } = new SqlBrowserDescriptors();
        /// <summary>
        /// A list of registered descriptors
        /// </summary>
        static public BrokerDescriptors Brokers { get; private set; } = new BrokerDescriptors();
        /// <summary>
        /// Returns the CodeProducers
        /// </summary>
        static public CodeDescriptors CodeProducers { get; private set; } = new CodeDescriptors();
        /// <summary>
        /// Returns the Locators
        /// </summary>
        static public LocatorDescriptors Locators { get; private set; } = new LocatorDescriptors();
        /// <summary>
        /// The main root command
        /// </summary>
        static public Command MainRootCommand { get; private set; } = new Command(CommandType.Container, "MAIN");
    }
}
