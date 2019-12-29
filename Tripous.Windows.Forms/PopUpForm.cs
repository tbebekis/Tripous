/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/


using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

using Tripous.Data;

namespace Tripous.Windows.Forms
{

    /// <summary>
    /// A form that can be used either as a modal dialog or as a drop-down like control.
    /// It displays a control according to its mode.
    /// </summary>
    public partial class PopUpForm : Form
    {
        //static private readonly int ButtonHeight = 20;
        static private readonly int ButtonWidth = 48;

        /// <summary>
        /// A MonthCalendar descendant that supports the DoubleClick event.
        /// <para>Taken from: http://dotnet.mvps.org/dotnet/faqs/?id=monthcalendardoubleclick</para>
        /// </summary>
        internal class CalendarEx : MonthCalendar
        {
            private Point lastClickPosition;
            private long lastClickTime;
            private bool lastClickRaisedDoubleClick;

            bool IsInDoubleClickArea(Point P1, Point P2)
            {
                return (Math.Abs(P1.X - P2.X) <= SystemInformation.DoubleClickSize.Width) 
                    && (Math.Abs(P1.Y - P2.Y) <= SystemInformation.DoubleClickSize.Height);
            }
            /// <summary>
            /// Override
            /// </summary>
            protected override void OnMouseDown(MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (!lastClickRaisedDoubleClick
                        && ((DateTime.Now.Ticks - lastClickTime) <= (SystemInformation.DoubleClickTime * 10000))
                        && (IsInDoubleClickArea(lastClickPosition, Cursor.Position)))
                    {
                        this.OnDoubleClick(EventArgs.Empty);
                        lastClickRaisedDoubleClick = true;
                    }
                    else
                    {
                        lastClickRaisedDoubleClick = false;
                    }

                    lastClickPosition = Cursor.Position;
                    lastClickTime = DateTime.Now.Ticks;
                }
 
                base.OnMouseDown(e);
            }
        }

        private int stdMinHeight;
        private int stdMinWidth;
        //private MemoryStream MS = new MemoryStream();

        private Control control;
        private Control associate;

        private ListBox listBox; // = new ListBox();
        private CheckedListBox checkListBox; //  = new CheckedListBox();
        private MonthCalendar calendar; //  = new CalendarEx();
        private PictureBox pictureBox; //  = new PictureBox();
        private RichTextBox memo; //  = new RichTextBox();
        private DataGridView grid; //  = new DataGridView();
        private TreeView treeView;

        /* multi-choise table/grid with Include column */
        private bool isMultiChoiseGrid;
        private ContextMenuStrip mnuGrid;
        private ToolStripMenuItem mnuSelectAll;
        private ToolStripMenuItem mnuDeselectAll;

        private ImageContextMenu imageContextMenu = new ImageContextMenu();
        
        private PopUpMode mode = PopUpMode.Custom;
        private PopUpButtons buttons = 0;
        private BlobType blobType = BlobType.Image;
        private PopUpFlags flags = PopUpFlags.Sizable;
        
        private bool readOnly;
        private bool popUpResult;
        private object formResult;
        private bool displaying;
        private bool deActivating;
        private Binding binding;
        private string[] visibleColumns;

        private DataTable table;
        private DataRow row;
        private DataColumn column;


        
 
