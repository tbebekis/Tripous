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
    /// <summary>
    /// CheckBox <see cref="UserControl"/>
    /// </summary>
    public partial class CheckBoxControlRow : UserControl, IControlRow
    {
        bool fReadOnly;
        bool fRequired;
        string fDataSourceName;
        string fDataField;

        /// <summary>
        /// Override
        /// </summary>
        protected override void OnSizeChanged(EventArgs e)
        {
            UpdateTextPanelWidth();
            base.OnSizeChanged(e);
        }

        /// <summary>
        /// Updates the width of the text panel
        /// </summary>
        protected virtual void UpdateTextPanelWidth()
        {
            Size Size = TextRenderer.MeasureText(lblText.Text, pnlText.Font, new Size(pnlText.ClientSize.Width, 0), TextFormatFlags.WordBreak);
            int H = Size.Height + pnlText.Padding.Top + pnlText.Padding.Bottom + this.Padding.Top + this.Padding.Bottom;
            if (H <= 28)
                return;

            this.Height = H;
        }
        /// <summary>
        /// Called when the caption text is changed.
        /// </summary>
        protected virtual void OnCaptionTextChanged(object sender, EventArgs e)
        {
            UpdateTextPanelWidth();
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnParentChanged(EventArgs e)
        {
            UpdateTextPanelWidth();
            base.OnParentChanged(e);
        }

        /// <summary>
        /// Called on a property change
        /// </summary>
        protected virtual void OnReadOnlyChanged()
        {
            if (Control != null)
            {
                chBox.Enabled = !ReadOnly;
            }
        }
        /// <summary>
        /// Called on a property change
        /// </summary>
        protected virtual void OnRequiredChanged()
        {
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
        /// Returns the value of the <see cref="Value"/> property
        /// </summary>
        protected virtual object GetValue()
        {
            return chBox.Checked;
        }
        /// <summary>
        /// Sets the value of the <see cref="Value"/> property
        /// </summary>
        protected virtual void SetValue(object V)
        {
            try
            {
                if (Sys.IsNull(V))
                {
                    chBox.Checked = false;
                }
                else if (V.GetType().IsAssignableFrom(typeof(bool)))
                {
                    chBox.Checked = Convert.ToBoolean(V);
                }
            }
            catch  
            {
            }
        }


        /* constructor */
        /// <summary>
        /// Constructor
        /// </summary>
        public CheckBoxControlRow()
        {
            InitializeComponent();

            this.Control = chBox;
            Dock = DockStyle.Top;

            this.lblText.TextChanged += OnCaptionTextChanged;
        }



        /* public */
        /// <summary>
        /// Data bind method
        /// </summary>
        public virtual Binding Bind()
        {
            string PropertyName = "CheckState"; //"CheckState";       // Checked  CheckState
            return Ui.Bind(Control, PropertyName, DataSource, DataField);
        }



        /* properties */
        /// <summary>
        /// The control text (caption)
        /// </summary>
        public virtual string Caption
        {
            get { return lblText.Text; }
            set 
            { 
                if (lblText.Text != value)
                {
                    lblText.Text = value;
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
        public object DataSource { get; set; }

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
        /// The control 
        /// </summary>
        [Browsable(false)]
        public Control Control { get; protected set; }
 
        /// <summary>
        /// Hides a property from PropertyGrid
        /// </summary>
        [Browsable(false)]
        new public AutoSizeMode AutoSizeMode { get => base.AutoSizeMode; set => base.AutoSizeMode = value; }

        /// <summary>
        /// Indicates the cheked state of the control
        /// </summary>
        [DefaultValue(true), Description("Indicates the cheked state of the control"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Checked
        {
            get { return chBox.Checked; }
            set { chBox.Checked = value; }
        }
        /// <summary>
        /// The control
        /// </summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CheckBox Box { get { return chBox; } }
    }
}
