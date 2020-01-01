using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;



namespace Tripous.Forms
{
    /// <summary>
    /// A helper class that contains logic on how to display commands to menus, tool bars, side bars, etc.
    /// </summary>
    static public class CommandHostHelper
    {
        /// <summary>
        /// Constant
        /// </summary>
        static public System.Drawing.Image DefaultImage = Res.GetImage(Icons32.Application);

        /* private */
        static bool CanRealize(Command Cmd, bool AddLookUps, bool AddEnums)
        {
            bool Result = Cmd != null && !Cmd.Hidden; 
            return Result;
        }

        static void Link(Command Cmd, ToolStripMenuItem MenuItem)
        {
            if (!Cmd.IsContainer && !Cmd.IsRoot && !Cmd.IsSeparator)
                CommandLinker.Link(Cmd, MenuItem);
        }

        /* public */
        /// <summary>
        /// Adds commands of the ParentCommand to ParentDropDownItems
        /// </summary>
        static public void AddMenuItems(Command ParentCmd, ToolStripItemCollection ParentDropDownItems, bool AddLookUps, bool AddEnums)
        {
            ToolStripMenuItem MenuItem;
            ToolStripSeparator Separator;
 

            if (CanRealize(ParentCmd, AddLookUps, AddEnums) && (ParentDropDownItems != null))
            {
                foreach (Command Cmd in ParentCmd)
                {
                    if (CanRealize(Cmd, AddLookUps, AddEnums))
                    {
                        if (Cmd.Type == CommandType.Separator)
                        {
                            Separator = new ToolStripSeparator();
                            Separator.Name = "mnu" + Cmd.Name;
                            ParentDropDownItems.Add(Separator);
                        }
                        else
                        {
                            MenuItem = new ToolStripMenuItem(Cmd.Text);
                            MenuItem.Name = "mnu" + Cmd.Name;
                            ParentDropDownItems.Add(MenuItem);

                            MenuItem.Image = Cmd.Icon;
                            if (MenuItem.Image == null)
                            {
                                MenuItem.Image = DefaultImage;
                            }

                            Link(Cmd, MenuItem);
 
                            AddMenuItems(Cmd, MenuItem.DropDownItems, AddLookUps, AddEnums);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Adds Command to Menu. It adds child commands too.
        /// </summary>
        static public void AddMenuItems(Command Cmd, MenuStrip Menu, bool AddLookUps, bool AddEnums)
        {
            if (CanRealize(Cmd, AddLookUps, AddEnums) && (Menu != null))
            {
                ToolStripMenuItem MenuItem = new ToolStripMenuItem(Cmd.Text);
                MenuItem.Name = "mnu" + Cmd.Name;
                Link(Cmd, MenuItem);
                AddMenuItems(Cmd, MenuItem.DropDownItems, AddLookUps, AddEnums);
                Menu.Items.Add(MenuItem);
            }
        }
        
        /// <summary>
        /// Adds Processor commands to Menu
        /// </summary>
        static public void AddProcessorMenuItems(Command Processor, MenuStrip Menu, bool AddLookUps, bool AddEnums)
        {
            if (CanRealize(Processor, AddLookUps, AddEnums) && (Menu != null))
            {
                foreach (Command Cmd in Processor)
                {
                    AddMenuItems(Cmd, Menu, AddLookUps, AddEnums);
                }
            }
        }

        /*
        /// <summary>
        /// Adds CommandList command items to ToolBar
        /// </summary>
        static public void AddCommandListToToolBar(IList<CommandItem> CommandList, ToolStrip ToolBar, bool ClearToolBar)
        {
            if (ToolBar != null)
            {

                if (ClearToolBar)
                    ToolBar.Items.Clear();

                if ((CommandList != null) && (CommandList.Count > 0))
                {

                    Command Cmd;
                    foreach (CommandItem Item in CommandList)
                    {
                        if (Command.CanRealize(Item.Command) && Command.IsExecutable(Item.Command))
                        {
                            Cmd = Item.Command;
                            ToolStripButton Button = new ToolStripButton();
                            Button.Name = Cmd.Name;
                            Button.Text = Cmd.Title;
                            Button.ToolTipText = string.IsNullOrEmpty(Cmd.ToolTip) ? Cmd.Title : Cmd.ToolTip;
                            Button.AutoSize = true;
                            Button.DisplayStyle = ToolStripItemDisplayStyle.Image;
                            Button.Image = Item.Image == null ? DefaultImage : Item.Image;
                            ToolBar.Items.Add(Button);
                            Cmd.Link(Button);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Adds CommandList command items to ToolBar
        /// </summary>
        static public void AddCommandListToToolBar(IList<Command> CommandList, ToolStrip ToolBar, bool ClearToolBar)
        {
            if (ToolBar != null)
            {
                if (ClearToolBar)
                    ToolBar.Items.Clear();

                if ((CommandList != null) && (CommandList.Count > 0))
                {
                    foreach (Command Cmd in CommandList)
                    {
                        if (Command.CanRealize(Cmd) && Command.IsExecutable(Cmd))
                        {
                            ToolStripButton Button = new ToolStripButton();
                            Button.Name = Cmd.Name;
                            Button.Text = Cmd.Title;
                            Button.ToolTipText = string.IsNullOrEmpty(Cmd.ToolTip) ? Cmd.Title : Cmd.ToolTip;
                            Button.AutoSize = true;

                            Button.DisplayStyle = ToolStripItemDisplayStyle.Image;
                            Button.Image = Cmd.Image == null ? DefaultImage : Cmd.Image;

                            ToolBar.Items.Add(Button);
                            Cmd.Link(Button);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// The main tool bar provides a contex menu which displays the avaialable command sets. 
        /// </summary>
        static public void AddCommandSetsToToolBarContextMenuItems(ToolStrip ToolBar, IList<CommandSet> CommandSets, EventHandler Handler)
        {
            if ((ToolBar != null) && (ToolBar.ContextMenuStrip != null))
            {
                ToolBar.ContextMenuStrip.Items.Clear();
                if ((CommandSets != null) && (CommandSets.Count > 0))
                {
                    ToolStripMenuItem MenuItem;
                    foreach (CommandSet CommandSet in CommandSets)
                    {
                        MenuItem = new ToolStripMenuItem(CommandSet.Title);
                        MenuItem.Name = "mnu" + CommandSet.Name;
                        MenuItem.Click += Handler;
                        MenuItem.Tag = CommandSet;
                        ToolBar.ContextMenuStrip.Items.Add(MenuItem);
                    }
                }
            }
        }
        */
    }
}
