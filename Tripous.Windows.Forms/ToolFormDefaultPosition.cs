using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeifenLuo.WinFormsUI.Docking;

namespace Tripous.Windows.Forms
{
    public enum ToolFormDefaultPosition
    {
        Left = (int)DockState.DockLeft,
        Right = (int)DockState.DockRight,
        Bottom = (int)DockState.DockBottom,
        Top = (int)DockState.DockTop,
    }
}
