using FotoChef.Models;
using System;
using System.Windows.Forms;

namespace FotoChef.Forms
{
    public partial class FrmResize : Form
    {
        private PictureBox Canvas;
      
        public FrmResize(PictureBox canvas)
        {
            InitializeComponent();

            Canvas = canvas;
            txtWidth.Text = canvas.Image.Width.ToString();
            txtHeight.Text = canvas.Image.Height.ToString();
            txtWidth.Focus();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Canvas.Image = Chef.ResizeImage(
                Canvas.Image,
                int.Parse(txtWidth.Text),
                int.Parse(txtHeight.Text),
                chkAspectRatio.Checked
            );
            Canvas.Update();

            Close();
        }

        private void Size_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                   (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}