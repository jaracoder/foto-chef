using static FotoChef.Models.Enums;

namespace FotoChef.Models
{
    public class Picture
    {
        public byte[] Data { get; set; }

        public PictureFile File { get; set; }

        public PictureFormat Format { get; set; }
        
        public byte[] ApplyFilter(Filter filterType)
        {
            switch (filterType)
            {
                case Filter.GrayScale:
                    break;

                case Filter.ColorScale:
                    break;
            }

            return null;
        }
    }
}
