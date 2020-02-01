using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeifenLuo.WinFormsUI.Docking;

namespace Tripous.Forms
{
    /// <summary>
    /// Indicates the default position of a tool form in a dock container
    /// </summary>
    public enum ToolFormDefaultPosition
    {
        /// <summary>
        /// Left
        /// </summary>
        Left = (int)DockState.DockLeft,
        /// <summary>
        /// Right
        /// </summary>
        Right = (int)DockState.DockRight,
        /// <summary>
        /// Bottom
        /// </summary>
        Bottom = (int)DockState.DockBottom,
        /// <summary>
        /// Top
        /// </summary>
        Top = (int)DockState.DockTop,
    }
}
