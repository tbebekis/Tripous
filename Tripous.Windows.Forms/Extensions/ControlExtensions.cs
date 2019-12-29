/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

 
using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Drawing;
using System.Linq;
using System.IO;



namespace Tripous.Windows.Forms
{

    /// <summary>
    /// Extensions
    /// </summary>
    static public class ControlExtensions
    {
        /// <summary>
        /// Returns true if the mouse cursor is over the Control
        /// </summary>
        static public bool IsUnderMouse(this Control Control, Point P)
        {
            if ((Control != null) && (Control.Parent != null))
            {
                P = Control.PointToClient(P);
                return Control.Bounds.Contains(P);
            }

            return false;
        }
        /// <summary>
        /// Returns a Label control associated to the Instance, if any, else null.
        /// <para>The Label control must be at the left side of the Instance.</para>
        /// </summary>
        static public Label FindLabel(this Control Instance)
        {
            if ((Instance != null) && !(Instance is CheckBox) && (Instance.Parent != null))
            {
                Point P = new Point(Instance.Left - 15, Instance.Top + 8);
                return Instance.Parent.GetChildAt(P) as Label;
            }

            return null;
        }

        /// <summary>
        /// Centers Control vertically
        /// </summary>
        static public void CenterVertically(this Control Control)
        {
            if ((Control != null) && (Control.Parent != null))
                Control.Top = (Control.Parent.Height - Control.Height) / 2;
        }
        /// <summary>
        /// Centers Control horizontally
        /// </summary>
        static public void CenterHorizontally(this Control Control)
        {
            if ((Control != null) && (Control.Parent != null))
                Control.Left = (Control.Parent.Width - Control.Width) / 2;
        }

        /// <summary>
        /// Saves Control text to the FileName file. Control can be a ListBox, a ComboBox, or a TextBox
        /// </summary>
        static public void SaveControlTextToFile(this Control Control, string FileName)
        {
            if (Control != null)
                File.WriteAllText(FileName, ControlToText(Control));
        }
        /// <summary>
        /// Loads Control text to the FileName file. Control can be a ListBox, a ComboBox, or a TextBox
        /// </summary>
        static public void LoadControlTextFromFile(this Control Control, string FileName)
        {
            if ((Control != null) && File.Exists(FileName)) 
                TextToControl(Control, File.ReadAllText(FileName));
        }

        /// <summary>
        /// Returns the text of the Control. Control can be a ListBox, a ComboBox, or a TextBox
        /// </summary>
        static public string ControlToText(this Control Control)
        {
            object Instance;
            string S;

            PropertyInfo PI = Control.GetType().GetProperty("Items");
            if (PI != null)
            {
                Instance = PI.GetValue(Control, null);
                if (Instance is IList)
                {
                    IList Items = (IList)Instance;

                    S = "";
                    for (int i = 0; i < Items.Count; i++)
                        S = S + (string)Items[i] + Environment.NewLine;

                    return S;
                }

                return "";
            }

            PI = Control.GetType().GetProperty("Lines");
            if (PI != null)
            {
                Instance = PI.GetValue(Control, null);
                if (Instance is string[])
                {
                    string[] Lines = (string[])Instance;

                    S = "";
                    for (int i = 0; i < Lines.Length; i++)
                        S = S + Lines[i] + Environment.NewLine;

                    return S;
                }
                return "";
            }


            PI = Control.GetType().GetProperty("Text");
            return (string)PI.GetValue(Control, null);
        }
        /// <summary>
        /// Loads Text to the Control. Control can be a ListBox, a ComboBox, or a TextBox
        /// </summary>
        static public void TextToControl(this Control Control, string Text)
        {
            string[] SourceLines;
            object Instance;


            PropertyInfo PI = Control.GetType().GetProperty("Items");
            if (PI != null)
            {
                Instance = PI.GetValue(Control, null);
                if (Instance is IList)
                {
                    IList Items = (IList)Instance;
                    Items.Clear();

                    SourceLines = Text.Split(Environment.NewLine);

                    for (int i = 0; i < SourceLines.Length; i++)
                        Items.Add(SourceLines[i]);
                }

                return;
            }



            PI = Control.GetType().GetProperty("Text");
            PI.SetValue(Control, Text, null);

        }

