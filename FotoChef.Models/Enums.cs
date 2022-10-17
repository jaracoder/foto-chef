namespace FotoChef.Models
{
    public static class Enums
    {
        public enum Filter { GrayScale, ColorScale }

        public enum PictureFormat
        {
            // https://es.wikipedia.org/wiki/Formatos_de_archivos_de_imagen

            PNG, JPG, JPEG, GIF, BMP, TIFF, ICO, WMF, PDF, EPS, SVG, PSD, AI, PS, UFO, TGA, EMF, WEBP
        }
    }
}
