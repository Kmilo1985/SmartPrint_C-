namespace SmartPrint
{
    partial class FrmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleado));
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.CkbActivo = new System.Windows.Forms.CheckBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtObservaciones = new System.Windows.Forms.TextBox();
            this.CmbDisponibilidad = new System.Windows.Forms.ComboBox();
            this.DateRetiro = new System.Windows.Forms.DateTimePicker();
            this.DateIngreso = new System.Windows.Forms.DateTimePicker();
            this.DateNacimiento = new System.Windows.Forms.DateTimePicker();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtSapellido = new System.Windows.Forms.TextBox();
            this.TxtPapellido = new System.Windows.Forms.TextBox();
            this.TxtSnombre = new System.Windows.Forms.TextBox();
            this.TxtPnombre = new System.Windows.Forms.TextBox();
            this.TxtCc = new System.Windows.Forms.TextBox();
            this.LblObservaciones = new System.Windows.Forms.Label();
            this.LblDisponibilidad = new System.Windows.Forms.Label();
            this.LblCargo = new System.Windows.Forms.Label();
            this.LblRetiro = new System.Windows.Forms.Label();
            this.LblIngreso = new System.Windows.Forms.Label();
            this.LblNacimiento = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblCelular = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblSapellido = new System.Windows.Forms.Label();
            this.LblPapellido = new System.Windows.Forms.Label();
            this.LblSnombre = new System.Windows.Forms.Label();
            this.LblPnombre = new System.Windows.Forms.Label();
            this.LblCc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Eps = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblArp = new System.Windows.Forms.Label();
            this.txtPensiones = new System.Windows.Forms.TextBox();
            this.txtARP = new System.Windows.Forms.TextBox();
            this.txtEps = new System.Windows.Forms.TextBox();
            this.ChekFecha = new System.Windows.Forms.CheckBox();
            this.cbxContrato = new System.Windows.Forms.ComboBox();
            this.buscarContratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartPrintDataSet = new SmartPrint.SmartPrintDataSet();
            this.buscarContratoTableAdapter = new SmartPrint.SmartPrintDataSetTableAdapters.BuscarContratoTableAdapter();
            this.BtnEmpleados = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCompensaciones = new System.Windows.Forms.TextBox();
            this.lblCaja = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarContratoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartPrintDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(482, 131);
            this.TxtEmail.MaxLength = 49;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(184, 23);
            this.TxtEmail.TabIndex = 9;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(418, 134);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(58, 16);
            this.LblEmail.TabIndex = 111;
            this.LblEmail.Text = "* Email:";
            // 
            // CkbActivo
            // 
            this.CkbActivo.AutoSize = true;
            this.CkbActivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbActivo.Location = new System.Drawing.Point(251, 23);
            this.CkbActivo.Name = "CkbActivo";
            this.CkbActivo.Size = new System.Drawing.Size(68, 20);
            this.CkbActivo.TabIndex = 110;
            this.CkbActivo.Text = "Activo";
            this.CkbActivo.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(704, 210);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(126, 48);
            this.BtnLimpiar.TabIndex = 26;
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
            this.BtnModificar.Location = new System.Drawing.Point(704, 145);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(126, 48);
            this.BtnModificar.TabIndex = 25;
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
            this.BtnGuardar.Location = new System.Drawing.Point(704, 80);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(126, 48);
            this.BtnGuardar.TabIndex = 24;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(10, 590);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(174, 13);
            this.label16.TabIndex = 106;
            this.label16.Text = "Los campos con (*) son obligatorios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(695, 549);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservaciones.Location = new System.Drawing.Point(145, 411);
            this.TxtObservaciones.MaxLength = 224;
            this.TxtObservaciones.Multiline = true;
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(531, 97);
            this.TxtObservaciones.TabIndex = 22;
            this.TxtObservaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtObservaciones_KeyPress);
            // 
            // CmbDisponibilidad
            // 
            this.CmbDisponibilidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDisponibilidad.FormattingEnabled = true;
            this.CmbDisponibilidad.Items.AddRange(new object[] {
            "Activo",
            "inactivo"});
            this.CmbDisponibilidad.Location = new System.Drawing.Point(482, 215);
            this.CmbDisponibilidad.Name = "CmbDisponibilidad";
            this.CmbDisponibilidad.Size = new System.Drawing.Size(141, 25);
            this.CmbDisponibilidad.TabIndex = 15;
            this.CmbDisponibilidad.Text = "Seleccione...";
            this.CmbDisponibilidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbDisponibilidad_KeyPress);
            // 
            // DateRetiro
            // 
            this.DateRetiro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateRetiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateRetiro.Location = new System.Drawing.Point(145, 205);
            this.DateRetiro.Name = "DateRetiro";
            this.DateRetiro.Size = new System.Drawing.Size(100, 23);
            this.DateRetiro.TabIndex = 14;
            this.DateRetiro.Value = new System.DateTime(2015, 4, 15, 0, 0, 0, 0);
            // 
            // DateIngreso
            // 
            this.DateIngreso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateIngreso.Location = new System.Drawing.Point(145, 179);
            this.DateIngreso.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.DateIngreso.Name = "DateIngreso";
            this.DateIngreso.Size = new System.Drawing.Size(100, 23);
            this.DateIngreso.TabIndex = 12;
            // 
            // DateNacimiento
            // 
            this.DateNacimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateNacimiento.Location = new System.Drawing.Point(145, 153);
            this.DateNacimiento.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.DateNacimiento.Name = "DateNacimiento";
            this.DateNacimiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateNacimiento.Size = new System.Drawing.Size(100, 23);
            this.DateNacimiento.TabIndex = 10;
            // 
            // CmbSexo
            // 
            this.CmbSexo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.CmbSexo.Location = new System.Drawing.Point(483, 184);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmbSexo.Size = new System.Drawing.Size(141, 25);
            this.CmbSexo.TabIndex = 13;
            this.CmbSexo.Text = "Seleccione...";
            this.CmbSexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbSexo_KeyPress);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(145, 127);
            this.TxtDireccion.MaxLength = 50;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(184, 23);
            this.TxtDireccion.TabIndex = 8;
            this.TxtDireccion.Text = " ";
            this.TxtDireccion.TextChanged += new System.EventHandler(this.TxtDireccion_TextChanged);
            // 
            // TxtCelular
            // 
            this.TxtCelular.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCelular.Location = new System.Drawing.Point(482, 102);
            this.TxtCelular.MaxLength = 10;
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(130, 23);
            this.TxtCelular.TabIndex = 7;
            this.TxtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCelular_KeyPress);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(145, 101);
            this.TxtTelefono.MaxLength = 7;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(100, 23);
            this.TxtTelefono.TabIndex = 6;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // TxtSapellido
            // 
            this.TxtSapellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSapellido.Location = new System.Drawing.Point(482, 76);
            this.TxtSapellido.MaxLength = 20;
            this.TxtSapellido.Name = "TxtSapellido";
            this.TxtSapellido.Size = new System.Drawing.Size(184, 23);
            this.TxtSapellido.TabIndex = 5;
            this.TxtSapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSapellido_KeyPress);
            // 
            // TxtPapellido
            // 
            this.TxtPapellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPapellido.Location = new System.Drawing.Point(145, 75);
            this.TxtPapellido.MaxLength = 20;
            this.TxtPapellido.Name = "TxtPapellido";
            this.TxtPapellido.Size = new System.Drawing.Size(184, 23);
            this.TxtPapellido.TabIndex = 4;
            this.TxtPapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPapellido_KeyPress);
            // 
            // TxtSnombre
            // 
            this.TxtSnombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSnombre.Location = new System.Drawing.Point(482, 50);
            this.TxtSnombre.MaxLength = 20;
            this.TxtSnombre.Name = "TxtSnombre";
            this.TxtSnombre.Size = new System.Drawing.Size(184, 23);
            this.TxtSnombre.TabIndex = 3;
            this.TxtSnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSnombre_KeyPress);
            // 
            // TxtPnombre
            // 
            this.TxtPnombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPnombre.Location = new System.Drawing.Point(145, 49);
            this.TxtPnombre.MaxLength = 20;
            this.TxtPnombre.Name = "TxtPnombre";
            this.TxtPnombre.Size = new System.Drawing.Size(184, 23);
            this.TxtPnombre.TabIndex = 2;
            this.TxtPnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPnombre_KeyPress);
            // 
            // TxtCc
            // 
            this.TxtCc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCc.Location = new System.Drawing.Point(145, 23);
            this.TxtCc.MaxLength = 11;
            this.TxtCc.Name = "TxtCc";
            this.TxtCc.Size = new System.Drawing.Size(100, 23);
            this.TxtCc.TabIndex = 1;
            this.TxtCc.Tag = "";
            this.TxtCc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCc_KeyPress);
            this.TxtCc.Leave += new System.EventHandler(this.FocoTxtCc);
            // 
            // LblObservaciones
            // 
            this.LblObservaciones.AutoSize = true;
            this.LblObservaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObservaciones.Location = new System.Drawing.Point(30, 414);
            this.LblObservaciones.Name = "LblObservaciones";
            this.LblObservaciones.Size = new System.Drawing.Size(109, 16);
            this.LblObservaciones.TabIndex = 89;
            this.LblObservaciones.Text = "Observaciones:";
            // 
            // LblDisponibilidad
            // 
            this.LblDisponibilidad.AutoSize = true;
            this.LblDisponibilidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDisponibilidad.Location = new System.Drawing.Point(358, 218);
            this.LblDisponibilidad.Name = "LblDisponibilidad";
            this.LblDisponibilidad.Size = new System.Drawing.Size(118, 16);
            this.LblDisponibilidad.TabIndex = 88;
            this.LblDisponibilidad.Text = "* Disponibilidad:";
            // 
            // LblCargo
            // 
            this.LblCargo.AutoSize = true;
            this.LblCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargo.Location = new System.Drawing.Point(413, 161);
            this.LblCargo.Name = "LblCargo";
            this.LblCargo.Size = new System.Drawing.Size(63, 16);
            this.LblCargo.TabIndex = 87;
            this.LblCargo.Text = "* Cargo:";
            // 
            // LblRetiro
            // 
            this.LblRetiro.AutoSize = true;
            this.LblRetiro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRetiro.Location = new System.Drawing.Point(37, 210);
            this.LblRetiro.Name = "LblRetiro";
            this.LblRetiro.Size = new System.Drawing.Size(96, 16);
            this.LblRetiro.TabIndex = 86;
            this.LblRetiro.Text = " Fecha Retiro:";
            // 
            // LblIngreso
            // 
            this.LblIngreso.AutoSize = true;
            this.LblIngreso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIngreso.Location = new System.Drawing.Point(26, 184);
            this.LblIngreso.Name = "LblIngreso";
            this.LblIngreso.Size = new System.Drawing.Size(113, 16);
            this.LblIngreso.TabIndex = 85;
            this.LblIngreso.Text = "* Fecha Ingreso:";
            // 
            // LblNacimiento
            // 
            this.LblNacimiento.AutoSize = true;
            this.LblNacimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNacimiento.Location = new System.Drawing.Point(-1, 158);
            this.LblNacimiento.Name = "LblNacimiento";
            this.LblNacimiento.Size = new System.Drawing.Size(140, 16);
            this.LblNacimiento.TabIndex = 84;
            this.LblNacimiento.Text = "* Fecha Nacimiento:";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSexo.Location = new System.Drawing.Point(425, 187);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(52, 16);
            this.LblSexo.TabIndex = 83;
            this.LblSexo.Text = "* Sexo:";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(55, 130);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(84, 16);
            this.LblDireccion.TabIndex = 82;
            this.LblDireccion.Text = "* Dirección:";
            // 
            // LblCelular
            // 
            this.LblCelular.AutoSize = true;
            this.LblCelular.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCelular.Location = new System.Drawing.Point(416, 105);
            this.LblCelular.Name = "LblCelular";
            this.LblCelular.Size = new System.Drawing.Size(60, 16);
            this.LblCelular.TabIndex = 81;
            this.LblCelular.Text = "Celular:";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono.Location = new System.Drawing.Point(67, 105);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(76, 16);
            this.LblTelefono.TabIndex = 80;
            this.LblTelefono.Text = "* Teléfono:";
            // 
            // LblSapellido
            // 
            this.LblSapellido.AutoSize = true;
            this.LblSapellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSapellido.Location = new System.Drawing.Point(347, 80);
            this.LblSapellido.Name = "LblSapellido";
            this.LblSapellido.Size = new System.Drawing.Size(129, 16);
            this.LblSapellido.TabIndex = 79;
            this.LblSapellido.Text = "Segundo Apellido:";
            // 
            // LblPapellido
            // 
            this.LblPapellido.AutoSize = true;
            this.LblPapellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPapellido.Location = new System.Drawing.Point(16, 80);
            this.LblPapellido.Name = "LblPapellido";
            this.LblPapellido.Size = new System.Drawing.Size(123, 16);
            this.LblPapellido.TabIndex = 78;
            this.LblPapellido.Text = "* Primer Apellido:";
            // 
            // LblSnombre
            // 
            this.LblSnombre.AutoSize = true;
            this.LblSnombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSnombre.Location = new System.Drawing.Point(351, 53);
            this.LblSnombre.Name = "LblSnombre";
            this.LblSnombre.Size = new System.Drawing.Size(125, 16);
            this.LblSnombre.TabIndex = 77;
            this.LblSnombre.Text = "Segundo Nombre:";
            // 
            // LblPnombre
            // 
            this.LblPnombre.AutoSize = true;
            this.LblPnombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPnombre.Location = new System.Drawing.Point(20, 53);
            this.LblPnombre.Name = "LblPnombre";
            this.LblPnombre.Size = new System.Drawing.Size(119, 16);
            this.LblPnombre.TabIndex = 76;
            this.LblPnombre.Text = "* Primer Nombre:";
            // 
            // LblCc
            // 
            this.LblCc.AutoSize = true;
            this.LblCc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCc.Location = new System.Drawing.Point(93, 27);
            this.LblCc.Name = "LblCc";
            this.LblCc.Size = new System.Drawing.Size(46, 16);
            this.LblCc.TabIndex = 75;
            this.LblCc.Text = "* C.C:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 113;
            this.label1.Text = "* Tipo de Contrato:";
            // 
            // Eps
            // 
            this.Eps.AutoSize = true;
            this.Eps.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eps.Location = new System.Drawing.Point(406, 26);
            this.Eps.Name = "Eps";
            this.Eps.Size = new System.Drawing.Size(40, 16);
            this.Eps.TabIndex = 115;
            this.Eps.Text = "*Eps:";
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(482, 158);
            this.txtCargo.MaxLength = 49;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(184, 23);
            this.txtCargo.TabIndex = 11;
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(145, 233);
            this.txtSalario.MaxLength = 10;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(184, 23);
            this.txtSalario.TabIndex = 16;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 117;
            this.label2.Text = "* Salario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 122;
            this.label3.Text = "* Pensiones:";
            // 
            // lblArp
            // 
            this.lblArp.AutoSize = true;
            this.lblArp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArp.Location = new System.Drawing.Point(399, 51);
            this.lblArp.Name = "lblArp";
            this.lblArp.Size = new System.Drawing.Size(47, 16);
            this.lblArp.TabIndex = 124;
            this.lblArp.Text = "* ARP:";
            // 
            // txtPensiones
            // 
            this.txtPensiones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPensiones.Location = new System.Drawing.Point(201, 51);
            this.txtPensiones.MaxLength = 49;
            this.txtPensiones.Name = "txtPensiones";
            this.txtPensiones.Size = new System.Drawing.Size(186, 23);
            this.txtPensiones.TabIndex = 18;
            this.txtPensiones.TextChanged += new System.EventHandler(this.txtPensiones_TextChanged);
            this.txtPensiones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPensiones_KeyPress);
            // 
            // txtARP
            // 
            this.txtARP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtARP.Location = new System.Drawing.Point(452, 51);
            this.txtARP.MaxLength = 49;
            this.txtARP.Name = "txtARP";
            this.txtARP.Size = new System.Drawing.Size(184, 23);
            this.txtARP.TabIndex = 20;
            this.txtARP.TextChanged += new System.EventHandler(this.txtARP_TextChanged);
            this.txtARP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtARP_KeyPress);
            // 
            // txtEps
            // 
            this.txtEps.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEps.Location = new System.Drawing.Point(452, 19);
            this.txtEps.MaxLength = 49;
            this.txtEps.Name = "txtEps";
            this.txtEps.Size = new System.Drawing.Size(184, 23);
            this.txtEps.TabIndex = 19;
            this.txtEps.TextChanged += new System.EventHandler(this.txtEps_TextChanged);
            this.txtEps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEps_KeyPress);
            // 
            // ChekFecha
            // 
            this.ChekFecha.AutoSize = true;
            this.ChekFecha.Location = new System.Drawing.Point(29, 212);
            this.ChekFecha.Name = "ChekFecha";
            this.ChekFecha.Size = new System.Drawing.Size(15, 14);
            this.ChekFecha.TabIndex = 126;
            this.ChekFecha.UseVisualStyleBackColor = true;
            this.ChekFecha.Click += new System.EventHandler(this.ChekFecha_Click);
            // 
            // cbxContrato
            // 
            this.cbxContrato.DataSource = this.buscarContratoBindingSource;
            this.cbxContrato.DisplayMember = "Nombre";
            this.cbxContrato.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxContrato.FormattingEnabled = true;
            this.cbxContrato.Location = new System.Drawing.Point(482, 243);
            this.cbxContrato.Name = "cbxContrato";
            this.cbxContrato.Size = new System.Drawing.Size(184, 25);
            this.cbxContrato.TabIndex = 17;
            this.cbxContrato.ValueMember = "Nombre";
            this.cbxContrato.Click += new System.EventHandler(this.cbxContrato_Click);
            this.cbxContrato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxContrato_KeyPress);
            // 
            // buscarContratoBindingSource
            // 
            this.buscarContratoBindingSource.DataMember = "BuscarContrato";
            this.buscarContratoBindingSource.DataSource = this.smartPrintDataSet;
            // 
            // smartPrintDataSet
            // 
            this.smartPrintDataSet.DataSetName = "SmartPrintDataSet";
            this.smartPrintDataSet.EnforceConstraints = false;
            this.smartPrintDataSet.Locale = new System.Globalization.CultureInfo("es-CO");
            this.smartPrintDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscarContratoTableAdapter
            // 
            this.buscarContratoTableAdapter.ClearBeforeFill = true;
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnEmpleados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpleados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("BtnEmpleados.Image")));
            this.BtnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmpleados.Location = new System.Drawing.Point(704, 270);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Size = new System.Drawing.Size(126, 48);
            this.BtnEmpleados.TabIndex = 128;
            this.BtnEmpleados.Text = "Empleados";
            this.BtnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEmpleados.UseVisualStyleBackColor = false;
            this.BtnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCompensaciones);
            this.groupBox1.Controls.Add(this.lblCaja);
            this.groupBox1.Controls.Add(this.txtEps);
            this.groupBox1.Controls.Add(this.txtARP);
            this.groupBox1.Controls.Add(this.txtPensiones);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblArp);
            this.groupBox1.Controls.Add(this.Eps);
            this.groupBox1.Location = new System.Drawing.Point(33, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 91);
            this.groupBox1.TabIndex = 175;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prestaciones";
            // 
            // txtCompensaciones
            // 
            this.txtCompensaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompensaciones.Location = new System.Drawing.Point(203, 19);
            this.txtCompensaciones.MaxLength = 49;
            this.txtCompensaciones.Name = "txtCompensaciones";
            this.txtCompensaciones.Size = new System.Drawing.Size(184, 23);
            this.txtCompensaciones.TabIndex = 176;
            this.txtCompensaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCompensaciones_KeyPress_1);
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja.Location = new System.Drawing.Point(6, 22);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(191, 16);
            this.lblCaja.TabIndex = 177;
            this.lblCaja.Text = "* Caja de Compensaciones:";
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 605);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnEmpleados);
            this.Controls.Add(this.cbxContrato);
            this.Controls.Add(this.ChekFecha);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.CkbActivo);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtObservaciones);
            this.Controls.Add(this.CmbDisponibilidad);
            this.Controls.Add(this.DateRetiro);
            this.Controls.Add(this.DateIngreso);
            this.Controls.Add(this.DateNacimiento);
            this.Controls.Add(this.CmbSexo);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtCelular);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtSapellido);
            this.Controls.Add(this.TxtPapellido);
            this.Controls.Add(this.TxtSnombre);
            this.Controls.Add(this.TxtPnombre);
            this.Controls.Add(this.TxtCc);
            this.Controls.Add(this.LblObservaciones);
            this.Controls.Add(this.LblDisponibilidad);
            this.Controls.Add(this.LblCargo);
            this.Controls.Add(this.LblRetiro);
            this.Controls.Add(this.LblIngreso);
            this.Controls.Add(this.LblNacimiento);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.LblDireccion);
            this.Controls.Add(this.LblCelular);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.LblSapellido);
            this.Controls.Add(this.LblPapellido);
            this.Controls.Add(this.LblSnombre);
            this.Controls.Add(this.LblPnombre);
            this.Controls.Add(this.LblCc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmpleado";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarContratoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartPrintDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.CheckBox CkbActivo;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtObservaciones;
        private System.Windows.Forms.ComboBox CmbDisponibilidad;
        private System.Windows.Forms.DateTimePicker DateRetiro;
        private System.Windows.Forms.DateTimePicker DateIngreso;
        private System.Windows.Forms.DateTimePicker DateNacimiento;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtCelular;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtSapellido;
        private System.Windows.Forms.TextBox TxtPapellido;
        private System.Windows.Forms.TextBox TxtSnombre;
        private System.Windows.Forms.TextBox TxtPnombre;
        private System.Windows.Forms.TextBox TxtCc;
        private System.Windows.Forms.Label LblObservaciones;
        private System.Windows.Forms.Label LblDisponibilidad;
        private System.Windows.Forms.Label LblCargo;
        private System.Windows.Forms.Label LblRetiro;
        private System.Windows.Forms.Label LblIngreso;
        private System.Windows.Forms.Label LblNacimiento;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblCelular;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblSapellido;
        private System.Windows.Forms.Label LblPapellido;
        private System.Windows.Forms.Label LblSnombre;
        private System.Windows.Forms.Label LblPnombre;
        private System.Windows.Forms.Label LblCc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Eps;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblArp;
        private System.Windows.Forms.TextBox txtPensiones;
        private System.Windows.Forms.TextBox txtARP;
        private System.Windows.Forms.TextBox txtEps;
        private System.Windows.Forms.CheckBox ChekFecha;
        private System.Windows.Forms.ComboBox cbxContrato;
        private SmartPrintDataSet smartPrintDataSet;
        private System.Windows.Forms.BindingSource buscarContratoBindingSource;
        private SmartPrintDataSetTableAdapters.BuscarContratoTableAdapter buscarContratoTableAdapter;
        private System.Windows.Forms.Button BtnEmpleados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCompensaciones;
        private System.Windows.Forms.Label lblCaja;
    }
}