using System.IO;

namespace FotoChef.Models
{
    public class Helpers
    {
        public static byte[] ImageToByteArray(System.Drawing.Image img)
        {
            using (var ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }


        public static System.Drawing.Image ByteArrayToImage(byte[] img)
        {
            using (var ms = new MemoryStream(img))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }
    }
}
