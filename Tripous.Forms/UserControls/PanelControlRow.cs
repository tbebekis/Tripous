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
    /// A panel control row
    /// </summary>
    public class PanelControlRow: Panel, IControlRow
    {
        string fCaption;
        string fDataSourceName;
        string fDataField;
        object fDataSource;

        /* overridables */
        /// <summary>
        /// Called on a property change
        /// </summary>
        protected virtual void OnCaptionChanged()
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
        /// Called on a property change
        /// </summary>
        protected virtual void OnDataSourceChanged()
        {
        }

        /* constructor */
        /// <summary>
        /// Constructor
        /// </summary>
        public PanelControlRow()
        {
        }

        /// <summary>
        /// Data bind method
        /// </summary>
        public virtual Binding Bind()
        {
            return null;
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
        public virtual string Caption
        {
            get { return fCaption; }
            set 
            { 
                if (fCaption != value)
                {
                    fCaption = value;
                    OnCaptionChanged();
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
        public virtual object DataSource
        {
            get { return fDataSource; }
            set
            {
                if (fDataSource != value)
                {
                    fDataSource = value;
                    OnDataSourceChanged();
                }
            }
        }

        /// <summary>
        /// True means stack as column (text on top), false means stack as row.
        /// <para>NOT APPLICABLE</para>
        /// </summary>
        public virtual bool TextOnTop { get; set; }
    }
}