        /// <summary>
        /// Tries to find a Control with Name in the ParentControl and its children.
        /// </summary>
        static public Control FindControlByName(this Control ParentControl, string Name)
        {
            if (ParentControl != null)
            {
                Control Res = null;

                for (int i = 0; i < ParentControl.Controls.Count; i++)
                {
                    if (string.Compare(ParentControl.Controls[i].Name, Name, true) == 0)
                        return ParentControl.Controls[i];
                    else
                    {
                        Res = FindControlByName(ParentControl.Controls[i], Name);
                        if (Res != null)
                            return Res;
                    }
                }
            }


            return null;
        }
        /// <summary>
        /// Tries to find a component with Name in the Control
        /// </summary>
        static public IComponent FindComponentByName(this Control Control, string Name)
        {
            if (Control != null)
            {
                IList<IComponent> Components = GetComponents(Control);
                string sName;

                foreach (IComponent Component in Components)
                {
                    sName = Component.GetType().GetPublicPropertyValue(Component, "Name") as System.String;
                    if (!string.IsNullOrEmpty(sName) && Sys.IsSameText(Name, sName))
                        return Component;
                }
            }

            return null;
        }
        /// <summary>
        /// Returns a list with the componens of the Control
        /// </summary>
        static public IList<IComponent> GetComponents(this Control Control)
        {
            List<IComponent> List = new List<IComponent>();

            if (Control != null)
            {
                object Obj = null;
                IList<FieldInfo> Fields = Control.GetType().GetFields(typeof(Control));

                foreach (FieldInfo Field in Fields)
                {
                    Obj = Field.GetValue(Control);
 
                    if (Obj is Container)
                    {
                        foreach (IComponent Item in (Obj as Container).Components)
                        {
                            if (!List.Contains(Item))
                                List.Add(Item);
                        }
                    }
 
                    if ((Obj is IComponent) && !List.Contains(Obj as IComponent))
                    {
                        List.Add(Obj as IComponent);
                    }
                }
            }

            return List;
        }


        /// <summary>
        /// Hides all TabPages of the Pager. After this call you may call
        ///	Pager.SelectedTab = tabXXX;  or
        ///	Pager.SelectedIndex = Index;
        /// to display a single TabPage
        /// </summary>
        public static void HideTabs(this TabControl Pager)
        {
 
            Pager.SizeMode = TabSizeMode.Fixed;  //Fixed, Normal, FillToRight
            Pager.ItemSize = new Size(0, 1);
 
            for (int i = 0; i < Pager.TabPages.Count; i++)
                Pager.TabPages[i].Visible = false;
        }
        /// <summary>
        /// Hides all TabPages of Pager except TabPage at PageIndex
        /// </summary>
        public static void DisplayPage(this TabControl Pager, int PageIndex)
        {
            HideTabs(Pager);
            TabPage Page = Pager.TabPages[PageIndex];
            Page.Visible = true;
        }
        /// <summary>
        /// Hides all TabPages of Pager except Page
        /// </summary>
        public static void DisplayPage(this TabPage Page)
        {
            if (Page.Parent == null)
                return;

            HideTabs((TabControl)Page.Parent);
            Page.Visible = true;
        }

 
        /// <summary>
        /// Returns the MdiClient of the Form, if the Form is an Mdi container, else null.
        /// </summary>
        public static MdiClient MdiClient(this Form Form)
        {
            if ((Form != null) && (Form.IsMdiContainer))
            {
                foreach (Control Control in Form.Controls)
                {
                    if (Control is MdiClient)
                        return Control as MdiClient;
                }
            }
            return null;
        }
        /// <summary>
        /// Assigns Handler as the DoubleClick handler method to Grid.DoubleClick
        /// If there is a DataGridTableStyle assigned to the Grid
        /// this function assigns Handler as the DoubleClick handler to
        /// the internal inplace editor TextBox of the Grid for any TextBox column.
        ///
        /// Example call : Utils.HookGridDoubleClick(Grid, new System.EventHandler(this.Grid_DoubleClick));
        ///
        /// </summary>
        public static void HookGridDoubleClick(this DataGrid Grid, EventHandler Handler)
        {
            Grid.DoubleClick += Handler;

            if (Grid.TableStyles.Count > 0)
            {
                DataGridColumnStyle Col = null;
                DataGridTableStyle TableStyle = Grid.TableStyles[0];
                for (int i = 0; i < TableStyle.GridColumnStyles.Count; i++)
                {
                    Col = TableStyle.GridColumnStyles[i];

                    if (Col.GetType() == typeof(DataGridTextBoxColumn))
                        try
                        {
                            DataGridTextBoxColumn TextBoxCol = (DataGridTextBoxColumn)Col;
                            DataGridTextBox TextBox = (DataGridTextBox)TextBoxCol.TextBox;
                            TextBox.DoubleClick += Handler;
                        }
                        catch
                        {
                        }
                }
            }
        }
 

