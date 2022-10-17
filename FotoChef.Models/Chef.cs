using nQuant;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

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
        public static Image ResizeImage(Image img, int width, int height)
        {
            Size s = new Size(width, height);
            Image resizedImg = Resize(img, s);

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


        public static Image ApplyFilter(Image img, Enums.Filter filter, Color color)
        {
            Bitmap newBitmap = new Bitmap(img.Width, img.Height);
         
            using (Graphics grap = Graphics.FromImage(newBitmap))
            {
                using (ImageAttributes attr = new ImageAttributes())
                {
                    switch (filter)
                    {
                        case Enums.Filter.GrayScale:

                            attr.SetColorMatrix(
                                new ColorMatrix(new float[][]
                                {
                                    new float[] {.3f, .3f, .3f, 0, 0},
                                    new float[] {.59f, .59f, .59f, 0, 0},
                                    new float[] {.11f, .11f, .11f, 0, 0},
                                    new float[] {0, 0, 0, 1, 0},
                                    new float[] {0, 0, 0, 0, 1}
                                })
                            );
                            break;

                        case Enums.Filter.ColorScale:

                            attr.SetColorMatrix(
                                new ColorMatrix(new float[][]
                                {
                                    new float[] { color.R / 255.0f, 0, 0, 0, 0 },
                                    new float[] { 0, color.G / 255.0f, 0, 0, 0 },
                                    new float[] { 0, 0, color.B / 255.0f, 0, 0 },
                                    new float[] { 0, 0, 0, 1, 0 },
                                    new float[] { 0, 0, 0, 0, 1 }
                                })
                            );
                            break;
                    }

                    grap.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height),
                        0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attr);
                }
            }

            return newBitmap;
        }

        //public static Image MakeGrayscale3(Image img)
        //{
        //    //create a blank bitmap the same size as original
        //    Bitmap newBitmap = new Bitmap(img.Width, img.Height);
        //    //newBitmap.fo = img.RawFormat;

        //    //get a graphics object from the new image
        //    using (Graphics g = Graphics.FromImage(newBitmap))
        //    {

        //        //create the grayscale ColorMatrix
        //        ColorMatrix colorMatrix = new ColorMatrix(
        //           new float[][]
        //           {
        //                new float[] {.3f, .3f, .3f, 0, 0},
        //                new float[] {.59f, .59f, .59f, 0, 0},
        //                new float[] {.11f, .11f, .11f, 0, 0},
        //                new float[] {0, 0, 0, 1, 0},
        //                new float[] {0, 0, 0, 0, 1}
        //           });

        //        //create some image attributes
        //        using (ImageAttributes attributes = new ImageAttributes())
        //        {

        //            //set the color matrix attribute
        //            attributes.SetColorMatrix(colorMatrix);
                   
        //            //draw the original image on the new image
        //            //using the grayscale color matrix
        //            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 
        //                0, 0, img.Width, img.Height, GraphicsUnit.Pixel, attributes);
        //        }
        //    }

        //    return newBitmap;/*(byte[])new ImageConverter()
        //        .ConvertTo(newBitmap, typeof(byte[]));*/
        //}


        //public static byte[] MakeScaleByColor(byte[] imgBytes, Color color)
        //{
        //    Bitmap original;
        //    using (var ms = new MemoryStream(imgBytes))
        //    {
        //        original = new Bitmap(ms);
        //    }

        //    //create a blank bitmap the same size as original
        //    Bitmap newBitmap = new Bitmap(original.Width, original.Height);

        //    //get a graphics object from the new image
        //    using (Graphics g = Graphics.FromImage(newBitmap))
        //    {
        //       ColorMatrix colorMatrix = new ColorMatrix(
        //           new float[][]
        //           {
        //                new float[] { color.R / 255.0f, 0, 0, 0, 0 },
        //                new float[] { 0, color.G / 255.0f, 0, 0, 0 },
        //                new float[] { 0, 0, color.B / 255.0f, 0, 0 },
        //                new float[] { 0, 0, 0, 1, 0 },
        //                new float[] { 0, 0, 0, 0, 1 }
        //           });

        //        //create some image attributes
        //        using (ImageAttributes attributes = new ImageAttributes())
        //        {

        //            //set the color matrix attribute
        //            attributes.SetColorMatrix(colorMatrix);

        //            //draw the original image on the new image
        //            //using the grayscale color matrix
        //            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
        //                        0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);
        //        }
        //    }

        //    return (byte[])new ImageConverter()
        //        .ConvertTo(newBitmap, typeof(byte[]));
        //}


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


        private static Image Resize(Image image, Size newSize)
        {
            Image newImage = new Bitmap(newSize.Width, newSize.Height);
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
            float scaleHeight = (float)newSize.Height / (float)current.Height,
                  scaleWidth = (float)newSize.Width / (float)current.Width,
                  scale = scaleHeight != 1 ? scaleHeight : scaleWidth;

            if (scaleHeight != 1)
            {
                newSize.Width = (int)(current.Width * scale);
            }
            else
            {
                newSize.Height = (int)(current.Height * scale);
            }

            return newSize;
        }

        #endregion
    }
}
