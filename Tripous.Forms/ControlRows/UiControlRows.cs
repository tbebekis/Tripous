using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tripous.Forms
{
    /// <summary>
    /// Helper
    /// </summary>
    static public class UiControlRows
    {
        /// <summary>
        /// Constant
        /// </summary>
        public const string ControlRowCheckBox = "CheckBox";
        /// <summary>
        /// Constant
        /// </summary>
        public const string ControlRowCheckListBox = "CheckListBox";
        /// <summary>
        /// Constant
        /// </summary>
        public const string ControlRowComboBox = "ComboBox";
        /// <summary>
        /// Constant
        /// </summary>
        public const string ControlRowDateTime = "DateTime";
        /// <summary>
        /// Constant
        /// </summary>
        public const string ControlRowGrid = "Grid";
        /// <summary>
        /// Constant
        /// </summary>
        public const string ControlRowListBox = "ListBox";
        /// <summary>
        /// Constant
        /// </summary>
        public const string ControlRowListView = "ListView";
        /// <summary>
        /// Constant
        /// </summary>
        public const string ControlRowMemo = "Memo";
        /// <summary>
        /// Constant
        /// </summary>
        public const string ControlRowNumericUpDown = "NumericUpDown";
        /// <summary>
        /// Constant
        /// </summary>
        public const string ControlRowPanel = "Panel";
        /// <summary>
        /// Constant
        /// </summary>
        public const string ControlRowPictureBox = "PictureBox";
        /// <summary>
        /// Constant
        /// </summary>
        public const string ControlRowTextBox = "TextBox";
        /// <summary>
        /// Constant
        /// </summary>
        public const string ControlRowTreeView = "TreeView";


        /// <summary>
        /// ControlRow types
        /// </summary>
        static public Dictionary<string, Type> Types = new Dictionary<string, Type>()
        {
            {ControlRowCheckBox      , typeof(CheckBoxControlRow)},
            {ControlRowCheckListBox  , typeof(CheckListBoxControlRow)},
            {ControlRowComboBox      , typeof(ComboBoxControlRow)},
            {ControlRowDateTime      , typeof(DateBoxControlRow)},
            {ControlRowGrid          , typeof(GridControlRow)},
            {ControlRowListBox       , typeof(ListBoxControlRow)},
            {ControlRowListView      , typeof(ListViewControlRow)},
            {ControlRowMemo          , typeof(MemoControlRow)},
            {ControlRowNumericUpDown , typeof(NumericBoxControlRow)},
            {ControlRowPanel         , typeof(PanelControlRow)},
            {ControlRowPictureBox    , typeof(PictureBoxControlRow)},
            {ControlRowTextBox       , typeof(TextBoxControlRow)},
            {ControlRowTreeView      , typeof(TreeViewControlRow)},
        };


        /*
        CheckBox                      
        CheckListBox
        ComboBox
        DateTime
        Grid
        ListBox
        ListView
        Memo
        NumericUpDown
        Panel
        PictureBox
        TextBox
        TreeView
                 */
    }
}
