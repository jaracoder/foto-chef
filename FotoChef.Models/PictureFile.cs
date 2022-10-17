namespace FotoChef.Models
{
    public class PictureFile : Picture
    {
        public string FileName { get; set; }

        public long FileSize { get; set; }  
    }
}
