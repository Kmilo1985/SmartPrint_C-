namespace SmartPrint
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.GridViewUsuario = new System.Windows.Forms.DataGridView();
            this.vistaUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartPrintDataSet = new SmartPrint.SmartPrintDataSet();
            this.CbxPerfil = new System.Windows.Forms.ComboBox();
            this.CbxEstado = new System.Windows.Forms.ComboBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.LblPerfil = new System.Windows.Forms.Label();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblConfirmar = new System.Windows.Forms.Label();
            this.TxtConfirmar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartPrintDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(3, 511);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Los campos con (*) son obligatorios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(675, 486);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.BtnLimpiar.Location = new System.Drawing.Point(606, 136);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(126, 48);
            this.BtnLimpiar.TabIndex = 9;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnModificar.Enabled = false;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(606, 82);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(126, 48);
            this.BtnModificar.TabIndex = 8;
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
            this.BtnGuardar.Location = new System.Drawing.Point(606, 28);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(126, 48);
            this.BtnGuardar.TabIndex = 7;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // GridViewUsuario
            // 
            this.GridViewUsuario.AllowUserToAddRows = false;
            this.GridViewUsuario.AllowUserToDeleteRows = false;
            this.GridViewUsuario.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.GridViewUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewUsuario.Location = new System.Drawing.Point(38, 199);
            this.GridViewUsuario.Name = "GridViewUsuario";
            this.GridViewUsuario.ReadOnly = true;
            this.GridViewUsuario.Size = new System.Drawing.Size(741, 264);
            this.GridViewUsuario.TabIndex = 46;
            this.GridViewUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewUsuario_CellClick);
            // 
            // vistaUsuariosBindingSource
            // 
            this.vistaUsuariosBindingSource.DataMember = "VistaUsuarios";
            this.vistaUsuariosBindingSource.DataSource = this.smartPrintDataSet;
            // 
            // smartPrintDataSet
            // 
            this.smartPrintDataSet.DataSetName = "SmartPrintDataSet";
            this.smartPrintDataSet.EnforceConstraints = false;
            this.smartPrintDataSet.Locale = new System.Globalization.CultureInfo("es-CO");
            this.smartPrintDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CbxPerfil
            // 
            this.CbxPerfil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxPerfil.FormattingEnabled = true;
            this.CbxPerfil.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.CbxPerfil.Location = new System.Drawing.Point(129, 115);
            this.CbxPerfil.Name = "CbxPerfil";
            this.CbxPerfil.Size = new System.Drawing.Size(162, 25);
            this.CbxPerfil.TabIndex = 5;
            this.CbxPerfil.Text = "Seleccione:";
            this.CbxPerfil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxPerfil_KeyPress);
            // 
            // CbxEstado
            // 
            this.CbxEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxEstado.FormattingEnabled = true;
            this.CbxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CbxEstado.Location = new System.Drawing.Point(129, 146);
            this.CbxEstado.Name = "CbxEstado";
            this.CbxEstado.Size = new System.Drawing.Size(162, 25);
            this.CbxEstado.TabIndex = 6;
            this.CbxEstado.Text = "Seleccione...";
            this.CbxEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxEstado_KeyPress);
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.Location = new System.Drawing.Point(403, 89);
            this.TxtContraseña.MaxLength = 15;
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '*';
            this.TxtContraseña.Size = new System.Drawing.Size(162, 23);
            this.TxtContraseña.TabIndex = 4;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(129, 28);
            this.TxtCodigo.MaxLength = 11;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(121, 23);
            this.TxtCodigo.TabIndex = 1;
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(129, 57);
            this.TxtNombre.MaxLength = 20;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(436, 23);
            this.TxtNombre.TabIndex = 2;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(129, 86);
            this.TxtUsuario.MaxLength = 19;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(162, 23);
            this.TxtUsuario.TabIndex = 3;
            this.TxtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(49, 60);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(74, 16);
            this.LblNombre.TabIndex = 39;
            this.LblNombre.Text = "* Nombre:";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(58, 149);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(65, 16);
            this.LblEstado.TabIndex = 38;
            this.LblEstado.Text = "* Estado:";
            // 
            // LblPerfil
            // 
            this.LblPerfil.AutoSize = true;
            this.LblPerfil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPerfil.Location = new System.Drawing.Point(73, 118);
            this.LblPerfil.Name = "LblPerfil";
            this.LblPerfil.Size = new System.Drawing.Size(50, 16);
            this.LblPerfil.TabIndex = 37;
            this.LblPerfil.Text = "*Perfil:";
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContraseña.Location = new System.Drawing.Point(304, 92);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(93, 16);
            this.LblContraseña.TabIndex = 36;
            this.LblContraseña.Text = "*Contraseña:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(49, 89);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(70, 16);
            this.LblUsuario.TabIndex = 35;
            this.LblUsuario.Text = "* Usuario:";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(53, 31);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(70, 16);
            this.LblCodigo.TabIndex = 34;
            this.LblCodigo.Text = "* Código:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(256, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 23);
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // LblConfirmar
            // 
            this.LblConfirmar.AutoSize = true;
            this.LblConfirmar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConfirmar.Location = new System.Drawing.Point(304, 127);
            this.LblConfirmar.Name = "LblConfirmar";
            this.LblConfirmar.Size = new System.Drawing.Size(79, 16);
            this.LblConfirmar.TabIndex = 53;
            this.LblConfirmar.Text = "*Confirmar";
            // 
            // TxtConfirmar
            // 
            this.TxtConfirmar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConfirmar.Location = new System.Drawing.Point(403, 121);
            this.TxtConfirmar.MaxLength = 15;
            this.TxtConfirmar.Name = "TxtConfirmar";
            this.TxtConfirmar.PasswordChar = '*';
            this.TxtConfirmar.Size = new System.Drawing.Size(162, 23);
            this.TxtConfirmar.TabIndex = 54;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 542);
            this.Controls.Add(this.TxtConfirmar);
            this.Controls.Add(this.LblConfirmar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.GridViewUsuario);
            this.Controls.Add(this.CbxPerfil);
            this.Controls.Add(this.CbxEstado);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.LblPerfil);
            this.Controls.Add(this.LblContraseña);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaUsuariosBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.smartPrintDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView GridViewUsuario;
        private System.Windows.Forms.ComboBox CbxPerfil;
        private System.Windows.Forms.ComboBox CbxEstado;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label LblPerfil;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblConfirmar;
        private System.Windows.Forms.TextBox TxtConfirmar;
        private SmartPrintDataSet smartPrintDataSet;
        private System.Windows.Forms.BindingSource vistaUsuariosBindingSource;
      
    }
}