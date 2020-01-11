using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using WeifenLuo.WinFormsUI.Docking;
using Tripous.Logging;

namespace Tripous.Forms
{
    /// <summary>
    /// Base tool form
    /// </summary>
    public partial class ToolForm : DockContent, IBroadcasterListener
    {
        /* private */
        class ToolItem
        {
            public ToolItem(string ToolType, Type ToolFormClass, ToolFormDefaultPosition DefaultPosition)
            {
                this.ToolType = ToolType;
                this.ToolFormClass = ToolFormClass;
                this.DefaultPosition = DefaultPosition;
            }

            public string ToolType { get;  }
            public Type ToolFormClass { get; }
            public ToolFormDefaultPosition DefaultPosition { get; }
        }

        static List<ToolItem> ToolItems = new List<ToolItem>();         // registry for tools
        static List<ToolForm> OpenToolForms = new List<ToolForm>();

        #region IBroadcasterListener implementation
        void IBroadcasterListener.HandleBroadcasterEvent(string EventName, IDictionary<string, object> Args)
        {
            if (!IsDisposed)
            {
                /* check carefully if Invoke() is required */
                bool IsInvokeRequired;
                try
                {
                    IsInvokeRequired = this.InvokeRequired;
                }
                catch /* it should be ObjectDisposedException */
                {
                    return;
                }


                if (IsInvokeRequired)   /* synchronize the call */
                {

                    try
                    {
                        IBroadcasterListener Listener = this as IBroadcasterListener;
                        this.Invoke(new BroadcasterDelegate(Listener.HandleBroadcasterEvent), EventName, Args);
                    }
                    catch (Exception e)  /* it should be ObjectDisposedException ONLY */
                    {
                        if (!(e is ObjectDisposedException))
                            Logger.Error(e);
                    }
                }
                else  /* it is synchronized */
                {
                    try
                    {
                        this.HandleBroadcasterEvent(EventName, Args);
                        Application.DoEvents();
                    }
                    catch (Exception e)
                    {
                        Logger.Error(e);
                    }
                }
            }
        }
        #endregion

        /* protected */
        /// <summary>
        /// Field
        /// </summary>
        protected string fTitle;
 

        /* overridables */
        /// <summary>
        /// Called just before form initialization
        /// </summary>
        protected virtual void FormInitializeBefore()
        {
        }
        /// <summary>
        /// Called in order to initialize the form
        /// </summary>
        protected virtual void FormInitialize()
        {
        }
        /// <summary>
        /// Called just after form initialization
        /// </summary>
        protected virtual void FormInitializeAfter()
        {
        }

        /// <summary>
        /// Updates the user interface, title, enable-disable buttons etc.
        /// </summary>
        public virtual void UpdateUi()
        {
            if (!IsDisposed)
            {
                EnableCommands();
                OnTitleChanged();
            }
        }
        /// <summary>
        /// Enables and disables buttons and menu items.
        /// </summary>
        protected virtual void EnableCommands()
        {

        }
        /// <summary>
        /// Called whenever the title is changed
        /// </summary>
        protected virtual void OnTitleChanged()
        {
        }

        /// <summary>
        /// Handles a broadcaster event.
        /// </summary>
        protected virtual void HandleBroadcasterEvent(string EventName, IDictionary<string, object> Args)
        {
            switch (EventName)
            {
                case "NOT_EXISTED_EVENT_NAME":
                    break;
            }
        }

        /* overrides */
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnShown(EventArgs e)
        {
            if (!DesignMode)
            {
                if (!Initialized)
                {
                    Broadcaster.Add(this);

                    Initialized = true;
                    FormInitializeBefore();
                    FormInitialize();
                    FormInitializeAfter();
                }
            }

            base.OnShown(e);
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = Ui.Waiting;
            base.OnFormClosing(e);
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Broadcaster.Remove(this);
            OpenToolForms.Remove(this);
            base.OnFormClosed(e);
        }


        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public ToolForm()
        {
            InitializeComponent();
            OpenToolForms.Add(this);
        }


        /* static */
        /// <summary>
        /// Registers a tool form under a globally unique tool type
        /// </summary>
        static public void RegisterForm(string ToolType, Type ToolFormClass, ToolFormDefaultPosition DefaultPosition = ToolFormDefaultPosition.Left)
        {
            if (ToolItems.FirstOrDefault(item => !ToolType.IsSameText(item.ToolType)) == null)
            {
                ToolItems.Add(new ToolItem(ToolType, ToolFormClass, DefaultPosition));
            }
        }

