using nQuant;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace FotoChef.Models
{
    public class Chef
    {
       

        /// <summary>
        /// Resize an image from an array of bytes
        /// </summary>
        /// <param name="imgBytes">Array of bytes</param>
        /// <param name="height">New height</param>
        /// <param name="maxOfWidth">New max width</param>
        /// <returns></returns>
        public static System.Drawing.Image ResizeImage(System.Drawing.Image img, int width, int height, bool preserveAspectRadio)
        {
            //System.Drawing.Image img = Helpers.ByteArrayToImage(imgBytes);
           //int width = img.Width * (height / img.Height);
            //if (maxOfWidth != 0)
            //{
            //    if (width > maxOfWidth)
            //    {
            //        height = img.Height * (maxOfWidth / img.Width);
            //        width = maxOfWidth;
            //    }
            //}
            Size s = new Size(width, height);
            System.Drawing.Image resizedImg = Resize(img, s, preserveAspectRadio);

            using (MemoryStream ms = new MemoryStream())
            {
                if (ImageFormat.Png == img.RawFormat)
                {
                    resizedImg.Save(ms, ImageFormat.Png);
                }
                else
                {
                    resizedImg.Save(ms, ImageFormat.Jpeg);
                }

                return System.Drawing.Image.FromStream(ms);
            }
        }


        /// <summary>
        /// Compress an image in PNG format from a bitmap
        /// </summary>
        /// <param name="imgBytes">Array of bytes of image</param>
        /// <remarks>Change depth to 8 bits</remarks>
        public static byte[] CompressPNG(byte[] imgBytes)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(imgBytes))
                {
                    var quantizer = new WuQuantizer();

                    using (var quantized = quantizer.QuantizeImage(new Bitmap(ms)))
                    {
                        var imgCompress = new MemoryStream();
                        quantized.Save(imgCompress, ImageFormat.Png);

                        return imgCompress.ToArray();
                    }
                }
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
        /// <param name="levelCompression">Compression level. 0 maximum compression and 100 minimum.</param>
        public static byte[] CompressJPG(byte[] imgBytes, long levelCompression = 30L)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(imgBytes))
                {
                    ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                    Encoder myEncoder = Encoder.Quality;
                    EncoderParameters myEncoderParameters = new EncoderParameters(1);

                    EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, levelCompression);
                    myEncoderParameters.Param[0] = myEncoderParameter;

                    var imgCompress = new MemoryStream();

                    new Bitmap(ms)
                            .Save(imgCompress, jpgEncoder, myEncoderParameters);

                    return imgCompress.ToArray();
                }
            }
            catch
            {
                throw;
            }
        }


        public static byte[] MakeGrayscale3(byte[] imgBytes)
        {
            Bitmap original;
            using (var ms = new MemoryStream(imgBytes))
            {
                original = new Bitmap(ms);
            }

            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            //get a graphics object from the new image
            using (Graphics g = Graphics.FromImage(newBitmap))
            {

                //create the grayscale ColorMatrix
                ColorMatrix colorMatrix = new ColorMatrix(
                   new float[][]
                   {
                        new float[] {.3f, .3f, .3f, 0, 0},
                        new float[] {.59f, .59f, .59f, 0, 0},
                        new float[] {.11f, .11f, .11f, 0, 0},
                        new float[] {0, 0, 0, 1, 0},
                        new float[] {0, 0, 0, 0, 1}
                   });

                //create some image attributes
                using (ImageAttributes attributes = new ImageAttributes())
                {

                    //set the color matrix attribute
                    attributes.SetColorMatrix(colorMatrix);

                    //draw the original image on the new image
                    //using the grayscale color matrix
                    g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
                                0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);
                }
            }

            return (byte[])new ImageConverter()
                .ConvertTo(newBitmap, typeof(byte[]));
        }


        public static byte[] MakeScaleByColor(byte[] imgBytes, Color color)
        {
            Bitmap original;
            using (var ms = new MemoryStream(imgBytes))
            {
                original = new Bitmap(ms);
            }

            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            //get a graphics object from the new image
            using (Graphics g = Graphics.FromImage(newBitmap))
            {
               ColorMatrix colorMatrix = new ColorMatrix(
                   new float[][]
                   {
                        new float[] { color.R / 255.0f, 0, 0, 0, 0 },
                        new float[] { 0, color.G / 255.0f, 0, 0, 0 },
                        new float[] { 0, 0, color.B / 255.0f, 0, 0 },
                        new float[] { 0, 0, 0, 1, 0 },
                        new float[] { 0, 0, 0, 0, 1 }
                   });

                //create some image attributes
                using (ImageAttributes attributes = new ImageAttributes())
                {

                    //set the color matrix attribute
                    attributes.SetColorMatrix(colorMatrix);

                    //draw the original image on the new image
                    //using the grayscale color matrix
                    g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
                                0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);
                }
            }

            return (byte[])new ImageConverter()
                .ConvertTo(newBitmap, typeof(byte[]));
        }


        #region private methods

        private static ImageCodecInfo GetEncoder(ImageFormat format)
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


        private static System.Drawing.Image Resize(System.Drawing.Image image, Size size, bool preserveAspectRatio = true)
        {
            Size newSize = new Size(size.Width, size.Height);

            //int newWidth;
            //int newHeight;
            
            if (preserveAspectRatio)
            {
                newSize = CalculateAspectRatio(image.Size, size);

                //int originalWidth = image.Width;
                //int originalHeight = image.Height;
                //float percentWidth = (float)size.Width / (float)originalWidth;
                //float percentHeight = (float)size.Height / (float)originalHeight;
                //float percent = percentHeight < percentWidth ? percentHeight : percentWidth;
                //newWidth = (int)(originalWidth * percent);
                //newHeight = (int)(originalHeight * percent);
            }
            //else
            //{
            //    newWidth = size.Width;
            //    newHeight = size.Height;
            //}

            System.Drawing.Image newImage = new Bitmap(newSize.Width, newSize.Height);
            using (Graphics gp = Graphics.FromImage(newImage))
            {
                gp.SmoothingMode = SmoothingMode.AntiAlias;
                gp.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gp.DrawImage(image, 0, 0, newSize.Width, newSize.Height);

                return newImage;
            }
        }

        public static Size CalculateAspectRatio(Size current, Size newSize)
        {
            float percentWidth = (float)newSize.Width / (float)current.Width;
            float percentHeight = (float)newSize.Height / (float)current.Height;
            float percent = (percentHeight < percentWidth ? percentHeight : percentWidth);

            return new Size(
                (int)(current.Width * percent), 
                (int)(current.Height * percent)
            );
        }

        #endregion
    }
}
