namespace SmartPrint
{
    partial class FrmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.PicCancelar = new System.Windows.Forms.PictureBox();
            this.PicAceptar = new System.Windows.Forms.PictureBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.LblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAceptar)).BeginInit();
            this.SuspendLayout();
            // 
            // PicCancelar
            // 
            this.PicCancelar.Image = ((System.Drawing.Image)(resources.GetObject("PicCancelar.Image")));
            this.PicCancelar.Location = new System.Drawing.Point(575, 444);
            this.PicCancelar.Name = "PicCancelar";
            this.PicCancelar.Size = new System.Drawing.Size(31, 33);
            this.PicCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicCancelar.TabIndex = 9;
            this.PicCancelar.TabStop = false;
            this.PicCancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // PicAceptar
            // 
            this.PicAceptar.Image = ((System.Drawing.Image)(resources.GetObject("PicAceptar.Image")));
            this.PicAceptar.Location = new System.Drawing.Point(499, 444);
            this.PicAceptar.Name = "PicAceptar";
            this.PicAceptar.Size = new System.Drawing.Size(31, 33);
            this.PicAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicAceptar.TabIndex = 8;
            this.PicAceptar.TabStop = false;
            this.PicAceptar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(449, 315);
            this.TxtUsuario.MaxLength = 10;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(210, 16);
            this.TxtUsuario.TabIndex = 1;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.Location = new System.Drawing.Point(449, 386);
            this.TxtContraseña.MaxLength = 15;
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '*';
            this.TxtContraseña.Size = new System.Drawing.Size(210, 16);
            this.TxtContraseña.TabIndex = 2;
            this.TxtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContraseña_KeyPress);
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(683, 537);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(0, 13);
            this.LblFecha.TabIndex = 10;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(796, 559);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.PicCancelar);
            this.Controls.Add(this.PicAceptar);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.TxtContraseña);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAceptar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicCancelar;
        private System.Windows.Forms.PictureBox PicAceptar;
        public System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Label LblFecha;
    }
}