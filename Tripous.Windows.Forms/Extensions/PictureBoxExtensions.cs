/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

 
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Tripous.Windows.Forms 
{
    
    /// <summary>
    /// Extensions
    /// </summary>
    static public class PictureBoxExtensions
    {


        /// <summary>
        /// Returns a null bitmap
        /// </summary>
        static public Bitmap EmptyBitmap(this PictureBox PictureBox)
        {
            return null; 
        }
        /// <summary>
        /// Empties the image of the PictureBox
        /// </summary>
        static public void ClearImage(this PictureBox PictureBox)
        {
            PictureBox.Image = null;
        }
        /// <summary>
        /// Cuts the image of the PictureBox to the clipboard
        /// </summary>
        static public void CutToClipboard(this PictureBox PictureBox)
        {
            CopyToClipboard(PictureBox);
            ClearImage(PictureBox);
        }
        /// <summary>
        /// Copies the image of the PictureBox to the clipboard
        /// </summary>
        static public void CopyToClipboard(this PictureBox PictureBox)
        {
            if (PictureBox.Image != null)
                Clipboard.SetDataObject(PictureBox.Image, false);
        }
        /// <summary>
        /// Pastes a bitmap from the clipboard, if any, to the PictureBox
        /// </summary>
        static public void PasteFromClipboard(this PictureBox PictureBox)
        {
            if (PictureBox.Enabled)
            {
                IDataObject DataObject = Clipboard.GetDataObject();
                if (DataObject.GetDataPresent(DataFormats.Bitmap))
                {
                    PictureBox.Image = DataObject.GetData(DataFormats.Bitmap) as Bitmap;
                }
            }
        }
        /// <summary>
        /// Displays an open file box for the user to choose an image for the PictureBox from a disk file.
        /// </summary>
        static public void LoadFromFile(this PictureBox PictureBox)
        {
            if (PictureBox.Enabled)
            {
                string FileName = "";

                if (FileBox.Open(ref FileName, "ALL;BMP;JPG;PNG;TIF;GIF;EMF;WMF;ICO"))
                {
                    PictureBox.Image = Bitmap.FromFile(FileName);
                }
            }
        }
        /// <summary>
        /// Displays a save file box for the user to save the image of the PictureBox to a disk file.
        /// </summary>
        static public void SaveToFile(this PictureBox PictureBox)
        {
            if (PictureBox.Image != null)
            {
                string FileName = "";
                if (FileBox.Save(ref FileName, "BMP;JPG;PNG;TIF;GIF;EMF;WMF;ICO"))
                {
                    PictureBox.Image.Save(FileName, FileBox.ExtensionToImageFormat(FileName));
                }
            }

        }
        /// <summary>
        /// Makes the Bitmap of the Image transparent
        /// </summary>
        static public void MakeTransparent(this Image Image)
        {
            if (Image is Bitmap)
                (Image as Bitmap).MakeTransparent();
        }

    }

}
