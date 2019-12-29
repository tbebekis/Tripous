/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

 
using System;
using System.Collections;
using System.Windows.Forms;

namespace Tripous.Windows.Forms
{
    /// <summary>
    /// Extensions
    /// </summary>
    static public class ComboBoxExtensions
    {
        /// <summary>
        /// Returns true if Index is in valid range regarding ComboBox.Items
        /// </summary>
        static public bool IsValidIndex(this ComboBox ComboBox, int Index)
        {
            return (ComboBox != null) && (Index >= 0) && (Index < ComboBox.Items.Count);
        }
        /// <summary>
        /// Sets the Index as the SelectedIndex of ComboBox in a safe manner
        /// </summary>
        static public int SetIndex(this ComboBox ComboBox, int Index)
        {
            if (ComboBox != null)
            {
                if ((Index >= 0) && (Index < ComboBox.Items.Count))
                    ComboBox.SelectedIndex = Index;
                else if (ComboBox.Items.Count > 0)
                    ComboBox.SelectedIndex = 0;

                return ComboBox.SelectedIndex;
            }

            return -1;
        }
        /// <summary>
        /// Clears the passed Control and adds Items to its Items.
        /// </summary>
        static public void RefreshItems(this ComboBox Control, object[] Items)
        {
            if ((Control != null) && (Items != null))
            {
                int Index = Control.SelectedIndex;

                Control.BeginUpdate();
                try
                {
                    Control.Items.Clear();

                    if (Items.Length > 0)
                    {
                        foreach (object Item in Items)
                            Control.Items.Add(Item);
                    }

                    SetIndex(Control, Index);
                }
                finally
                {
                    Control.EndUpdate();
                }
            }
        }

        /// <summary>
        /// Adds EnumType values to the items of the ComboBox starting from the FirstIndex enum value.
        /// </summary>
        static public void EnumToItems(this ComboBox ComboBox, Type EnumType, int FirstIndex)
        {
            Array Values = Bf.EnumGetValues(EnumType);
            for (int i = FirstIndex; i < Values.Length; i++)
                ComboBox.Items.Add(Values.GetValue(i));
        }
        /// <summary>
        /// Adds EnumType values to the items of the ComboBox starting from the first enum value.
        /// </summary>
        static public void EnumToItems(this ComboBox ComboBox, Type EnumType)
        {
            EnumToItems(ComboBox, EnumType, 0);
        }
        /// <summary>
        /// Adds EnumType value names (strings) to the items of the ComboBox starting from the FirstIndex enum value.
        /// </summary>
        static public void EnumToItemsResText(this ComboBox ComboBox, Type EnumType, int FirstIndex)
        {
            string[] Names = Bf.EnumGetNames(EnumType);
            for (int i = FirstIndex; i < Names.Length; i++)
                ComboBox.Items.Add(Sys.SplitCamelCase(Names[i]));
        }
        /// <summary>
        /// Adds EnumType value names (strings) to the items of the ComboBox starting from the first enum value.
        /// </summary>
        static public void EnumToItemsResText(this ComboBox ComboBox, Type EnumType)
        {
            EnumToItemsResText(ComboBox, EnumType, 0);
        }

 
        /// <summary>
        /// Adds EnumType values to the items of the ComboBox starting from the FirstIndex enum value.
        /// </summary>
        static public void EnumToItems(this ToolStripComboBox ComboBox, Type EnumType, int FirstIndex)
        {
            Array Values = Bf.EnumGetValues(EnumType);
            for (int i = FirstIndex; i < Values.Length; i++)
                ComboBox.Items.Add(Values.GetValue(i));
        }
        /// <summary>
        /// Adds EnumType values to the items of the ComboBox starting from the first enum value.
        /// </summary>
        static public void EnumToItems(this ToolStripComboBox ComboBox, Type EnumType)
        {
            EnumToItems(ComboBox, EnumType, 0);
        }
        /// <summary>
        /// Adds EnumType value names (strings) to the items of the ComboBox starting from the FirstIndex enum value.
        /// </summary>
        static public void EnumToItemsResText(this ToolStripComboBox ComboBox, Type EnumType, int FirstIndex)
        {
            string[] Names = Bf.EnumGetNames(EnumType);
            for (int i = FirstIndex; i < Names.Length; i++)
                ComboBox.Items.Add(Sys.SplitCamelCase(Names[i]));
        }
        /// <summary>
        /// Adds EnumType value names (strings) to the items of the ComboBox starting from the first enum value.
        /// </summary>
        static public void EnumToItemsResText(this ToolStripComboBox ComboBox, Type EnumType)
        {
            EnumToItemsResText(ComboBox, EnumType, 0);
        }
 

    }


 

}

 