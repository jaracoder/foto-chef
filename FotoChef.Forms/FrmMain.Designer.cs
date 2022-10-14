namespace FotoChef.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageChef = new System.Windows.Forms.PictureBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.groupRedimension = new System.Windows.Forms.GroupBox();
            this.panelColorSelected = new System.Windows.Forms.Panel();
            this.checkPorColor = new System.Windows.Forms.CheckBox();
            this.checkEscalaGrises = new System.Windows.Forms.CheckBox();
            this.checkCompresion = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarDeTamañoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprimirImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaDeGrisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaPorColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imageChef)).BeginInit();
            this.groupRedimension.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveImageDialog
            // 
            this.saveImageDialog.DefaultExt = "png";
            this.saveImageDialog.Filter = "Image files|*.jpg;*.png;";
            this.saveImageDialog.RestoreDirectory = true;
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
            this.imageChef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageChef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageChef.Location = new System.Drawing.Point(0, 28);
            this.imageChef.Name = "imageChef";
            this.imageChef.Size = new System.Drawing.Size(800, 353);
            this.imageChef.TabIndex = 0;
            this.imageChef.TabStop = false;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(64, 25);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(54, 20);
            this.txtWidth.TabIndex = 3;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(20, 28);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 13);
            this.lblWidth.TabIndex = 4;
            this.lblWidth.Text = "Ancho";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(138, 28);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(25, 13);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Alto";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(169, 25);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(54, 20);
            this.txtHeight.TabIndex = 5;
            // 
            // groupRedimension
            // 
            this.groupRedimension.Controls.Add(this.panelColorSelected);
            this.groupRedimension.Controls.Add(this.checkPorColor);
            this.groupRedimension.Controls.Add(this.checkEscalaGrises);
            this.groupRedimension.Controls.Add(this.checkCompresion);
            this.groupRedimension.Controls.Add(this.txtHeight);
            this.groupRedimension.Controls.Add(this.txtWidth);
            this.groupRedimension.Controls.Add(this.lblHeight);
            this.groupRedimension.Controls.Add(this.lblWidth);
            this.groupRedimension.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupRedimension.Location = new System.Drawing.Point(0, 381);
            this.groupRedimension.Name = "groupRedimension";
            this.groupRedimension.Size = new System.Drawing.Size(800, 61);
            this.groupRedimension.TabIndex = 8;
            this.groupRedimension.TabStop = false;
            this.groupRedimension.Text = "Dimensiones";
            // 
            // panelColorSelected
            // 
            this.panelColorSelected.Location = new System.Drawing.Point(457, 22);
            this.panelColorSelected.Name = "panelColorSelected";
            this.panelColorSelected.Size = new System.Drawing.Size(35, 22);
            this.panelColorSelected.TabIndex = 11;
            // 
            // checkPorColor
            // 
            this.checkPorColor.AutoSize = true;
            this.checkPorColor.Location = new System.Drawing.Point(349, 27);
            this.checkPorColor.Name = "checkPorColor";
            this.checkPorColor.Size = new System.Drawing.Size(102, 17);
            this.checkPorColor.TabIndex = 8;
            this.checkPorColor.Text = "Escala por color";
            this.checkPorColor.UseVisualStyleBackColor = true;
            this.checkPorColor.CheckedChanged += new System.EventHandler(this.checkPorColor_CheckedChanged);
            // 
            // checkEscalaGrises
            // 
            this.checkEscalaGrises.AutoSize = true;
            this.checkEscalaGrises.Location = new System.Drawing.Point(240, 28);
            this.checkEscalaGrises.Name = "checkEscalaGrises";
            this.checkEscalaGrises.Size = new System.Drawing.Size(103, 17);
            this.checkEscalaGrises.TabIndex = 7;
            this.checkEscalaGrises.Text = "Escala de grises";
            this.checkEscalaGrises.UseVisualStyleBackColor = true;
            this.checkEscalaGrises.CheckedChanged += new System.EventHandler(this.checkEscalaGrises_CheckedChanged);
            // 
            // checkCompresion
            // 
            this.checkCompresion.AutoSize = true;
            this.checkCompresion.Checked = true;
            this.checkCompresion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCompresion.Location = new System.Drawing.Point(498, 24);
            this.checkCompresion.Name = "checkCompresion";
            this.checkCompresion.Size = new System.Drawing.Size(108, 17);
            this.checkCompresion.TabIndex = 0;
            this.checkCompresion.Text = "Comprimir imagen";
            this.checkCompresion.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.filtrosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
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
            this.abrirImagenToolStripMenuItem.Name = "abrirImagenToolStripMenuItem";
            this.abrirImagenToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.abrirImagenToolStripMenuItem.Text = "Abrir";
            this.abrirImagenToolStripMenuItem.Click += new System.EventHandler(this.abrirImagenToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.guardarComoToolStripMenuItem.Text = "Guardar como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
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
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarDeTamañoToolStripMenuItem,
            this.comprimirImagenToolStripMenuItem});
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.ediciónToolStripMenuItem.Text = "Edición";
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
            // cambiarDeTamañoToolStripMenuItem
            // 
            this.cambiarDeTamañoToolStripMenuItem.Name = "cambiarDeTamañoToolStripMenuItem";
            this.cambiarDeTamañoToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.cambiarDeTamañoToolStripMenuItem.Text = "Cambiar de tamaño";
            this.cambiarDeTamañoToolStripMenuItem.Click += new System.EventHandler(this.cambiarDeTamañoToolStripMenuItem_Click);
            // 
            // comprimirImagenToolStripMenuItem
            // 
            this.comprimirImagenToolStripMenuItem.Name = "comprimirImagenToolStripMenuItem";
            this.comprimirImagenToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.comprimirImagenToolStripMenuItem.Text = "Comprimir imagen";
            // 
            // escalaDeGrisesToolStripMenuItem
            // 
            this.escalaDeGrisesToolStripMenuItem.Name = "escalaDeGrisesToolStripMenuItem";
            this.escalaDeGrisesToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.escalaDeGrisesToolStripMenuItem.Text = "Escala de grises";
            // 
            // escalaPorColorToolStripMenuItem
            // 
            this.escalaPorColorToolStripMenuItem.Name = "escalaPorColorToolStripMenuItem";
            this.escalaPorColorToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.escalaPorColorToolStripMenuItem.Text = "Escala por color";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.Controls.Add(this.imageChef);
            this.Controls.Add(this.groupRedimension);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foto Chef {0}";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.imageChef)).EndInit();
            this.groupRedimension.ResumeLayout(false);
            this.groupRedimension.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveImageDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox imageChef;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.GroupBox groupRedimension;
        private System.Windows.Forms.CheckBox checkCompresion;
        private System.Windows.Forms.CheckBox checkEscalaGrises;
        private System.Windows.Forms.CheckBox checkPorColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panelColorSelected;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarDeTamañoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprimirImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaDeGrisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaPorColorToolStripMenuItem;
    }
}

