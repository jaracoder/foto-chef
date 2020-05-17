namespace image.processing.forms
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
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.groupRedimension = new System.Windows.Forms.GroupBox();
            this.checkCompresion = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkEscalaGrises = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.groupRedimension.SuspendLayout();
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
            // imageBox
            // 
            this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox.Location = new System.Drawing.Point(28, 51);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(170, 167);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(28, 224);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(170, 23);
            this.btnLoadImage.TabIndex = 1;
            this.btnLoadImage.Text = "Subir imagen";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(363, 224);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Guardar cambios";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(20, 45);
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
            this.lblHeight.Location = new System.Drawing.Point(100, 28);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(25, 13);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Alto";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(100, 45);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(54, 20);
            this.txtHeight.TabIndex = 5;
            // 
            // groupRedimension
            // 
            this.groupRedimension.Controls.Add(this.checkEscalaGrises);
            this.groupRedimension.Controls.Add(this.checkCompresion);
            this.groupRedimension.Controls.Add(this.txtHeight);
            this.groupRedimension.Controls.Add(this.txtWidth);
            this.groupRedimension.Controls.Add(this.lblHeight);
            this.groupRedimension.Controls.Add(this.lblWidth);
            this.groupRedimension.Location = new System.Drawing.Point(222, 31);
            this.groupRedimension.Name = "groupRedimension";
            this.groupRedimension.Size = new System.Drawing.Size(268, 149);
            this.groupRedimension.TabIndex = 8;
            this.groupRedimension.TabStop = false;
            this.groupRedimension.Text = "Dimensiones";
            // 
            // checkCompresion
            // 
            this.checkCompresion.AutoSize = true;
            this.checkCompresion.Checked = true;
            this.checkCompresion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCompresion.Location = new System.Drawing.Point(154, 90);
            this.checkCompresion.Name = "checkCompresion";
            this.checkCompresion.Size = new System.Drawing.Size(108, 17);
            this.checkCompresion.TabIndex = 0;
            this.checkCompresion.Text = "Comprimir imagen";
            this.checkCompresion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Imagen";
            // 
            // checkEscalaGrises
            // 
            this.checkEscalaGrises.AutoSize = true;
            this.checkEscalaGrises.Location = new System.Drawing.Point(23, 90);
            this.checkEscalaGrises.Name = "checkEscalaGrises";
            this.checkEscalaGrises.Size = new System.Drawing.Size(103, 17);
            this.checkEscalaGrises.TabIndex = 7;
            this.checkEscalaGrises.Text = "Escala de grises";
            this.checkEscalaGrises.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupRedimension);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.imageBox);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.groupRedimension.ResumeLayout(false);
            this.groupRedimension.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveImageDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.GroupBox groupRedimension;
        private System.Windows.Forms.CheckBox checkCompresion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkEscalaGrises;
    }
}

