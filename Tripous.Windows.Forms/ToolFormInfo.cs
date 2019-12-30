using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using WeifenLuo.WinFormsUI.Docking;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tripous.Windows.Forms
{
 

    /// <summary>
    /// Used in saving the state of tool forms in a .json file
    /// </summary>
    public class ToolFormInfo
    {
        int fAutoHidePortion;

        /* properties */
        /// <summary>
        /// A string that uniquely identities the tool form.
        /// <para>Used in persisting the form state and position to a json file.</para>
        /// </summary> 
        public string ToolType { get; set; }
        /// <summary>
        /// DockState
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public DockState DockState { get; set; }
        /// <summary>
        /// AutoHidePortion
        /// </summary>
        public int AutoHidePortion { get { return fAutoHidePortion >= 50 ? fAutoHidePortion : 50; } set { fAutoHidePortion = value; } }
        /// <summary>
        /// FloatBounds
        /// </summary>
        public Rectangle FloatBounds { get; set; } = new Rectangle();
    }
}
