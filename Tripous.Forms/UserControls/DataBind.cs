﻿using System;
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
    public interface IControlRow
    {
        /// <summary>
        /// Data bind method
        /// </summary>
        Binding Bind();
 

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
    }

    /// <summary>
    /// Represents a control with lookup binding
    /// </summary>
    public interface ILookUpControlRow: IControlRow
    {

        /// <summary>
        /// The name of the field to display.
        /// <para>NOTE: For ComboBox and ListBox only.</para>
        /// </summary>
        string DisplayMember { get; set; }
        /// <summary>
        /// The name of the field to be used as the actual control value.
        /// <para>NOTE: For ComboBox and ListBox only.</para>
        /// </summary>
        string ValueMember { get; set; }
        /// <summary>
        /// The list source name of the Control.
        /// <para>NOTE: For ComboBox and ListBox only.</para>
        /// </summary>
        string ListSourceName { get; set; }
        /// <summary>
        /// The list source of the Control.
        /// <para>NOTE: For ComboBox and ListBox only.</para>
        /// </summary>        
        object ListSource { get; set; }
    }

    /// <summary>
    /// Represents a control with grid binding
    /// </summary>
    public interface IGridControlRow : IControlRow // IDataControlRow
    {
    }
}