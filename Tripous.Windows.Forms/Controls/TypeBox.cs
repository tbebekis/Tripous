/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Threading;

 

namespace Tripous.Windows.Forms
{

    /// <summary>
    /// A TextBox class capable of editing any Type that provides a TypeConverter and a UITypeEditor. 
    /// <para>Heavily based on the http://www.codeproject.com/KB/database/DataGridEdtAlmostAnythin.aspx, 
    /// special thanks to the author, Declan Brennan, for the brilliant idea and his code.</para>
    /// </summary>
    [ToolboxBitmap(typeof(TextBox))]
    public class TypeBox : TextBox, IWindowsFormsEditorService, IServiceProvider, ITypeDescriptorContext, ISupportInitialize 
    {
        /* fields */
 

        /// <summary>
        /// Field
        /// </summary>
        protected bool initializing;
        /// <summary>
        /// Field
        /// </summary>
        protected bool setting;
        /// <summary>
        /// Field
        /// </summary>
        protected object dataValue;
        /// <summary>
        /// Field
        /// </summary>
        protected object delayedValue;
        /// <summary>
        /// Field
        /// </summary>
        protected Button button = new Button();
        /// <summary>
        /// Field
        /// </summary>
        protected bool fUseStringAsUnderlyingType;
        /// <summary>
        /// Field
        /// </summary>
        protected TypeConverter.StandardValuesCollection standardValues;
        /// <summary>
        /// Field
        /// </summary>
        protected Type fDataType = null;
        /// <summary>
        /// Field
        /// </summary>
        protected UITypeEditor typeEditor;
        /// <summary>
        /// Field
        /// </summary>
        protected TypeConverter typeConverter;

        /* dropdown */
        /// <summary>
        /// Field
        /// </summary>
        const int defaultHeight = 95;
        /// <summary>
        /// Field
        /// </summary>
        protected Form dropDownForm;
        /// <summary>
        /// Field
        /// </summary>
        protected Control control;
        /// <summary>
        /// Field
        /// </summary>
        protected ListBox listBox;

