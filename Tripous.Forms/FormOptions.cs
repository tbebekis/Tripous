using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace Tripous.Forms
{
    public class FormOptions
    {
        /* private */
        static List<FormOptions> Registry = new List<FormOptions>();

        /* construction */
        public FormOptions()
        {
        }
        public FormOptions(string FormClassFullName, string Text = "", string UniqueId = "")
        {
            this.UniqueId = !string.IsNullOrWhiteSpace(UniqueId) ? UniqueId : FormClassFullName;
            this.FormClassName = FormClassFullName;
            this.Text = Text;
        }
        public FormOptions(Type FormClass, string Text = "", string UniqueId = "")
            : this(FormClass.FullName, Text, UniqueId)
        { 
        }

        /* static */
        static public bool Contains(string UniqueId)
        {
            return Find(UniqueId) != null;
        }
        static public FormOptions Find(string UniqueId)
        {
            return !string.IsNullOrWhiteSpace(UniqueId)? Registry.FirstOrDefault(item => UniqueId.IsSameText(item.UniqueId)): null;
        }
        static public FormOptions[] GetList()
        {
            return Registry.ToArray();
        }
        static public FormOptions Register(string UniqueId, Type FormClass, string Text, string BrokerName, FormState StartState, FormState InvalidStates)
        {
            if (string.IsNullOrWhiteSpace(UniqueId))
                Sys.Error("Can not register a form with an empty or null UniqueId");

            FormOptions Result = Find(UniqueId);
            if (Result == null)
            {
                Result = new FormOptions(FormClass, Text)
                {
                    UniqueId = UniqueId,
                    BrokerName = BrokerName,
                    StartState = StartState,
                    InvalidStates = InvalidStates
                };

                Registry.Add(Result);
            }

            return Result;
        }

        /* properties */        
        /// <summary>
        /// The full class name of the form, i.e. fully qualified with its namespace.
        /// </summary>
        public string FormClassName { get; set; }
        public string Text { get; set; }
        public string UniqueId { get; private set; }
        public string KeyField { get; set; } = "Id";
        public string BrokerName { get; set; }
        public FormState StartState { get; set; } = FormState.List;
        public FormState InvalidStates { get; set; }

        [JsonIgnore]
        public Type FormClass { get { return Type.GetType(FormClassName, true); } }
        [JsonIgnore]
        public object Result { get; set; }
        [JsonIgnore]
        public bool AsModal { get; set; }
        [JsonIgnore]
        public object Id { get; set; }
        [JsonIgnore]
        public Dictionary<string, object> Params { get; } = new Dictionary<string, object>();
    }
}
