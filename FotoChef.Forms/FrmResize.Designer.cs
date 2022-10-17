namespace FotoChef.Forms
{
    partial class FrmResize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResize));
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.groupRedimension = new System.Windows.Forms.GroupBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.chkAspectRatio = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdbByPercentage = new System.Windows.Forms.RadioButton();
            this.rdbByPixels = new System.Windows.Forms.RadioButton();
            this.lblBy = new System.Windows.Forms.Label();
            this.groupRedimension.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(84, 60);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(60, 20);
            this.txtWidth.TabIndex = 3;
            this.txtWidth.TextChanged += new System.EventHandler(this.Size_TextChanged);
            this.txtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Size_KeyPress);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(16, 63);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(41, 13);
            this.lblWidth.TabIndex = 4;
            this.lblWidth.Text = "Ancho:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(20, 98);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(37, 13);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Altura:";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(84, 95);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(60, 20);
            this.txtHeight.TabIndex = 5;
            this.txtHeight.TextChanged += new System.EventHandler(this.Size_TextChanged);
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Size_KeyPress);
            // 
            // groupRedimension
            // 
            this.groupRedimension.BackColor = System.Drawing.Color.White;
            this.groupRedimension.Controls.Add(this.lblBy);
            this.groupRedimension.Controls.Add(this.rdbByPixels);
            this.groupRedimension.Controls.Add(this.rdbByPercentage);
            this.groupRedimension.Controls.Add(this.chkAspectRatio);
            this.groupRedimension.Controls.Add(this.txtHeight);
            this.groupRedimension.Controls.Add(this.txtWidth);
            this.groupRedimension.Controls.Add(this.lblHeight);
            this.groupRedimension.Controls.Add(this.lblWidth);
            this.groupRedimension.Location = new System.Drawing.Point(12, 16);
            this.groupRedimension.Name = "groupRedimension";
            this.groupRedimension.Size = new System.Drawing.Size(273, 167);
            this.groupRedimension.TabIndex = 8;
            this.groupRedimension.TabStop = false;
            this.groupRedimension.Text = "Redimensionar";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(105, 202);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(87, 27);
            this.btnAccept.TabIndex = 13;
            this.btnAccept.Text = "&Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // chkAspectRatio
            // 
            this.chkAspectRatio.AutoSize = true;
            this.chkAspectRatio.Checked = true;
            this.chkAspectRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAspectRatio.Location = new System.Drawing.Point(84, 131);
            this.chkAspectRatio.Name = "chkAspectRatio";
            this.chkAspectRatio.Size = new System.Drawing.Size(167, 17);
            this.chkAspectRatio.TabIndex = 7;
            this.chkAspectRatio.Text = "Mantener relación de aspecto";
            this.chkAspectRatio.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(198, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 27);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // rdbByPercentage
            // 
            this.rdbByPercentage.AutoSize = true;
            this.rdbByPercentage.Location = new System.Drawing.Point(148, 28);
            this.rdbByPercentage.Name = "rdbByPercentage";
            this.rdbByPercentage.Size = new System.Drawing.Size(76, 17);
            this.rdbByPercentage.TabIndex = 8;
            this.rdbByPercentage.Text = "Porcentaje";
            this.rdbByPercentage.UseVisualStyleBackColor = true;
            // 
            // rdbByPixels
            // 
            this.rdbByPixels.AutoSize = true;
            this.rdbByPixels.Checked = true;
            this.rdbByPixels.Location = new System.Drawing.Point(84, 28);
            this.rdbByPixels.Name = "rdbByPixels";
            this.rdbByPixels.Size = new System.Drawing.Size(60, 17);
            this.rdbByPixels.TabIndex = 8;
            this.rdbByPixels.TabStop = true;
            this.rdbByPixels.Text = "Píxeles";
            this.rdbByPixels.UseVisualStyleBackColor = true;
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Location = new System.Drawing.Point(31, 30);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(26, 13);
            this.lblBy.TabIndex = 9;
            this.lblBy.Text = "Por:";
            // 
            // FrmResize
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(297, 241);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.groupRedimension);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmResize";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar de tamaño";
            this.groupRedimension.ResumeLayout(false);
            this.groupRedimension.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.GroupBox groupRedimension;
        private System.Windows.Forms.CheckBox chkAspectRatio;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblBy;
        private System.Windows.Forms.RadioButton rdbByPixels;
        private System.Windows.Forms.RadioButton rdbByPercentage;
    }
}

