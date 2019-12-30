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
    static public class RichTextBoxExtensions
    {
        /// <summary>
        /// Returns the caret position in RichTextBox
        /// </summary>
        static public Point GetCaretPosition(this RichTextBox RichTextBox)
        {
            Point P = new Point();
            P.Y = (RichTextBox.GetLineFromCharIndex(RichTextBox.SelectionStart));
            P.X = (RichTextBox.SelectionStart - RichTextBox.GetFirstCharIndexOfCurrentLine());
            return P;
        }
    }

}
 
