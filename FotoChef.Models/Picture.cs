using static FotoChef.Models.Enums;

namespace FotoChef.Models
{
    public class Picture : Shape
    {
        public string Extension { get; set; }

        public string FileName { get; set; }


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
