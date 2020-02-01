using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

using System.Windows.Forms.Design;
using System.ComponentModel.Design;

using Tripous.Model;

namespace Tripous.Forms
{
    /*
    - To create a scrolling container for one or more UiGroup instances
        this.AutoScroll = false;
        this.HorizontalScroll.Enabled = false;
        this.HorizontalScroll.Visible = false; 
    */

    /// <summary>
    /// Represents a control that can be placed on a <see cref="UiViewInfo"/>
    /// </summary>
    [Designer(typeof(UiControlRowControlDesigner))]
    public partial class UiControlRow : UserControl, IUiControlRow
    {
        /// <summary>
        /// Constant
        /// </summary>
        protected const int TextPanelDefaultHeight = 28;
        /// <summary>
        /// Constant
        /// </summary>
        protected const int ControlPanelMultilineDefaultHeight = 163;
        /// <summary>
        /// Constant
        /// </summary>
        protected const int HeightPadding = 3;
        /// <summary>
        /// Constant
        /// </summary>
        protected const int WidthPadding = 6;

        //bool Layouting;
        int fSplit = 35;
        bool fTextOnTop;
        bool fReadOnly;
        bool fRequired;
        string fDataSourceName;
        string fDataField;

        /// <summary>
        /// True when is a control row with a multiline control, such as grid, list box, etc
        /// </summary>
        protected virtual bool IsMultiLine { get { return false; } }

        /// <summary>
        /// Updates the width of the text panel
        /// </summary>
        protected virtual void UpdateTextPanelWidth()
        {
            if (!TextOnTop && pnlText.Visible)
                pnlText.Width = Convert.ToInt32((Width / 100) * Split);
        }
        /// <summary>
        /// Updates the height of the control
        /// </summary>
        protected virtual void LayoutControls()
        {
            if (Control != null)
            {
                this.MaximumSize = new Size(0, 0);
                this.MinimumSize = new Size(0, 0);

                // control
                Control.Dock = DockStyle.None;
                Control.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                if (IsMultiLine)
                    Control.Anchor |= AnchorStyles.Bottom;

                int L = WidthPadding;
                int T = HeightPadding;
                int W = pnlControl.Width - (WidthPadding * 2);
                int H = !IsMultiLine ? Control.Height - (HeightPadding * 2) : pnlControl.Height - (HeightPadding * 2);
                this.Control.SetBounds(L, T, W, H);

                pnlControl.Height = !IsMultiLine ? Control.Height + (HeightPadding * 2) : pnlControl.Height;

                if (TextOnTop)
                {
                    int TextPanelHeight = 0;
                    if (pnlText.Visible)
                    {
                        this.pnlText.Height = TextPanelDefaultHeight;
                        TextPanelHeight = this.pnlText.Height;
                    }

                    this.Height = pnlControl.Height + TextPanelHeight;
                }
                else
                {
                    pnlText.Height = pnlControl.Height;
                    this.Height = pnlControl.Height;
                }

                if (!IsMultiLine)
                {
                    this.MaximumSize = new Size(0, this.Height);
                    this.MinimumSize = new Size(0, this.Height);
                }

            }
 

        }
        /// <summary>
        /// Calls all custom update methods
        /// </summary>
        protected virtual void UpdateAll()
        {
            UpdateTextPanelWidth();
            LayoutControls();
        }
        /// <summary>
        /// Called on a property change
        /// </summary>
        protected virtual void OnTextOnTopChanged()
        {
            pnlText.Dock = DockStyle.None;
            pnlControl.Dock = DockStyle.None;
            LayoutControls();

            if (TextOnTop)
            {
                pnlText.Dock = DockStyle.Top;
                pnlControl.Dock = DockStyle.Top;                
            }
            else
            {                
                UpdateTextPanelWidth(); 
                pnlText.Dock = DockStyle.Left;
                pnlControl.Dock = DockStyle.Fill;                
            } 
            
        }
       
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnSizeChanged(EventArgs e)
        {
            UpdateTextPanelWidth();
            base.OnSizeChanged(e);
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnParentChanged(EventArgs e)
        {
            UpdateAll();
            base.OnParentChanged(e);
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            //UpdateTextPanelWidth();
            //LayoutControls();
        }

        /// <summary>
        /// Called on a property change
        /// </summary>
        protected virtual void OnSplitChanged()
        {
            UpdateTextPanelWidth();
        }
        /// <summary>
        /// Called on a property change
        /// </summary>
        protected virtual void OnReadOnlyChanged()
        {
            if (Control != null)
            {
                PropertyInfo PropInfo = Control.GetType().GetProperty("ReadOnly");
                if (PropInfo != null)
                    PropInfo.SetValue(Control, this.ReadOnly, null);
            }
        }
        /// <summary>
        /// Called on a property change
        /// </summary>
        protected virtual void OnRequiredChanged()
        {
            FontStyle Style = Required ? FontStyle.Bold : FontStyle.Regular;
            lblText.Font = new Font(lblText.Font, Style);
        }
        /// <summary>
        /// Called on a property change
        /// </summary>
        protected virtual void OnDataSourceNameChanged()
        {

        }
        /// <summary>
        /// Called on a property change
        /// </summary>
        protected virtual void OnDataFieldChanged()
        {

        }
        /// <summary>
        /// Called when the caption text of the label is changed.
        /// </summary>
        protected virtual void OnCaptionTextChanged(object sender, EventArgs e)
        {
            pnlText.Visible = !string.IsNullOrWhiteSpace(lblText.Text);
        }
        /// <summary>
        /// Returns the value of the <see cref="Value"/> property
        /// </summary>
        protected virtual object GetValue()
        {
            return null;
        }
        /// <summary>
        /// Sets the value of the <see cref="Value"/> property
        /// </summary>
        protected virtual void SetValue(object V)
        {
        }

        /// <summary>
        /// The name of the property to bind to
        /// </summary>
        protected virtual string BindPropertyName { get; }

        /* constructor */
        /// <summary>
        /// Constructor
        /// </summary>
        public UiControlRow()
        {
            InitializeComponent();


            lblText.TextChanged += OnCaptionTextChanged;
        }

        /// <summary>
        /// Returns the parent IControlRow of the specified Control, if any, else null.
        /// </summary>
        static public IUiControlRow ParentRowOf(Control Control)
        {
            while (Control != null)
            {
                if (Control is IUiControlRow)
                    return Control as IUiControlRow;
                Control = Control.Parent;
            }

            return null;
        }


        /* public */
        /// <summary>
        /// Data bind method
        /// </summary>
        public virtual Binding Bind()
        { 
            return Ui.Bind(Control, BindPropertyName, DataSource, DataField);
        }
        /// <summary>
        /// Called by a parent <see cref="UiGroup"/> when the size changing of that parent "changes screen mode".
        /// </summary>
        public virtual void OnScreenModeChanged(ScreenMode Mode)
        {
        }

        /* properties */
        /// <summary>
        /// The control text (caption)
        /// </summary>
        [DefaultValue("Text")]
        public virtual string Caption
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }
        /// <summary>
        /// Percent of the Text portion.
        /// </summary>
        [DefaultValue(35)]
        public virtual int Split
        {
            get { return fSplit; }
            set
            {
                if (fSplit != value && value > 10 && value < 50)
                {
                    fSplit = value;
                    OnSplitChanged();
                }
            }
        }
        /// <summary>
        /// True means stack as column (text on top), false means stack as row.
        /// </summary>
        [DefaultValue(false)]
        public virtual bool TextOnTop
        {
            get { return fTextOnTop; }
            set
            {
                if (fTextOnTop != value)
                {
                    fTextOnTop = value;
                    OnTextOnTopChanged();
                }
            }
        }
        /// <summary>
        /// When true the control is readonly
        /// </summary>
        [DefaultValue(false)]
        public virtual bool ReadOnly
        {
            get { return fReadOnly; }
            set
            {
                if (fReadOnly != value)
                {
                    fReadOnly = value;
                    OnReadOnlyChanged();
                }
            }
        }
        /// <summary>
        /// When true the control must have a value
        /// </summary>
        [DefaultValue(false)]
        public virtual bool Required
        {
            get { return fRequired; }
            set
            {
                if (fRequired != value)
                {
                    fRequired = value;
                    OnRequiredChanged();
                }
            }
        }

