using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Tripous.Windows.Forms
{
    public class FormOptions
    {
        public FormOptions()
        {
        }
        public FormOptions(string FormClassFullName, string Text = "")
            : this(Type.GetType(FormClassFullName, true, true), Text)
        {
        }
        public FormOptions(Type FormClass, string Text = "")
        {
            this.FormClass = FormClass;
            this.Text = Text;
        }

        public Type FormClass { get; set; }
        //public string FormClassFullName { get; set; } 
        public string Text { get; set; }
        public object Result { get; set; }
        public Dictionary<string, object> Params { get; } = new Dictionary<string, object>();
    }
}
