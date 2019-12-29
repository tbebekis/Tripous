using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Tripous
{
    /// <summary>
    /// Extensions
    /// see also: https://blogs.msdn.microsoft.com/dotnet/2017/01/19/net-core-image-processing/
    /// </summary>
    static public class ImageExtensions
    {

        /// <summary>
        /// Returns the mime of an image
        /// </summary>
        static public string Mime(this Image Instance)
        {
            return Mime(Instance.RawFormat);
        }
        /// <summary>
        /// Returns the mime of an image format
        /// </summary>
        static public string Mime(this ImageFormat RawFormat)
        {
            if (RawFormat.Guid == ImageFormat.Png.Guid)
            {
                return "image/png";
            }
            else if (RawFormat.Guid == ImageFormat.Bmp.Guid)
            {
                return "image/bmp";
            }
            else if (RawFormat.Guid == ImageFormat.Emf.Guid)
            {
                return "image/x-emf";
            }
            else if (RawFormat.Guid == ImageFormat.Exif.Guid)
            {
                return "image/jpeg";
            }
            else if (RawFormat.Guid == ImageFormat.Gif.Guid)
            {
                return "image/gif";
            }
            else if (RawFormat.Guid == ImageFormat.Icon.Guid)
            {
                return "image/ico";
            }
            else if (RawFormat.Guid == ImageFormat.Jpeg.Guid)
            {
                return "image/jpeg";
            }
            else if (RawFormat.Guid == ImageFormat.MemoryBmp.Guid)
            {
                return "image/bmp";
            }
            else if (RawFormat.Guid == ImageFormat.Tiff.Guid)
            {
                return "image/tiff";
            }
            else if (RawFormat.Guid == ImageFormat.Wmf.Guid)
            {
                return "image/wmf";
            }

            return string.Empty;
        }

    }
}