        void InitializeForm()
        {
            if (this.DesignMode)
                return;

            this.Owner = Ui.MainForm;

            this.SuspendLayout();
            Text = " Content Editor";
            KeyPreview = true;
            Visible = false;
            AutoScroll = false;  

            stdMinHeight = 220;//220;
            stdMinWidth = (ButtonWidth * 5) + 15; // 255

            this.Height = stdMinHeight;
            this.Width = stdMinWidth;

            pnlButtons.Visible = !Bf.IsEmpty(buttons);
               

            if (control != null)
            {
                control.Parent = pnlParent;
                if (control != calendar)
                {
                    control.Dock = DockStyle.Fill;
                }
                else
                {
                    calendar.Top = -12;
                    calendar.Left = -2;
                }

                control.Visible = false;
                control.DoubleClick += new EventHandler(AnyControl_DoubleClick);

                control.TabIndex = 0;
            }

            if (listBox != null)
                listBox.KeyDown += new KeyEventHandler(AnyControl_KeyDown);

            if (grid != null)
            {
                grid.KeyDown += new KeyEventHandler(AnyControl_KeyDown);
                grid.DataSource = bindingSource;
                grid.RowHeadersVisible = false;
            }

            if (memo != null)
            {
                memo.HideSelection = true;
                memo.ScrollBars = RichTextBoxScrollBars.Both;
                memo.WordWrap = false;
                memo.Font = new Font("Verbana", memo.Font.Size);
            }

            if (pictureBox != null)
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            if (calendar != null)
                calendar.ShowToday = false;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        void MemoBinding_Format(object sender, ConvertEventArgs e)
        {
            if (!Sys.IsNull(e.Value) && (e.DesiredType == typeof(string)))
            {
                byte[] Bytes = (byte[])e.Value;
                e.Value = string.Empty;
                char[] Chars = Encoding.UTF8.GetChars(Bytes);
                e.Value = new string(Chars);
            }
        }
        void MemoBinding_Parse(object sender, ConvertEventArgs e)
        {
            if (!Sys.IsNull(e.Value) && ((column.DataType == typeof(byte[])) || (column.DataType == typeof(object))))
            {
                string Value = e.Value.ToString();
                e.Value = Encoding.UTF8.GetBytes(Value);
            }

        }
        void ImageBinding_Format(object sender, ConvertEventArgs e)
        {
            if (!Sys.IsNull(e.Value) && (e.DesiredType == typeof(System.Drawing.Image)))
            {
                byte[] Bytes = (byte[])e.Value;

                MemoryStream MS = new MemoryStream(Bytes);
                e.Value = Image.FromStream(MS);               
            }
        }
        void ImageBinding_Parse(object sender, ConvertEventArgs e)
        {
            if (!Sys.IsNull(e.Value) && ((column.DataType == typeof(byte[])) || (column.DataType == typeof(object))))
            {
                Image img = e.Value as Image;
                if (img != null)
                {
                    MemoryStream MS = new MemoryStream();
                    img.Save(MS, System.Drawing.Imaging.ImageFormat.Gif);
                    e.Value = MS.ToArray();
                }
            }
        }
        void Grid_Disposed(object sender, EventArgs e)
        {
            if (mnuGrid != null)
            {
                mnuGrid.Dispose();
                mnuGrid = null;
            }
        }
        void Grid_AnyLocalMenu_Click(object sender, EventArgs e)
        {
            if ((table != null) && table.Columns.Contains("Include"))
            {
                bool Flag = sender == mnuSelectAll;

                foreach (DataRow Row in table.Rows)
                    Row["Include"] = Flag;
            }
        }
        void AnyControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                AnyControl_DoubleClick(sender, EventArgs.Empty);
        }
        void AnyControl_DoubleClick(object sender, EventArgs e)
        {
            bool Flag = ((sender == listBox) && (listBox.Items.Count > 0) && (listBox.SelectedIndex != -1))
                || ((sender == checkListBox) && (checkListBox.Items.Count > 0))
                || (sender == calendar)
                || ((sender == pictureBox) && (pictureBox.Image != null))
                || (sender == memo)
                || ((sender == grid) && (table != null) && (table.Rows.Count > 0))
                ; 

            if (Flag)
                AnyCommand(btnOK, EventArgs.Empty);  
        }
        void AnyCommand(object sender, EventArgs e)
        {
            if (sender == btnOK)
            {
                ProcessCloseCommand(true);               
            }
            else if (sender == btnCancel)
            {
                ProcessCloseCommand(false);     
            }
            else if (sender == btnClear)
            {
                if (pictureBox != null)
                    pictureBox.Image = null;

                if (memo != null)
                    memo.Clear(); 

                ReapplyBounds();
                EnableControls(); 
            }
            else if (sender == btnLoad)
            {
                if (!ReadOnly)
                {
                    deActivating = true;
                    try
                    {
                        if ((pictureBox != null) && pictureBox.Visible)
                        {
                            pictureBox.LoadFromFile();
                            ReapplyBounds();
                            EnableControls();
                        }
                        else if ((memo != null) && memo.Visible)
                        {
                            string FileName = "";
                            if (FileBox.Open(ref FileName, "TXT"))
                            {
                                memo.LoadControlTextFromFile(FileName);
                                this.PerformLayout();
                                EnableControls();
                            }
                        }   
                    }
                    finally
                    {
                        deActivating = false;
                    }

                                     
                }
            }
            else if (sender == btnSave)
            {
                deActivating = true;
                try
                {
                    if ((pictureBox != null) && pictureBox.Visible)
                    {
                        pictureBox.SaveToFile();
                    }
                    else if ((memo != null) && memo.Visible)
                    {
                        string FileName = "";
                        if (FileBox.Save(ref FileName, "TXT"))
                        {
                            memo.SaveControlTextToFile(FileName);
                        }
                    }
                }
                finally
                {
                    deActivating = false;
                }

                
            }
        }


