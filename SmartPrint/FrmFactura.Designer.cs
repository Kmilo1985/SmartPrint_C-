namespace SmartPrint
{
    partial class FrmFactura
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFactura));
            this.GbxOrden = new System.Windows.Forms.GroupBox();
            this.TxtOrden = new System.Windows.Forms.TextBox();
            this.LblOrden = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCc = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtCc = new System.Windows.Forms.TextBox();
            this.CbxEstado = new System.Windows.Forms.ComboBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.TxtObservaciones = new System.Windows.Forms.TextBox();
            this.DateVencimiento = new System.Windows.Forms.DateTimePicker();
            this.GridViewFactura = new System.Windows.Forms.DataGridView();
            this.TxtFactura = new System.Windows.Forms.TextBox();
            this.LblObservaciones = new System.Windows.Forms.Label();
            this.LblFechavencimiento = new System.Windows.Forms.Label();
            this.LblFactura = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TxtImpuesto = new System.Windows.Forms.TextBox();
            this.TxtIva = new System.Windows.Forms.TextBox();
            this.TxtDescuento = new System.Windows.Forms.TextBox();
            this.LblIva = new System.Windows.Forms.Label();
            this.LblDescuento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.cbmPago = new System.Windows.Forms.ComboBox();
            this.lblpago = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CkbActivo = new System.Windows.Forms.CheckBox();
            this.BtnBuscar = new System.Windows.Forms.PictureBox();
            this.GbxOrden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxOrden
            // 
            this.GbxOrden.Controls.Add(this.TxtOrden);
            this.GbxOrden.Controls.Add(this.LblOrden);
            this.GbxOrden.Controls.Add(this.LblEstado);
            this.GbxOrden.Controls.Add(this.LblNombre);
            this.GbxOrden.Controls.Add(this.LblCc);
            this.GbxOrden.Controls.Add(this.LblDireccion);
            this.GbxOrden.Controls.Add(this.LblTelefono);
            this.GbxOrden.Controls.Add(this.TxtNombre);
            this.GbxOrden.Controls.Add(this.TxtTelefono);
            this.GbxOrden.Controls.Add(this.TxtCc);
            this.GbxOrden.Controls.Add(this.CbxEstado);
            this.GbxOrden.Controls.Add(this.TxtDireccion);
            this.GbxOrden.Location = new System.Drawing.Point(31, 51);
            this.GbxOrden.Name = "GbxOrden";
            this.GbxOrden.Size = new System.Drawing.Size(682, 100);
            this.GbxOrden.TabIndex = 49;
            this.GbxOrden.TabStop = false;
            this.GbxOrden.Text = "Orden de Servicio";
            // 
            // TxtOrden
            // 
            this.TxtOrden.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOrden.Location = new System.Drawing.Point(183, 19);
            this.TxtOrden.MaxLength = 20;
            this.TxtOrden.Name = "TxtOrden";
            this.TxtOrden.Size = new System.Drawing.Size(99, 23);
            this.TxtOrden.TabIndex = 1;
            this.TxtOrden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOrden_KeyPress);
            // 
            // LblOrden
            // 
            this.LblOrden.AutoSize = true;
            this.LblOrden.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrden.Location = new System.Drawing.Point(44, 20);
            this.LblOrden.Name = "LblOrden";
            this.LblOrden.Size = new System.Drawing.Size(133, 16);
            this.LblOrden.TabIndex = 99;
            this.LblOrden.Text = "*Orden Servicio Nº:";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(288, 21);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(65, 16);
            this.LblEstado.TabIndex = 2;
            this.LblEstado.Text = "* Estado:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(14, 46);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(163, 16);
            this.LblNombre.TabIndex = 99;
            this.LblNombre.Text = "* Nombre/Razón Social:";
            // 
            // LblCc
            // 
            this.LblCc.AutoSize = true;
            this.LblCc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCc.Location = new System.Drawing.Point(478, 49);
            this.LblCc.Name = "LblCc";
            this.LblCc.Size = new System.Drawing.Size(72, 16);
            this.LblCc.TabIndex = 99;
            this.LblCc.Text = "* C.C/NIT:";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(93, 72);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(84, 16);
            this.LblDireccion.TabIndex = 99;
            this.LblDireccion.Text = "* Dirección:";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono.Location = new System.Drawing.Point(474, 74);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(76, 16);
            this.LblTelefono.TabIndex = 99;
            this.LblTelefono.Text = "* Teléfono:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(183, 45);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(285, 23);
            this.TxtNombre.TabIndex = 3;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(556, 71);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(116, 23);
            this.TxtTelefono.TabIndex = 6;
            // 
            // TxtCc
            // 
            this.TxtCc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCc.Location = new System.Drawing.Point(556, 46);
            this.TxtCc.Name = "TxtCc";
            this.TxtCc.Size = new System.Drawing.Size(116, 23);
            this.TxtCc.TabIndex = 5;
            // 
            // CbxEstado
            // 
            this.CbxEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxEstado.FormattingEnabled = true;
            this.CbxEstado.Items.AddRange(new object[] {
            "Finalizado (F)",
            "Pendiente (P)",
            "No Conforme (N)"});
            this.CbxEstado.Location = new System.Drawing.Point(359, 19);
            this.CbxEstado.Name = "CbxEstado";
            this.CbxEstado.Size = new System.Drawing.Size(105, 25);
            this.CbxEstado.TabIndex = 2;
            this.CbxEstado.Text = "Seleccione...";
            this.CbxEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxEstado_KeyPress);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(183, 71);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(285, 23);
            this.TxtDireccion.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(9, 678);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(402, 26);
            this.label11.TabIndex = 48;
            this.label11.Text = "Los campos con (*) son obligatorios\r\nPara imprimir la factura, la orden de servic" +
    "io tiene que estar en estado (F) Finalizado.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(732, 679);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 47;
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
            this.BtnLimpiar.Location = new System.Drawing.Point(743, 192);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(126, 48);
            this.BtnLimpiar.TabIndex = 46;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(743, 127);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(126, 48);
            this.BtnCancelar.TabIndex = 45;
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
            this.BtnAceptar.Location = new System.Drawing.Point(743, 65);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(126, 48);
            this.BtnAceptar.TabIndex = 44;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(686, 556);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(88, 23);
            this.TxtTotal.TabIndex = 13;
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservaciones.Location = new System.Drawing.Point(214, 199);
            this.TxtObservaciones.MaxLength = 254;
            this.TxtObservaciones.Multiline = true;
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(499, 95);
            this.TxtObservaciones.TabIndex = 8;
            // 
            // DateVencimiento
            // 
            this.DateVencimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateVencimiento.Location = new System.Drawing.Point(597, 170);
            this.DateVencimiento.Name = "DateVencimiento";
            this.DateVencimiento.Size = new System.Drawing.Size(116, 23);
            this.DateVencimiento.TabIndex = 7;
            // 
            // GridViewFactura
            // 
            this.GridViewFactura.AllowUserToAddRows = false;
            this.GridViewFactura.AllowUserToDeleteRows = false;
            this.GridViewFactura.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.GridViewFactura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridViewFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewFactura.Location = new System.Drawing.Point(175, 313);
            this.GridViewFactura.Name = "GridViewFactura";
            this.GridViewFactura.ReadOnly = true;
            this.GridViewFactura.Size = new System.Drawing.Size(538, 150);
            this.GridViewFactura.TabIndex = 39;
            // 
            // TxtFactura
            // 
            this.TxtFactura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFactura.Location = new System.Drawing.Point(597, 26);
            this.TxtFactura.MaxLength = 10;
            this.TxtFactura.Name = "TxtFactura";
            this.TxtFactura.Size = new System.Drawing.Size(116, 23);
            this.TxtFactura.TabIndex = 38;
            this.toolTip1.SetToolTip(this.TxtFactura, "Presione la tecla enter para buscar");
            this.TxtFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFactura_KeyPress);
            // 
            // LblObservaciones
            // 
            this.LblObservaciones.AutoSize = true;
            this.LblObservaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObservaciones.Location = new System.Drawing.Point(99, 184);
            this.LblObservaciones.Name = "LblObservaciones";
            this.LblObservaciones.Size = new System.Drawing.Size(109, 16);
            this.LblObservaciones.TabIndex = 37;
            this.LblObservaciones.Text = "Observaciones:";
            // 
            // LblFechavencimiento
            // 
            this.LblFechavencimiento.AutoSize = true;
            this.LblFechavencimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechavencimiento.Location = new System.Drawing.Point(445, 174);
            this.LblFechavencimiento.Name = "LblFechavencimiento";
            this.LblFechavencimiento.Size = new System.Drawing.Size(146, 16);
            this.LblFechavencimiento.TabIndex = 36;
            this.LblFechavencimiento.Text = "* Fecha Vencimiento:";
            // 
            // LblFactura
            // 
            this.LblFactura.AutoSize = true;
            this.LblFactura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFactura.Location = new System.Drawing.Point(511, 26);
            this.LblFactura.Name = "LblFactura";
            this.LblFactura.Size = new System.Drawing.Size(80, 16);
            this.LblFactura.TabIndex = 34;
            this.LblFactura.Text = "Factura Nº:";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(623, 559);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(51, 16);
            this.LblTotal.TabIndex = 33;
            this.LblTotal.Text = "TOTAL:";
            // 
            // TxtImpuesto
            // 
            this.TxtImpuesto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImpuesto.Location = new System.Drawing.Point(-5, 652);
            this.TxtImpuesto.MaxLength = 10;
            this.TxtImpuesto.Name = "TxtImpuesto";
            this.TxtImpuesto.Size = new System.Drawing.Size(19, 23);
            this.TxtImpuesto.TabIndex = 11;
            // 
            // TxtIva
            // 
            this.TxtIva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIva.Location = new System.Drawing.Point(686, 498);
            this.TxtIva.Name = "TxtIva";
            this.TxtIva.Size = new System.Drawing.Size(88, 23);
            this.TxtIva.TabIndex = 10;
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescuento.Location = new System.Drawing.Point(686, 527);
            this.TxtDescuento.MaxLength = 10;
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(88, 23);
            this.TxtDescuento.TabIndex = 12;
            this.TxtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescuento_KeyPress);
            this.TxtDescuento.Leave += new System.EventHandler(this.TxtDescuento_Leave);
            // 
            // LblIva
            // 
            this.LblIva.AutoSize = true;
            this.LblIva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIva.Location = new System.Drawing.Point(648, 501);
            this.LblIva.Name = "LblIva";
            this.LblIva.Size = new System.Drawing.Size(32, 16);
            this.LblIva.TabIndex = 18;
            this.LblIva.Text = "Iva:";
            // 
            // LblDescuento
            // 
            this.LblDescuento.AutoSize = true;
            this.LblDescuento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescuento.Location = new System.Drawing.Point(601, 530);
            this.LblDescuento.Name = "LblDescuento";
            this.LblDescuento.Size = new System.Drawing.Size(79, 16);
            this.LblDescuento.TabIndex = 52;
            this.LblDescuento.Text = "Descuento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(606, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "SUBTOTAL:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(686, 472);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(88, 23);
            this.txtSubtotal.TabIndex = 9;
            // 
            // cbmPago
            // 
            this.cbmPago.FormattingEnabled = true;
            this.cbmPago.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbmPago.Location = new System.Drawing.Point(686, 584);
            this.cbmPago.Name = "cbmPago";
            this.cbmPago.Size = new System.Drawing.Size(88, 21);
            this.cbmPago.TabIndex = 14;
            this.cbmPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbmPago_KeyPress);
            // 
            // lblpago
            // 
            this.lblpago.AutoSize = true;
            this.lblpago.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpago.Location = new System.Drawing.Point(632, 587);
            this.lblpago.Name = "lblpago";
            this.lblpago.Size = new System.Drawing.Size(45, 16);
            this.lblpago.TabIndex = 58;
            this.lblpago.Text = "Pago:";
            // 
            // CkbActivo
            // 
            this.CkbActivo.AutoSize = true;
            this.CkbActivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbActivo.Location = new System.Drawing.Point(719, 26);
            this.CkbActivo.Name = "CkbActivo";
            this.CkbActivo.Size = new System.Drawing.Size(68, 20);
            this.CkbActivo.TabIndex = 63;
            this.CkbActivo.Text = "Activo";
            this.CkbActivo.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.Location = new System.Drawing.Point(719, 26);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(24, 23);
            this.BtnBuscar.TabIndex = 64;
            this.BtnBuscar.TabStop = false;
            this.BtnBuscar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(879, 731);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.CkbActivo);
            this.Controls.Add(this.lblpago);
            this.Controls.Add(this.cbmPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.LblDescuento);
            this.Controls.Add(this.LblIva);
            this.Controls.Add(this.TxtDescuento);
            this.Controls.Add(this.TxtImpuesto);
            this.Controls.Add(this.TxtIva);
            this.Controls.Add(this.GbxOrden);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtObservaciones);
            this.Controls.Add(this.DateVencimiento);
            this.Controls.Add(this.GridViewFactura);
            this.Controls.Add(this.TxtFactura);
            this.Controls.Add(this.LblObservaciones);
            this.Controls.Add(this.LblFechavencimiento);
            this.Controls.Add(this.LblFactura);
            this.Controls.Add(this.LblTotal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            this.GbxOrden.ResumeLayout(false);
            this.GbxOrden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxOrden;
        private System.Windows.Forms.TextBox TxtOrden;
        private System.Windows.Forms.Label LblOrden;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCc;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtCc;
        private System.Windows.Forms.ComboBox CbxEstado;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.TextBox TxtObservaciones;
        private System.Windows.Forms.DateTimePicker DateVencimiento;
        private System.Windows.Forms.DataGridView GridViewFactura;
        private System.Windows.Forms.TextBox TxtFactura;
        private System.Windows.Forms.Label LblObservaciones;
        private System.Windows.Forms.Label LblFechavencimiento;
        private System.Windows.Forms.Label LblFactura;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TextBox TxtImpuesto;
        private System.Windows.Forms.TextBox TxtIva;
        private System.Windows.Forms.TextBox TxtDescuento;
        private System.Windows.Forms.Label LblIva;
        private System.Windows.Forms.Label LblDescuento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.ComboBox cbmPago;
        private System.Windows.Forms.Label lblpago;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox CkbActivo;
        private System.Windows.Forms.PictureBox BtnBuscar;
    }
}