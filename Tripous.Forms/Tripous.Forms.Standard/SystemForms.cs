using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tripous.Data;
using Tripous.Model;

namespace Tripous.Forms.Standard
{
    /// <summary>
    /// Helper
    /// </summary>
    static public class SystemForms
    {
 

        /// <summary>
        /// Registration method
        /// </summary>
        static public void Register()
        {
            //CMD_SYS_COMPANY
            //Register(Type FormClass, string UniqueId, string BrokerName = "", string TextKey = "",  FormState StartState = FormState.List, FormState InvalidStates = FormState.None)
            FormOptions.Register(SqlListForm, SystemCommands.CMD_SYS_COMPANY, SysTables.Company, SystemCommands.CMD_SYS_COMPANY);
        }


        /// <summary>
        /// The type of the list form
        /// </summary>
        static public Type SqlListForm { get; set; } = typeof(Tripous.Forms.Standard.DataFormSqlBrokerList);
    }
}
