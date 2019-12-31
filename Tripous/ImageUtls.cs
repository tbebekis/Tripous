/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Tripous
{
    /// <summary>
    /// Helper class for images
    /// </summary>
    static public class ImageUtls
    {

        /// <summary>
        /// Resizes Source image to the specified dimensions, keeping the aspect ratio.
        /// <para>WARNING: Quality must be non-negative.</para>
        /// </summary>    
        static public Image Resize(this Image Source, int MaxWidth, int MaxHeight, int Quality = 90)
        {
            // Get the image's original width and height
            int originalWidth = Source.Width;
            int originalHeight = Source.Height;

            // To preserve the aspect ratio
            float ratioX = (float)MaxWidth / (float)originalWidth;
            float ratioY = (float)MaxHeight / (float)originalHeight;
            float ratio = Math.Min(ratioX, ratioY);

            // New width and height based on aspect ratio
            int newWidth = (int)(originalWidth * ratio);
            int newHeight = (int)(originalHeight * ratio);

            // Convert other formats (including CMYK) to RGB.
            using (Bitmap WorkingImage = new Bitmap(newWidth, newHeight, PixelFormat.Format24bppRgb))
            {

                // Draws the image in the specified size with quality mode set to HighQuality
                using (Graphics graphics = Graphics.FromImage(WorkingImage))
                {
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.DrawImage(Source, 0, 0, newWidth, newHeight);
                }

                WorkingImage.MakeTransparent();

                // Get an ImageCodecInfo object that represents the JPEG codec.
                ImageCodecInfo imageCodecInfo = GetEncoderInfo(Source.RawFormat);

                // Create an Encoder object for the Quality parameter.
                Encoder encoder = Encoder.Quality;

                // Create an EncoderParameters object. 
                EncoderParameters encoderParameters = new EncoderParameters(1);

                // Save the image as a JPEG file with quality level.
                EncoderParameter encoderParameter = new EncoderParameter(encoder, Quality);
                encoderParameters.Param[0] = encoderParameter;

                using (MemoryStream MS = new MemoryStream())
                {
                    WorkingImage.Save(MS, imageCodecInfo, encoderParameters);
                    return Image.FromStream(MS);
                }

            }
        }
        /// <summary>
        /// Resizes Source image to the specified dimensions, keeping the aspect ratio.
        /// <para>FROM: http://stackoverflow.com/questions/1940581/c-sharp-image-resizing-to-different-size-while-preserving-aspect-ratio </para>
        /// </summary>    
        static public Image Resize2(this Image imgPhoto, int Width, int Height)
        {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)Width / (float)sourceWidth);
            nPercentH = ((float)Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((Width -
                              (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((Height -
                              (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(Width, Height,
                              PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                             imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.Red);
            grPhoto.InterpolationMode =
                    InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }
        /// <summary>
        /// Method to get encoder infor for given image format.
        /// </summary>
        /// <param name="format">Image format</param>
        /// <returns>image codec info.</returns>
        static public ImageCodecInfo GetEncoderInfo(ImageFormat format)
        {
            return ImageCodecInfo.GetImageDecoders().SingleOrDefault(c => c.FormatID == format.Guid);
        }

        /// <summary>
        /// Returns the mime format string, i.e image/jpg
        /// </summary>
        static public string MimeOf(Image Source)
        {
            return MimeOf(Source.RawFormat);
        }
        /// <summary>
        /// Returns the mime format string, i.e image/jpg
        /// </summary>
        static public string MimeOf(ImageFormat Format)
        {
            if (Format.Equals(ImageFormat.Png))
                return "image/png";
            if (Format.Equals(ImageFormat.Jpeg))
                return "image/jpeg";
            if (Format.Equals(ImageFormat.Gif))
                return "image/gif";
            if (Format.Equals(ImageFormat.Tiff))
                return "image/tiff";

            return "";
        }


        /// <summary>
        /// The method takes two objects - the image to crop (System.Drawing.Image) 
        /// and the rectangle to crop out (System.Drawing.Rectangle). 
        /// The next thing done is to create a Bitmap (System.Drawing.Bitmap) of the image. 
        /// The only thing left is to crop the image. 
        /// This is done by cloning the original image but only taking a rectangle of the original.
        /// From: http://tech.pro/tutorial/620/csharp-tutorial-image-editing-saving-cropping-and-resizing
        /// </summary>
        static public Image CropImage(Image img, Rectangle cropArea)
        {
            if (img != null)
            {
                Bitmap bmpImage = new Bitmap(img);
                Bitmap bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);
                return (Image)(bmpCrop);
            }

            return null;
        }
        /// <summary>
        /// Creates and returns a new Image containing the specified Image, rotated by Angle (in degrees)
        /// <para>from: http://www.codeproject.com/KB/graphics/RotatePictureBox.aspx</para>
        /// </summary>
        public static Bitmap RotateImage(Image Image, float Angle)
        {
            if (Image == null)
                throw new ArgumentNullException("Image");

            //create a new empty bitmap to hold rotated image
            Bitmap Result = new Bitmap(Image.Width, Image.Height);

            PointF Offset = new PointF(Image.Width / 2, Image.Height / 2);

            Result.SetResolution(Image.HorizontalResolution, Image.VerticalResolution);

            //make a graphics object from the empty bitmap
            Graphics g = Graphics.FromImage(Result);

            //Put the rotation point in the center of the image
            g.TranslateTransform(Offset.X, Offset.Y);

            //rotate the image
            g.RotateTransform(Angle);

            //move the image back
            g.TranslateTransform(-Offset.X, -Offset.Y);

            //draw passed in image onto graphics object
            g.DrawImage(Image, new PointF(0, 0));

            return Result;
        }

        /// <summary>
        /// Converts the passed Bitmap to a gray one.
        /// </summary>
        static public void BitmapGray(Bitmap Bitmap)
        {
            Color LastColor1 = System.Drawing.Color.Transparent;
            Color LastColor2 = System.Drawing.Color.Transparent;
            Color Color;

            for (int Y = 0; Y < Bitmap.Height; Y++)
            {

                for (int X = 0; X < Bitmap.Width; X++)
                {
                    Color = Bitmap.GetPixel(X, Y);
                    if (Color == LastColor1)
                        Bitmap.SetPixel(X, Y, LastColor2);
                    else
                    {
                        LastColor2 = Colorist.Gray(Color);
                        Bitmap.SetPixel(X, Y, LastColor2);
                        LastColor1 = Color;
                    }
                }
            }
        }


        /// <summary>
        /// Makes the Source transparent and returns it as a bitmap
        /// </summary>
        static public Bitmap MakeTransparent(Image Source)
        {
            Bitmap Result = new Bitmap(Source);
            Result.MakeTransparent(Result.GetPixel(Result.Width - 1, Result.Height - 1));
            return Result;
        }
        /// <summary>
        /// Makes the FileName image transparent and returns it as a bitmap
        /// </summary>
        static public Bitmap MakeTransparent(string FileName)
        {
            return MakeTransparent(Image.FromFile(FileName));
        }
        /// <summary>
        /// Makes transparent all images (gif, jpg, png and bmp) found in Folder
        /// and saves the new images into a Transparent sub-folder of Folder
        /// </summary>
        static public void MakeTransparentAll(string Folder)
        {

            string DestFolder = Path.Combine(Folder, "Transparent");
            Sys.EnsureDirectories(DestFolder);

            string Ext;
            string FilePath2;
            ImageFormat Format;
            string[] FilePaths = Sys.GetFiles(Folder, "*.gif;*.jpg;*.jpeg;*.png;*.bmp;", false);
            foreach (string FilePath in FilePaths)
            {
                using (Bitmap B = MakeTransparent(FilePath))
                {
                    Format = null;
                    Ext = Path.GetExtension(FilePath).ToLower();
                    switch (Ext)
                    {
                        case ".gif": Format = ImageFormat.Gif; break;
                        case ".jpg": Format = ImageFormat.Jpeg; break;
                        case ".jpeg": Format = ImageFormat.Jpeg; break;
                        case ".png": Format = ImageFormat.Png; break;
                        case ".bmp": Format = ImageFormat.Bmp; break;
                        default: Format = null; break;
                    }

                    if (Format != null)
                    {
                        FilePath2 = Path.Combine(DestFolder, Path.GetFileName(FilePath));
                        try
                        {
                            if (Format == ImageFormat.Bmp)
                                B.Save(FilePath2);
                            else
                                B.Save(FilePath2, Format);
                        }
                        catch
                        {
                        }

                    }
                }
            }
        }

        /// <summary>
        /// Converts an image to a base64 string
        /// </summary>
        static public string ImageToBase64(Image Image, bool InsertLineBreaks = true)
        {
            return Sys.ImageToBase64(Image, InsertLineBreaks);
        }
        /// <summary>
        /// Converts a base64 string back to an image
        /// </summary>
        static public Image Base64ToImage(string Text)
        {
            return Sys.Base64ToImage(Text);
        }

        /*
                 /// <summary>
                /// Converts an image into an array of bytes
                /// </summary>
                static public byte[] ImageToBytes(Image Image)
                {
                    ImageConverter Converter = new ImageConverter();
                    return (byte[])Converter.ConvertTo(Image, typeof(byte[]));
                }
                /// <summary>
                /// Converts a byte array back to an image
                /// </summary>
                static public Image BytesToImage(byte[] Bytes)
                {
                    if ((Bytes != null) && (Bytes.Length > 0))
                    {
                        ImageConverter Converter = new ImageConverter();
                        return Converter.ConvertFrom(Bytes) as Image;
                    }

                    return null;
                }
                 */
    }
}
