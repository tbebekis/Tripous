/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

 
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tripous.Forms
{
    /// <summary>
    /// Extensions
    /// </summary>
    static public class FontExtensions
    {

        /// <summary>
        /// Sets the Size of the Font
        /// </summary>
        static public Font SetFont(this Font Font, float Size)
        {
            return new Font(Font.Name, Size, Font.Style);
        }
        /// <summary>
        /// Sets the Style of the Font
        /// </summary>
        static public Font SetFont(this Font Font, FontStyle Style)
        {
            return new Font(Font.Name, Font.Size, Style);
        }
        /// <summary>
        /// Sets the Size and Style of the Font
        /// </summary>
        static public Font SetFont(this Font Font, float Size, FontStyle Style)
        {
            return new Font(Font.Name, Size, Style);
        }
        /// <summary>
        /// Sets the Size of the Control.Font
        /// </summary>
        static public void SetFont(this Control Control, float Size)
        {
            Control.Font = new Font(Control.Font.Name, Size, Control.Font.Style);
        }
        /// <summary>
        /// Sets the Style of the Control.Font
        /// </summary>
        static public void SetFont(this Control Control, FontStyle Style)
        {
            Control.Font = new Font(Control.Font.Name, Control.Font.Size, Style);
        }
        /// <summary>
        /// Sets the Size and Style of the Control.Font
        /// </summary>
        static public void SetFont(this Control Control, float Size, FontStyle Style)
        {
            Control.Font = new Font(Control.Font.Name, Size, Style);
        }
    }
}
 