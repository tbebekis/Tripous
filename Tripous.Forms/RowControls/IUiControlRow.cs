using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tripous.Forms
{
    /// <summary>
    /// Represents a control with simple binding
    /// </summary>
    public interface IUiControlRow
    {
        /// <summary>
        /// Data bind method
        /// </summary>
        Binding Bind();

        /// <summary>
        /// True means stack as column (Text on top), false means stack as row.
        /// </summary>
        bool TextOnTop { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// The height of the row
        /// </summary>
        int Height { get; }
        /// <summary>
        /// The parent control
        /// </summary>
        Control Parent { get; set; }

        /// <summary>
        /// The control text (caption)
        /// </summary>
        string Caption { get; set; }

        /// <summary>
        /// The data source name. When empty then it binds to its parent's source.
        /// </summary>
        string DataSourceName { get; set; }
        /// <summary>
        /// The data field to bind
        /// </summary>
        string DataField { get; set; }
        /// <summary>
        /// The data source of the Control.
        /// </summary>        
        object DataSource { get; set; }

        /// <summary>
        /// Called by a parent <see cref="UiGroup"/> when the size changing of that parent "changes screen mode".
        /// </summary>
        void OnScreenModeChanged(ScreenMode Mode);
    }
}
