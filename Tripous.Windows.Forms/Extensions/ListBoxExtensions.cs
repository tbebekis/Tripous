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
    static public class ListBoxExtensions
    {
        /// <summary>
        /// Returns true if Index is in valid range regarding ListBox.Items
        /// </summary>
        static public bool IsValidIndex(this ListBox ListBox, int Index)
        {
            return (ListBox != null) && (Index >= 0) && (Index < ListBox.Items.Count);
        }
        /// <summary>
        /// Sets the Index as the SelectedIndex of ListBox in a safe manner
        /// </summary>
        static public int SetIndex(this ListBox ListBox, int Index)
        {
            if (ListBox != null)
            {
                if ((Index >= 0) && (Index < ListBox.Items.Count))
                    ListBox.SelectedIndex = Index;
                else if (ListBox.Items.Count > 0)
                    ListBox.SelectedIndex = 0;

                return ListBox.SelectedIndex;
            }

            return -1;
        }
        /// <summary>
        /// Clears the passed Control and adds Items to its Items.
        /// </summary>
        static public void RefreshItems(this ListBox Control, object[] Items)
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
    }

}

 