using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

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
            : this(Type.GetType(FormClassFullName, true, true), Text, UniqueId)
        {
        }
        public FormOptions(Type FormClass, string Text = "", string UniqueId = "")
        {
            this.UniqueId = !string.IsNullOrWhiteSpace(UniqueId)? UniqueId: FormClass.FullName;
            this.FormClass = FormClass;
            this.Text = Text;
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
        public Type FormClass { get; set; }
        public string Text { get; set; }
        public string UniqueId { get; private set; }
        public string KeyField { get; set; } = "Id";
        public object Result { get; set; }
        public bool AsModal { get; set; }
        public object Id { get; set; }
        public string BrokerName { get; set; }
        public FormState StartState { get; set; } = FormState.List;
        public FormState InvalidStates { get; set; }
        public Dictionary<string, object> Params { get; } = new Dictionary<string, object>();
    }
}
