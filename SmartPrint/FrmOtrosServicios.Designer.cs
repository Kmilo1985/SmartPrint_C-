namespace SmartPrint
{
    partial class FrmOtrosServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOtrosServicios));
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.GridViewOtrosServ = new System.Windows.Forms.DataGridView();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtSerial = new System.Windows.Forms.TextBox();
            this.TxtValorUni = new System.Windows.Forms.TextBox();
            this.TxtObservaciones = new System.Windows.Forms.TextBox();
            this.LblValorUni = new System.Windows.Forms.Label();
            this.LblObservaciones = new System.Windows.Forms.Label();
            this.LblSerial = new System.Windows.Forms.Label();
            this.LblProveedor = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.BtnAgregar = new System.Windows.Forms.PictureBox();
            this.BtnCancelarSer = new System.Windows.Forms.Button();
            this.CbxProveedor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOtrosServ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(12, 516);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Los campos con (*) son obligatorios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(697, 485);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 54;
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
            this.BtnLimpiar.Location = new System.Drawing.Point(647, 149);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(126, 48);
            this.BtnLimpiar.TabIndex = 10;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(647, 95);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(126, 48);
            this.BtnModificar.TabIndex = 9;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(647, 41);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(126, 48);
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // GridViewOtrosServ
            // 
            this.GridViewOtrosServ.AllowUserToAddRows = false;
            this.GridViewOtrosServ.AllowUserToDeleteRows = false;
            this.GridViewOtrosServ.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.GridViewOtrosServ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridViewOtrosServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewOtrosServ.Location = new System.Drawing.Point(37, 257);
            this.GridViewOtrosServ.Name = "GridViewOtrosServ";
            this.GridViewOtrosServ.ReadOnly = true;
            this.GridViewOtrosServ.Size = new System.Drawing.Size(736, 221);
            this.GridViewOtrosServ.TabIndex = 50;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(165, 32);
            this.TxtNombre.MaxLength = 50;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(402, 23);
            this.TxtNombre.TabIndex = 3;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(403, 61);
            this.TxtCodigo.MaxLength = 11;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(164, 23);
            this.TxtCodigo.TabIndex = 1;
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
            // 
            // TxtSerial
            // 
            this.TxtSerial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSerial.Location = new System.Drawing.Point(165, 64);
            this.TxtSerial.MaxLength = 50;
            this.TxtSerial.Name = "TxtSerial";
            this.TxtSerial.Size = new System.Drawing.Size(164, 23);
            this.TxtSerial.TabIndex = 4;
            // 
            // TxtValorUni
            // 
            this.TxtValorUni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorUni.Location = new System.Drawing.Point(165, 95);
            this.TxtValorUni.MaxLength = 15;
            this.TxtValorUni.Name = "TxtValorUni";
            this.TxtValorUni.Size = new System.Drawing.Size(164, 23);
            this.TxtValorUni.TabIndex = 5;
            this.TxtValorUni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorUni_KeyPress);
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservaciones.Location = new System.Drawing.Point(165, 155);
            this.TxtObservaciones.MaxLength = 50;
            this.TxtObservaciones.Multiline = true;
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(402, 83);
            this.TxtObservaciones.TabIndex = 7;
            this.TxtObservaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtObservaciones_KeyPress);
            // 
            // LblValorUni
            // 
            this.LblValorUni.AutoSize = true;
            this.LblValorUni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorUni.Location = new System.Drawing.Point(54, 96);
            this.LblValorUni.Name = "LblValorUni";
            this.LblValorUni.Size = new System.Drawing.Size(111, 16);
            this.LblValorUni.TabIndex = 42;
            this.LblValorUni.Text = "* Valor Unitario:";
            // 
            // LblObservaciones
            // 
            this.LblObservaciones.AutoSize = true;
            this.LblObservaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObservaciones.Location = new System.Drawing.Point(54, 158);
            this.LblObservaciones.Name = "LblObservaciones";
            this.LblObservaciones.Size = new System.Drawing.Size(105, 16);
            this.LblObservaciones.TabIndex = 41;
            this.LblObservaciones.Text = "Observaciones";
            // 
            // LblSerial
            // 
            this.LblSerial.AutoSize = true;
            this.LblSerial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSerial.Location = new System.Drawing.Point(100, 67);
            this.LblSerial.Name = "LblSerial";
            this.LblSerial.Size = new System.Drawing.Size(59, 16);
            this.LblSerial.TabIndex = 40;
            this.LblSerial.Text = "* Serial:";
            // 
            // LblProveedor
            // 
            this.LblProveedor.AutoSize = true;
            this.LblProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProveedor.Location = new System.Drawing.Point(72, 127);
            this.LblProveedor.Name = "LblProveedor";
            this.LblProveedor.Size = new System.Drawing.Size(87, 16);
            this.LblProveedor.TabIndex = 38;
            this.LblProveedor.Text = "* Proveedor:";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(327, 64);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(70, 16);
            this.LblCodigo.TabIndex = 37;
            this.LblCodigo.Text = "* Código:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(85, 35);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(74, 16);
            this.LblNombre.TabIndex = 36;
            this.LblNombre.Text = "* Nombre:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(573, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 23);
            this.btnBuscar.TabIndex = 57;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.Location = new System.Drawing.Point(789, 316);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(26, 26);
            this.BtnAgregar.TabIndex = 59;
            this.BtnAgregar.TabStop = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnCancelarSer
            // 
            this.BtnCancelarSer.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCancelarSer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarSer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelarSer.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelarSer.Image")));
            this.BtnCancelarSer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarSer.Location = new System.Drawing.Point(647, 203);
            this.BtnCancelarSer.Name = "BtnCancelarSer";
            this.BtnCancelarSer.Size = new System.Drawing.Size(126, 48);
            this.BtnCancelarSer.TabIndex = 60;
            this.BtnCancelarSer.Text = "Cancelar";
            this.BtnCancelarSer.UseVisualStyleBackColor = false;
            this.BtnCancelarSer.Visible = false;
            this.BtnCancelarSer.Click += new System.EventHandler(this.BtnCancelarSer_Click);
            // 
            // CbxProveedor
            // 
            this.CbxProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxProveedor.FormattingEnabled = true;
            this.CbxProveedor.Items.AddRange(new object[] {
            "Monterrey"});
            this.CbxProveedor.Location = new System.Drawing.Point(165, 124);
            this.CbxProveedor.Name = "CbxProveedor";
            this.CbxProveedor.Size = new System.Drawing.Size(402, 25);
            this.CbxProveedor.TabIndex = 61;
            this.CbxProveedor.Click += new System.EventHandler(this.CbxProveedor_Click);
            this.CbxProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxProveedor_KeyPress);
            // 
            // FrmOtrosServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(841, 542);
            this.Controls.Add(this.CbxProveedor);
            this.Controls.Add(this.BtnCancelarSer);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.GridViewOtrosServ);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.TxtSerial);
            this.Controls.Add(this.TxtValorUni);
            this.Controls.Add(this.TxtObservaciones);
            this.Controls.Add(this.LblValorUni);
            this.Controls.Add(this.LblObservaciones);
            this.Controls.Add(this.LblSerial);
            this.Controls.Add(this.LblProveedor);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.LblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOtrosServicios";
            this.Text = "Otros Servicios";
            this.Load += new System.EventHandler(this.FrmOtrosServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOtrosServ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnLimpiar;
        public System.Windows.Forms.Button BtnModificar;
        public System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView GridViewOtrosServ;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtSerial;
        private System.Windows.Forms.TextBox TxtValorUni;
        private System.Windows.Forms.TextBox TxtObservaciones;
        private System.Windows.Forms.Label LblValorUni;
        private System.Windows.Forms.Label LblObservaciones;
        private System.Windows.Forms.Label LblSerial;
        private System.Windows.Forms.Label LblProveedor;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.PictureBox btnBuscar;
        public System.Windows.Forms.PictureBox BtnAgregar;
        public System.Windows.Forms.Button BtnCancelarSer;
        private System.Windows.Forms.ComboBox CbxProveedor;
    }
}