        /* overrides */
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Escape)
                AnyCommand(btnCancel, EventArgs.Empty);
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            /* displaying the menu, de-activates the form when in dropdown */
            if (pictureBox != null)
            {
                if (Modal)
                    pictureBox.ContextMenuStrip = imageContextMenu;
                else
                    pictureBox.ContextMenuStrip = null;
            }

            formResult = null;
            popUpResult = false;
            displaying = true;
            Prepare();
            ReapplyBounds();            

            if (ShowAfter != null)
                ShowAfter(this, EventArgs.Empty);


            if ((control != null) && control.Visible)
            {
                control.Focus();
                this.ActiveControl = control;
            }

            if (mode == PopUpMode.Grid)
            {
                if (row != null)
                {
                    CurrencyManager Manager = Grid.ManagerOf();
                    if (Manager != null)
                        Manager.PositionToRow(row);
                }
            }
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnDeactivate(EventArgs e)
        {
            if (!deActivating)
            {
                deActivating = true;
                try
                {
                    base.OnDeactivate(e);
                    if (Visible && !Modal && displaying)
                        Close();
                }
                finally
                {
                    deActivating = false;      
                }
            }
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (displaying)
            {
                displaying = false;

                if (CloseBefore != null)
                    CloseBefore(this, EventArgs.Empty);

                base.OnFormClosed(e);
                
                FocusAssociate();           
            }
            else
            {
                base.OnFormClosed(e);
            }
        }
        
        /* preparation for DropDown() and ShowDialog() */
        /// <summary>
        /// It is called by the <see cref="OnShown"/> to prepare the whole form display.
        /// </summary>
        protected virtual void Prepare()
        {
            /* form border style */
            if (Modal)
            {
                if (Bf.Member(PopUpFlags.Sizable, Flags))
                    this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                else
                    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

                //Text = " Content Editor";
            }
            else
            { 
                Text = "";
                FormBorderStyle = FormBorderStyle.Sizable;
                ControlBox = false;
             }

            
            /* bind to content if blob */
            if (mode == PopUpMode.Blob)
            {
                table = new DataTable();
                column.CopyStructureTo(table, column.AllowDBNull); 
                table.Rows.Add(row[column]);

                if (blobType == BlobType.Image)
                {
                    pictureBox.DataBindings.Clear();
                    binding = new Binding("Image", table, column.ColumnName, true, DataSourceUpdateMode.OnPropertyChanged);
                    if ((column.DataType == typeof(byte[])) || (column.DataType == typeof(object)))
                    {
                        binding.Parse += new ConvertEventHandler(ImageBinding_Parse);
                        binding.Format += new ConvertEventHandler(ImageBinding_Format);
                    }
                    pictureBox.DataBindings.Add(binding);
                }
                else
                {
                    memo.DataBindings.Clear();
                    binding = new Binding("Text", table, column.ColumnName, true, DataSourceUpdateMode.OnPropertyChanged);
                    if ((column.DataType == typeof(byte[])) || (column.DataType == typeof(object)))
                    {
                        binding.Parse += new ConvertEventHandler(MemoBinding_Parse);
                        binding.Format += new ConvertEventHandler(MemoBinding_Format);
                    }
                    memo.DataBindings.Add(binding);
                }
                
            }
 
       
            /* prepare controls */
            ActiveControl = null;

            /*  
                        listBox.Visible = mode == PopUpMode.List;
                        checkListBox.Visible = mode == PopUpMode.CheckList;
                        calendar.Visible = mode == PopUpMode.Date;
                        pictureBox.Visible = (mode == PopUpMode.Image) || ((mode == PopUpMode.Blob) && (blobType == PopUpBlobType.Image));
                        memo.Visible = (mode == PopUpMode.Memo) || ((mode == PopUpMode.Blob) && (blobType == PopUpBlobType.Text));
                        grid.Visible = mode == PopUpMode.Grid; 
             */

            if (control != null)
                control.Visible = true;

            if ((grid != null) && grid.Visible)
            {
                if (table != null)
                {
                    bindingSource.DataSource = table;
                    grid.SetupGridColumns(table);

                    if ((visibleColumns != null) && (visibleColumns.Length > 0))
                    {
                        foreach (DataGridViewColumn Column in grid.Columns)
                        {
                            Column.Visible = visibleColumns.ContainsText(Column.DataPropertyName);
                        }
                    }
                }

                grid.AllowUserToAddRows = false;
                grid.AllowUserToDeleteRows = false;
                grid.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

                if (isMultiChoiseGrid)
                {

                    foreach (DataGridViewColumn GridColumn in grid.Columns)
                        GridColumn.ReadOnly = !Sys.IsSameText(GridColumn.DataPropertyName, "Include");

                    mnuGrid = new ContextMenuStrip();
                    mnuSelectAll = new ToolStripMenuItem();
                    mnuDeselectAll = new ToolStripMenuItem();

                    grid.ContextMenuStrip = mnuGrid;
                    mnuGrid.Items.AddRange(new ToolStripItem[] { mnuSelectAll, mnuDeselectAll });

                    mnuSelectAll.Name = "mnuSelectAll";
                    mnuSelectAll.Text = "Select all";

                    mnuDeselectAll.Name = "mnuDeselectAll";
                    mnuDeselectAll.Text = "Deselect all";

                    mnuSelectAll.Click += new EventHandler(Grid_AnyLocalMenu_Click);
                    mnuDeselectAll.Click += new EventHandler(Grid_AnyLocalMenu_Click);

                    grid.Disposed += new EventHandler(Grid_Disposed);
                }
                else
                {
                    grid.ReadOnly = true;
                }

        
                grid.RowHeadersVisible = Bf.Member(PopUpFlags.GridRowHeader, flags);
                grid.ColumnHeadersVisible = Bf.Member(PopUpFlags.GridTitles, flags);

                if (table.Rows.Count <= 1500)
                    grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }

            /* prepare buttons */
            PopUpButtons B = 0;

            switch (mode)
            {
                case PopUpMode.Custom: B = buttons; break;
                case PopUpMode.List: B = PopUpButtons.OK | PopUpButtons.Cancel; break;
                case PopUpMode.CheckList: B = PopUpButtons.OK | PopUpButtons.Cancel; break;
                case PopUpMode.Date: B = PopUpButtons.OK | PopUpButtons.Cancel; break;
                case PopUpMode.Grid: B = PopUpButtons.OK | PopUpButtons.Cancel; break;
                case PopUpMode.Memo: B = (PopUpButtons)Bf.All(typeof(PopUpButtons)); break;
                case PopUpMode.Image: B = (PopUpButtons)Bf.All(typeof(PopUpButtons)); break;
                case PopUpMode.Blob: B = (PopUpButtons)Bf.All(typeof(PopUpButtons)); break;
                case PopUpMode.TreeView: B = PopUpButtons.OK | PopUpButtons.Cancel; break;
            }

            buttons = B;

            btnOK.Visible = Bf.Member(PopUpButtons.OK, buttons);
            btnCancel.Visible = Bf.Member(PopUpButtons.Cancel, buttons);
            btnClear.Visible = Bf.Member(PopUpButtons.Clear, buttons);
            btnSave.Visible = Bf.Member(PopUpButtons.Save, buttons);
            btnLoad.Visible = Bf.Member(PopUpButtons.Load, buttons);


            if (btnCancel.Visible)
                btnCancel.Enabled = true;

            if (btnOK.Visible && !btnLoad.Visible)
            {
                //btnLoad.Visible = true;
                //btnLoad.Enabled = false;
            }

            pnlButtons.Visible = !Bf.IsEmpty(buttons);
        }


        
        /* bounds and size constraints */
        /// <summary>
        /// Calculates the bounds of the form and returns a bounds rectangle.
        /// </summary>
        protected virtual Rectangle CalculateBounds()
        {
            if (UseSpecifiedBounds)
            {
                return SpecifiedBounds;
            }

            int W = stdMinWidth;
            int H = stdMinHeight;

            /* suggested dimension */

            if (calendar != null)
            {
                W = calendar.Width;
                H = calendar.Height - 12;

                if (pnlButtons.Visible)
                    H += 26;
            }

            if (pictureBox != null)
            {
                if (pictureBox.Image != null)
                {
                    W = pictureBox.Image.Width;
                    H = pictureBox.Image.Height;
                }
            }

 



            if (Modal)
                H = H - SystemInformation.CaptionHeight;

            Point P = new Point(0, 0);

            if (associate != null)
            {
                P = associate.Parent.PointToScreen(associate.Bounds.Location);
                P.Y = P.Y + associate.Height;
 
                if (!Bf.Member(mode, PopUpMode.Date | PopUpMode.Image) || ((mode == PopUpMode.Blob) && (blobType != BlobType.Image)))
                {
                    W = associate.Width > W ? associate.Width : W;
                }
            }
            else
            {
                Rectangle SR = Screen.GetWorkingArea(this);
                P.X = (SR.Width - W) / 2;
                P.Y = (SR.Height - H) / 2;
            }

            return new Rectangle(P.X, P.Y, W, H);

        }
        /// <summary>
        /// Positions the form on screen according to R bounds.
        /// </summary>
        protected virtual void ApplyBounds(Rectangle R)
        {

            Rectangle SR = Screen.GetWorkingArea(this);

            if (R.Bottom > SR.Height)
                R.Y = R.Top - R.Height;

            if (R.Top < 0)
                R.Y = 0;

            if (R.Right > SR.Width)
                R.X = R.Left - R.Width;

            if (R.Left < 0)
                R.X = 0;
            else if (R.Right > SR.Width)
                R.X = SR.Width - R.Width;

            this.Bounds = R;

        }
        /// <summary>
        /// Applies min and max size constraints to the form
        /// </summary>
        protected virtual void ApplySizeConstraints(bool Apply)
        {
            this.MaximumSize = new Size(0, 0);
            this.MinimumSize = new Size(0, 0);

            Application.DoEvents();

            if (Apply)
            {
                if (!Bf.Member(PopUpFlags.Sizable, Flags) || (mode == PopUpMode.Date))
                {
                    this.MaximumSize = new Size(Width, Height);
                    this.MinimumSize = new Size(Width, Height);
                }
            }
        }
        /// <summary>
        /// Re-inforces a bounds calculation and application.
        /// </summary>
        protected virtual void ReapplyBounds()
        {
            ApplySizeConstraints(false);
            ApplyBounds(CalculateBounds());
            ApplySizeConstraints(true);
        }

        /* form result */
        /// <summary>
        /// Assigns the formResult variable, passes back any result and closes the form
        /// </summary>
        protected virtual void ProcessCloseCommand(bool IsOk)
        {
            popUpResult = IsOk;

            if (!ReadOnly)
            {
                if (!Modal || (Modal && IsOk))
                {
                    if (mode == PopUpMode.Blob)
                    {
                        binding.WriteValue();
                        table.Rows[0].EndEdit();
                        row[column] = table.Rows[0][0];
                    }
                }
            }

            if (popUpResult)
            {
                formResult = null;

                if (control != null)
                {
                    switch (mode)
                    {
                        case PopUpMode.List: formResult = listBox.SelectedItem; break;
                        case PopUpMode.CheckList: formResult = checkListBox.SelectedItems; break;
                        case PopUpMode.Date: formResult = calendar.SelectionStart; break;
                        case PopUpMode.Grid: formResult = grid.ManagerOf().CurrentRow(); break;
                        case PopUpMode.Memo: formResult = memo.Text; break;
                        case PopUpMode.Image: formResult = pictureBox.Image; break;
                        case PopUpMode.Blob: formResult = table.Rows[0][0]; break;
                        case PopUpMode.TreeView: formResult = treeView.SelectedNode; break;
                    }
                }
            }

            if (Modal)
                DialogResult = IsOk ? DialogResult.OK : DialogResult.Cancel;
            else
                Close();
        }
 

        /* miscs */
        /// <summary>
        /// Sets focus to the associate control.
        /// </summary>
        protected virtual void FocusAssociate()
        {
            if ((associate != null) && associate.CanFocus)
                try
                {
                    associate.Focus();
                }
                catch  
                {
                }
                
        }
        /// <summary>
        /// Enables-disables controls.
        /// </summary>
        protected virtual void EnableControls()
        {
            btnOK.Enabled = !ReadOnly;
            btnSave.Enabled = ((pictureBox != null) && (pictureBox.Image != null)) || ((memo != null) && (memo.Text.Length > 0));
            btnLoad.Enabled = true;
            btnClear.Enabled = !ReadOnly;

            ActiveControl = null;
            if ((control != null) && control.Visible)
                ActiveControl = control;
        }

        /* constructors */
        /// <summary>
        /// Constructor.
        /// <para>NOTE: for design-time only</para>
        /// </summary>
        public PopUpForm()
        {
            InitializeComponent();            
        }
        /// <summary>
        /// Constructor.
        /// <para>Mode: Custom, Control: Any control, the specified Control.</para>
        /// </summary>
        public PopUpForm(Control Control)
            : this()
        {
            if (!DesignMode)
            {
                control = Control;

                this.mode = PopUpMode.Custom;

                InitializeForm();
            }
        }
        /// <summary>
        /// Constructor.
        /// <para>Mode: List, Control: ListBox</para>
        /// </summary>
        public PopUpForm(IEnumerable List, int SelectedIndex)
            : this()
        {
            if (!DesignMode)
            {
                listBox = new ListBox();
                control = listBox;

                this.mode = PopUpMode.List;
                this.flags |= PopUpFlags.Sizable;

                foreach (object item in List)
                    this.listBox.Items.Add(item);
                if (SelectedIndex != -1)
                    this.listBox.SelectedIndex = SelectedIndex;

                InitializeForm();
            }
        }
        /// <summary>
        /// Constructor.
        /// <para>Mode: CheckList, Control: CheckedListBox</para>
        /// </summary>
        public PopUpForm(IEnumerable List, int[] CheckedIndexes)
            : this()
        {
            if (!DesignMode)
            {
                checkListBox = new CheckedListBox();
                control = checkListBox;

                this.mode = PopUpMode.CheckList;
                this.flags |= PopUpFlags.Sizable;
                foreach (object item in List)
                    this.checkListBox.Items.Add(item);

                if (CheckedIndexes != null)
                {
                    foreach (int Index in CheckedIndexes)
                        this.checkListBox.SetItemChecked(Index, true);
                }

                InitializeForm();
            }
        }
        /// <summary>
        /// Constructor.
        /// <para>Mode: Date, Control: CalendarEx</para>
        /// </summary>
        public PopUpForm(DateTime Date)
            : this()
        {
            if (!DesignMode)
            {
                calendar = new CalendarEx();
                control = calendar;

                this.mode = PopUpMode.Date;
                this.calendar.SelectionStart = Date;
                this.calendar.SelectionEnd = Date;

                InitializeForm();
            }
        }
        /// <summary>
        /// Constructor.
        /// <para>Mode: Grid, Control: DataGridView, IsMultiChoise = false</para>
        ///  <para>Row is the a Row of the specified Table, used to position the Grid on it. Could be null though.</para>
        /// </summary>
        public PopUpForm(DataTable Table, DataRow Row, string[] VisibleColumns = null)
            : this()
        {
            if (!DesignMode)
            {
                grid = new DataGridView();
                control = grid;

                this.mode = PopUpMode.Grid;
                this.flags |= PopUpFlags.Sizable | PopUpFlags.GridTitles;
                this.isMultiChoiseGrid = false;
                this.row = Row;
                this.table = Table;
                this.visibleColumns = VisibleColumns;

                InitializeForm();
            }
        }
        /// <summary>
        /// Constructor.
        /// <para>Mode: Grid, Control: DataGridView, IsMultiChoise = true</para>
        /// <para>WARNING: Table MUST contain a DataColumn named Include</para>
        /// </summary>
        public PopUpForm(DataTable Table, string[] VisibleColumns = null)
            : this()
        {
            if (!DesignMode)
            {
                if (!Table.Columns.Contains("Include"))
                    Sys.Error("Table MUST contain a DataColumn named Include!");

                grid = new DataGridView();
                control = grid;

                this.mode = PopUpMode.Grid;
                this.flags |= PopUpFlags.Sizable | PopUpFlags.GridTitles;
                this.isMultiChoiseGrid = true;
                this.table = Table;
                this.visibleColumns = VisibleColumns;

                InitializeForm();
            }
        }
        /// <summary>
        /// Constructor.
        /// <para>Mode: Memo, Control: RichTextBox</para>
        /// </summary>
        public PopUpForm(string Text)
            : this()
        {
            if (!DesignMode)
            {
                memo = new RichTextBox();
                control = memo;

                this.mode = PopUpMode.Memo;
                this.flags |= PopUpFlags.Sizable;
                this.memo.Text = Text;

                InitializeForm();
            }
        }
        /// <summary>
        /// Constructor.
        /// <para>Mode: Image, Control: PictureBox</para>
        /// </summary>
        public PopUpForm(Image Image)
            : this()
        {
            if (!DesignMode)
            {
                pictureBox  = new PictureBox();
                control = pictureBox;

                this.mode = PopUpMode.Image;
                this.flags |= PopUpFlags.Sizable;
                this.pictureBox.Image = Image;

                InitializeForm();
            }
        }
        /// <summary>
        /// Constructor.
        /// <para>Mode: Blob, Control: PictureBox or RichTextBox depending on BlobType </para>
        /// </summary>
        public PopUpForm(DataRow Row, string FieldName, BlobType BlobType)
            : this()
        {
            if (!DesignMode)
            {
                if (BlobType == BlobType.Image)
                {
                    pictureBox = new PictureBox();
                    control = pictureBox;
                }
                else
                {
                    memo = new RichTextBox();
                    control = memo;
                }

                this.mode = PopUpMode.Blob;
                this.flags |= PopUpFlags.Sizable;
                this.blobType = BlobType;
                this.row = Row;
                this.column = Row.Table.Columns[FieldName];

                InitializeForm();
            }
        }
        /// <summary>
        /// Constructor.
        /// <para>Mode: TreeView, Control: TreeView, the specified TreeView</para>
        /// </summary>
        public PopUpForm(TreeView TreeView)
            : this()
        {
            if (!DesignMode)
            {
                treeView = TreeView;
                control = treeView;

                this.mode = PopUpMode.TreeView;
                this.flags |= PopUpFlags.Sizable;
 
                InitializeForm();
            }
        }

        /* static methods */
        /// <summary>
        /// Creates a ListBox form.
        /// </summary>
        static public PopUpForm List(IEnumerable List, int SelectedIndex)
        { 
            PopUpForm Result = new PopUpForm(List, SelectedIndex);
            /*  
                        Result.mode = PopUpMode.List;
                        Result.flags |= PopUpFlags.Sizable;
                        foreach (object item in List)
                            Result.listBox.Items.Add(item);
                        if (SelectedIndex != -1)
                            Result.listBox.SelectedIndex = SelectedIndex; 
             */
            return Result;
        }
        /// <summary>
        /// Creates a CheckedListBox form.
        /// </summary>
        static public PopUpForm CheckList(IEnumerable List, int[] CheckedIndexes = null)
        {
            PopUpForm Result = new PopUpForm(List, CheckedIndexes);
            /*  
                        Result.mode = PopUpMode.CheckList;
                        Result.flags |= PopUpFlags.Sizable;
                        foreach (object item in List)
                            Result.listBox.Items.Add(item); 
             */
            return Result;
        }
        /// <summary>
        /// Creates a MonthCalendar form.
        /// </summary>
        static public PopUpForm Date(DateTime Date)
        {
            PopUpForm Result = new PopUpForm(Date);
            /*  
                        Result.mode = PopUpMode.Date;
                        Result.calendar.SelectionStart = Date;
                        Result.calendar.SelectionEnd = Date; 
             */
            return Result;
        }
        /// <summary>
        /// Creates a DataGridView form.
        /// <para>Row is the a Row of the specified Table, used to position the Grid on it. Could be null though.</para>
        /// </summary>
        static public PopUpForm Table(DataTable Table, DataRow Row, string[] VisibleColumns = null)
        {
            PopUpForm Result = new PopUpForm(Table, Row, VisibleColumns);
            /*  
                        Result.mode = PopUpMode.Grid;
                        Result.flags |= PopUpFlags.Sizable | PopUpFlags.GridTitles;
                        Result.isMultiChoiseGrid = false;
                        Result.row = Row;
                        Result.table = Table; 
             */
            return Result;
        }
        /// <summary>
        /// Creates a DataGridView form.
        /// <para>The Table must contain a boolean Column named Include</para>
        /// </summary>
        static public PopUpForm MultiChoise(DataTable Table, string[] VisibleColumns = null)
        {
            if (!Table.Columns.Contains("Include"))
                return PopUpForm.Table(Table, null, VisibleColumns);

            PopUpForm Result = new PopUpForm(Table, VisibleColumns);
            /*  
                        Result.mode = PopUpMode.Grid;
                        Result.flags |= PopUpFlags.Sizable | PopUpFlags.GridTitles;
                        Result.isMultiChoiseGrid = true;
                        Result.table = Table; 
             */
            return Result;
        }
        /// <summary>
        /// Creates a RichTextBox form.
        /// </summary>
        static public PopUpForm MemoText(string Text)
        {
            PopUpForm Result = new PopUpForm(Text);
            /*  
                        Result.mode = PopUpMode.Memo;
                        Result.flags |= PopUpFlags.Sizable;
                        Result.memo.Text = Text; 
             */
            return Result;
        }
        /// <summary>
        /// Creates a PictureBox form.
        /// </summary>
        static public PopUpForm Picture(Image Image)
        {
            PopUpForm Result = new PopUpForm(Image);
            /*  
                        Result.mode = PopUpMode.Image;
                        Result.flags |= PopUpFlags.Sizable;
                        Result.pictureBox.Image = Image; 
             */
            return Result;
        }
        /// <summary>
        /// Creates a form bound to either an image or text blob column.
        /// It uses a PictureBox or a RichTextBox accordingly.
        /// </summary>
        static public PopUpForm Blob(DataRow Row, string FieldName, BlobType BlobType)
        {
            if ((Row != null) && Row.Table.Columns.Contains(FieldName))
            {
                PopUpForm Result = new PopUpForm(Row, FieldName, BlobType);
                /*  
                                Result.mode = PopUpMode.Blob;
                                Result.flags |= PopUpFlags.Sizable;
                                Result.blobType = BlobType;
                                Result.row = Row;
                                Result.column = Row.Table.Columns[FieldName]; 
                 */

                return Result;
            }

            return null;
        }
        /// <summary>
        /// Creates a TreeVie form
        /// </summary>
        static public PopUpForm Tree(TreeView TreeView)
        {
            return new PopUpForm(TreeView);
        }



        /* image and text blob drop-down */
        /// <summary>
        /// Displays Form as a drop-down box, for either text memos or image blobs displayed on the Grid 
        /// in a column specified by FieldName
        /// </summary>
        static public void DropDownBlob(ref PopUpForm Form, DataGridView Grid, string FieldName, bool IsTextBlob)
        {
            if ((Form == null) || Form.IsDisposed)
                Form = null;

            if (Form != null)
            {
                if (!Form.IsDisposed)
                {
                    Form.Close();
                }

                Form = null;
            }
            else
            {
                DataRow Row = Grid.CurrentDataRow();
                if (Row == null)
                    return;

                Form = PopUpForm.Blob(Row, FieldName, IsTextBlob ? BlobType.Text : BlobType.Image);
                Form.Associate = Grid.EditingControl;
                Form.DropDown();
            }
        }
        /// <summary>
        /// Displays Form as a drop-down box, for image blobs displayed on the Grid 
        /// in a column specified by FieldName
        /// </summary>
        static public void DropDownImage(ref PopUpForm Form, DataGridView Grid, string FieldName)
        {
            DropDownBlob(ref Form, Grid, FieldName, false);
        }
        /// <summary>
        /// Displays Form as a drop-down box, for text memos displayed on the Grid 
        /// in a column specified by FieldName
        /// </summary>
        static public void DropDownTextMemo(ref PopUpForm Form, DataGridView Grid, string FieldName)
        {
            DropDownBlob(ref Form, Grid, FieldName, true);
        }


        /// <summary>
        /// Shows the form as a drop down box.
        /// </summary>
        public void DropDown()
        {
            // Show();
            Prepare();
            ReapplyBounds();

            Show();            
        }


        /* properties */
        /// <summary>
        /// Returns the "mode" of the form
        /// </summary>
        public PopUpMode Mode { get { return mode; } }
        /// <summary>
        /// Gets or sets the associate control of the form. Used with drop-down like forms.
        /// </summary>
        public Control Associate
        {
            get { return associate; }
            set 
            {
                if (!displaying)
                {
                    associate = value;
                }
            }
        }
        /// <summary>
        /// Gets or sets the button flags. Used with custom "mode" forms only.
        /// </summary>
        public PopUpButtons Buttons
        {
            get { return buttons; }
            set
            {
                if (!displaying)
                    buttons = value;
            }
        }
        /// <summary>
        /// Gets or sets the flags of the form.
        /// </summary>
        public PopUpFlags Flags
        {
            get { return flags; }
            set
            {
                if (!displaying)
                    flags = value;
            }
        }
        /// <summary>
        /// Gets or sets the readonly flag.
        /// </summary>
        public bool ReadOnly
        {
            get { return readOnly; }
            set
            {
                if (!displaying)
                    readOnly = value;
            }
        }
        /// <summary>
        /// Returns the "result" boolean flag of the form. It is true either with modal or drop-down forms
        /// if the user presses the OK button.
        /// </summary>
        public bool PopUpResult { get { return popUpResult || (DialogResult == DialogResult.OK); } }
        /// <summary>
        /// Gets the result object of the form. It depends on the Mode.
        /// </summary>
        public object FormResult { get { return formResult; } }
        /// <summary>
        /// True while the form is visible.
        /// </summary>
        public bool Displaying { get { return displaying; } }
        /// <summary>
        /// Gets or sets the standard minimum height.
        /// </summary>
        public int StdMinHeight
        {
            get { return stdMinHeight; }
            set
            {
                if (value != stdMinHeight)
                {
                    stdMinHeight = value;
                    if (displaying)
                        ReapplyBounds();
                }
            }
        }
        /// <summary>
        /// Gets or sets the standard minimum width.
        /// </summary>
        public int StdMinWidth
        {
            get { return stdMinWidth; }
            set
            {
                if (value != stdMinWidth)
                {
                    stdMinWidth = value;
                    if (displaying)
                        ReapplyBounds();
                }
            }
        }

        /// <summary>
        /// When true, no bouns calculation takes place
        /// </summary>
        public bool UseSpecifiedBounds { get; set; }
        /// <summary>
        /// Form bounds specified by a caller code, just before calling DropDown()
        /// </summary>
        public Rectangle SpecifiedBounds { get; set; }

        /// <summary>
        /// Gets the Control
        /// </summary>
        public Control Control { get { return control; } }
        /// <summary>
        /// Gets the ListBox control
        /// </summary>
        public ListBox ListBox { get { return listBox; } }
        /// <summary>
        /// Gets the CheckedListBox control
        /// </summary>
        public CheckedListBox CheckListBox { get { return checkListBox; } }
        /// <summary>
        /// Gets the MonthCalendar control
        /// </summary>
        public MonthCalendar Calendar { get { return calendar; } }
        /// <summary>
        /// Gets the PictureBox control
        /// </summary>
        public PictureBox PictureBox { get { return pictureBox; } }
        /// <summary>
        /// Gets the RichTextBox control
        /// </summary>
        public RichTextBox Memo { get { return memo; } }
        /// <summary>
        /// Gets the DataGridView control
        /// </summary>
        public DataGridView Grid { get { return grid; } }
        /// <summary>
        /// Gets the TreeView control
        /// </summary>
        public TreeView TreeView { get { return treeView; } }

        /* events */
        /// <summary>
        /// Occurs after OnShown
        /// </summary>
        public event EventHandler ShowAfter;
        /// <summary>
        /// Occurs before OnClose
        /// </summary>
        public event EventHandler CloseBefore;

    }


}




 