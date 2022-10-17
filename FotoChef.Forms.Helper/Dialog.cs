using System;
using System.Windows.Forms;

namespace FotoChef.Forms.Helper
{
    public class Dialog
    {
        private OpenFileDialog openPictureDialog;
        private SaveFileDialog savePictureDialog;


        public string GetFileNameOpenPictureDialog(string defExt = null, string defFilter = null)
        {
            var fileName = string.Empty;
            var filter = defFilter != null ? defFilter : "PNG (*.png)|*.png|JPEG (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif|GIF (*.gif)|*.gif"; //"Mapa de bits (*.bmp;*.dib)|*.bmp|GIF (*.gif)|*.gif|JPEG (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg|PNG (*.png)|*.png|TIFF (*.tif;*.tiff)|*.tif|ICO (*.ico)|*.ico|WMF (*.wmf)|*.wmf";
            var filterIndex = 1; // PNG

            if (defExt != null)
            {
                filterIndex = GetFilterIndex(defExt);
            }

            if (openPictureDialog == null)
            {
                openPictureDialog = new OpenFileDialog()
                {
                    Title = "Abrir",
                    CheckFileExists = false,
                    CheckPathExists = false,
                    Multiselect = false,
                    ShowHelp = false,
                    ShowReadOnly = false,
                    ReadOnlyChecked = false,
                    AutoUpgradeEnabled = true /*change dialog ui if false*/,
                    RestoreDirectory = true,
                    InitialDirectory = string.Empty, /*conflict with RestoreDirectory *///Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                    FileName = string.Empty,
                    Filter = filter,
                    AddExtension = true,
                    DefaultExt = (defExt != null ? defExt : ".png"),
                    FilterIndex = filterIndex,
                };
            }
            else
            {
                openPictureDialog.FileName = string.Empty;
                openPictureDialog.DefaultExt = defExt;
                openPictureDialog.FilterIndex = filterIndex;
                openPictureDialog.Filter = filter;
            }

            if (openPictureDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openPictureDialog.FileName;
            }

            return fileName;
        }

        public string GetFileNameSavePictureDialog(string defFileName = null, string defExt = null, string defFilter = null)
        {
            var fileName = string.Empty;
            var filter = defFilter != null ? defFilter : "PNG (*.png)|*.png|JPEG (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg|GIF (*.gif)|*.gif";//"Mapa de bits (*.bmp;*.dib)|*.bmp|GIF (*.gif)|*.gif|JPEG (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg|PNG (*.png)|*.png|TIFF (*.tif;*.tiff)|*.tif|ICO (*.ico)|*.ico|WMF (*.wmf)|*.wmf";
            var filterIndex = 1; // PNG

            if (defExt != null)
            {
                filterIndex = GetFilterIndex(defExt);
            }

            if (defFileName is null)
            {
                defFileName = DateTime.Now.ToString("yyyyMMddHHmmss");
            }

            if (savePictureDialog == null)
            {
                savePictureDialog = new SaveFileDialog()
                {
                    CheckFileExists = false,
                    CheckPathExists = false,
                    CreatePrompt = false,
                    OverwritePrompt = true,
                    ShowHelp = false,
                    AutoUpgradeEnabled = true  /*change dialog ui if false*/,
                    RestoreDirectory = true,
                    InitialDirectory = string.Empty, /*conflict with RestoreDirectory *///Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                    FileName = defFileName,
                    Filter = filter,
                    AddExtension = true,
                    DefaultExt = (defExt != null ? defExt : ".png"),
                    FilterIndex = filterIndex,
                    Title = "Guardar como"
                };
            }
            else
            {
                savePictureDialog.FileName = defFileName;
                savePictureDialog.DefaultExt = defExt;
                savePictureDialog.FilterIndex = filterIndex;
                savePictureDialog.Filter = filter;
            }

            if (savePictureDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = savePictureDialog.FileName;
            }

            return fileName;
        }

        private int GetFilterIndex(string picExtension)
        {
            switch (picExtension)
            {
                case ".png":
                    return 1;

                case ".jpg":
                case ".jpeg":
                case ".jpe":
                case ".jfif":
                    return 2;

                case ".gif":
                    return 3;

                default: //.png
                    return 1;
            }
        }

        public class PictureExtension
        {
            public string Name { get; set; }

            public string Description { get; set; }

            public string Extension { get; set; }

            public enum PictureExtensionType
            {
                // https://es.wikipedia.org/wiki/Formatos_de_archivos_de_imagen

                PNG, JPG, JPEG, GIF, BMP, TIFF, ICO, WMF, PDF, EPS, SVG, PSD, AI, PS, UFO, TGA, EMF, WEBP   
            }

            public override string ToString()
            {
                return $"{Description}|*{Extension}";
            }
        }
    }
}
