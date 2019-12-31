using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Tripous
{
    /// <summary>
    /// Represents a command that can be associated to a Ui element such as a menu item or a button.
    /// </summary>
    public class Command : Node
    {
        string fText;
        bool fEnabled = true;
        bool fVisible = true;

        /* protected */
        /// <summary>
        /// Throws an exception if a command with Name, already exists in list.
        /// </summary>
        protected virtual void CheckName(string Name)
        {
            string ErrorText = Res.GS("E_ItemWithNameAlreadyInList", "An item with this name already exists in list: {0} ");
            if (this.Contains(Name))
                Sys.Error(ErrorText, Name);
        }
        /// <summary>
        /// Called when a property value is changed
        /// </summary>
        protected virtual void OnEnabledChanged()
        {
            if (this.Handler != null)
                Handler.EnabledChanged(this);
            else
                Commander.EnabledChanged(this);
        }
        /// <summary>
        /// Called when a property value is changed
        /// </summary>
        protected virtual void OnVisibleChanged()
        {
            if (this.Handler != null)
                Handler.VisibleChanged(this);
            else
                Commander.VisibleChanged(this);
        }

        /* construction */
        /// <summary>
        /// Constructor.
        /// </summary>
        public Command(CommandType Type, string Name, ICommandHandler Handler = null)
        {
            this.Type = Type;
            this.Name = Name;
            this.Handler = Handler;
        }

        /// <summary>
        /// Executes this command.
        /// </summary>
        public void Execute()
        {
            if (this.Handler != null)
                Handler.Execute(this);
            else
                Commander.Execute(this);
        }
 

        /* find */
        /// <summary>
        /// Returns a child command of this command by Name, if any, else null.
        /// </summary>
        public Command Find(string Name)
        {
            foreach (Command child in list)
                if (string.Compare(Name, child.Name, true) == 0)
                    return child;

            return null;
        }
        /// <summary>
        /// Returns true if a child of this command exists under a specified name.
        /// </summary>
        public bool Contains(string Name)
        {
            return Find(Name) != null;
        }
        /// <summary>
        /// Returns the index a child of this command under a specified name, if any, else -1
        /// </summary>
        public int IndexOf(string Name)
        {
            return base.IndexOf(Find(Name));
        }
        /// <summary>
        /// Returns a Command by Name, if any, else null. 
        /// <para>NOTE: It searches the whole tree.</para>
        /// </summary>
        public Command TreeFind(string Name)
        {
            Command Result = Find(Name);
            if (Result != null)
                return Result;

            foreach (Command child in list)
            {
                Result = child.TreeFind(Name);
                if (Result != null)
                    return Result;
            }

            return null;
        }
        /// <summary>
        /// Returns true if a Command with Name exists in the list. 
        /// <para>NOTE: It searches the whole tree.</para>
        /// </summary>
        public bool TreeContains(string Name)
        {
            return TreeFind(Name) != null;
        }
        /// <summary>
        /// Removes a command by Name, if any.
        /// <para>NOTE: It searches the whole tree.</para>
        /// </summary>
        public void Remove(string Name)
        {
            Command Cmd = TreeFind(Name);
            if (Cmd != null)
                Cmd.Parent.Remove(Cmd);
        }

        /// <summary>
        /// Adds all owned commands in the tree to the CommandList
        /// </summary>
        public List<Command> GetFlatList(bool ExcludeContainers = false, bool ExcludeHidden = false, bool ExcludeSeparators = false)
        {
            List<Command> Result = new List<Command>();
            GetFlatList(Result, ExcludeContainers, ExcludeHidden, ExcludeSeparators);
            return Result;
        }
        /// <summary>
        /// Adds all owned commands in the tree to the CommandList
        /// </summary>
        public void GetFlatList(List<Command> CommandList, bool ExcludeContainers = false, bool ExcludeHidden = false, bool ExcludeSeparators = false)
        {
            bool Flag;
            foreach (Command Command in list)
            {
                Flag = (ExcludeContainers && Command.IsContainer)
                    || (ExcludeHidden && Command.Hidden)
                    || (ExcludeSeparators && Command.IsSeparator)
                    ;
                if (!Flag)
                    CommandList.Add(Command);

                Command.GetFlatList(CommandList, ExcludeContainers, ExcludeHidden, ExcludeSeparators);
            }
        }
        /// <summary>
        /// Gets a list of direct child commands
        /// </summary>
        public List<Command> GetChildList()
        {
            List<Command> Result = new List<Command>();
            foreach (var Item in list)
                Result.Add(Item as Command);
            return Result;
        }

        /* properties */
        public ICommandHandler Handler { get; private set; }
        /// <summary>
        /// Gets or sets the "type" of the command.
        /// </summary>  
        public CommandType Type { get; protected set; }
        /// <summary>
        /// Gets or sets the Name of the command or the processor.
        /// </summary>
        public string Name { get; protected set; }
        /// <summary>
        /// Gets or sets a resource Key used in returning a localized version of Title
        /// </summary>
        public virtual string TextKey { get; set; }
        /// <summary>
        /// Gets the caption text of the command or the processor.
        /// </summary>
        public string Text
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(fText))
                    return fText;

                return !string.IsNullOrWhiteSpace(TextKey) ? Res.GS(TextKey, Name) : Name;
            }
            set { fText = value; }
        }
        /// <summary>
        /// Gets or sets the script source. It is used when the command is of type Procedure
        /// and this property is not empty
        /// </summary>
        public string ScriptSource { get; set; }
        /// <summary>
        /// Gets or sets a string key for the image of the command.
        /// </summary>
        public string ImageKey { get; set; }
        /// <summary>
        /// The image associated with this command
        /// </summary>
        public Image Image { get; set; }
        /// <summary>
        /// Gets or sets Enabled and Visible in a single call.
        /// </summary>
        public bool Accessible
        {
            get { return Enabled && Visible; }
            set
            {
                Enabled = value;
                Visible = value;
            }
        }
        /// <summary>
        /// Gets or sets a value indicating whether the command is Enabled.
        /// </summary>
        public bool Enabled
        {
            get { return fEnabled; }
            set
            {
                if (value != fEnabled)
                {
                    fEnabled = value;
                    OnEnabledChanged();
                }                
            }
        }
        /// <summary>
        /// Gets or sets a value indicating whether the command is Visible.
        /// </summary>
        public bool Visible
        {
            get { return fVisible; }
            set
            {
                if (value != fVisible)
                {
                    fVisible = value;
                    OnVisibleChanged();
                }
            }
        }
        /// <summary>
        /// Indicates whether the execution of the command requires user attention or not.
        /// </summary>
        public bool CanAutoOperate { get; set; } = true;
        /// <summary>
        /// Gets or sets a boolean value indicating whether the command can be displayed in menus, toolbars etc.
        /// </summary>
        public bool Hidden { get; set; }
        /// <summary>
        /// User defined value.
        /// </summary>
        public object Tag { get; set; }

        /// <summary>
        ///  Returns true if this Command is of type CommandType.Container, that is only a parent for other commands
        /// </summary>
        public bool IsContainer { get { return (Type == CommandType.Container); } }
        /// <summary>
        /// Returns true if this is a separator command.
        /// </summary>
        public bool IsSeparator { get { return (Type == CommandType.Separator); } }
    }
}
