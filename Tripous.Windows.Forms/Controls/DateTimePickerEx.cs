/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Tripous.Windows.Forms
{
    /// <summary>
    /// A nullable DateTimePicker control
    /// </summary>
    [ToolboxBitmap(typeof(DateTimePicker))]
    public class DateTimePickerEx : DateTimePicker 
    {
        private const string DefaultNullValue = "[select a date]";
        private DateTimeFormatType format;
        private bool isNull;
        private string nullValue = DefaultNullValue;
        private string customFormat;

 
        /* private */
        private void UpdateCustomFormat()
        {

            if (format == DateTimeFormatType.Custom)
                base.CustomFormat = this.CustomFormat;
            else
                base.CustomFormat = format.GetFormatString();

        }



        /* overrides */
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnCloseUp(EventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.None)
            {
                IsNull = false;
            }

            base.OnCloseUp(e);
        }
        /// <summary>
        /// Override
        /// </summary>
        protected override void OnKeyUp(KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Back))
            {
                Value = null;
            }

            base.OnKeyUp(e);
        }

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public DateTimePickerEx()
        {
            base.Format = DateTimePickerFormat.Custom;
            format = DateTimeFormatType.Date;
            UpdateCustomFormat();
        }

 

        /* properties */
        /// <summary>
        /// The format of the DateTimePicker
        /// </summary>
        [Browsable(true), DefaultValue(DateTimePickerFormat.Long), TypeConverter(typeof(Enum)), Description("The format of the DateTimePicker")]
        public new DateTimeFormatType Format
        {
            get { return format; }
            set
            {
                format = value;
                UpdateCustomFormat();
                OnFormatChanged(EventArgs.Empty);
            }
        }
        /// <summary>
        /// True when the control has a null value.
        /// </summary>
        [Browsable(true), ReadOnly(true), Description("True when the control has a null value.")]
        public bool IsNull
        {
            get { return isNull; }
            private set
            {
                if (value != isNull)
                {
                    isNull = value;
                    if (isNull)
                    {
                        base.CustomFormat = (nullValue == null || nullValue == String.Empty) ? " " : "'" + nullValue + "'";
                    }
                    else
                    {
                        UpdateCustomFormat();
                    }
                }
            }
        }
        /// <summary>
        /// A string value to display when the value property is null.
        /// </summary>
        [DefaultValue("<select a date>"), Description("A string value to display when the value is null")]
        public string NullValue
        {
            get { return string.IsNullOrEmpty(nullValue) ? " " : string.Format("{0}", nullValue); }
            set { nullValue = value; }
        }
        /// <summary>
        /// Gets or sets the value of the control
        /// </summary>
        [Browsable(true), Description("Gets or sets the value of the control")]
        public new object Value
        {
            get { return IsNull ? null : (object)base.Value; }
            set
            {
                if ((value == null) || (value == DBNull.Value) || string.IsNullOrEmpty(value.ToString().Trim()) || (value.GetType() != typeof(DateTime)))
                {
                    IsNull = true;
                }
                else
                {
                    IsNull = false;
                    base.Value = (DateTime)value;
                }

                OnValueChanged(new EventArgs());
            }
        }
        /// <summary>
        /// Not applicable.
        /// </summary>
        [Browsable(true), Description("Read-only. Set the Format property instead.")]
        public new string CustomFormat
        {
            get { return string.IsNullOrEmpty(customFormat) ? string.Empty : customFormat; ; }
            set
            {
                if (value != customFormat)
                {
                    customFormat = value;
                    UpdateCustomFormat();
                }
            }
        }

 

    }
}
