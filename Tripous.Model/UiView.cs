using System;
using System.Collections.Generic;
using System.Text;

namespace Tripous.Model
{
    /// <summary>
    /// Columns per screen size
    /// </summary>
    public class UiSplit
    {
        /// <summary>
        /// How many columns to have in a certain screen size.
        /// </summary>
        public int Large { get; set; } = 3;
        /// <summary>
        /// How many columns to have in a certain screen size.
        /// </summary>
        public int Medium { get; set; } = 2;
        /// <summary>
        /// How many columns to have in a certain screen size.
        /// </summary>
        public int Small { get; set; } = 2;
        /// <summary>
        /// How many columns to have in a certain screen size.
        /// </summary>
        public int XSmall { get; set; } = 1;
    }

 
    /// <summary>
    /// Top level container. Represents a desktop form or a html page
    /// </summary>
    public class UiView
    {
        /// <summary>
        /// A unique name among all view containers.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The data source name
        /// </summary>
        public string SourceName { get; set; }
        /// <summary>
        /// A list of tabs. Could be empty.
        /// </summary>
        public List<UiTab> Tabs { get; } = new List<UiTab>();
        /// <summary>
        /// A list of groups. Could be empty.
        /// </summary>
        public List<UiGroup> Groups { get; } = new List<UiGroup>();
        /// <summary>
        /// A list of columns. Could be empty.
        /// </summary>
        public List<UiColumn> Columns { get; } = new List<UiColumn>();

        /// <summary>
        /// Columns per screen size
        /// </summary>
        public UiSplit Split { get; set; } = new UiSplit();
    }

    /// <summary>
    /// Represents a tab page
    /// </summary>
    public class UiTab
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public UiTab()
        {
        }

        /// <summary>
        /// The text of the tab.
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// The data source name. When empty then it binds to its parent's source.
        /// </summary>
        public string SourceName { get; set; }
        /// <summary>
        /// A list of groups. Could be empty.
        /// </summary>
        public List<UiGroup> Groups { get; } = new List<UiGroup>();
        /// <summary>
        /// A list of columns. Could be empty.
        /// </summary>
        public List<UiColumn> Columns { get; } = new List<UiColumn>();

        /// <summary>
        /// Columns per screen size
        /// </summary>
        public UiSplit Split { get; set; } = new UiSplit();

    }

    /// <summary>
    /// Represents a container such as a DIV or panel which groups controls under a specified text.
    /// </summary>
    public class UiGroup
    {
        /// <summary>
        /// The text of the group.
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// The data source name. When empty then it binds to its parent's source.
        /// </summary>
        public string SourceName { get; set; }
        /// <summary>
        /// A list of columns. Could be empty.
        /// </summary>
        public List<UiColumn> Columns { get; } = new List<UiColumn>();

        /// <summary>
        /// Columns per screen size
        /// </summary>
        public UiSplit Split { get; set; } = new UiSplit();
    }

    /// <summary>
    /// Represents a column in any container, <see cref="UiView"/>, <see cref="UiTab"/> or <see cref="UiGroup"/>
    /// </summary>
    public class UiColumn
    {
        /// <summary>
        /// The data source name. When empty then it binds to its parent's source.
        /// </summary>
        public string SourceName { get; set; }

        /// <summary>
        /// Width percent of text in rows.
        /// </summary>
        public int TextSplit { get; set; } = 35;

        /// <summary>
        /// A list of rows.  
        /// </summary>
        public List<UiRow> Rows { get; } = new List<UiRow>();
    }

    /// <summary>
    /// Represents a row in a <see cref="UiColumn"/>.
    /// <para>The row is the control container.</para>
    /// </summary>
    public class UiRow
    {
        /// <summary>
        /// The data source name. When empty then it binds to its parent's source.
        /// </summary>
        public string SourceName { get; set; }

        /// <summary>
        /// A list of controls.  
        /// </summary>
        public List<UiControl> Controls { get; } = new List<UiControl>();
    }

    /// <summary>
    /// Represents a control along with its caption text.
    /// <para>The control may be data-bindable or not.</para>
    /// </summary>
    public class UiControl
    {
        /// <summary>
        /// The caption text of the control
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The HTML Id and HTML Name of the control.
        /// <para>The name of a desktop control.</para>
        /// </summary>
        public string Id { get; set; }        
        /// <summary>
        /// Indicates the control type, such as TextBox
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// When true the control is readonly
        /// </summary>
        public bool ReadOnly { get; set; }
        /// <summary>
        /// When true the control must have a value
        /// </summary>
        public bool Required { get; set; }
        /// <summary>
        /// The data source name. When empty then it binds to its parent's source.
        /// </summary>
        public string SourceName { get; set; }
        /// <summary>
        /// The data field to bind
        /// </summary>
        public string DataField { get; set; }
    }
}
