namespace SmartPrint
{
    partial class FrmOrdenServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdenServicio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GbxRemision = new System.Windows.Forms.GroupBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblRemision = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCc = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.TxtRemision = new System.Windows.Forms.TextBox();
            this.TxtCc = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CbxEstado = new System.Windows.Forms.ComboBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.DateOrden = new System.Windows.Forms.DateTimePicker();
            this.GridViewOrden = new System.Windows.Forms.DataGridView();
            this.TxtObservaciones = new System.Windows.Forms.TextBox();
            this.TxtOrdenServ = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.LblObservaciones = new System.Windows.Forms.Label();
            this.LblFechaOrden = new System.Windows.Forms.Label();
            this.LblAsignado = new System.Windows.Forms.Label();
            this.LblOrden = new System.Windows.Forms.Label();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.vistaEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartPrintDataSet = new SmartPrint.SmartPrintDataSet();
            this.vistaEmpleadosTableAdapter = new SmartPrint.SmartPrintDataSetTableAdapters.VistaEmpleadosTableAdapter();
            this.spBuscarRemisionServiciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblIva = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.GbxRemision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartPrintDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBuscarRemisionServiciosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxRemision
            // 
            this.GbxRemision.Controls.Add(this.TxtNombre);
            this.GbxRemision.Controls.Add(this.LblRemision);
            this.GbxRemision.Controls.Add(this.LblNombre);
            this.GbxRemision.Controls.Add(this.LblCc);
            this.GbxRemision.Controls.Add(this.LblDireccion);
            this.GbxRemision.Controls.Add(this.LblTelefono);
            this.GbxRemision.Controls.Add(this.TxtRemision);
            this.GbxRemision.Controls.Add(this.TxtCc);
            this.GbxRemision.Controls.Add(this.TxtTelefono);
            this.GbxRemision.Controls.Add(this.TxtDireccion);
            this.GbxRemision.Location = new System.Drawing.Point(27, 50);
            this.GbxRemision.Name = "GbxRemision";
            this.GbxRemision.Size = new System.Drawing.Size(738, 112);
            this.GbxRemision.TabIndex = 55;
            this.GbxRemision.TabStop = false;
            this.GbxRemision.Text = "Remisión";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(173, 51);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(233, 23);
            this.TxtNombre.TabIndex = 7;
            // 
            // LblRemision
            // 
            this.LblRemision.AutoSize = true;
            this.LblRemision.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRemision.Location = new System.Drawing.Point(68, 21);
            this.LblRemision.Name = "LblRemision";
            this.LblRemision.Size = new System.Drawing.Size(99, 16);
            this.LblRemision.TabIndex = 0;
            this.LblRemision.Text = "* Remisión Nº:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(4, 53);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(163, 16);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "* Nombre/Razón Social:";
            // 
            // LblCc
            // 
            this.LblCc.AutoSize = true;
            this.LblCc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCc.Location = new System.Drawing.Point(517, 51);
            this.LblCc.Name = "LblCc";
            this.LblCc.Size = new System.Drawing.Size(72, 16);
            this.LblCc.TabIndex = 3;
            this.LblCc.Text = "* C.C/NIT:";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(83, 86);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(84, 16);
            this.LblDireccion.TabIndex = 4;
            this.LblDireccion.Text = "* Dirección:";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono.Location = new System.Drawing.Point(513, 78);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(76, 16);
            this.LblTelefono.TabIndex = 5;
            this.LblTelefono.Text = "* Teléfono:";
            // 
            // TxtRemision
            // 
            this.TxtRemision.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRemision.Location = new System.Drawing.Point(173, 20);
            this.TxtRemision.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtRemision.MaxLength = 20;
            this.TxtRemision.Name = "TxtRemision";
            this.TxtRemision.Size = new System.Drawing.Size(100, 23);
            this.TxtRemision.TabIndex = 1;
            this.TxtRemision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRemision_KeyPress);
            // 
            // TxtCc
            // 
            this.TxtCc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCc.Location = new System.Drawing.Point(595, 50);
            this.TxtCc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCc.Name = "TxtCc";
            this.TxtCc.Size = new System.Drawing.Size(100, 23);
            this.TxtCc.TabIndex = 3;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(595, 77);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(100, 23);
            this.TxtTelefono.TabIndex = 5;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(173, 82);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(233, 23);
            this.TxtDireccion.TabIndex = 4;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(789, 286);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(126, 48);
            this.BtnLimpiar.TabIndex = 54;
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
            this.BtnCancelar.Location = new System.Drawing.Point(789, 200);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(126, 48);
            this.BtnCancelar.TabIndex = 53;
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
            this.BtnAceptar.Location = new System.Drawing.Point(789, 114);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(126, 48);
            this.BtnAceptar.TabIndex = 52;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(31, 597);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Los campos con (*) son obligatorios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(767, 556);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CbxEstado
            // 
            this.CbxEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxEstado.FormattingEnabled = true;
            this.CbxEstado.Items.AddRange(new object[] {
            "Finalizado (F)",
            "Pendiente (P)",
            "No Conforme (N)"});
            this.CbxEstado.Location = new System.Drawing.Point(156, 532);
            this.CbxEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbxEstado.Name = "CbxEstado";
            this.CbxEstado.Size = new System.Drawing.Size(166, 25);
            this.CbxEstado.TabIndex = 49;
            this.CbxEstado.Text = "Seleccione...";
            this.CbxEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxEstado_KeyPress);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(660, 583);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(86, 23);
            this.TxtTotal.TabIndex = 48;
            // 
            // DateOrden
            // 
            this.DateOrden.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOrden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOrden.Location = new System.Drawing.Point(641, 173);
            this.DateOrden.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DateOrden.Name = "DateOrden";
            this.DateOrden.Size = new System.Drawing.Size(100, 20);
            this.DateOrden.TabIndex = 8;
            // 
            // GridViewOrden
            // 
            this.GridViewOrden.AllowUserToAddRows = false;
            this.GridViewOrden.AllowUserToDeleteRows = false;
            this.GridViewOrden.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.GridViewOrden.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewOrden.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewOrden.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewOrden.Location = new System.Drawing.Point(200, 342);
            this.GridViewOrden.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GridViewOrden.Name = "GridViewOrden";
            this.GridViewOrden.ReadOnly = true;
            this.GridViewOrden.Size = new System.Drawing.Size(541, 177);
            this.GridViewOrden.TabIndex = 45;
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservaciones.Location = new System.Drawing.Point(200, 203);
            this.TxtObservaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtObservaciones.MaxLength = 254;
            this.TxtObservaciones.Multiline = true;
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(541, 116);
            this.TxtObservaciones.TabIndex = 9;
            // 
            // TxtOrdenServ
            // 
            this.TxtOrdenServ.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOrdenServ.Location = new System.Drawing.Point(665, 30);
            this.TxtOrdenServ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtOrdenServ.MaxLength = 10;
            this.TxtOrdenServ.Name = "TxtOrdenServ";
            this.TxtOrdenServ.Size = new System.Drawing.Size(100, 23);
            this.TxtOrdenServ.TabIndex = 0;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(612, 588);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(51, 16);
            this.LblTotal.TabIndex = 41;
            this.LblTotal.Text = "TOTAL:";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(85, 532);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(65, 16);
            this.LblEstado.TabIndex = 40;
            this.LblEstado.Text = "* Estado:";
            // 
            // LblObservaciones
            // 
            this.LblObservaciones.AutoSize = true;
            this.LblObservaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObservaciones.Location = new System.Drawing.Point(85, 204);
            this.LblObservaciones.Name = "LblObservaciones";
            this.LblObservaciones.Size = new System.Drawing.Size(109, 16);
            this.LblObservaciones.TabIndex = 39;
            this.LblObservaciones.Text = "Observaciones:";
            // 
            // LblFechaOrden
            // 
            this.LblFechaOrden.AutoSize = true;
            this.LblFechaOrden.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaOrden.Location = new System.Drawing.Point(489, 176);
            this.LblFechaOrden.Name = "LblFechaOrden";
            this.LblFechaOrden.Size = new System.Drawing.Size(146, 16);
            this.LblFechaOrden.TabIndex = 38;
            this.LblFechaOrden.Text = "* Fecha Vencimiento:";
            // 
            // LblAsignado
            // 
            this.LblAsignado.AutoSize = true;
            this.LblAsignado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAsignado.Location = new System.Drawing.Point(95, 176);
            this.LblAsignado.Name = "LblAsignado";
            this.LblAsignado.Size = new System.Drawing.Size(99, 16);
            this.LblAsignado.TabIndex = 37;
            this.LblAsignado.Text = "* Asignado A:";
            // 
            // LblOrden
            // 
            this.LblOrden.AutoSize = true;
            this.LblOrden.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrden.Location = new System.Drawing.Point(532, 31);
            this.LblOrden.Name = "LblOrden";
            this.LblOrden.Size = new System.Drawing.Size(127, 16);
            this.LblOrden.TabIndex = 36;
            this.LblOrden.Text = "Orden Servicio Nº:";
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vistaEmpleadosBindingSource, "NombreCompleto", true));
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(201, 176);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(267, 21);
            this.cmbEmpleados.TabIndex = 2;
            this.cmbEmpleados.Click += new System.EventHandler(this.cmbEmpleados_Click);
            this.cmbEmpleados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEmpleados_KeyPress);
            // 
            // vistaEmpleadosBindingSource
            // 
            this.vistaEmpleadosBindingSource.DataMember = "VistaEmpleados";
            this.vistaEmpleadosBindingSource.DataSource = this.smartPrintDataSet;
            // 
            // smartPrintDataSet
            // 
            this.smartPrintDataSet.DataSetName = "SmartPrintDataSet";
            this.smartPrintDataSet.EnforceConstraints = false;
            this.smartPrintDataSet.Locale = new System.Globalization.CultureInfo("es-CO");
            this.smartPrintDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaEmpleadosTableAdapter
            // 
            this.vistaEmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // spBuscarRemisionServiciosBindingSource
            // 
            this.spBuscarRemisionServiciosBindingSource.DataMember = "SpBuscar_RemisionServicios";
            // 
            // LblIva
            // 
            this.LblIva.AutoSize = true;
            this.LblIva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIva.Location = new System.Drawing.Point(619, 556);
            this.LblIva.Name = "LblIva";
            this.LblIva.Size = new System.Drawing.Size(35, 16);
            this.LblIva.TabIndex = 60;
            this.LblIva.Text = "IVA:";
            // 
            // txtIva
            // 
            this.txtIva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(660, 553);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(88, 23);
            this.txtIva.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "SUBTOTAL:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(660, 528);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(88, 23);
            this.txtSubtotal.TabIndex = 57;
            // 
            // FrmOrdenServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(927, 619);
            this.Controls.Add(this.LblIva);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.cmbEmpleados);
            this.Controls.Add(this.GbxRemision);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CbxEstado);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.DateOrden);
            this.Controls.Add(this.GridViewOrden);
            this.Controls.Add(this.TxtObservaciones);
            this.Controls.Add(this.TxtOrdenServ);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.LblObservaciones);
            this.Controls.Add(this.LblFechaOrden);
            this.Controls.Add(this.LblAsignado);
            this.Controls.Add(this.LblOrden);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrdenServicio";
            this.Text = "Orden de Servicio";
            this.GbxRemision.ResumeLayout(false);
            this.GbxRemision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartPrintDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBuscarRemisionServiciosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxRemision;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblRemision;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCc;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.TextBox TxtRemision;
        private System.Windows.Forms.TextBox TxtCc;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CbxEstado;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.DateTimePicker DateOrden;
        private System.Windows.Forms.DataGridView GridViewOrden;
        private System.Windows.Forms.TextBox TxtObservaciones;
        private System.Windows.Forms.TextBox TxtOrdenServ;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label LblObservaciones;
        private System.Windows.Forms.Label LblFechaOrden;
        private System.Windows.Forms.Label LblAsignado;
        private System.Windows.Forms.Label LblOrden;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private SmartPrintDataSet smartPrintDataSet;
        private System.Windows.Forms.BindingSource vistaEmpleadosBindingSource;
        private SmartPrintDataSetTableAdapters.VistaEmpleadosTableAdapter vistaEmpleadosTableAdapter;
        private System.Windows.Forms.BindingSource spBuscarRemisionServiciosBindingSource;
        private System.Windows.Forms.Label LblIva;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubtotal;
    }
}