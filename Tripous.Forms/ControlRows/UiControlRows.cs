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
        public const string ControlRowCheckBox = "CheckBox";
        public const string ControlRowCheckListBox = "CheckListBox";
        public const string ControlRowComboBox = "ComboBox";
        public const string ControlRowDateTime = "DateTime";
        public const string ControlRowGrid = "Grid";
        public const string ControlRowListBox = "ListBox";
        public const string ControlRowListView = "ListView";
        public const string ControlRowMemo = "Memo";
        public const string ControlRowNumericUpDown = "NumericUpDown";
        public const string ControlRowPanel = "Panel";
        public const string ControlRowPictureBox = "PictureBox";
        public const string ControlRowTextBox = "TextBox";
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
