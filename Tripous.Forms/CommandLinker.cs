using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace Tripous.Forms
{

    /// <summary>
    /// Links a <see cref="Command"/> to a component or other clickable UI element, such as a <see cref="ToolStripMenuItem"/>.
    /// </summary>
    static public class CommandLinker
    {
        static List<CommandLink> Links = new List<CommandLink>();

        static bool Contains(Command Cmd)
        {
            return Find(Cmd) != null;
        }
        static CommandLink Find(Command Cmd)
        {
            return Links.FirstOrDefault(item => item.Command == Cmd);
        }


        /// <summary>
        /// Links a <see cref="Command"/> to a component or other clickable UI element, such as a <see cref="ToolStripMenuItem"/>.
        /// </summary>
        static public void Link(Command Cmd, object Instance)
        {
            CommandLink L = Find(Cmd);
            if (L == null)
            {
                L = new CommandLink(Cmd);
                Links.Add(L);
            }


            L.Link(Instance);
        }
        /// <summary>
        /// Unlinks a <see cref="Command"/> from a component or other clickable UI element, such as a <see cref="ToolStripMenuItem"/>.
        /// </summary>
        static public void UnLink(Command Cmd, object Instance)
        {
            CommandLink L = Find(Cmd);
            if (L != null)
            {
                L.UnLink(Instance);
            }
        }
    }



    class CommandLink
    {
        private const BindingFlags linkBindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

        List<WeakReference> Components = new List<WeakReference>();

        WeakReference FindWrapperOf(object Instance)
        {
            return Components.FirstOrDefault(item => item.Target == Instance);
        }
        
        /// <summary>
        /// Helper. Sets the PropName property of all instances contained in components to the passed Value using reflection.
        /// </summary>
        void SetLinkProperty(string PropName, object Value)
        {
            if (Components.Count > 0)
            {
                PropertyInfo PropInfo = null;
                WeakReference[] Refs = new WeakReference[Components.Count];
                Components.CopyTo(Refs, 0);

                foreach (WeakReference WeakRef in Refs)
                {
                    if (WeakRef.IsAlive)
                    {
                        try
                        {
                            PropInfo = WeakRef.Target.GetType().GetProperty(PropName);
                            if (PropInfo != null)
                                PropInfo.SetValue(WeakRef.Target, Value, null);
                        }
                        catch
                        {
                            Components.Remove(WeakRef);
                        }
                    }
                    else
                    {
                        Components.Remove(WeakRef);
                    }
                }

            }
        }
        /// <summary>
        /// Called by linked UI elements and executes the command.
        /// </summary>
        void OnClick(object sender, EventArgs e)
        {
            Command.Execute();
        }
        void OnDisposed(object sender, EventArgs e)
        {
            UnLink(sender);
        }

        public CommandLink(Command Cmd)
        {
            this.Command = Cmd;
        }

        /// <summary>
        /// Links Instance to this Command.
        /// </summary>
        public void Link(object Instance)
        {
            if ((Instance != null) && (FindWrapperOf(Instance) == null))
            {
                Type T = Instance.GetType();

                /* Click event */
                EventInfo EventInfo = T.GetEvent("Click", linkBindingFlags);
                if (EventInfo != null)
                    EventInfo.AddEventHandler(Instance, new EventHandler(OnClick));

                /* Disposed event */
                EventInfo = T.GetEvent("Disposed", linkBindingFlags);
                if (EventInfo != null)
                    EventInfo.AddEventHandler(Instance, new EventHandler(OnDisposed));

                /* properties */
                PropertyInfo PropInfo = T.GetProperty("Text");
                if (PropInfo != null)
                    PropInfo.SetValue(Instance, this.Command.Text, null);

                Components.Add(new WeakReference(Instance));

                SetLinkProperty("Enabled", this.Command.Enabled);
                SetLinkProperty("Active", this.Command.Enabled);
                SetLinkProperty("Visible", this.Command.Visible);
            }

        }
        /// <summary>
        /// Un-Links Instance from this Command.
        /// </summary>
        public void UnLink(object Instance)
        {

            WeakReference WeakRef = FindWrapperOf(Instance);
            if (WeakRef != null)
            {
                Type T = Instance.GetType();

                EventInfo EventInfo = T.GetEvent("Click", linkBindingFlags);
                if (EventInfo != null)
                    EventInfo.RemoveEventHandler(Instance, new EventHandler(OnClick));

                Components.Remove(WeakRef);
            }

        }

        public Command Command { get; set; }
    }
}
