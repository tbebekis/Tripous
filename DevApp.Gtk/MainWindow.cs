using System;
using Gtk;
using System.Reflection;
using UI = Gtk.Builder.ObjectAttribute;

using Tripous;

namespace DevApp.Gtk
{
    class MainWindow : Window
    { 
        [UI] TextView edtLog = null;
        [UI] Button btnLog = null;
 
        Builder builder;

        void AnyClick(object sender, EventArgs ea)
        {
            if (btnLog == sender)
            {
                edtLog.Buffer.Text += SysConfig.AppExeFolder + Environment.NewLine;
            }
        }

        void MainWindow_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }

        void WindowInitialize()
        {
            DeleteEvent += MainWindow_DeleteEvent;
            btnLog.Clicked += AnyClick;
        }

        public MainWindow()
            : base("")
        {
            builder = new Builder("MainWindow.glade");
            this.Raw = builder.GetObject("MainWindow").Handle;
            builder.Autoconnect(this);

            WindowInitialize();
        }
 

 
    }
}
