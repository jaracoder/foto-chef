using nQuant;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace image.processing.binary
{
    public class ImageProcessor
    {

        /// <summary>
        /// Resize an image from an array of bytes
        /// </summary>
        /// <param name="imgBytes">Array of bytes</param>
        /// <param name="height">New height</param>
        /// <param name="maxOfWidth">New max width</param>
        /// <returns></returns>
        public byte[] ResizeImage(byte[] imgBytes, int height, int maxOfWidth = 0)
        {
            Image img = MakeImage(imgBytes);
            int width = Convert.ToInt32(Convert.ToDouble(img.Width) * (Convert.ToDouble(height) / Convert.ToDouble(img.Height)));
            if (maxOfWidth != 0)
            {
                if (width > maxOfWidth)
                {
                    height = Convert.ToInt32(Convert.ToDouble(img.Height) *
                    (Convert.ToDouble(maxOfWidth) / Convert.ToDouble(img.Width)));
                    width = maxOfWidth;
                }
            }
            Size s = new Size(width, height);
            Image resizedImg = Resize(img, s, true);

            using (MemoryStream ms = new MemoryStream())
            {
                if (ImageFormat.Png.Equals(img.RawFormat))
                {
                    resizedImg.Save(ms, ImageFormat.Png);
                }
                else
                {
                    resizedImg.Save(ms, ImageFormat.Jpeg);
                }

                return ms.ToArray();
            }
        }


        /// <summary>
        /// Compress an image in PNG format from a bitmap
        /// </summary>
        /// <param name="imgBytes">Array of bytes of image</param>
        /// <param name="fileName">Image path</param>
        /// <remarks>Change depth to 8 bits</remarks>
        public bool CompressPNG(byte[] imgBytes, string fileName)
        {
            try
            {
                if (IsValidImage(fileName, ".png"))
                {
                    using (MemoryStream ms = new MemoryStream(imgBytes))
                    {
                        var quantizer = new WuQuantizer();
                        using (var quantized = quantizer.QuantizeImage(new Bitmap(ms)))
                        {
                            quantized.Save(fileName, ImageFormat.Png);
                        }
                        return true;
                    }                    
                }
                return false;
            }
            catch
            {
                throw;
            }
        }


        /// <summary>
        /// Compress an image in JPG format from a bitmap
        /// </summary>
        /// <param name="imgBytes">Array of bytes of image</param>
        /// <param name="fileName">Image path</param>
        /// <param name="levelCompression">Compression level. 0 maximum compression and 100 minimum.</param>
        public bool CompressJPG(byte[] imgBytes, string fileName, long levelCompression = 30L)
        {
            try
            {
                if (IsValidImage(fileName, ".jpg"))
                {
                    using (MemoryStream ms = new MemoryStream(imgBytes))
                    {
                        ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                        Encoder myEncoder = Encoder.Quality;
                        EncoderParameters myEncoderParameters = new EncoderParameters(1);

                        EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, levelCompression);
                        myEncoderParameters.Param[0] = myEncoderParameter;

                        new Bitmap(ms)
                            .Save(fileName, jpgEncoder, myEncoderParameters);

                        return true;
                    }
                }
                return false;
            }
            catch
            {
                throw;
            }
        }


        #region private methods

        private bool IsValidImage(string fileName, string ext)
        {
            if (Path.GetExtension(fileName).ToLower() != ext.ToLower())
                return false;

            return true;
        }


        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private Image MakeImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private static Image Resize(Image image, Size size, bool preserveAspectRatio = true)
        {
            int newWidth;
            int newHeight;

            if (preserveAspectRatio)
            {
                int originalWidth = image.Width;
                int originalHeight = image.Height;
                float percentWidth = (float)size.Width / (float)originalWidth;
                float percentHeight = (float)size.Height / (float)originalHeight;
                float percent = percentHeight < percentWidth ? percentHeight : percentWidth;
                newWidth = (int)(originalWidth * percent);
                newHeight = (int)(originalHeight * percent);
            }
            else
            {
                newWidth = size.Width;
                newHeight = size.Height;
            }

            Image newImage = new Bitmap(newWidth, newHeight);
            using (Graphics graphicsHandle = Graphics.FromImage(newImage))
            {
                graphicsHandle.SmoothingMode = SmoothingMode.AntiAlias;
                graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return newImage;
        }

        #endregion
    }
}
