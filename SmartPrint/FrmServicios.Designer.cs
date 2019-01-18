namespace SmartPrint
{
    partial class FrmServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServicios));
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.GridViewServicios = new System.Windows.Forms.DataGridView();
            this.CbxTipo = new System.Windows.Forms.ComboBox();
            this.TxtObservaciones = new System.Windows.Forms.TextBox();
            this.TxtItem = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtValorUni = new System.Windows.Forms.TextBox();
            this.LblObservaciones = new System.Windows.Forms.Label();
            this.LblValorUni = new System.Windows.Forms.Label();
            this.LblItem = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.bnBuscarItem = new System.Windows.Forms.PictureBox();
            this.BtnAgregar = new System.Windows.Forms.PictureBox();
            this.BtnCancelarSer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnBuscarItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(12, 520);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Los campos con (*) son obligatorios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(692, 491);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 48;
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
            this.BtnLimpiar.Location = new System.Drawing.Point(645, 141);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(126, 48);
            this.BtnLimpiar.TabIndex = 47;
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
            this.BtnModificar.Location = new System.Drawing.Point(645, 87);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(126, 48);
            this.BtnModificar.TabIndex = 46;
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
            this.BtnGuardar.Location = new System.Drawing.Point(645, 33);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(126, 48);
            this.BtnGuardar.TabIndex = 45;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // GridViewServicios
            // 
            this.GridViewServicios.AllowUserToAddRows = false;
            this.GridViewServicios.AllowUserToDeleteRows = false;
            this.GridViewServicios.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.GridViewServicios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridViewServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewServicios.Location = new System.Drawing.Point(35, 251);
            this.GridViewServicios.Name = "GridViewServicios";
            this.GridViewServicios.ReadOnly = true;
            this.GridViewServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewServicios.Size = new System.Drawing.Size(736, 221);
            this.GridViewServicios.TabIndex = 44;
            // 
            // CbxTipo
            // 
            this.CbxTipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxTipo.FormattingEnabled = true;
            this.CbxTipo.Items.AddRange(new object[] {
            "Asesoria",
            "Servicio"});
            this.CbxTipo.Location = new System.Drawing.Point(145, 62);
            this.CbxTipo.Name = "CbxTipo";
            this.CbxTipo.Size = new System.Drawing.Size(170, 25);
            this.CbxTipo.TabIndex = 1;
            this.CbxTipo.Text = "Seleccione...";
            this.CbxTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxTipo_KeyPress);
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservaciones.Location = new System.Drawing.Point(145, 122);
            this.TxtObservaciones.MaxLength = 254;
            this.TxtObservaciones.Multiline = true;
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(416, 95);
            this.TxtObservaciones.TabIndex = 3;
            this.TxtObservaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtObservaciones_KeyPress);
            // 
            // TxtItem
            // 
            this.TxtItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtItem.Location = new System.Drawing.Point(391, 62);
            this.TxtItem.MaxLength = 11;
            this.TxtItem.Name = "TxtItem";
            this.TxtItem.Size = new System.Drawing.Size(170, 23);
            this.TxtItem.TabIndex = 4;
            this.TxtItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtItem_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(145, 33);
            this.TxtNombre.MaxLength = 50;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(416, 23);
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtValorUni
            // 
            this.TxtValorUni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorUni.Location = new System.Drawing.Point(145, 93);
            this.TxtValorUni.MaxLength = 15;
            this.TxtValorUni.Name = "TxtValorUni";
            this.TxtValorUni.Size = new System.Drawing.Size(170, 23);
            this.TxtValorUni.TabIndex = 2;
            this.TxtValorUni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorUni_KeyPress);
            // 
            // LblObservaciones
            // 
            this.LblObservaciones.AutoSize = true;
            this.LblObservaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObservaciones.Location = new System.Drawing.Point(29, 125);
            this.LblObservaciones.Name = "LblObservaciones";
            this.LblObservaciones.Size = new System.Drawing.Size(109, 16);
            this.LblObservaciones.TabIndex = 38;
            this.LblObservaciones.Text = "Observaciones:";
            // 
            // LblValorUni
            // 
            this.LblValorUni.AutoSize = true;
            this.LblValorUni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorUni.Location = new System.Drawing.Point(29, 96);
            this.LblValorUni.Name = "LblValorUni";
            this.LblValorUni.Size = new System.Drawing.Size(111, 16);
            this.LblValorUni.TabIndex = 37;
            this.LblValorUni.Text = "* Valor Unitario:";
            // 
            // LblItem
            // 
            this.LblItem.AutoSize = true;
            this.LblItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItem.Location = new System.Drawing.Point(335, 65);
            this.LblItem.Name = "LblItem";
            this.LblItem.Size = new System.Drawing.Size(50, 16);
            this.LblItem.TabIndex = 36;
            this.LblItem.Text = "* Ítem:";
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.Location = new System.Drawing.Point(90, 65);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(49, 16);
            this.LblTipo.TabIndex = 35;
            this.LblTipo.Text = "* Tipo:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(65, 36);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(74, 16);
            this.LblNombre.TabIndex = 34;
            this.LblNombre.Text = "* Nombre:";
            // 
            // bnBuscarItem
            // 
            this.bnBuscarItem.Image = ((System.Drawing.Image)(resources.GetObject("bnBuscarItem.Image")));
            this.bnBuscarItem.Location = new System.Drawing.Point(567, 62);
            this.bnBuscarItem.Name = "bnBuscarItem";
            this.bnBuscarItem.Size = new System.Drawing.Size(24, 23);
            this.bnBuscarItem.TabIndex = 52;
            this.bnBuscarItem.TabStop = false;
            this.bnBuscarItem.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.Location = new System.Drawing.Point(792, 318);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(26, 26);
            this.BtnAgregar.TabIndex = 53;
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
            this.BtnCancelarSer.Location = new System.Drawing.Point(645, 195);
            this.BtnCancelarSer.Name = "BtnCancelarSer";
            this.BtnCancelarSer.Size = new System.Drawing.Size(126, 48);
            this.BtnCancelarSer.TabIndex = 54;
            this.BtnCancelarSer.Text = "Cancelar";
            this.BtnCancelarSer.UseVisualStyleBackColor = false;
            this.BtnCancelarSer.Visible = false;
            this.BtnCancelarSer.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(841, 542);
            this.Controls.Add(this.BtnCancelarSer);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.bnBuscarItem);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.GridViewServicios);
            this.Controls.Add(this.CbxTipo);
            this.Controls.Add(this.TxtObservaciones);
            this.Controls.Add(this.TxtItem);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtValorUni);
            this.Controls.Add(this.LblObservaciones);
            this.Controls.Add(this.LblValorUni);
            this.Controls.Add(this.LblItem);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.LblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmServicios";
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.FrmServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnBuscarItem)).EndInit();
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
        private System.Windows.Forms.DataGridView GridViewServicios;
        private System.Windows.Forms.ComboBox CbxTipo;
        private System.Windows.Forms.TextBox TxtObservaciones;
        private System.Windows.Forms.TextBox TxtItem;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtValorUni;
        private System.Windows.Forms.Label LblObservaciones;
        private System.Windows.Forms.Label LblValorUni;
        private System.Windows.Forms.Label LblItem;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.PictureBox bnBuscarItem;
        public System.Windows.Forms.PictureBox BtnAgregar;
        public System.Windows.Forms.Button BtnCancelarSer;
    }
}