namespace SmartPrint
{
    partial class FrmClientes
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtObservaciones = new System.Windows.Forms.TextBox();
            this.CkbActivo = new System.Windows.Forms.CheckBox();
            this.TxtExt = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtFax = new System.Windows.Forms.TextBox();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCc = new System.Windows.Forms.TextBox();
            this.LblObservaciones = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblFax = new System.Windows.Forms.Label();
            this.LblCelular = new System.Windows.Forms.Label();
            this.LblExt = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCc = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.TxtContacto = new System.Windows.Forms.TextBox();
            this.LblContacto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(11, 339);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Los campos con (*) son obligatorios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(470, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(453, 151);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(126, 48);
            this.BtnLimpiar.TabIndex = 13;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click_1);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(453, 49);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(126, 48);
            this.BtnGuardar.TabIndex = 11;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click_1);
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Location = new System.Drawing.Point(200, 221);
            this.TxtObservaciones.MaxLength = 254;
            this.TxtObservaciones.Multiline = true;
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(204, 88);
            this.TxtObservaciones.TabIndex = 10;
            this.TxtObservaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtObservaciones_KeyPress);
            // 
            // CkbActivo
            // 
            this.CkbActivo.AutoSize = true;
            this.CkbActivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbActivo.Location = new System.Drawing.Point(320, 13);
            this.CkbActivo.Name = "CkbActivo";
            this.CkbActivo.Size = new System.Drawing.Size(68, 20);
            this.CkbActivo.TabIndex = 46;
            this.CkbActivo.Text = "Activo";
            this.CkbActivo.UseVisualStyleBackColor = true;
            // 
            // TxtExt
            // 
            this.TxtExt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtExt.Location = new System.Drawing.Point(352, 90);
            this.TxtExt.MaxLength = 5;
            this.TxtExt.Name = "TxtExt";
            this.TxtExt.Size = new System.Drawing.Size(52, 23);
            this.TxtExt.TabIndex = 5;
            this.TxtExt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtExt_KeyPress);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(200, 192);
            this.TxtEmail.MaxLength = 50;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(204, 23);
            this.TxtEmail.TabIndex = 9;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(200, 166);
            this.TxtDireccion.MaxLength = 50;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(204, 23);
            this.TxtDireccion.TabIndex = 8;
            this.TxtDireccion.TextChanged += new System.EventHandler(this.TxtDireccion_TextChanged);
            // 
            // TxtFax
            // 
            this.TxtFax.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFax.Location = new System.Drawing.Point(200, 140);
            this.TxtFax.MaxLength = 7;
            this.TxtFax.Name = "TxtFax";
            this.TxtFax.Size = new System.Drawing.Size(100, 23);
            this.TxtFax.TabIndex = 7;
            this.TxtFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFax_KeyPress);
            // 
            // TxtCelular
            // 
            this.TxtCelular.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCelular.Location = new System.Drawing.Point(200, 114);
            this.TxtCelular.MaxLength = 10;
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(100, 23);
            this.TxtCelular.TabIndex = 6;
            this.TxtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCelular_KeyPress);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(200, 88);
            this.TxtTelefono.MaxLength = 7;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(100, 23);
            this.TxtTelefono.TabIndex = 4;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(200, 37);
            this.TxtNombre.MaxLength = 50;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(204, 23);
            this.TxtNombre.TabIndex = 2;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // TxtCc
            // 
            this.TxtCc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCc.Location = new System.Drawing.Point(200, 12);
            this.TxtCc.MaxLength = 19;
            this.TxtCc.Name = "TxtCc";
            this.TxtCc.Size = new System.Drawing.Size(114, 23);
            this.TxtCc.TabIndex = 1;
            this.TxtCc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCc_KeyPress);
            this.TxtCc.Leave += new System.EventHandler(this.TxtCc_Foco);
            // 
            // LblObservaciones
            // 
            this.LblObservaciones.AutoSize = true;
            this.LblObservaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObservaciones.Location = new System.Drawing.Point(87, 221);
            this.LblObservaciones.Name = "LblObservaciones";
            this.LblObservaciones.Size = new System.Drawing.Size(109, 16);
            this.LblObservaciones.TabIndex = 36;
            this.LblObservaciones.Text = "Observaciones:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(133, 195);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(63, 16);
            this.LblEmail.TabIndex = 35;
            this.LblEmail.Text = "* E-mail:";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(111, 169);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(84, 16);
            this.LblDireccion.TabIndex = 34;
            this.LblDireccion.Text = "* Dirección:";
            // 
            // LblFax
            // 
            this.LblFax.AutoSize = true;
            this.LblFax.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFax.Location = new System.Drawing.Point(161, 143);
            this.LblFax.Name = "LblFax";
            this.LblFax.Size = new System.Drawing.Size(34, 16);
            this.LblFax.TabIndex = 33;
            this.LblFax.Text = "Fax:";
            // 
            // LblCelular
            // 
            this.LblCelular.AutoSize = true;
            this.LblCelular.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCelular.Location = new System.Drawing.Point(130, 115);
            this.LblCelular.Name = "LblCelular";
            this.LblCelular.Size = new System.Drawing.Size(64, 16);
            this.LblCelular.TabIndex = 32;
            this.LblCelular.Text = " Celular:";
            // 
            // LblExt
            // 
            this.LblExt.AutoSize = true;
            this.LblExt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExt.Location = new System.Drawing.Point(316, 91);
            this.LblExt.Name = "LblExt";
            this.LblExt.Size = new System.Drawing.Size(30, 16);
            this.LblExt.TabIndex = 31;
            this.LblExt.Text = "Ext:";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono.Location = new System.Drawing.Point(118, 91);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(76, 16);
            this.LblTelefono.TabIndex = 30;
            this.LblTelefono.Text = "* Teléfono:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(32, 40);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(163, 16);
            this.LblNombre.TabIndex = 28;
            this.LblNombre.Text = "* Nombre/Razón Social:";
            // 
            // LblCc
            // 
            this.LblCc.AutoSize = true;
            this.LblCc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCc.Location = new System.Drawing.Point(120, 13);
            this.LblCc.Name = "LblCc";
            this.LblCc.Size = new System.Drawing.Size(75, 16);
            this.LblCc.TabIndex = 27;
            this.LblCc.Text = "* CC - NIT:";
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(453, 101);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(126, 48);
            this.BtnModificar.TabIndex = 12;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click_1);
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClientes.Image = ((System.Drawing.Image)(resources.GetObject("BtnClientes.Image")));
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(453, 205);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(126, 48);
            this.BtnClientes.TabIndex = 53;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClientes.UseVisualStyleBackColor = false;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // TxtContacto
            // 
            this.TxtContacto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContacto.Location = new System.Drawing.Point(200, 62);
            this.TxtContacto.MaxLength = 50;
            this.TxtContacto.Name = "TxtContacto";
            this.TxtContacto.Size = new System.Drawing.Size(204, 23);
            this.TxtContacto.TabIndex = 3;
            this.TxtContacto.TextChanged += new System.EventHandler(this.TxtContacto_TextChanged);
            this.TxtContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContacto_KeyPress);
            // 
            // LblContacto
            // 
            this.LblContacto.AutoSize = true;
            this.LblContacto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContacto.Location = new System.Drawing.Point(113, 65);
            this.LblContacto.Name = "LblContacto";
            this.LblContacto.Size = new System.Drawing.Size(81, 16);
            this.LblContacto.TabIndex = 55;
            this.LblContacto.Text = "* Contacto:";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(620, 364);
            this.Controls.Add(this.TxtContacto);
            this.Controls.Add(this.LblContacto);
            this.Controls.Add(this.BtnClientes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtObservaciones);
            this.Controls.Add(this.CkbActivo);
            this.Controls.Add(this.TxtExt);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtFax);
            this.Controls.Add(this.TxtCelular);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCc);
            this.Controls.Add(this.LblObservaciones);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.LblFax);
            this.Controls.Add(this.LblCelular);
            this.Controls.Add(this.LblExt);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblCc);
            this.Controls.Add(this.BtnModificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtObservaciones;
        private System.Windows.Forms.CheckBox CkbActivo;
        private System.Windows.Forms.TextBox TxtExt;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtFax;
        private System.Windows.Forms.TextBox TxtCelular;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCc;
        private System.Windows.Forms.Label LblObservaciones;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblFax;
        private System.Windows.Forms.Label LblCelular;
        private System.Windows.Forms.Label LblExt;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCc;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.TextBox TxtContacto;
        private System.Windows.Forms.Label LblContacto;
    }
}

