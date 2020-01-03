using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripous.Forms
{
    public class UiColumnPanel: Panel
    {
        const int DefaultHeight = 30;


        protected List<IControlRow> GetRows()
        {
            List<IControlRow> Result = new List<IControlRow>();

            foreach (Control C in this.Controls)
            {
                if (C is IControlRow)
                {
                    Result.Add(C as IControlRow);
                }
            }

            return Result;
        }
        protected void UpdateHeight()
        { 
            List<IControlRow> Rows = GetRows();
            int H = 0;
            foreach (var Row in Rows)
            {
                H += Row.RowHeight;
            }

            H = DesignMode ? H + DefaultHeight : H;

            this.Height = H;

            if (Parent is UiColumnContainer)
            {
                (Parent as UiColumnContainer).PerformLayout();
            }
        }
        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            if (Parent != null)
            {
                UpdateHeight();
            }
        }
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
        }
        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            e.Control.Dock = DockStyle.Top;
            UpdateHeight();
        }
        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);
            UpdateHeight();
        }

        protected override Size DefaultSize { get { return new Size(120, DefaultHeight); } }


        /* construction */
        public UiColumnPanel()
        {

        }
    }
}
