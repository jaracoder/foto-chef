using FotoChef.Models;
using Jaracoder.FotoChef;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FotoChef.Forms
{
    public partial class FrmFotoChef : Form
    {
        private Canvas canvas;

        public FrmFotoChef()
        {
            InitializeComponent();

            canvas = new Canvas(this);
        }

        private void FotoChef_OpenImage(object sender, EventArgs e)
        {
            canvas.OpenImage();
        }

        private void Save(object sender, EventArgs e)
        {
            canvas.Save();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.CopyClipboardImage();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.PasteClipboardImage();
        }

        private void cambiarDeTamañoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.Resize();
        }

        private void girar90ºToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.Rotar(RotateFlipType.Rotate90FlipNone);
        }

        private void girar180ºToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.Rotar(RotateFlipType.Rotate180FlipNone);
        }

        private void voltearVerticalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.Rotar(RotateFlipType.RotateNoneFlipX);
        }

        private void voltearHorizontalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.Rotar(RotateFlipType.RotateNoneFlipX);
        }

        private void escalaDeGrisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.Filter(Enums.Filter.GrayScale);
        }

        private void escalaPorColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvas.Filter(Enums.Filter.ColorScale);
        }

        private void comprimirImagenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            canvas.Zip();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAbout().ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}