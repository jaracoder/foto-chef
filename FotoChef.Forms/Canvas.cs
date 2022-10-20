using FotoChef.Forms;
using FotoChef.Forms.Helper;
using FotoChef.Models;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace Jaracoder.FotoChef
{
    public class Canvas
    {
        private FrmFotoChef frmFotoChef;
        private Image ImgOriginal = null;
        private ImageFormat ImgFormatOriginal = null;

        private byte[] ImgStylizedBytesArray = null;//,
                    //   ImgCompressed = null;

        private string FilePath = null,
                       FileName = null,
                       FileExt = null;

        private Dialog pictureDialog;
        private ColorDialog colorDialog;

        public Canvas(FrmFotoChef frmFotoChef)
        {
            this.frmFotoChef = frmFotoChef;

            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            this.frmFotoChef.Text = string.Format(this.frmFotoChef.Text, version.Major + "." + version.Minor + "." + version.Revision.ToString().Substring(0, 1) + " (build " + version.Build + ")");

            pictureDialog = new Dialog();
            colorDialog = new ColorDialog();
        }

        public void OpenImage()
        {
            FilePath = pictureDialog.GetFileNameOpenPictureDialog(defExt: FileExt);

            if (FilePath != string.Empty)
            {
               // frmFotoChef.Name = Path.GetFileNameWithoutExtension(FilePath);
                FileName = Path.GetFileNameWithoutExtension(FilePath);
                FileExt = Path.GetExtension(FilePath);

                UpdateImage(FilePath);
                ShowProperties();
                EnableOptionsMenu();
            }
        }

        public void UpdateImage(string fileName = null, Image image = null)
        {
            frmFotoChef.imageChef.Image = (fileName is null ? image : Image.FromFile(FilePath));
            frmFotoChef.imageChef.Width = frmFotoChef.imageChef.Image.Width;
            frmFotoChef.imageChef.Height = frmFotoChef.imageChef.Image.Height;

            if (ImgOriginal is null)
            {
                ImgOriginal = frmFotoChef.imageChef.Image;
                ImgFormatOriginal = ImgOriginal.RawFormat;
            }
            else
            {
                ImgStylizedBytesArray = Helpers.ImageToByteArray(frmFotoChef.imageChef.Image, ImgFormatOriginal);
            }

            ///ImgCompressed = null;
        }

        public void ShowProperties()
        {
            frmFotoChef.lblSize.Text = $"{frmFotoChef.imageChef.Image.Width} x {frmFotoChef.imageChef.Image.Height} píxeles";
            frmFotoChef.lblFileSize.Text = $"Tamaño: {(Helpers.GetFileSizeDouble(FilePath, true)).ToString("0.00")} KB";
            frmFotoChef.lblExtension.Text = $"Imagen {FileExt.ToUpper().Substring(1)}";

            frmFotoChef.lblSize.Visible = true;
            frmFotoChef.lblFileSize.Visible = true;
            frmFotoChef.lblExtension.Visible = true;
        }

        public void EnableOptionsMenu()
        {
            frmFotoChef.guardarComoToolStripMenuItem.Enabled = true;
            frmFotoChef.copiarToolStripMenuItem.Enabled = true;
            frmFotoChef.pegarToolStripMenuItem.Enabled = true;
            frmFotoChef.cambiarDeTamañoToolStripMenuItem.Enabled = true;
            frmFotoChef.girar90ºToolStripMenuItem.Enabled = true;
            frmFotoChef.girar180ºToolStripMenuItem.Enabled = true;
            frmFotoChef.voltearHorizontalmenteToolStripMenuItem.Enabled = true;
            frmFotoChef.voltearVerticalmenteToolStripMenuItem.Enabled = true;
            frmFotoChef.comprimirImagenToolStripMenuItem.Enabled = true;
            frmFotoChef.escalaDeGrisesToolStripMenuItem.Enabled = true;
            frmFotoChef.escalaPorColorToolStripMenuItem.Enabled = true;
        }

        public void Save(string fileName = null)
        {
            try
            {
                bool showAlert = false;
                if (fileName is null)
                {
                    fileName = pictureDialog.GetFileNameSavePictureDialog(defExt: FileExt);
                    showAlert = true;
                }
                
                byte[] image = (ImgStylizedBytesArray is null ? Helpers.ImageToByteArray(ImgOriginal) : ImgStylizedBytesArray);

                using (MemoryStream ms = new MemoryStream(image))
                {
                    using (Image picture = Image.FromStream(ms))
                    {
                        var imageFormat = ImageFormat.Png;
                        var ext = Path.GetExtension(fileName).ToLower();

                        switch (ext)
                        {
                            case ".png":
                                imageFormat = ImageFormat.Png;
                                break;

                            case ".jpg":
                            case ".jpeg":
                            case ".jpe":
                            case ".jfif":
                                imageFormat = ImageFormat.Jpeg;
                                break;

                            case ".gif":
                                imageFormat = ImageFormat.Gif;
                                break;

                            case ".bmp":
                                imageFormat = ImageFormat.Bmp;
                                break;

                            case ".tif":
                                imageFormat = ImageFormat.Tiff;
                                break;

                            case ".ico":
                                imageFormat = ImageFormat.Icon;
                                break;

                            case ".wmf":
                                imageFormat = ImageFormat.Wmf;
                                break;
                        }

                        picture.Save(fileName, imageFormat);
                    }
                    if (showAlert)
                    {
                        MessageBox.Show("La imagen se ha guardado correctamente.", "Imagen guardada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error de aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Rotar(RotateFlipType rotateType)
        {
            var aux = frmFotoChef.imageChef.Image;
            aux.RotateFlip(rotateType);

            UpdateImage(image: aux);
        }

        public void Resize()
        {
            if (new FrmResize(frmFotoChef.imageChef).ShowDialog() == DialogResult.OK)
            {
                ShowProperties();
            }
        }

        public void Filter(Enums.Filter filterType)
        {
            var color = Color.Gray;

            if (filterType == Enums.Filter.ColorScale && colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
            } 
            
            UpdateImage(image: Chef.ApplyFilter(frmFotoChef.imageChef.Image, filterType, color));
        }

        public void Zip()
        {
            var img = ImgStylizedBytesArray is null ? Helpers.ImageToByteArray(ImgOriginal) : ImgStylizedBytesArray;

            if (FileExt.ToLower().Equals(".png"))
            {
                ImgStylizedBytesArray = Chef.CompressPNG(img);
            }
            else
            {
                ImgStylizedBytesArray = Chef.CompressJPG(img);
            }

            UpdateImage(image: Helpers.ByteArrayToImage(ImgStylizedBytesArray));

            var tempFile = $@"{Path.GetTempPath()}\{FileName}{FileExt}";
            Save(tempFile);

            frmFotoChef.lblFileSizeMin.Text = $"Tamaño reducido a: {(Helpers.GetFileSizeDouble(tempFile, true)).ToString("0.00")} KB"; ;
            frmFotoChef.lblFileSizeMin.Visible = true;

            File.Delete(tempFile);

            //MessageBox.Show("La imagen se ha comprimido correctamente.", "Imagen comprimida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void CopyClipboardImage()
        {
            Clipboard.SetImage(ImgStylizedBytesArray is null ? 
                ImgOriginal : Helpers.ByteArrayToImage(ImgStylizedBytesArray));
        }

        public void PasteClipboardImage()
        {
            if (Clipboard.ContainsImage())
            {
                UpdateImage(image: Clipboard.GetImage());
            }
        }
    }
}
