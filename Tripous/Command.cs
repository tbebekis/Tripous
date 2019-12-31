using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Tripous
{
    /// <summary>
    /// Represents a command that can be associated to a Ui element such as a menu item or a button.
    /// </summary>
    [JsonConverter(typeof(CommandJsonConverter))]
    public class Command : Node
    {
        static int SeparatorCount = 0;

        string fText;
        bool fEnabled = true;
        bool fVisible = true;
        ICommandHandler fHandler;

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
            Handler.EnabledChanged(this);
        }
        /// <summary>
        /// Called when a property value is changed
        /// </summary>
        protected virtual void OnVisibleChanged()
        {
            Handler.VisibleChanged(this);
        }


        /* construction */
        /// <summary>
        /// Constructor.
        /// </summary>
        private Command()
        { 
        }
        /// <summary>
        /// Constructor.
        /// </summary>
        public Command(CommandType Type, string Name, ICommandHandler Handler = null)
        {
            this.Type = Type;
            this.Name = Name;
            this.Handler = Handler;
        }


        /* public */
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

        /* add methods */
        /// <summary>
        /// Creates a separator 
        /// </summary>
        public Command AddSeparator()
        {
            SeparatorCount++;
            Command Cmd = new Command(CommandType.Separator, $"SEPARATOR_{SeparatorCount}");
            Cmd.Text = "-";
            return Add(Cmd);
        }
        /// <summary>
        /// Creates a container, a command that contains other commands 
        /// </summary>
        public Command AddContainer(string Name, string TextKey = "", string Text = "")
        {
            if (!IsRoot)
                Sys.Error("Can not add a container command to a non root command");

            Command Cmd = new Command(CommandType.Container, Name);
            Cmd.TextKey = TextKey;
            Cmd.Text = Text;            
            return Add(Cmd);
        }

        /// <summary>
        /// Adds a command to the list.
        /// </summary>
        public Command Add(Command Cmd)
        {
            base.Add(Cmd);
            return Cmd;
        }
        /// <summary>
        /// Adds a command to the list.
        /// </summary>
        public Command Add(string Name, string TextKey = "", string Text = "")
        {
            Command Cmd = new Command(CommandType.Command, Name);
            Cmd.TextKey = TextKey;
            Cmd.Text = Text;
            return Add(Cmd);
        }
        /// <summary>
        /// Inserts a command at Index
        /// </summary>
        public void Insert(int Index, Command Cmd)
        {
            base.Insert(Index, Cmd);
        }
        /// <summary>
        /// Inserts Cmd before the BeforeName command
        /// </summary>
        public void InsertBefore(string BeforeName, Command Cmd)
        {
            int Index = IndexOf(BeforeName);
            if (Index != -1)
            {
                Insert(Index, Cmd);
            }
            else
            {
                Add(Cmd);
            }
        }
        /// <summary>
        /// Inserts Cmd after the AfterName command
        /// </summary>
        public void InsertAfter(string AfterName, Command Cmd)
        {
            int Index = IndexOf(AfterName);
            if (Index != -1)
            {
                Index++;
                Insert(Index, Cmd);
            }
            else
            {
                Add(Cmd);
            }
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

        /// <summary>
        /// Sets the icon path of a command
        /// </summary>
        public void SetIconPath(string CommandName, string IconPath)
        {
            Command Command = TreeFind(CommandName);
            if (Command != null)
            {
                Command.IconPath = IconPath;
                if (string.IsNullOrWhiteSpace(Command.IconKey))
                    Command.IconKey = ResourceKeyResolvers.ResourcePathToKey(Command.IconPath);
            }
                
        }


        /* json */
        /// <summary>
        /// Serializes CmdRoot and its children to Json
        /// <para>NOTE: It is used by the internal CommandJsonConverter class</para>
        /// </summary>
        static public string ToJson(Command CmdRoot)
        {
            Action<JObject, Command> Process = null;

            Process = delegate (JObject JO, Command Cmd)
            {
                dynamic JCmd = JO;

                JCmd.Name = Cmd.Name;
                JCmd.Type = Cmd.Type;
                JCmd.TextKey = Cmd.TextKey;
                JCmd.Text = Cmd.Text;
                JCmd.ScriptSource = Cmd.ScriptSource;
                JCmd.IconKey = Cmd.IconKey;
                JCmd.IconPath = Cmd.IconPath;
                JCmd.UiMode = Cmd.UiMode;
                JCmd.Hidden = Cmd.Hidden;

                JArray Items = new JArray();

                JCmd.Items = Items as dynamic;

                JObject JOChild;
                foreach (Command ChildCmd in Cmd)
                {
                    JOChild = new JObject();
                    Items.Add(JOChild);
                    Process(JOChild, ChildCmd);
                }

            };


            JObject JORoot = new JObject();
            Process(JORoot, CmdRoot);

            return JORoot.ToString();
        }
        /// <summary>
        /// Deserializes a JObject to Command
        /// <para>NOTE: It is used by the internal CommandJsonConverter class</para>
        /// </summary>
        static public Command FromJson(JObject JRoot)
        {
            Command Result = new Command();
            JArray DefaultItems = null;
            Action<JObject, Command> Process = null;

            Process = delegate (JObject JO, Command Cmd)
            {
                Cmd.Name = Json.AsValue(JO.Property("Name"), "");
                Cmd.Type = Json.AsValue(JO.Property("Type"), CommandType.Command);
                Cmd.TextKey = Json.AsValue(JO.Property("TextKey"), "");
                Cmd.Text = Json.AsValue(JO.Property("Text"), "");
                Cmd.ScriptSource = Json.AsValue(JO.Property("ScriptSource"), "");
                Cmd.IconKey = Json.AsValue(JO.Property("IconKey"), "");
                Cmd.IconPath = Json.AsValue(JO.Property("IconPath"), "");
                Cmd.UiMode = Json.AsValue(JO.Property("UiMode"), UiModes.All);
                Cmd.Hidden = Json.AsValue(JO.Property("Hidden"), false); 

                JArray Items = Json.AsValue(JO.Property("Items"), DefaultItems);
                if ((Items != null))
                {
                    Command ChildCmd;
                    foreach (JObject ChildItem in Items)
                    {
                        ChildCmd = new Command();
                        Process(ChildItem, ChildCmd);
                        Cmd.Add(ChildCmd);
                    }
                }

            };


            Process(JRoot, Result);

            return Result;
        }


        /* properties */
        /// <summary>
        /// The command handler, an object that handles command execution.
        /// </summary>
        public ICommandHandler Handler
        {
            get
            {
                if (this.fHandler != null)
                    return this.fHandler;

                if (!this.IsRoot)
                {
                    Command RootCommand = this.Root as Command;
                    if (RootCommand != null && RootCommand.Handler != null)
                        return RootCommand.Handler;
                }

                Sys.Error($"No command handler for a command: {Name}");

                return null;

            }
            set
            {
                this.fHandler = value;
            }
        }
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
        public string IconKey { get; set; }
        /// <summary>
        /// Gets or sets the image path  
        /// </summary>
        public string IconPath { get; set; }
        /// <summary>
        /// The image associated with this command
        /// </summary>
        public Image Icon { get { return string.IsNullOrWhiteSpace(IconPath) ? null : Res.GetImage(IconPath); } }
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
        /// Indicates the platform where a Ui element may displayed, such as 
        /// in desktop or web applications, or any kind of application.
        /// <para>Defaults to UiMode.None</para>
        /// </summary>
        public UiMode UiMode { get; set; } = UiModes.All;
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
        /// Custom params passed to the command
        /// </summary>
        public Dictionary<string, object> Params { get; } = new Dictionary<string, object>();

        /// <summary>
        ///  Returns true if this Command is of type CommandType.Container, that is only a parent for other commands
        /// </summary>
        public bool IsContainer { get { return (Type == CommandType.Container); } }
        /// <summary>
        /// Returns true if this is a separator command.
        /// </summary>
        public bool IsSeparator { get { return (Type == CommandType.Separator); } }
    }








    /// <summary>
    /// A custom json converter for the Command class
    /// </summary>
    internal class CommandJsonConverter : JsonConverter
    {
        /// <summary>
        /// Override
        /// </summary>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Command Cmd = (Command)value;
            string JsonText = Command.ToJson(Cmd);
            JToken t = JToken.Parse(JsonText);
            t.WriteTo(writer);
        }
        /// <summary>
        /// Override
        /// </summary>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject JO = JObject.Load(reader);
            Command Cmd = Command.FromJson(JO);
            return Cmd;
        }
        /// <summary>
        /// Override
        /// </summary>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Command);
        }

        /* properties */
        /// <summary>
        /// Override
        /// </summary>
        public override bool CanRead { get { return true; } }

    }

















}