        /// <summary>
        /// Finds the public instance property of Control by PropertyName
        /// </summary>
        static public PropertyInfo FindPublicProperty(this Control Control, string PropertyName)
        {
            if (Control != null)
                return TypeExtensions.FindPublicProperty(Control.GetType(), PropertyName);
            return null;
        }
        /// <summary>
        /// Returns true if the Control has a public instance property with PropertyName
        /// </summary>
        static public bool HasPublicProperty(this Control Control, string PropertyName)
        {
            return FindPublicProperty(Control, PropertyName) != null;
        }
        /// <summary>
        /// Tries to find the currency manager of Control.
        /// </summary>
        static public CurrencyManager ManagerOf(this Control Control)
        {
            if (Control == null)
                return null;
            return CurrencyManagerExtensions.ManagerOf(Control);
        }
        /// <summary>
        /// Returns the parent form of this control, if any, else null.
        /// </summary>
        static public Form GetParentForm(this Control Control)
        {
            if (Control != null)
            {
                return Control.FindForm();

                /*  
                                Control ControlParent = Control.Parent;
                                while (ControlParent != null)
                                {
                                    if (ControlParent is Form)
                                        return ControlParent as Form;

                                    ControlParent = ControlParent.Parent;
                                } 
                 */
            }

            return null;
        }

        /// <summary>
        /// Returns the child control with the input focus, if any, else null.
        /// </summary>
        static public Control FindFocusedControl(this Control Container)
        {
            if (Container != null)
            {
                if (Container.Focused)
                    return Container;

                Control ChildControl;

                foreach (Control Control in Container.Controls)
                {
                    if (Control.Focused)
                        return Control;

                    ChildControl = FindFocusedControl(Control);
                    if (ChildControl != null)
                        return ChildControl;
                }
            }
            return null;
        }

        /// <summary>
        /// Control.GetChildAtPoint() replacement
        /// </summary>
        static public Control GetChildAt(this Control Parent, int X, int Y)
        {
            return GetChildAt(Parent, new Point(X, Y));
        }
        /// <summary>
        /// Control.GetChildAtPoint() replacement
        /// </summary>
        static public Control GetChildAt(this Control Parent, Point P)
        {
            if (Parent != null)
            {
                foreach (Control C in Parent.Controls)
                {
                    if (C.Bounds.Contains(P))
                        return C;
                }
            }

            return null;
        }



        /// <summary>
        /// Can be used by a thread to access a Control. Synchronizes the call
        /// </summary>
        public static void Synchronize(this Control Control, Action Proc)
        {
            if (Control.InvokeRequired)
            {
                Control.BeginInvoke(Proc, new object[] { });
            }
            else
            {
                Proc();
            }
        }
        /// <summary>
        /// Can be used by a thread to access a Control. Synchronizes the call
        /// </summary>
        public static void Synchronize<T>(this Control Control, Action<T> Proc, T Arg1)
        {
            if (Control.InvokeRequired)
            {
                Control.BeginInvoke(Proc, new object[] { Arg1 });
            }
            else
            {
                Proc(Arg1);
            }
        }
        /// <summary>
        /// Can be used by a thread to access a Control. Synchronizes the call
        /// </summary>
        public static void Synchronize<T1, T2>(this Control Control, Action<T1, T2> Proc, T1 Arg1, T2 Arg2)
        {
            if (Control.InvokeRequired)
            {
                Control.BeginInvoke(Proc, new object[] { Arg1, Arg2 });
            }
            else
            {
                Proc(Arg1, Arg2);
            }
        }

        /// <summary>
        /// Can be used by a thread to access a Control. Synchronizes the call
        /// </summary>
        public static TResult Synchronize<T, TResult>(this Control Control, Func<T, TResult> Func, T Arg1)
        {
            if (Control.InvokeRequired)
            {
                IAsyncResult AS = Control.BeginInvoke(Func, new object[] { Arg1 });
                return (TResult)Control.EndInvoke(AS);
            }
            else
                return Func(Arg1);
        }
        /// <summary>
        /// Can be used by a thread to access a Control. Synchronizes the call
        /// </summary>
        public static TResult Synchronize<T1, T2, TResult>(this Control Control, Func<T1, T2, TResult> Func, T1 Arg1, T2 Arg2)
        {
            if (Control.InvokeRequired)
            {
                IAsyncResult AS = Control.BeginInvoke(Func, new object[] { Arg1, Arg2 });
                return (TResult)Control.EndInvoke(AS);
            }
            else
                return Func(Arg1, Arg2);
        }
    }



}
 