        /* dropdown  form, control, list box, button and text box event handlers */
        private void DropDownForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                dropDownForm.Hide();
            }
            else base.OnKeyDown(e);

        }
        private void DropDownForm_Deactivate(object sender, EventArgs e)
        {
            (this as IWindowsFormsEditorService).CloseDropDown();
        }
        private void DropDownControl_Layout(object sender, LayoutEventArgs e)
        {
            if (dropDownForm != null)
            {
                Size size = ((Control)sender).Size;

                if (sender == listBox)
                {
                    int height = defaultHeight;
                    int maxHeight = listBox.ItemHeight * listBox.Items.Count + 4;
                    if (height > maxHeight)
                        height = maxHeight;
                    if (size.Height != height)
                    {
                        size.Height = height;
                        listBox.Size = size;
                    }
                }

                dropDownForm.Size = size;
            }
        }
        private void ListBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.Value = listBox.SelectedItem;
            (this as IWindowsFormsEditorService).CloseDropDown();
        }
        private void ListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Return)
            {
                this.Value = listBox.SelectedItem;
                (this as IWindowsFormsEditorService).CloseDropDown();
                e.Handled = true;
            }
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            if (typeEditor != null)
            {
                Value = typeEditor.EditValue(this as ITypeDescriptorContext, this as IServiceProvider, dataValue);
            }
            else if (standardValues != null)
            {
                if (listBox == null)
                {
                    listBox = new ListBox();
                    foreach (object obj in this.standardValues)
                        listBox.Items.Add(obj);
                    listBox.MouseUp += new MouseEventHandler(ListBox_MouseUp);
                    listBox.KeyPress += new KeyPressEventHandler(ListBox_KeyPress);
                    listBox.Font = this.Font;
                    listBox.ForeColor = this.ForeColor;
                    listBox.BackColor = this.BackColor;
                    listBox.Size = new Size(DropDownWidth, 95);
                    listBox.IntegralHeight = true;

                    int Index = this.AutoCompleteCustomSource.IndexOf(this.Text);
                    if (Index != -1)
                        listBox.SelectedIndex = Index;
                }

                listBox.SelectedItem = this.Value;
                (this as IWindowsFormsEditorService).DropDownControl(listBox);
            }
        }

        #region IWindowsFormsEditorService, IServiceProvider, ITypeDescriptorContext, ISupportInitialize

        /* IWindowsFormsEditorService */
        /// <summary>
        /// Closes the drop down
        /// </summary>
        void IWindowsFormsEditorService.CloseDropDown()
        {
            control = null;

            if (dropDownForm != null)
                dropDownForm.Visible = false;
        }
        /// <summary>
        /// Shows the dialog
        /// </summary>
        DialogResult IWindowsFormsEditorService.ShowDialog(Form dialog)
        {
            return dialog.ShowDialog(this.TopLevelControl);
        }
        /// <summary>
        /// Displays the drop down area.
        /// </summary>
        void IWindowsFormsEditorService.DropDownControl(Control control)
        {
            if (dropDownForm == null)
            {
                dropDownForm = new Form();
                dropDownForm.KeyPreview = true;
                dropDownForm.StartPosition = FormStartPosition.Manual;
                dropDownForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                dropDownForm.ControlBox = false;
                dropDownForm.Text = string.Empty;
                dropDownForm.ShowInTaskbar = false;
                dropDownForm.BackColor = SystemColors.ActiveCaption;

                dropDownForm.Deactivate += new EventHandler(DropDownForm_Deactivate);
                dropDownForm.KeyDown += new KeyEventHandler(DropDownForm_KeyDown);
            }

            dropDownForm.Location = DropDownLocation;
            dropDownForm.Size = control.Size;

            control.Location = new System.Drawing.Point(0, 0);
            control.Size = dropDownForm.Size;
            control.Layout += new LayoutEventHandler(DropDownControl_Layout);

            dropDownForm.Controls.Add(control);

            this.control = control;
            dropDownForm.Show();

            while (dropDownForm.Visible)
            {
                Application.DoEvents();
                Thread.Sleep(5);
            }

            dropDownForm.Controls.Remove(control);
            dropDownForm.Hide();
        }

        /* IServiceProvider */
        /// <summary>
        ///  Returns an object that represents a service provided by the Component or by its Container.
        /// </summary>
        object IServiceProvider.GetService(Type serviceType)
        {
            if (serviceType == typeof(IWindowsFormsEditorService))
                return this as IWindowsFormsEditorService;
            else
                return base.GetService(serviceType);
        }

        /* ITypeDescriptorContext */
        /// <summary>
        /// Raises the ComponentChanged event.
        /// </summary>
        void ITypeDescriptorContext.OnComponentChanged()
        {
            // nothing
        }
        /// <summary>
        /// Returns a value indicating whether the component can be changed
        /// </summary>
        bool ITypeDescriptorContext.OnComponentChanging()
        {
            return false;
        }
        /// <summary>
        /// Gets the instance of the object that is connected with this TypeDescriptor request
        /// </summary>
        object ITypeDescriptorContext.Instance { get { return null; } }
        /// <summary>
        /// Gets the container representing this TypeDescriptor request
        /// </summary>
        IContainer ITypeDescriptorContext.Container { get { return null; } }
        /// <summary>
        /// Gets the PropertyDescriptor that describes the given context item.
        /// </summary>
        PropertyDescriptor ITypeDescriptorContext.PropertyDescriptor { get { return null; } }

        /* ISupportInitialize */
        /// <summary>
        /// Signals that initialization is starting.
        /// </summary>
        void ISupportInitialize.BeginInit()
        {
            initializing = true;
        }
        /// <summary>
        /// Signals that initialization is complete.
        /// </summary>
        void ISupportInitialize.EndInit()
        {
            initializing = false;
            // We can now act upon the DelayedValue as we can be sure that PropertyType has been assigned. 
            if (delayedValue != null)
                this.Value = delayedValue;
            delayedValue = null;
        }
        #endregion

        /* overridables */
        /// <summary>
        /// Layouts the button
        /// </summary>
        protected virtual void LayoutButton()
        {

            switch (this.BorderStyle)
            {
                case BorderStyle.Fixed3D:
                    button.Width = Height - 1;
                    button.Height = Height - 3;
                    button.Top = 0;
                    button.Left = Width - (button.Width + 3);
                    break;
                case BorderStyle.FixedSingle:
                    button.Width = Height - 1;
                    button.Height = Height - 2;
                    button.Top = 1;
                    button.Left = Width - (button.Width + 1);
                    break;
                case BorderStyle.None:
                    button.Width = Height - 1;
                    button.Height = Height - 1;
                    button.Top = 0;
                    button.Left = Width - (button.Width + 1);
                    break;
            }

            button.Visible = CanDisplayButton;
        }
        /// <summary>
        /// Returns true if the button MUST be visible
        /// </summary>
        protected virtual bool CanDisplayButton
        {
            get
            {
                UITypeEditorEditStyle editStyle = UITypeEditorEditStyle.None;

                if (typeEditor != null)
                    editStyle = typeEditor.GetEditStyle(this as ITypeDescriptorContext);
                else if ((typeConverter != null) && typeConverter.GetStandardValuesSupported())
                    editStyle = UITypeEditorEditStyle.DropDown;

                return (editStyle != UITypeEditorEditStyle.None) && !ReadOnly;

            }
        }
        /// <summary>
        /// Returns the drop-down width
        /// </summary>
        protected virtual int DropDownWidth { get { return this.Width; } }
        /// <summary>
        /// Returns the drop down Location
        /// </summary>
        protected virtual Point DropDownLocation
        {
            get
            {
                try
                {
                    Point P = this.PointToScreen(new Point(0, 0));
                    P.Y += this.Height;
                    P.X -= 2;
                    return P;
                }
                catch
                {
                }

                return new Point(0, 0);
            }
        }

        /// <summary>
        /// Triggers the associated event
        /// </summary>
        protected virtual void OnValueChanged()
        {
            if (ValueChanged != null)
                ValueChanged(this, EventArgs.Empty);
        }
        /// <summary>
        /// Triggers the associated event
        /// </summary>
        protected virtual void OnDataTypeChanged()
        {
            if (DataTypeChanged != null)
                DataTypeChanged(this, EventArgs.Empty);
        }
        /// <summary>
        /// Triggers the associated event
        /// </summary>
        protected virtual void OnUseStringAsUnderlyingTypeChanged()
        {
            if (UseStringAsUnderlyingTypeChanged != null)
                UseStringAsUnderlyingTypeChanged(this, EventArgs.Empty);
        }

        /* overrides */
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (button.Visible && e.Shift && (e.KeyCode == Keys.Return))
                button.PerformClick();
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);

            if (this.AutoCompleteCustomSource.Count != 0)
            {
                int Index = this.AutoCompleteCustomSource.IndexOf(this.Text);
                if (Index != -1)
                {
                    Index++;
                    if (Index >= this.AutoCompleteCustomSource.Count)
                        Index = 0;
                    this.Text = this.AutoCompleteCustomSource[Index];

                    this.SelectAll();
                }
            }
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            AsString = this.Text;
        }


        /// <summary>
        /// Override
        /// </summary>
        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
            LayoutButton();
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            if (listBox != null)
            {
                listBox.Dispose();
                listBox = null;
            }
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            if (listBox != null)
            {
                listBox.Dispose();
                listBox = null;
            }
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            if (listBox != null)
            {
                listBox.Dispose();
                listBox = null;
            }
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            this.button.Enabled = this.Enabled;
        }

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public TypeBox()
        {
            button.BackColor = SystemColors.Control;
            button.Visible = false;
            button.Click += new System.EventHandler(Button_Click);

            button.Parent = this;
        }

 

        /* properties */
        /// <summary>
        /// The value of the data that is being edited
        /// </summary>
        [Description("The value of the data that is being edited"), Localizable(false)]
        public object Value
        {
            get
            {
                if (fUseStringAsUnderlyingType)
                    return (dataValue == null) ? string.Empty : typeConverter.ConvertToInvariantString(dataValue);
                else
                    //return (dataValue == null && !DesignMode) ? Convert.DBNull : dataValue;
                    return (dataValue == null && !DesignMode) ? null : dataValue;
            }
            set
            {


                if (initializing)
                {
                    delayedValue = value;
                    return;
                }

                object newObject = null;

                //if (value == Convert.DBNull)
                if (value == null)
                    newObject = null;

                else if (fUseStringAsUnderlyingType)
                {
                    string s = value as String;
                    if (s != null)
                    {
                        try
                        {
                            newObject = typeConverter.ConvertFromInvariantString(s);
                        }
                        catch
                        {
                        }
                    }
                }
                else
                    newObject = value;

                if (newObject != dataValue)
                {
                    dataValue = newObject;

                    if (dataValue != null)
                    {
                        if ((fDataType == null) || (fDataType != dataValue.GetType()))
                            DataType = dataValue.GetType();
                    }

                    if ((AsString != this.Text) && !setting)
                    {
                        setting = true;
                        try
                        {
                            if (dataValue != null && typeConverter != null)
                                this.Text = typeConverter.ConvertToString(dataValue);
                            else
                                this.Text = string.Empty;
                        }
                        finally
                        {
                            setting = false;
                        }
                    }


                    OnValueChanged();
                }







            }
        }
        /// <summary>
        /// The type of the property that is being edited
        /// </summary>
        [TypeConverter(typeof(TypeTypeConverter)), Description("The type of the property that is being editing.")]
        public Type DataType
        {
            get
            {
                return fDataType;
            }
            set
            {
                if (fDataType != value)
                {
                    typeEditor = null;
                    typeConverter = null;
                    standardValues = null;

                    fDataType = value;

                    if (fDataType != null)
                    {
                        typeEditor = (UITypeEditor)TypeDescriptor.GetEditor(fDataType, typeof(UITypeEditor));
                        typeConverter = TypeDescriptor.GetConverter(fDataType);
                        standardValues = null;
                        this.AutoCompleteCustomSource.Clear();
                        if (typeConverter != null && this.typeConverter.GetStandardValuesSupported())
                        {
                            standardValues = this.typeConverter.GetStandardValues(this as ITypeDescriptorContext);

                            foreach (object StandardValue in standardValues)
                                this.AutoCompleteCustomSource.Add(StandardValue.ToString());

                            this.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                            this.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        }

                        button.Visible = CanDisplayButton;

                        if (listBox != null) // Make sure its refreshed if necessary
                        {
                            listBox.Dispose();
                            listBox = null;
                        }

                        object v = Value;
                        if (v != null && v.GetType() != fDataType)
                            this.Value = null;

                        PerformLayout();

                    }

                    OnDataTypeChanged();
                }
            }
        }
        /// <summary>
        /// Gets or sets the Value as string.
        /// </summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Localizable(false)]
        public string AsString
        {
            get { return Value == null ? string.Empty : Value.ToString(); }
            set
            {
                string S = string.IsNullOrEmpty(value) ? string.Empty : value;

                object newValue = null;

                if (typeConverter != null)
                {
                    try
                    {
                        if (S.Length > 0)
                            newValue = typeConverter.ConvertFromString(S);
                    }
                    catch
                    {
                    }
                }

                Value = newValue;
            }
        }
        /// <summary>
        /// Should the object be converted to a string before being written back to the data source?
        /// </summary>
        [Description("Should the object be converted to a string before being written back to the data source?")]
        public bool UseStringAsUnderlyingType
        {
            get
            {
                return fUseStringAsUnderlyingType;
            }
            set
            {
                fUseStringAsUnderlyingType = value;
                OnUseStringAsUnderlyingTypeChanged();
            }
        }
 

        /* events */
        /// <summary>
        /// Occurs when the Value property is changed
        /// </summary>
        public event EventHandler ValueChanged;
        /// <summary>
        /// Occurs when the PropertyType property is changed
        /// </summary>
        public event EventHandler DataTypeChanged;
        /// <summary>
        /// Occurs when the UseStringAsUnderlyingType property is changed
        /// </summary>
        public event EventHandler UseStringAsUnderlyingTypeChanged;
    }
}