        /// <summary>
        /// The data source name. When empty then it binds to its parent's source.
        /// </summary>
        [DefaultValue("")]
        public virtual string DataSourceName
        {
            get { return fDataSourceName; }
            set
            {
                if (fDataSourceName != value)
                {
                    fDataSourceName = value;
                    OnDataSourceNameChanged();
                }
            }
        }
        /// <summary>
        /// The data field to bind
        /// </summary>
        [DefaultValue("")]
        public virtual string DataField
        {
            get { return fDataField; }
            set
            {
                if (fDataField != value)
                {
                    fDataField = value;
                    OnDataFieldChanged();
                }
            }
        }
        /// <summary>
        /// The data source of the Control.
        /// </summary>
        [DefaultValue(null), Browsable(false), Description("The data source of the Control."), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual object DataSource { get; set; }

        /// <summary>
        /// The value of the control
        /// </summary>
        [Browsable(false)]
        public virtual object Value
        {
            get { return GetValue(); }
            set { SetValue(value); }
        }
        /// <summary>
        /// The text label 
        /// </summary>
        [Browsable(false)]
        public Label Label { get { return lblText; } }
        /// <summary>
        /// The control 
        /// </summary>
        [Browsable(false)]
        public Control Control { get; protected set; }
        /// <summary>
        /// Hides a property from PropertyGrid
        /// </summary>
        [Browsable(false)]
        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = value; }
        /// <summary>
        /// Hides a property from PropertyGrid
        /// </summary>
        [Browsable(false)]
        new public AutoSizeMode AutoSizeMode { get => base.AutoSizeMode; set => base.AutoSizeMode = value; }
    }




}
