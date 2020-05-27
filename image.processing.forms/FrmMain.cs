using image.processing.binary;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace image.processing.forms
{
    public partial class FrmMain : Form
    {
        private string Name = string.Empty;
        private string Extension = string.Empty;
      

        public FrmMain()
        {
            InitializeComponent();     
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
                imageBox.ImageLocation = fileName;
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
            }
        }

        public void Save()
        {
            try
            {
                int newHeight = int.Parse(txtHeight.Text);
                int newWidth = int.Parse(txtWidth.Text);
                string fileName = imageBox.ImageLocation;

                byte[] img = getByteArrayImageFromFileName(fileName);
                byte[] newImg = ImageProcessor.ResizeImage(img, newHeight, newWidth);

                processAndSave(newImg);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void processAndSave(byte[] img)
        {
            saveImageDialog.FileName = Name + Extension;

            if (saveImageDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveImageDialog.FileName;


                if (checkEscalaGrises.Checked)
                {
                    img = ImageProcessor.MakeGrayscale3(img);
                }
                else
                {
                    if (checkPorColor.Checked)
                    {
                        Color color = panelColorSelected.BackColor;
                        img = ImageProcessor.MakeScaleByColor(img, color);
                    }
                }


                if (checkCompresion.Checked)
                {
                    if (isPNGImage())
                    {
                        img = ImageProcessor.CompressPNG(img);
                    }
                    else
                    {
                        img = ImageProcessor.CompressJPG(img);
                    }
                }

                using (MemoryStream ms = new MemoryStream(img))
                {
                    using (Image picture = Image.FromStream(ms))
                    {
                        picture.Save(fileName);
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
    }
}