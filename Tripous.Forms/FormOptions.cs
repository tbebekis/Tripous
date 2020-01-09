using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace Tripous.Forms
{

    /// <summary>
    /// Form creation options.
    /// <para>This class serves as a registry for form option instances.</para>
    /// </summary>
    public class FormOptions
    {
        /* private */
        static List<FormOptions> Registry = new List<FormOptions>();

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public FormOptions()
        {
        }
        /// <summary>
        /// Constructor
        /// </summary>
        public FormOptions(string FormClassFullName, string TextKey = "", string UniqueId = "")
        {
            this.FormClassName = FormClassFullName;
            this.UniqueId = !string.IsNullOrWhiteSpace(UniqueId) ? UniqueId : FormClassFullName;            
            this.TextKey = TextKey;

        }
        /// <summary>
        /// Constructor
        /// </summary>
        public FormOptions(Type FormClass, string TextKey = "", string UniqueId = "")
            : this(FormClass.FullName, TextKey, UniqueId)
        { 
        }

        /* static */
        /// <summary>
        /// True when a form specified by a unique id is registered.
        /// </summary>
        static public bool Contains(string UniqueId)
        {
            return Find(UniqueId) != null;
        }
        /// <summary>
        /// Finds and returns a form registered under a unique id, if any, else returns null.
        /// </summary>
        /// <param name="UniqueId"></param>
        /// <returns></returns>
        static public FormOptions Find(string UniqueId)
        {
            return !string.IsNullOrWhiteSpace(UniqueId)? Registry.FirstOrDefault(item => UniqueId.IsSameText(item.UniqueId)): null;
        }
        /// <summary>
        /// Finds and returns a form registered under a unique id, if any, else throws and exception
        /// </summary>
        static public FormOptions Get(string UniqueId)
        {
            FormOptions Result = Find(UniqueId);
            if (Result == null)
                Sys.Error($"Form not registered. UniqueId: {UniqueId}");
            return Result;
        }
        /// <summary>
        /// Returns an array with all registered forms.
        /// </summary>
        static public FormOptions[] GetList()
        {
            return Registry.ToArray();
        }
        /// <summary>
        /// Registers a form. See the properties of this class for details.
        /// </summary>
        static public FormOptions Register(Type FormClass, string UniqueId, string BrokerName = "", string TextKey = "", FormAction StartAction = FormAction.List, FormAction InvalidActions = FormAction.None)
        {
            if (string.IsNullOrWhiteSpace(UniqueId))
                Sys.Error("Can not register a form with an empty or null UniqueId");

            FormOptions Result = Find(UniqueId);
            if (Result == null)
            {
                if (string.IsNullOrWhiteSpace(BrokerName))
                    BrokerName = UniqueId;

                if (string.IsNullOrWhiteSpace(TextKey))
                    TextKey = BrokerName;

                Result = new FormOptions()
                {
                    FormClassName = FormClass.FullName,
                    UniqueId = UniqueId,
                    BrokerName = BrokerName,
                    TextKey = TextKey,
                    StartAction = StartAction,
                    InvalidActions = InvalidActions
                };

                Registry.Add(Result);
            }

            return Result;
        }

        /// <summary>
        /// Returns a string representation of this instance
        /// </summary>
        public override string ToString()
        {
            return UniqueId;
        }

        /* properties */
        /// <summary>
        /// The full class name of the form, i.e. fully qualified with its namespace.
        /// </summary>
        public string FormClassName { get; set; }
        /// <summary>
        /// The key for a resource string that is used as the caption of the form
        /// </summary>
        public string TextKey { get; set; }
        /// <summary>
        /// A string that uniquely identifies the form and this options instance. This is the registration name.
        /// </summary>
        public string UniqueId { get; private set; }
        /// <summary>
        /// The key field. Used with data-forms
        /// </summary>
        public string KeyField { get; set; } = "Id";
        /// <summary>
        /// The broker registration name. Used with data-forms
        /// </summary>
        public string BrokerName { get; set; }
        /// <summary>
        /// The first action a data form should execute.
        /// </summary>
        public FormAction StartAction { get; set; } = FormAction.List;
        /// <summary>
        /// Form action a data-form can not execute.
        /// </summary>
        public FormAction InvalidActions { get; set; }

        /// <summary>
        /// The <see cref="Type"/> of the form. Used in creating the form instance.
        /// </summary>
        [JsonIgnore]
        public Type FormClass { get { return Type.GetType(FormClassName, true); } }
        /// <summary>
        /// A user defined object. Useful with modal dialogs.
        /// </summary>
        [JsonIgnore]
        public object Result { get; set; }
        /// <summary>
        /// Used internally.
        /// </summary>
        [JsonIgnore]
        public bool AsModal { get; set; }
        /// <summary>
        /// Passed to the form when its <see cref="StartAction"/> is <see cref="FormAction.Edit"/>
        /// </summary>
        [JsonIgnore]
        public object Id { get; set; }
        /// <summary>
        /// User defined.
        /// </summary>
        [JsonIgnore]
        public Dictionary<string, object> Params { get; } = new Dictionary<string, object>();
    }
}
