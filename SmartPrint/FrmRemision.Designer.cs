namespace SmartPrint
{
    partial class FrmRemision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRemision));
            this.GbxCliente = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblCc = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.TxtCc = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.GridViewRemision = new System.Windows.Forms.DataGridView();
            this.DateVencimiento = new System.Windows.Forms.DateTimePicker();
            this.TxtObservaciones = new System.Windows.Forms.TextBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.LblObvservaciones = new System.Windows.Forms.Label();
            this.Lblnumero = new System.Windows.Forms.Label();
            this.LblVencimiento = new System.Windows.Forms.Label();
            this.CbxSeleccionServicio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.LblIva = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.btnBuscarREmision = new System.Windows.Forms.PictureBox();
            this.GbxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRemision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarREmision)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxCliente
            // 
            this.GbxCliente.Controls.Add(this.pictureBox2);
            this.GbxCliente.Controls.Add(this.TxtNombre);
            this.GbxCliente.Controls.Add(this.LblCc);
            this.GbxCliente.Controls.Add(this.LblNombre);
            this.GbxCliente.Controls.Add(this.LblDireccion);
            this.GbxCliente.Controls.Add(this.LblTelefono);
            this.GbxCliente.Controls.Add(this.TxtCc);
            this.GbxCliente.Controls.Add(this.TxtDireccion);
            this.GbxCliente.Controls.Add(this.TxtTelefono);
            this.GbxCliente.Location = new System.Drawing.Point(30, 51);
            this.GbxCliente.Name = "GbxCliente";
            this.GbxCliente.Size = new System.Drawing.Size(603, 97);
            this.GbxCliente.TabIndex = 1;
            this.GbxCliente.TabStop = false;
            this.GbxCliente.Text = "Cliente";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(308, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 23);
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(185, 42);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(402, 23);
            this.TxtNombre.TabIndex = 3;
            // 
            // LblCc
            // 
            this.LblCc.AutoSize = true;
            this.LblCc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCc.Location = new System.Drawing.Point(107, 17);
            this.LblCc.Name = "LblCc";
            this.LblCc.Size = new System.Drawing.Size(72, 16);
            this.LblCc.TabIndex = 0;
            this.LblCc.Text = "* C.C/NIT:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(16, 43);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(163, 16);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "* Nombre/Razón Social:";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(95, 71);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(84, 16);
            this.LblDireccion.TabIndex = 2;
            this.LblDireccion.Text = "* Dirección:";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono.Location = new System.Drawing.Point(388, 69);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(76, 16);
            this.LblTelefono.TabIndex = 3;
            this.LblTelefono.Text = "* Teléfono:";
            // 
            // TxtCc
            // 
            this.TxtCc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCc.Location = new System.Drawing.Point(185, 16);
            this.TxtCc.MaxLength = 11;
            this.TxtCc.Name = "TxtCc";
            this.TxtCc.Size = new System.Drawing.Size(117, 23);
            this.TxtCc.TabIndex = 2;
            this.TxtCc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCc_KeyPress);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(185, 68);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(198, 23);
            this.TxtDireccion.TabIndex = 4;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(470, 70);
            this.TxtTelefono.MaxLength = 10;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(117, 23);
            this.TxtTelefono.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(27, 525);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Los campos con (*) son obligatorios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(680, 527);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 45;
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
            this.BtnLimpiar.Location = new System.Drawing.Point(663, 238);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(126, 48);
            this.BtnLimpiar.TabIndex = 10;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click_1);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(663, 171);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(126, 48);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnAceptar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAceptar.Image")));
            this.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAceptar.Location = new System.Drawing.Point(663, 106);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(126, 48);
            this.BtnAceptar.TabIndex = 8;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(472, 547);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(51, 16);
            this.LblTotal.TabIndex = 41;
            this.LblTotal.Text = "TOTAL:";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(529, 544);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(88, 23);
            this.TxtTotal.TabIndex = 14;
            // 
            // GridViewRemision
            // 
            this.GridViewRemision.AllowUserToAddRows = false;
            this.GridViewRemision.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.GridViewRemision.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridViewRemision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewRemision.Location = new System.Drawing.Point(74, 303);
            this.GridViewRemision.Name = "GridViewRemision";
            this.GridViewRemision.Size = new System.Drawing.Size(543, 177);
            this.GridViewRemision.TabIndex = 12;
            this.GridViewRemision.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewRemision_CellEnter);
            this.GridViewRemision.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridViewRemision_KeyDown);
            this.GridViewRemision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GridViewRemision_KeyPress);
            // 
            // DateVencimiento
            // 
            this.DateVencimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateVencimiento.Location = new System.Drawing.Point(215, 157);
            this.DateVencimiento.Name = "DateVencimiento";
            this.DateVencimiento.Size = new System.Drawing.Size(117, 23);
            this.DateVencimiento.TabIndex = 6;
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservaciones.Location = new System.Drawing.Point(215, 191);
            this.TxtObservaciones.MaxLength = 254;
            this.TxtObservaciones.Multiline = true;
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(402, 90);
            this.TxtObservaciones.TabIndex = 7;
            // 
            // TxtNumero
            // 
            this.TxtNumero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.Location = new System.Drawing.Point(500, 29);
            this.TxtNumero.MaxLength = 20;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(117, 23);
            this.TxtNumero.TabIndex = 35;
            this.TxtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            this.TxtNumero.Leave += new System.EventHandler(this.TxtNumero_Leave);
            // 
            // LblObvservaciones
            // 
            this.LblObvservaciones.AutoSize = true;
            this.LblObvservaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObvservaciones.Location = new System.Drawing.Point(100, 192);
            this.LblObvservaciones.Name = "LblObvservaciones";
            this.LblObvservaciones.Size = new System.Drawing.Size(109, 16);
            this.LblObvservaciones.TabIndex = 34;
            this.LblObvservaciones.Text = "Observaciones:";
            // 
            // Lblnumero
            // 
            this.Lblnumero.AutoSize = true;
            this.Lblnumero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblnumero.Location = new System.Drawing.Point(405, 29);
            this.Lblnumero.Name = "Lblnumero";
            this.Lblnumero.Size = new System.Drawing.Size(89, 16);
            this.Lblnumero.TabIndex = 33;
            this.Lblnumero.Text = "Remisión Nº:";
            // 
            // LblVencimiento
            // 
            this.LblVencimiento.AutoSize = true;
            this.LblVencimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVencimiento.Location = new System.Drawing.Point(63, 161);
            this.LblVencimiento.Name = "LblVencimiento";
            this.LblVencimiento.Size = new System.Drawing.Size(146, 16);
            this.LblVencimiento.TabIndex = 32;
            this.LblVencimiento.Text = "* Fecha Vencimiento:";
            // 
            // CbxSeleccionServicio
            // 
            this.CbxSeleccionServicio.Enabled = false;
            this.CbxSeleccionServicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxSeleccionServicio.FormattingEnabled = true;
            this.CbxSeleccionServicio.Items.AddRange(new object[] {
            "Servicio",
            "OtrosServicios"});
            this.CbxSeleccionServicio.Location = new System.Drawing.Point(668, 303);
            this.CbxSeleccionServicio.Name = "CbxSeleccionServicio";
            this.CbxSeleccionServicio.Size = new System.Drawing.Size(121, 25);
            this.CbxSeleccionServicio.TabIndex = 11;
            this.CbxSeleccionServicio.Text = "Tipo Servicio...";
            this.CbxSeleccionServicio.SelectedIndexChanged += new System.EventHandler(this.CbxSeleccionServicio_SelectedIndexChanged);
            this.CbxSeleccionServicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxSeleccionServicio_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "SUBTOTAL:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(529, 490);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(88, 23);
            this.txtSubtotal.TabIndex = 47;
            // 
            // LblIva
            // 
            this.LblIva.AutoSize = true;
            this.LblIva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIva.Location = new System.Drawing.Point(488, 518);
            this.LblIva.Name = "LblIva";
            this.LblIva.Size = new System.Drawing.Size(35, 16);
            this.LblIva.TabIndex = 50;
            this.LblIva.Text = "IVA:";
            // 
            // txtIva
            // 
            this.txtIva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(529, 515);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(88, 23);
            this.txtIva.TabIndex = 49;
            // 
            // btnBuscarREmision
            // 
            this.btnBuscarREmision.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarREmision.Image")));
            this.btnBuscarREmision.Location = new System.Drawing.Point(623, 29);
            this.btnBuscarREmision.Name = "btnBuscarREmision";
            this.btnBuscarREmision.Size = new System.Drawing.Size(24, 23);
            this.btnBuscarREmision.TabIndex = 59;
            this.btnBuscarREmision.TabStop = false;
            this.btnBuscarREmision.Click += new System.EventHandler(this.btnBuscarREmision_Click);
            // 
            // FrmRemision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(824, 582);
            this.Controls.Add(this.btnBuscarREmision);
            this.Controls.Add(this.LblIva);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.CbxSeleccionServicio);
            this.Controls.Add(this.GbxCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.GridViewRemision);
            this.Controls.Add(this.DateVencimiento);
            this.Controls.Add(this.TxtObservaciones);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.LblObvservaciones);
            this.Controls.Add(this.Lblnumero);
            this.Controls.Add(this.LblVencimiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRemision";
            this.Text = "Remision";
            this.GbxCliente.ResumeLayout(false);
            this.GbxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRemision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarREmision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxCliente;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblCc;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.TextBox TxtCc;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.DataGridView GridViewRemision;
        private System.Windows.Forms.DateTimePicker DateVencimiento;
        private System.Windows.Forms.TextBox TxtObservaciones;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label LblObvservaciones;
        private System.Windows.Forms.Label Lblnumero;
        private System.Windows.Forms.Label LblVencimiento;
        private System.Windows.Forms.ComboBox CbxSeleccionServicio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label LblIva;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.PictureBox btnBuscarREmision;
    }
}