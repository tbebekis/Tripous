/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/
using System;
using System.Drawing;



namespace Tripous
{



    /// <summary>
    /// Helper for darkening and lightening color valus
    /// </summary>
    static public class Colorist
    {
        private const double cSmall = 3;
        private const double cBig = 0.9;


        static private byte Normalize(int ByteValue)
        {
            if (ByteValue < 0)
                ByteValue = 0;
            else if (ByteValue > 255)
                ByteValue = 255;
            return (byte)ByteValue;
        }


        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        static Colorist()
        {

            Color BaseColor = (Color.FromArgb(207, 221, 238));

            StandardBackColor = Color.White;
            StandardGradientStartColor = StandardBackColor; //Color.White;
            StandardGradientEndColor = SystemColors.Control;


        }

        /// <summary>
        /// Returns a dark color based on the specified Color.
        /// </summary>
        public static Color Dark(Color Color)
        {
            byte R = Normalize(Color.R - (int)(Color.R / cSmall));
            byte G = Normalize(Color.G - (int)(Color.G / cSmall));
            byte B = Normalize(Color.B - (int)(Color.B / cSmall));
            return Color.FromArgb(R, G, B);

        }
        /// <summary>
        /// Returns a double dark color based on the specified Color.
        /// </summary>
        public static Color DarkDark(Color Color)
        {
            byte R = Normalize(Color.R - (int)(Color.R / cBig));
            byte G = Normalize(Color.G - (int)(Color.G / cBig));
            byte B = Normalize(Color.B - (int)(Color.B / cBig));
            return Color.FromArgb(R, G, B);

        }
        /// <summary>
        /// Returns a light color based on the specified Color.
        /// </summary>
        public static Color Light(Color Color)
        {
            byte R = Normalize(Color.R + (int)(Color.R / cSmall));
            byte G = Normalize(Color.G + (int)(Color.G / cSmall));
            byte B = Normalize(Color.B + (int)(Color.B / cSmall));
            return Color.FromArgb(R, G, B);

        }
        /// <summary>
        /// Returns a double light color based on the specified Color.
        /// </summary>
        public static Color LightLight(Color Color)
        {
            byte R = Normalize(Color.R + (int)(Color.R / cBig));
            byte G = Normalize(Color.G + (int)(Color.G / cBig));
            byte B = Normalize(Color.B + (int)(Color.B / cBig));
            return Color.FromArgb(R, G, B);

        }
        /// <summary>
        /// Returns a color by inversing the specified Color.
        /// </summary>
        public static Color Inverse(Color Color)
        {
            byte Value = 0xFF;

            byte R = Normalize(Color.R ^ Value);
            byte G = Normalize(Color.G ^ Value);
            byte B = Normalize(Color.B ^ Value);
            return Color.FromArgb(R, G, B);
        }
        /// <summary>
        /// Returns a grayed color based on specified Color.
        /// </summary>
        public static Color Gray(Color Color)
        {
            int ArgValue = Color.ToArgb();

            int R = ArgValue & 0x000000FF;
            int G = (ArgValue & 0x0000FF00) >> 8;
            int B = (ArgValue & 0x00FF0000) >> 16;

            int Avg = (int)((R + G + B) / 3) + 50;

            if (Avg > 240)
                Avg = 240;

            return Color.FromArgb(Avg, Avg, Avg);
        }
        /// <summary>
        /// Creates a new color based on Color.
        /// <para>Value is the new color intension and can be from 0 to 99.</para>
        /// </summary>
        public static Color NewColor(Color Color, int Value)
        {
            Value = Value > 100 ? 100 : Value;

            int ArgValue = Color.ToArgb();

            int R = ArgValue & 0x000000FF;
            int G = (ArgValue & 0x0000FF00) >> 8;
            int B = (ArgValue & 0x00FF0000) >> 16;

            R = R + (int)Math.Round((double)(255 - R) * (Value / 100));
            G = G + (int)Math.Round((double)(255 - G) * (Value / 100));
            B = B + (int)Math.Round((double)(255 - B) * (Value / 100));


            return Color.FromArgb(R, G, B);
        }

        /// <summary>
        /// Returns the ButtonHighlight color.
        /// </summary>
        static public Color ButtonHighlight { get { return Color.FromArgb(-9468000); } }

        /// <summary>
        /// Gets or sets the standard background color
        /// </summary>
        static public Color StandardBackColor { get; set; }
        /// <summary>
        /// Gets or sets the standard gradient start color
        /// </summary>
        static public Color StandardGradientStartColor { get; set; }
        /// <summary>
        /// Gets or sets the standard gradient end color
        /// </summary>
        static public Color StandardGradientEndColor { get; set; }

    }




}