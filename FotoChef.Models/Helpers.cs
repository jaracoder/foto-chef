using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace FotoChef.Models
{
    public class Helpers
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="img"></param>
        /// <param name="imageFormat">
        /// Utiliza el formato de la imagen original, al crear un nuevo Bitmap se establece por defecto,
        /// el tipo(ImageFormat.MemoryBmp) y retorna null cuando se intenta obtener su encoder.
        /// https:www.mejorcodigo.com/p/52197.html 
        /// </param>
        /// <returns></returns>
        public static byte[] ImageToByteArray(Image img, ImageFormat imageFormat = null)
        {
            using (var ms = new MemoryStream())
            {
                img.Save(ms, imageFormat != null ? imageFormat : img.RawFormat);
                return ms.ToArray();
            }


            //using (Bitmap bmb = new Bitmap(img))
            //{
            //    using (var ms = new MemoryStream())
            //    {
            //        bmb.Save(ms, img.RawFormat);

            //        return ms.ToArray();
            //    }
            //}
        }

        public static Image ByteArrayToImage(byte[] img)
        {
            using (var ms = new MemoryStream(img))
            using (var image = Image.FromStream(ms, false, true)) 
            { 
                return new Bitmap(image); 
            }
        }

        public static long GetFileSizeBytes(string fileName)
        {
            return new FileInfo(fileName).Length; // Bytes
        }

        public static long GetFileSizeLong(string fileName, bool inKbOrMb = true)
        {
            long fileSize = GetFileSizeBytes(fileName);

            if (inKbOrMb)
            {
                return fileSize >> 10; //KB (=> fileSize / 1024)
            }
            else
            {
                return fileSize >> 20; //MB (=> fileSize / 1048576)
            }
        }

        public static double GetFileSizeDouble(string fileName, bool inKbOrMb = true)
        {
            long fileSize = GetFileSizeBytes(fileName);

            if (inKbOrMb) 
            {
                return fileSize / 1024d; //KB
            }
            else
            {
                return fileSize / 1048576d; //MB
            }
        }
    }
}
