namespace SmartPrint
{
    partial class FrmConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultas));
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.cmbNumero = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GridViewFactura = new System.Windows.Forms.DataGridView();
            this.GridViewOS = new System.Windows.Forms.DataGridView();
            this.GridViewRemision = new System.Windows.Forms.DataGridView();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.Lblnumero = new System.Windows.Forms.Label();
            this.DateFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DateInicial = new System.Windows.Forms.DateTimePicker();
            this.LblFechaInicial = new System.Windows.Forms.Label();
            this.LblBuscar = new System.Windows.Forms.PictureBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblCc = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtCc = new System.Windows.Forms.TextBox();
            this.CbxCliente = new System.Windows.Forms.GroupBox();
            this.CbxNumero = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbReporte = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.smartPrintDataSet = new SmartPrint.SmartPrintDataSet();
            this.vistaMoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaMoraTableAdapter = new SmartPrint.SmartPrintDataSetTableAdapters.VistaMoraTableAdapter();
            this.btnMora = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRemision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblBuscar)).BeginInit();
            this.CbxNumero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartPrintDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaMoraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(880, 319);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(126, 48);
            this.BtnLimpiar.TabIndex = 102;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // cmbNumero
            // 
            this.cmbNumero.FormattingEnabled = true;
            this.cmbNumero.Items.AddRange(new object[] {
            "Remision",
            "Orden Servicio",
            "Factura"});
            this.cmbNumero.Location = new System.Drawing.Point(749, 68);
            this.cmbNumero.Name = "cmbNumero";
            this.cmbNumero.Size = new System.Drawing.Size(117, 21);
            this.cmbNumero.TabIndex = 99;
            this.cmbNumero.Text = "Seleccione...";
            this.cmbNumero.SelectedIndexChanged += new System.EventHandler(this.cmbNumero_SelectedIndexChanged);
            this.cmbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbNumero_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 98;
            this.label4.Text = "Remisión:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 97;
            this.label3.Text = "Factura :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 96;
            this.label2.Text = "Orden de Servicio:";
            // 
            // GridViewFactura
            // 
            this.GridViewFactura.AllowUserToOrderColumns = true;
            this.GridViewFactura.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.GridViewFactura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridViewFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewFactura.Location = new System.Drawing.Point(135, 444);
            this.GridViewFactura.Name = "GridViewFactura";
            this.GridViewFactura.Size = new System.Drawing.Size(714, 117);
            this.GridViewFactura.TabIndex = 95;
            // 
            // GridViewOS
            // 
            this.GridViewOS.AllowUserToOrderColumns = true;
            this.GridViewOS.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.GridViewOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridViewOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewOS.Location = new System.Drawing.Point(135, 321);
            this.GridViewOS.Name = "GridViewOS";
            this.GridViewOS.Size = new System.Drawing.Size(714, 117);
            this.GridViewOS.TabIndex = 94;
            // 
            // GridViewRemision
            // 
            this.GridViewRemision.AllowUserToOrderColumns = true;
            this.GridViewRemision.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.GridViewRemision.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridViewRemision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewRemision.Location = new System.Drawing.Point(135, 198);
            this.GridViewRemision.Name = "GridViewRemision";
            this.GridViewRemision.Size = new System.Drawing.Size(714, 117);
            this.GridViewRemision.TabIndex = 93;
            // 
            // TxtNumero
            // 
            this.TxtNumero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.Location = new System.Drawing.Point(749, 39);
            this.TxtNumero.MaxLength = 10;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(117, 23);
            this.TxtNumero.TabIndex = 92;
            // 
            // Lblnumero
            // 
            this.Lblnumero.AutoSize = true;
            this.Lblnumero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblnumero.Location = new System.Drawing.Point(6, 26);
            this.Lblnumero.Name = "Lblnumero";
            this.Lblnumero.Size = new System.Drawing.Size(67, 16);
            this.Lblnumero.TabIndex = 91;
            this.Lblnumero.Text = "Numero :";
            // 
            // DateFinal
            // 
            this.DateFinal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFinal.Location = new System.Drawing.Point(528, 128);
            this.DateFinal.Name = "DateFinal";
            this.DateFinal.Size = new System.Drawing.Size(117, 23);
            this.DateFinal.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 89;
            this.label1.Text = "* Fecha Final:";
            // 
            // DateInicial
            // 
            this.DateInicial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateInicial.Location = new System.Drawing.Point(236, 127);
            this.DateInicial.Name = "DateInicial";
            this.DateInicial.Size = new System.Drawing.Size(117, 23);
            this.DateInicial.TabIndex = 88;
            // 
            // LblFechaInicial
            // 
            this.LblFechaInicial.AutoSize = true;
            this.LblFechaInicial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaInicial.Location = new System.Drawing.Point(124, 128);
            this.LblFechaInicial.Name = "LblFechaInicial";
            this.LblFechaInicial.Size = new System.Drawing.Size(106, 16);
            this.LblFechaInicial.TabIndex = 87;
            this.LblFechaInicial.Text = "* Fecha Inicial:";
            // 
            // LblBuscar
            // 
            this.LblBuscar.Image = ((System.Drawing.Image)(resources.GetObject("LblBuscar.Image")));
            this.LblBuscar.Location = new System.Drawing.Point(359, 38);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(24, 23);
            this.LblBuscar.TabIndex = 86;
            this.LblBuscar.TabStop = false;
            this.LblBuscar.Click += new System.EventHandler(this.LblBuscar_Click_1);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(236, 64);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(402, 23);
            this.TxtNombre.TabIndex = 83;
            // 
            // LblCc
            // 
            this.LblCc.AutoSize = true;
            this.LblCc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCc.Location = new System.Drawing.Point(158, 39);
            this.LblCc.Name = "LblCc";
            this.LblCc.Size = new System.Drawing.Size(72, 16);
            this.LblCc.TabIndex = 84;
            this.LblCc.Text = "* C.C/NIT:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(67, 65);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(163, 16);
            this.LblNombre.TabIndex = 85;
            this.LblNombre.Text = "* Nombre/Razón Social:";
            // 
            // TxtCc
            // 
            this.TxtCc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCc.Location = new System.Drawing.Point(236, 38);
            this.TxtCc.MaxLength = 11;
            this.TxtCc.Name = "TxtCc";
            this.TxtCc.Size = new System.Drawing.Size(117, 23);
            this.TxtCc.TabIndex = 82;
            this.TxtCc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCc_KeyPress);
            // 
            // CbxCliente
            // 
            this.CbxCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxCliente.Location = new System.Drawing.Point(65, 22);
            this.CbxCliente.Name = "CbxCliente";
            this.CbxCliente.Size = new System.Drawing.Size(596, 75);
            this.CbxCliente.TabIndex = 100;
            this.CbxCliente.TabStop = false;
            this.CbxCliente.Text = "Cliente";
            // 
            // CbxNumero
            // 
            this.CbxNumero.Controls.Add(this.Lblnumero);
            this.CbxNumero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxNumero.Location = new System.Drawing.Point(679, 16);
            this.CbxNumero.Name = "CbxNumero";
            this.CbxNumero.Size = new System.Drawing.Size(228, 97);
            this.CbxNumero.TabIndex = 101;
            this.CbxNumero.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(877, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 103;
            this.label5.Text = "Reporte General";
            // 
            // cmbReporte
            // 
            this.cmbReporte.FormattingEnabled = true;
            this.cmbReporte.Items.AddRange(new object[] {
            "Remision",
            "Orden Servicio",
            "Factura"});
            this.cmbReporte.Location = new System.Drawing.Point(880, 226);
            this.cmbReporte.Name = "cmbReporte";
            this.cmbReporte.Size = new System.Drawing.Size(117, 21);
            this.cmbReporte.TabIndex = 104;
            this.cmbReporte.Text = "Seleccione...";
            this.cmbReporte.SelectedIndexChanged += new System.EventHandler(this.cmbReporte_SelectedIndexChanged);
            this.cmbReporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbReporte_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1044, 536);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // smartPrintDataSet
            // 
            this.smartPrintDataSet.DataSetName = "SmartPrintDataSet";
            this.smartPrintDataSet.EnforceConstraints = false;
            this.smartPrintDataSet.Locale = new System.Globalization.CultureInfo("es-CO");
            this.smartPrintDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaMoraBindingSource
            // 
            this.vistaMoraBindingSource.DataMember = "VistaMora";
            this.vistaMoraBindingSource.DataSource = this.smartPrintDataSet;
            // 
            // vistaMoraTableAdapter
            // 
            this.vistaMoraTableAdapter.ClearBeforeFill = true;
            // 
            // btnMora
            // 
            this.btnMora.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMora.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMora.Image = ((System.Drawing.Image)(resources.GetObject("btnMora.Image")));
            this.btnMora.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMora.Location = new System.Drawing.Point(879, 265);
            this.btnMora.Name = "btnMora";
            this.btnMora.Size = new System.Drawing.Size(126, 48);
            this.btnMora.TabIndex = 110;
            this.btnMora.Text = "Mora";
            this.btnMora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMora.UseVisualStyleBackColor = false;
            this.btnMora.Click += new System.EventHandler(this.btnMora_Click);
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1043, 587);
            this.Controls.Add(this.btnMora);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbReporte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.cmbNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridViewFactura);
            this.Controls.Add(this.GridViewOS);
            this.Controls.Add(this.GridViewRemision);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.DateFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateInicial);
            this.Controls.Add(this.LblFechaInicial);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblCc);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.TxtCc);
            this.Controls.Add(this.CbxCliente);
            this.Controls.Add(this.CbxNumero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.FrmConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRemision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblBuscar)).EndInit();
            this.CbxNumero.ResumeLayout(false);
            this.CbxNumero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartPrintDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaMoraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.ComboBox cmbNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GridViewFactura;
        private System.Windows.Forms.DataGridView GridViewOS;
        private System.Windows.Forms.DataGridView GridViewRemision;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label Lblnumero;
        private System.Windows.Forms.DateTimePicker DateFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateInicial;
        private System.Windows.Forms.Label LblFechaInicial;
        private System.Windows.Forms.PictureBox LblBuscar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblCc;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtCc;
        private System.Windows.Forms.GroupBox CbxCliente;
        private System.Windows.Forms.GroupBox CbxNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbReporte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SmartPrintDataSet smartPrintDataSet;
        private System.Windows.Forms.BindingSource vistaMoraBindingSource;
        private SmartPrintDataSetTableAdapters.VistaMoraTableAdapter vistaMoraTableAdapter;
        private System.Windows.Forms.Button btnMora;
    }
}