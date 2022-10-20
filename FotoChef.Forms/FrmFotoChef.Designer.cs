namespace FotoChef.Forms
{
    partial class FrmFotoChef
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFotoChef));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageChef = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cambiarDeTamañoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.girar90ºToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girar180ºToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltearHorizontalmenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltearVerticalmenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaDeGrisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaPorColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprimirImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblExtension = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFileSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFileSizeMin = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imageChef)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlCanvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "png";
            this.openFileDialog1.Filter = "Image files|*.jpg;*.png;";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // imageChef
            // 
            this.imageChef.BackColor = System.Drawing.Color.White;
            this.imageChef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageChef.Location = new System.Drawing.Point(6, 3);
            this.imageChef.Name = "imageChef";
            this.imageChef.Size = new System.Drawing.Size(752, 588);
            this.imageChef.TabIndex = 0;
            this.imageChef.TabStop = false;
            this.imageChef.DoubleClick += new System.EventHandler(this.FotoChef_OpenImage);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.filtrosToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagenToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirImagenToolStripMenuItem
            // 
            this.abrirImagenToolStripMenuItem.Image = global::Jaracoder.FotoChef.Properties.Resources.Open;
            this.abrirImagenToolStripMenuItem.Name = "abrirImagenToolStripMenuItem";
            this.abrirImagenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirImagenToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.abrirImagenToolStripMenuItem.Text = "Abrir";
            this.abrirImagenToolStripMenuItem.ToolTipText = "Abrir una imagen nueva.";
            this.abrirImagenToolStripMenuItem.Click += new System.EventHandler(this.FotoChef_OpenImage);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Enabled = false;
            this.guardarComoToolStripMenuItem.Image = global::Jaracoder.FotoChef.Properties.Resources.Save;
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.guardarComoToolStripMenuItem.Text = "Guardar como";
            this.guardarComoToolStripMenuItem.ToolTipText = "Guardar los cambios de la imagen.";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.Save);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::Jaracoder.FotoChef.Properties.Resources.Exit;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.ToolTipText = "Cerrar la aplicación.";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.toolStripSeparator3,
            this.cambiarDeTamañoToolStripMenuItem,
            this.toolStripSeparator2,
            this.girar90ºToolStripMenuItem,
            this.girar180ºToolStripMenuItem,
            this.voltearHorizontalmenteToolStripMenuItem,
            this.voltearVerticalmenteToolStripMenuItem});
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Enabled = false;
            this.copiarToolStripMenuItem.Image = global::Jaracoder.FotoChef.Properties.Resources.Copy;
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.copiarToolStripMenuItem.Text = "&Copiar";
            this.copiarToolStripMenuItem.ToolTipText = "Copiar imagen al portapapeles.";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Enabled = false;
            this.pegarToolStripMenuItem.Image = global::Jaracoder.FotoChef.Properties.Resources.Paste;
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.pegarToolStripMenuItem.Text = "&Pegar";
            this.pegarToolStripMenuItem.ToolTipText = "Pegar imagen desde el portapapeles.";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(235, 6);
            // 
            // cambiarDeTamañoToolStripMenuItem
            // 
            this.cambiarDeTamañoToolStripMenuItem.Enabled = false;
            this.cambiarDeTamañoToolStripMenuItem.Image = global::Jaracoder.FotoChef.Properties.Resources.Image_Resize;
            this.cambiarDeTamañoToolStripMenuItem.Name = "cambiarDeTamañoToolStripMenuItem";
            this.cambiarDeTamañoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.cambiarDeTamañoToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.cambiarDeTamañoToolStripMenuItem.Text = "&Redimensionar";
            this.cambiarDeTamañoToolStripMenuItem.ToolTipText = "Cambiar el tamaño de la imagen.";
            this.cambiarDeTamañoToolStripMenuItem.Click += new System.EventHandler(this.cambiarDeTamañoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(235, 6);
            // 
            // girar90ºToolStripMenuItem
            // 
            this.girar90ºToolStripMenuItem.Enabled = false;
            this.girar90ºToolStripMenuItem.Image = global::Jaracoder.FotoChef.Properties.Resources.Image_Rotate;
            this.girar90ºToolStripMenuItem.Name = "girar90ºToolStripMenuItem";
            this.girar90ºToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.girar90ºToolStripMenuItem.Text = "&Girar 90º";
            this.girar90ºToolStripMenuItem.ToolTipText = "Girar 90º la imagen en sentido de las agujas del reloj.";
            this.girar90ºToolStripMenuItem.Click += new System.EventHandler(this.girar90ºToolStripMenuItem_Click);
            // 
            // girar180ºToolStripMenuItem
            // 
            this.girar180ºToolStripMenuItem.Enabled = false;
            this.girar180ºToolStripMenuItem.Image = global::Jaracoder.FotoChef.Properties.Resources.Image_Rotate;
            this.girar180ºToolStripMenuItem.Name = "girar180ºToolStripMenuItem";
            this.girar180ºToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.girar180ºToolStripMenuItem.Text = "Girar 180º";
            this.girar180ºToolStripMenuItem.ToolTipText = "Girar 180º la imagen en sentido de las agujas del reloj.";
            this.girar180ºToolStripMenuItem.Click += new System.EventHandler(this.girar180ºToolStripMenuItem_Click);
            // 
            // voltearHorizontalmenteToolStripMenuItem
            // 
            this.voltearHorizontalmenteToolStripMenuItem.Enabled = false;
            this.voltearHorizontalmenteToolStripMenuItem.Image = global::Jaracoder.FotoChef.Properties.Resources.Image_Mirror;
            this.voltearHorizontalmenteToolStripMenuItem.Name = "voltearHorizontalmenteToolStripMenuItem";
            this.voltearHorizontalmenteToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.voltearHorizontalmenteToolStripMenuItem.Text = "Voltear horizontalmente";
            this.voltearHorizontalmenteToolStripMenuItem.ToolTipText = "Voltear horizontalmente la imagen.";
            this.voltearHorizontalmenteToolStripMenuItem.Click += new System.EventHandler(this.voltearHorizontalmenteToolStripMenuItem_Click);
            // 
            // voltearVerticalmenteToolStripMenuItem
            // 
            this.voltearVerticalmenteToolStripMenuItem.Enabled = false;
            this.voltearVerticalmenteToolStripMenuItem.Image = global::Jaracoder.FotoChef.Properties.Resources.Image_Flip;
            this.voltearVerticalmenteToolStripMenuItem.Name = "voltearVerticalmenteToolStripMenuItem";
            this.voltearVerticalmenteToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.voltearVerticalmenteToolStripMenuItem.Text = "Voltear verticalmente";
            this.voltearVerticalmenteToolStripMenuItem.ToolTipText = "Voltear verticalmente la imagen.";
            this.voltearVerticalmenteToolStripMenuItem.Click += new System.EventHandler(this.voltearVerticalmenteToolStripMenuItem_Click);
            // 
            // filtrosToolStripMenuItem
            // 
            this.filtrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escalaDeGrisesToolStripMenuItem,
            this.escalaPorColorToolStripMenuItem});
            this.filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            this.filtrosToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.filtrosToolStripMenuItem.Text = "Filtros";
            // 
            // escalaDeGrisesToolStripMenuItem
            // 
            this.escalaDeGrisesToolStripMenuItem.Enabled = false;
            this.escalaDeGrisesToolStripMenuItem.Name = "escalaDeGrisesToolStripMenuItem";
            this.escalaDeGrisesToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.escalaDeGrisesToolStripMenuItem.Text = "Escala de grises";
            this.escalaDeGrisesToolStripMenuItem.ToolTipText = "Aplicar un filtro de escala de grises.";
            this.escalaDeGrisesToolStripMenuItem.Click += new System.EventHandler(this.escalaDeGrisesToolStripMenuItem_Click);
            // 
            // escalaPorColorToolStripMenuItem
            // 
            this.escalaPorColorToolStripMenuItem.Enabled = false;
            this.escalaPorColorToolStripMenuItem.Name = "escalaPorColorToolStripMenuItem";
            this.escalaPorColorToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.escalaPorColorToolStripMenuItem.Text = "Escala por colores";
            this.escalaPorColorToolStripMenuItem.ToolTipText = "Aplicar un filtro de escala por colores.";
            this.escalaPorColorToolStripMenuItem.Click += new System.EventHandler(this.escalaPorColorToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprimirImagenToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // comprimirImagenToolStripMenuItem
            // 
            this.comprimirImagenToolStripMenuItem.Enabled = false;
            this.comprimirImagenToolStripMenuItem.Image = global::Jaracoder.FotoChef.Properties.Resources.Compress;
            this.comprimirImagenToolStripMenuItem.Name = "comprimirImagenToolStripMenuItem";
            this.comprimirImagenToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.comprimirImagenToolStripMenuItem.Text = "Comprimir imagen";
            this.comprimirImagenToolStripMenuItem.ToolTipText = "Comprime la imagen para reducir el tamaño en disco.";
            this.comprimirImagenToolStripMenuItem.Click += new System.EventHandler(this.comprimirImagenToolStripMenuItem_Click_1);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Image = global::Jaracoder.FotoChef.Properties.Resources.About;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.ToolTipText = "Acerca de Foto Chef.";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSize,
            this.lblExtension,
            this.lblFileSize,
            this.lblFileSizeMin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 704);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 25);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSize
            // 
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(110, 20);
            this.lblSize.Text = "{0} x {1} píxeles";
            this.lblSize.Visible = false;
            // 
            // lblExtension
            // 
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblExtension.Size = new System.Drawing.Size(165, 20);
            this.lblExtension.Text = "Tipo de imagen: PNG";
            this.lblExtension.Visible = false;
            // 
            // lblFileSize
            // 
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblFileSize.Size = new System.Drawing.Size(64, 20);
            this.lblFileSize.Text = "{0} KB";
            this.lblFileSize.Visible = false;
            // 
            // lblFileSizeMin
            // 
            this.lblFileSizeMin.Name = "lblFileSizeMin";
            this.lblFileSizeMin.Size = new System.Drawing.Size(49, 20);
            this.lblFileSizeMin.Text = "{0} KB";
            this.lblFileSizeMin.Visible = false;
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.AutoScroll = true;
            this.pnlCanvas.BackColor = System.Drawing.Color.White;
            this.pnlCanvas.Controls.Add(this.imageChef);
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(0, 28);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(1008, 676);
            this.pnlCanvas.TabIndex = 13;
            // 
            // FrmFotoChef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pnlCanvas);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmFotoChef";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foto Chef {0}";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.imageChef)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlCanvas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        internal System.Windows.Forms.PictureBox imageChef;
        internal System.Windows.Forms.ToolStripStatusLabel lblSize;
        internal System.Windows.Forms.ToolStripStatusLabel lblFileSize;
        internal System.Windows.Forms.ToolStripStatusLabel lblFileSizeMin;
        internal System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem cambiarDeTamañoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem escalaDeGrisesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem escalaPorColorToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem girar90ºToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem girar180ºToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem voltearHorizontalmenteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem voltearVerticalmenteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem comprimirImagenToolStripMenuItem;
        internal System.Windows.Forms.ToolStripStatusLabel lblExtension;
        internal System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

