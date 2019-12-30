/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/
using System;
using System.Drawing;


namespace Tripous.Forms
{

    /// <summary>
    /// Represents an object that contains an Image
    /// </summary>
    public interface IImageContainer
    {
        /// <summary>
        /// Returns the image
        /// </summary>
        Image Image { get; }
    }
}