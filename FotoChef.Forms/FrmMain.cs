using FotoChef.Forms.Helper;
using FotoChef.Models;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace FotoChef.Forms
{
    public partial class FrmMain : Form
    {
        private Image ImgOriginal = null;
        private byte[] ImgStylizedBytesArray = null;
        private byte[] ImgCompressed = null;
        private string FileName = null;
        private string Extension = null;

        private Dialog pictureDialog;
        public FrmMain()
        {
            pictureDialog = new Dialog();

            InitializeComponent();

            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            Text = string.Format(Text, version.Major + "." + version.Minor +  "." + version.Revision.ToString().Substring(0, 1) + " (build " + version.Build + ")");
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenImage();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAbout().ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void cambiarDeTamañoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (new FrmResize(imageChef).ShowDialog() == DialogResult.OK)
            {
                ShowDimensions();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar la aplicación?",
               "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) 
                == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FotoChef_OpenImage(object sender, EventArgs e)
        {
            OpenImage();
        }

        private void OpenImage()
        {
            FileName = pictureDialog.GetFileNameOpenPictureDialog(defExt: Extension); 
            
            if (FileName != string.Empty)
            {
                Name = Path.GetFileNameWithoutExtension(FileName);
                Extension = Path.GetExtension(FileName);

                UpdateImage(FileName);
                ShowDimensions();
                EnableOptionsMenu();
            }
        }

        private void UpdateImage(string fileName = null, Image image = null, ImageFormat imageFormat = null)
        {
            imageChef.Image = (fileName is null ? image : Image.FromFile(FileName));
            imageChef.Width = imageChef.Image.Width;
            imageChef.Height = imageChef.Image.Height;

            if (ImgOriginal is null)
            {
                ImgOriginal = imageChef.Image;
            }
            else
            {
                ImgStylizedBytesArray = Helpers.ImageToByteArray(imageChef.Image, ImgOriginal.RawFormat);
            }
          
            ImgCompressed = null;
        }

        public void ShowDimensions()
        {
            lblSize.Text = $"{imageChef.Image.Width} x {imageChef.Image.Height} píxeles";
            lblFileSize.Text = $"Tamaño: {(Helpers.GetFileSizeImage(FileName) / 1024).ToString()} KB";
            lblExtension.Text = $"Imagen {Extension.ToUpper().Substring(1)}";

            lblSize.Visible = true;
            lblFileSize.Visible = true;
            lblExtension.Visible = true;
        }

        public void EnableOptionsMenu()
        {
            guardarComoToolStripMenuItem.Enabled = true;
            cambiarDeTamañoToolStripMenuItem.Enabled = true;
            comprimirImagenToolStripMenuItem.Enabled = true;
            escalaDeGrisesToolStripMenuItem.Enabled = true;
            escalaPorColorToolStripMenuItem.Enabled = true;
        }

        public void Save()
        {
            try
            {
                var fileName = pictureDialog.GetFileNameSavePictureDialog(defExt: Extension);

                if (fileName != string.Empty)
                {
                    byte[] image = ImgCompressed != null ? ImgCompressed : ImgStylizedBytesArray is null ? 
                        Helpers.ImageToByteArray(ImgOriginal) : ImgStylizedBytesArray;

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
                    }

                    MessageBox.Show("La imagen se ha guardado correctamente.", "Imagen guardada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error de aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isPNGImage()
        {
            if (Extension.ToLower().Equals(".png"))
            {
                return true;
            }
            return false;
        }

        private void escalaDeGrisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var color = Color.Gray;

            UpdateImage(image: Chef.ApplyFilter(imageChef.Image, Enums.Filter.GrayScale, color), 
                imageFormat: imageChef.Image.RawFormat );
        }

        private void escalaPorColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                var color = colorDialog1.Color;

                UpdateImage(image: Chef.ApplyFilter(imageChef.Image, Enums.Filter.ColorScale, color), 
                    imageFormat: imageChef.Image.RawFormat);
            }
        }

        private void comprimirImagenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var img = ImgStylizedBytesArray is null ? Helpers.ImageToByteArray(ImgOriginal) : ImgStylizedBytesArray;

            if (isPNGImage())
            {
                ImgCompressed = Chef.CompressPNG(img);
            }
            else
            {
                ImgCompressed = Chef.CompressJPG(img);
            }

            MessageBox.Show("La imagen se ha comprimido correctamente.", "Imagen comprimida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}