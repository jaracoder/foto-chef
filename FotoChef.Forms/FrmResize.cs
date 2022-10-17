using FotoChef.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FotoChef.Forms
{
    public partial class FrmResize : Form
    {
        private PictureBox Canvas;
        private Size CurrentSize;

        public FrmResize(PictureBox canvas)
        {
            InitializeComponent();

            Canvas = canvas;
            CurrentSize = new Size(canvas.Image.Width, canvas.Image.Height);
            
            txtWidth.Text = CurrentSize.Width.ToString();
            txtHeight.Text = CurrentSize.Height.ToString();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Canvas.Image = Chef.ResizeImage(Canvas.Image, CurrentSize.Width, CurrentSize.Height);
            Canvas.Width = Canvas.Image.Width;
            Canvas.Height = Canvas.Image.Height;
            Canvas.Update();

            DialogResult = DialogResult.OK;
        }

        private void Size_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Size_TextChanged(object sender, EventArgs e)
        {
            if (txtWidth.Text != string.Empty && txtHeight.Text != string.Empty)
            {
                Size newSize = new Size(int.Parse(txtWidth.Text), int.Parse(txtHeight.Text));

                if (newSize != CurrentSize)
                {
                    if (chkAspectRatio.Checked)
                    {
                        newSize = Chef.CalculateAspectRatio(CurrentSize, newSize);
                    }

                    CurrentSize = newSize;

                    txtWidth.Text = CurrentSize.Width.ToString();
                    txtHeight.Text = CurrentSize.Height.ToString();
                }                
            }
        }
    }
}