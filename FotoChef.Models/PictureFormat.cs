using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotoChef.Models
{
    public class PictureFormat : Picture
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Extension { get; set; }


        public PictureFormat (Enums.PictureFormat pictureFormat)
        {
            switch (pictureFormat)
            {
                case Enums.PictureFormat.PNG: Name = "PNG"; Description = "Portable Network Graphics"; Extension = ".png"; break;
            }
        }
   
        public override string ToString()
        {
            return $"{Description}|*{Extension}";
        }

        public string ToDialogFilter()
        {
            return $"{Description}|*{Extension}";
        }
    }
}
