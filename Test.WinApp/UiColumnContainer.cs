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
    // https://www.codeproject.com/Articles/21489/Creating-a-Multi-Page-Windows-Forms-Control-with-D
    // https://www.codeproject.com/Articles/37830/Designing-Nested-Controls
    // https://www.cyotek.com/blog/creating-a-multi-paged-container-control-with-design-time-support


    //[Designer(typeof(System.Windows.Forms.Design.ParentControlDesigner))]

    [ToolboxItem(false), DesignTimeVisible(false)]
    public class UiColumnContainer: UserControl
    {
        const int DefaultHeight = 60;

        bool Layouting = false;
        ScreenMode fScreenMode;
        Dictionary<ScreenMode, int> Splits = new Dictionary<ScreenMode, int>()
        {
            { ScreenMode.XSmall, 1 },
            { ScreenMode.Small, 2 },
            { ScreenMode.Medium, 2 },
            { ScreenMode.Large, 3 },
        };

        protected List<UiColumn> GetColumns()
        {
            List<UiColumn> Result = new List<UiColumn>();

            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is UiColumn)
                {
                    Result.Add(Controls[i] as UiColumn);
                }
            }

            return Result;
        }

        protected virtual void OnLayoutColumns()
        {
            if (!Layouting)
            {
                Layouting = true;
                try
                {
                    if (this.Parent != null)
                    {
                        List<UiColumn> Columns = GetColumns();

                        if (Columns.Count == 0)
                            return;

                        fScreenMode = Ui.GetScreenMode(this.Parent);
                        int ColumnsPerRow = Splits[fScreenMode];

                        int Y = 0;

                        if (ColumnsPerRow == 1)
                        {
                            foreach (var Column in Columns)
                            {
                                Column.Dock = DockStyle.Top;
                                Y += Column.Height;
                            }
                        }
                        else
                        {

                            for (int i = Columns.Count - 1; i > 0; i--)
                            {
                                var Column = Columns[i];
                                Column.Dock = DockStyle.None;
                            }

                            int Count = 0;
                            int MaxHeight = 0;
                            int L = 0;
                            for (int i = 0; i < Columns.Count; i++)
                            {
                                Count++;
                                var Column = Columns[i];

                                Column.Width = Convert.ToInt32(this.Width / ColumnsPerRow);
                                Column.Top = Y;
                                Column.Left = L;

                                MaxHeight = Math.Max(MaxHeight, Column.Height);

                                L += Column.Width;

                                if (Count == ColumnsPerRow)
                                {
                                    Y += MaxHeight;
                                    MaxHeight = 0;
                                    Count = 0;
                                    L = 0;
                                }
                            }

                            if (Count < ColumnsPerRow)
                            {
                                Y += MaxHeight;
                            }

                        }

                        Y = DesignMode ? Y + DefaultHeight : Y;
                        this.Height = Y;
                    }
                }
                finally
                {
                    Layouting = false;
                }
            }

        }


        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            OnLayoutColumns();
        }
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
            OnLayoutColumns();
        }
        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);           
            OnLayoutColumns();
        }
        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);
            OnLayoutColumns();
        }

        protected override Size DefaultSize { get { return new Size(500, DefaultHeight); } }


        /* construction */
        public UiColumnContainer()
        {
            base.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
        }

        /// <summary>
        /// How many columns to have in a certain screen size.
        /// </summary>
        public int SplitXSmall
        {
            get { return Splits[ScreenMode.XSmall]; }
            set
            {
                if (value != Splits[ScreenMode.XSmall] && (value >= 1 && value <= 2))
                {
                    Splits[ScreenMode.XSmall] = value;
                    OnLayoutColumns();
                }
            }
        }
        /// <summary>
        /// How many columns to have in a certain screen size.
        /// </summary>
        public int SplitSmall
        {
            get { return Splits[ScreenMode.Small]; }
            set
            {
                if (value != Splits[ScreenMode.Small] && (value >= 1 && value <= 2))
                {
                    Splits[ScreenMode.Small] = value;
                    OnLayoutColumns();
                }
            }
        }
        /// <summary>
        /// How many columns to have in a certain screen size.
        /// </summary>
        public int SplitMedium
        {
            get { return Splits[ScreenMode.Medium]; }
            set
            {
                if (value != Splits[ScreenMode.Medium] && (value >= 1 && value <= 3))
                {
                    Splits[ScreenMode.Medium] = value;
                    OnLayoutColumns();
                }
            }
        }
        /// <summary>
        /// How many columns to have in a certain screen size.
        /// </summary>
        public int SplitLarge
        {
            get { return Splits[ScreenMode.Large]; }
            set
            {
                if (value != Splits[ScreenMode.Large] && (value >= 1 && value <= 5))
                {
                    Splits[ScreenMode.Large] = value;
                    OnLayoutColumns();
                }
            }
        }


        public override AnchorStyles Anchor 
        {
            get { return base.Anchor; }
            set { }     
        }
    }
}
