using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tripous.Model
{
    /// <summary>
    /// Helper
    /// </summary>
    static public class UiViews
    {
        /// <summary>
        /// Constant
        /// </summary>
        public const string TextBox = "TextBox";
        /// <summary>
        /// Constant
        /// </summary>
        public const string CheckBox = "CheckBox";
        /// <summary>
        /// Constant
        /// </summary>
        public const string DateBox = "DateBox";
        /// <summary>
        /// Constant
        /// </summary>
        public const string ComboBox = "ComboBox";
        /// <summary>
        /// Constant
        /// </summary>
        public const string ListBox = "ListBox";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Memo = "Memo";
        /// <summary>
        /// Constant
        /// </summary>
        public const string LocatorBox = "LocatorBox";
        /// <summary>
        /// Constant
        /// </summary>
        public const string NumberBox = "NumberBox";
        /// <summary>
        /// Constant
        /// </summary>
        public const string Grid = "Grid";



        static List<UiViewInfo> Views = new List<UiViewInfo>();

        static void CheckName(string Name)
        {
            if (string.IsNullOrWhiteSpace(Name))
                Sys.Error("Empty or null View Name.");
        }
        
        /// <summary>
        /// Registers a view and returns the view.
        /// </summary>
        static public UiViewInfo Register(string Name)
        {
            UiViewInfo Result = Find(Name);
            if (Result == null)
            {
                Result = new UiViewInfo();
                Result.Name = Name;
                Register(Result);
            }

            return Result;

        }
        /// <summary>
        /// Registers a view
        /// </summary>
        static public void Register(UiViewInfo View)
        {
            CheckName(View.Name);
            if (!Contains(View.Name))
                Views.Add(View);
        }

        /// <summary>
        /// Returns true if a view is already registered by a specified name.
        /// </summary>
        static public bool Contains(string Name)
        {
            return Find(Name) != null;
        }
        /// <summary>
        /// Finds and returns a view, if any, else null.
        /// </summary>
        static public UiViewInfo Find(string Name)
        {
            CheckName(Name);
            return Views.FirstOrDefault(item => item.Name.IsSameText(Name));
        }
    }
}
