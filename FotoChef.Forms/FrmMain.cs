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
        private string Name = string.Empty;
        private string Extension = string.Empty;
      

        public FrmMain()
        {
            InitializeComponent();

            Text = string.Format(Text, Assembly.GetExecutingAssembly().GetName().Version.ToString());

        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void LoadImage()
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                imageChef.ImageLocation = fileName;
                Name = Path.GetFileNameWithoutExtension(fileName);
                Extension = Path.GetExtension(fileName);
                
                ShowDimensionsImage(fileName);
            }
        }

        public void ShowDimensionsImage(string fileName)
        {
            using (Image sourceImage = Image.FromFile(fileName))
            {
                txtWidth.Text = sourceImage.Width.ToString();
                txtHeight.Text = sourceImage.Height.ToString();

                imageChef.Width = sourceImage.Width;
                imageChef.Height = sourceImage.Height;
            }
        }

        public void Save()
        {
            try
            {
                int newHeight = int.Parse(txtHeight.Text);
                int newWidth = int.Parse(txtWidth.Text);
                string fileName = imageChef.ImageLocation;

                byte[] img = getByteArrayImageFromFileName(fileName);
              //  byte[] newImg = Chef.ResizeImage(img, newHeight, newWidth);

                processAndSave(img);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void processAndSave(byte[] img)
        {
            saveImageDialog.Filter  = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|" +
                "Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Ico Image (.ico)|*.ico|Wmf Image (.wmf)|*.wmf";
            saveImageDialog.FileName = Name + Extension;

            if (saveImageDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = saveImageDialog.FileName;
                var ext = Path.GetExtension(fileName).ToLower();

                if (checkEscalaGrises.Checked)
                {
                    img = Chef.MakeGrayscale3(img);
                }
                else
                {
                    if (checkPorColor.Checked)
                    {
                        Color color = panelColorSelected.BackColor;
                        img = Chef.MakeScaleByColor(img, color);
                    }
                }


                if (checkCompresion.Checked)
                {
                    if (isPNGImage())
                    {
                        img = Chef.CompressPNG(img);
                    }
                    else
                    {
                        img = Chef.CompressJPG(img);
                    }
                }

                using (MemoryStream ms = new MemoryStream(img))
                {
                    using (Image picture = Image.FromStream(ms))
                    {
                        switch (ext)
                        {
                            case ".bmp": 
                                picture.Save(fileName, ImageFormat.Bmp);
                                break;
                            case ".gif":
                                picture.Save(fileName, ImageFormat.Gif);
                                break;
                            case ".jpg":
                                picture.Save(fileName, ImageFormat.Jpeg);
                                break;
                            case ".png":
                                picture.Save(fileName, ImageFormat.Png);
                                break;
                            case ".tiff":
                                picture.Save(fileName, ImageFormat.Tiff);
                                break;
                            case ".ico":
                                picture.Save(fileName, ImageFormat.Icon);
                                break;
                            case ".wmf":
                                picture.Save(fileName, ImageFormat.Wmf);
                                break;
                        }

                       
                    }
                }
            
                MessageBox.Show("Imagen guardada correctamente");
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

        private byte[] getByteArrayImageFromFileName(string fileName)
        {
            using (Image img = Image.FromFile(fileName))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, ImageFormat.Png);

                    return ms.ToArray();
                }
            }
        }

        private void checkPorColor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPorColor.Checked)
            {
                checkEscalaGrises.Checked = false;

                var result = colorDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    panelColorSelected.BackColor = colorDialog1.Color;
                }
            }
        }

        private void checkEscalaGrises_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEscalaGrises.Checked)
            {
                checkPorColor.Checked = false;
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutDialog = new About();
            aboutDialog.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abrirImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void cambiarDeTamañoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmResize(imageChef)
                .ShowDialog();
        }
    }
}