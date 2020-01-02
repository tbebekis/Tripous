using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

using Tripous.Model;

namespace Tripous.Forms
{

    /// <summary>
    /// Represents a control that can be placed on a <see cref="UiView"/>
    /// </summary>
    public partial class DataControl : UserControl, IDataBindControl
    {
        protected const int TextPanelDefaultHeight = 28;
        int fSplit = 35;
        bool fStacked;
        bool fReadOnly;
        bool fRequired;
        string fDataSourceName;
        string fDataField;

        /// <summary>
        /// Updates the width of the text panel
        /// </summary>
        protected virtual void UpdateTextPanelWidth()
        {
            if (!Stacked && pnlText.Visible)
                pnlText.Width = Convert.ToInt32((Width / 100) * Split);
        }
        /// <summary>
        /// Updates the height after a change to <see cref="Stacked"/> property
        /// </summary>
        protected virtual void UpdateHeight()
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            if (Stacked)
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
                this.Height = pnlControl.Height;
                this.AutoSize = false;
            } 
        }
        /// <summary>
        /// Calls all custom update methods
        /// </summary>
        protected virtual void UpdateAll()
        {
            UpdateTextPanelWidth();
            UpdateHeight();
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
        /// Called on a property change
        /// </summary>
        protected virtual void OnStackedChanged()
        {
            if (Stacked)
            {
                pnlControl.Dock = DockStyle.None;
                pnlText.Dock = DockStyle.Top;
                pnlControl.Dock = DockStyle.Top;
            }
            else
            {
                pnlControl.Dock = DockStyle.None;
                pnlText.Dock = DockStyle.Left;
                pnlControl.Dock = DockStyle.Fill;
                UpdateTextPanelWidth();
            }

            UpdateHeight();
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
        public DataControl()
        {
            InitializeComponent();


            lblText.TextChanged += OnCaptionTextChanged;
        }

        /* public */
        /// <summary>
        /// Data bind method
        /// </summary>
        public virtual Binding Bind()
        { 
            return Ui.Bind(Control, BindPropertyName, DataSource, DataField);
        }


        /* properties */
        /// <summary>
        /// The control text (caption)
        /// </summary>
        public virtual string Caption
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }
        /// <summary>
        /// Percent of the Text portion.
        /// </summary>
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
        /// True means stack as column, false means stack as row.
        /// </summary>
        public virtual bool Stacked
        {
            get { return fStacked; }
            set
            {
                if (fStacked != value)
                {
                    fStacked = value;
                    OnStackedChanged();
                }
            }
        }
        /// <summary>
        /// When true the control is readonly
        /// </summary>
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