        /// <summary>
        /// Loads tool form state and position previously saved into a file, and then creates and displays tool forms.
        /// </summary>
        static public void LoadToolForms()
        {
            if (Ui.Docker == null)
                Sys.Error("Can not create Tool Forms. No DockerPanel is defined");

            ToolForm F;
            if (!File.Exists(ToolFormsFilePath))
            {                
                foreach (ToolItem Item in ToolItems) 
                {
                    F = Activator.CreateInstance(Item.ToolFormClass) as ToolForm;
                    F.ToolType = Item.ToolType;
                    F.Show(Ui.Docker, (DockState)Item.DefaultPosition);
                }
            }
            else
            {
 
                List<ToolFormInfo> List = new List<ToolFormInfo>();
                Json.LoadFromFile(List, ToolFormsFilePath);

                ToolItem Item;
                foreach (ToolFormInfo Info in List)
                {
                    Item = ToolItems.FirstOrDefault(item => Info.ToolType.IsSameText(item.ToolType));
                    if (Item != null)
                    {
                        F = Activator.CreateInstance(Item.ToolFormClass) as ToolForm;
                        F.ToolType = Item.ToolType;

                        if (F != null)
                        {
                            F.AutoHidePortion = Info.AutoHidePortion;
                            bool IsHidden = false;
                            DockState State = DockState.DockLeft;
                            if (Info.DockState == DockState.DockLeftAutoHide)
                            {
                                State = DockState.DockLeft;
                                IsHidden = true;
                            }
                            if (Info.DockState == DockState.DockTopAutoHide)
                            {
                                State = DockState.DockTop;
                                IsHidden = true;
                            }
                            else if (Info.DockState == DockState.DockRightAutoHide)
                            {
                                State = DockState.DockRight;
                                IsHidden = true;
                            }
                            else if (Info.DockState == DockState.DockBottomAutoHide)
                            {
                                State = DockState.DockBottom;
                                IsHidden = true;
                            }

                            // if is hidden, then first set a normal (visible) state
                            F.Show(Ui.Docker, !IsHidden ? Info.DockState : State);

                            // ...and then set the actual state
                            if (IsHidden)
                            {
                                F.DockState = Info.DockState;
                            }

                            if (Info.DockState == DockState.Float)
                            {
                                F.FloatAt(Info.FloatBounds);
                            }
 
                        }
                    }
                }   
 
            }
        }
        /// <summary>
        /// Saves tool forms state and position to a file
        /// </summary>
        static public void SaveToolForms()
        {
            List<ToolFormInfo> List = new List<ToolFormInfo>();
            foreach (ToolForm F in OpenToolForms)
            {
                List.Add(F.ToolFormInfo);
            }
 
            Json.SaveToFile(List, ToolFormsFilePath);
        }
        /// <summary>
        /// Displays a tool form
        /// </summary>
        static public ToolForm DisplayToolForm(string ToolType)
        {
            ToolForm F = OpenToolForms.FirstOrDefault(item => ToolType.IsSameText(item.ToolType));

            if (F != null)
            {
                F.Show();
                F.Activate();
            }
            else
            {
                ToolItem Item = ToolItems.FirstOrDefault(item => ToolType.IsSameText(item.ToolType));
                if (Item != null)
                {
                    F = Activator.CreateInstance(Item.ToolFormClass) as ToolForm;
                    F.ToolType = Item.ToolType;
                    F.Show(Ui.Docker, (DockState)Item.DefaultPosition);
                }
            }

            return F;
        }

        /// <summary>
        /// Finds and returns a ToolForm, based in its globally unique tool type, if any, else returns null.
        /// </summary>
        static public ToolForm FindOpenToolForm(string ToolType)
        {
            return OpenToolForms.FirstOrDefault(item => ToolType.IsSameText(item.ToolType));
        }
        /// <summary>
        /// Returns all open tool forms
        /// </summary>
        static public ToolForm[] GetOpenToolForms()
        {
            return OpenToolForms.ToArray();
        }


        /// <summary>
        /// The full file path where state and position of tool forms is saved.
        /// </summary>
        static public string ToolFormsFilePath { get; set; } = "ToolForms.json";

        /* properties */
        /// <summary>
        /// True when initialized
        /// </summary>
        public bool Initialized { get; private set; }
        /// <summary>
        /// Gets the title text of the form
        /// </summary>
        public virtual string Title
        {
            get { return fTitle; }
            set
            {
                if (value != fTitle)
                {
                    fTitle = value;
                    this.Text = value;
                    OnTitleChanged();
                }
            }
        }
        /// <summary>
        /// Used in saving the state of the form
        /// </summary>
        internal ToolFormInfo ToolFormInfo
        {
            get
            {
                ToolFormInfo Result = new ToolFormInfo();
                Result.ToolType = this.ToolType;
                Result.DockState = DockState;
                Result.AutoHidePortion = Convert.ToInt32(AutoHidePortion);
                Result.FloatBounds = this.RectangleToScreen(this.Bounds);
                return Result;
            }
        }
        /// <summary>
        /// A string that uniquely identities the tool form.
        /// <para>Used in persisting the form state and position to a json file.</para>
        /// </summary> 
        internal string ToolType { get; private set; }

    }
}
