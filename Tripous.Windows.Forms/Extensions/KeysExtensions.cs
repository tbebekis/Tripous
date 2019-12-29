/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/
using System;
using System.Windows.Forms;

namespace Tripous.Windows.Forms
{
    /// <summary>
    /// A static class for cracking Keys enum values
    /// </summary>
    static public class KeysExtensions
    {
        /// <summary>
        /// returns true if Alt is in K
        /// </summary>
        static public bool HasAlt(this Keys K)
        {
            return ((K & Keys.Alt) == Keys.Alt);
        }
        /// <summary>
        /// Returns true if Control is in K
        /// </summary>
        static public bool HasControl(this Keys K)
        {
            return ((K & Keys.Control) == Keys.Control);
        }
        /// <summary>
        /// Returns true if Shift is in K
        /// </summary>
        static public bool HasShift(this Keys K)
        {
            return ((K & Keys.Shift) == Keys.Shift);
        }
        /// <summary>
        /// Returns the Keys enum constant of K, excluding modifiers, if any
        /// </summary>
        static public Keys CodeOf(this Keys K)
        {
            Keys Mask = K & Keys.KeyCode;
            if (!Enum.IsDefined(typeof(Keys), (int)Mask))
                return Keys.None;

            return Mask;
        }
        /// <summary>
        /// Returns true if CodeKey == K excluding any modifiers from K
        /// </summary>
        static public bool CodeIs(this Keys K, Keys CodeKey)
        {
            return CodeOf(K) == CodeKey;
        }
        /// <summary>
        /// Returns the modifier constants of K, that is the combination of modifier keys (CTRL, SHIFT, and ALT)
        /// </summary>
        static public Keys ModifiersOf(this Keys K)
        {
            return K & Keys.Modifiers;
        }
        /// <summary>
        /// Returns true if K contains modifiers keys
        /// </summary>
        static public bool ContainsModifiers(this Keys K)
        {
            return ModifiersOf(K) != Keys.None;
        }
        /// <summary>
        /// Returns true if K contains any non modifier key
        /// </summary>
        static public bool ContainsCode(this Keys K)
        {
            return CodeOf(K) != Keys.None;
        }
        /// <summary>
        /// Returns the integer representation of K 
        /// </summary>
        static public int ValueOf(this Keys K)
        {
            return (int)(K & Keys.KeyCode);
        }
        /// <summary>
        /// Returns a string representation of K
        /// </summary>
        static public string ToString(this Keys K)
        {
            string Res = "";

            if (HasAlt(K))
                Res = Res + "Alt, ";

            if (HasControl(K))
                Res = Res + "Control, ";

            if (HasShift(K))
                Res = Res + "Shift, ";

            if (Res.EndsWith(", "))
                Res = Res.Substring(0, Res.Length - 2);

            if (Res != "")
                Res = "(" + Res + ") + " + CodeOf(K).ToString();
            else
                Res = CodeOf(K).ToString();

            return Res;
        }
        /// <summary>
        /// Returns true if K is a number (digit).
        /// </summary>
        static public bool IsNumberKey(this Keys K)
        {
            return (K >= Keys.D0 && K <= Keys.D9) 
                || (K >= Keys.NumPad0 && K <= Keys.NumPad9);
                //|| (K == Keys.Decimal)
        }
        /// <summary>
        /// Returns true if K is a letter
        /// </summary>
        static public bool IsLetterKey(this Keys K)
        {
            return (K >= Keys.A && K <= Keys.Z);
        }
        /// <summary>
        /// Returns true if K is a number (digit) or a letter
        /// </summary>
        static public bool IsAlphaNumericKey(this Keys K)
        {
            return IsLetterKey(K) || IsNumberKey(K);
        }
        /// <summary>
        /// Returns true if K is a Function key (F1 to F24)
        /// </summary>
        static public bool IsFunctionKey(this Keys K)
        {
            return ((K & Keys.F1) == Keys.F1)
             || ((K & Keys.F2) == Keys.F2)
             || ((K & Keys.F3) == Keys.F3)
             || ((K & Keys.F4) == Keys.F4)
             || ((K & Keys.F5) == Keys.F5)
             || ((K & Keys.F6) == Keys.F6)
             || ((K & Keys.F7) == Keys.F7)
             || ((K & Keys.F8) == Keys.F8)
             || ((K & Keys.F9) == Keys.F9)
             || ((K & Keys.F10) == Keys.F10)
             || ((K & Keys.F11) == Keys.F11)
             || ((K & Keys.F12) == Keys.F12)
             || ((K & Keys.F13) == Keys.F13)
             || ((K & Keys.F14) == Keys.F14)
             || ((K & Keys.F15) == Keys.F15)
             || ((K & Keys.F16) == Keys.F16)
             || ((K & Keys.F17) == Keys.F17)
             || ((K & Keys.F18) == Keys.F18)
             || ((K & Keys.F19) == Keys.F19)
             || ((K & Keys.F20) == Keys.F20)
             || ((K & Keys.F21) == Keys.F21)
             || ((K & Keys.F22) == Keys.F22)
             || ((K & Keys.F23) == Keys.F23)
             || ((K & Keys.F24) == Keys.F24)
             ;
        }
        /// <summary>
        /// Returns true if K is a control key 
        /// </summary>
        static public bool IsContolKey(this Keys K)
        {
            return
                  ((K & Keys.None) == Keys.None)
       || ((K & Keys.Return) == Keys.Return)
       || ((K & Keys.Escape) == Keys.Escape)
       || ((K & Keys.Insert) == Keys.Insert)
       || ((K & Keys.Delete) == Keys.Delete)
       || ((K & Keys.Back) == Keys.Back)
       || ((K & Keys.Home) == Keys.Home)
       || ((K & Keys.End) == Keys.End)
       || ((K & Keys.PageUp) == Keys.PageUp)
       || ((K & Keys.PageDown) == Keys.PageDown)
       || ((K & Keys.Up) == Keys.Up)
       || ((K & Keys.Down) == Keys.Down)
       || ((K & Keys.Left) == Keys.Left)
       || ((K & Keys.Right) == Keys.Right)
       || ((K & Keys.Pause) == Keys.Pause)
               ;

        }
        /// <summary>
        /// Returns true if the ModifierKey specified by Modifier is pressed down in event e.
        /// </summary>
        static public bool IsModifierDown(this KeyEventArgs e, ModifierKey Modifier)
        {
            bool Flag = (((Modifier == ModifierKey.Control) && e.Control)
            || ((Modifier == ModifierKey.Alt) && e.Alt)
            || ((Modifier == ModifierKey.Shift) && e.Shift));

            return Flag;
        }
    }


    /// <summary>
    /// ModifierKey
    /// </summary>
    [Flags]
    public enum ModifierKey
    {
        /// <summary>
        /// None
        /// </summary>
        None = 1,
        /// <summary>
        /// Alt
        /// </summary>
        Alt = 2,
        /// <summary>
        /// Shift
        /// </summary>
        Shift = 4,
        /// <summary>
        /// Control
        /// </summary>
        Control = 8,
    }


}
