namespace SmartPrint
{
    partial class VistaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaClientes));
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DateFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DateInicial = new System.Windows.Forms.DateTimePicker();
            this.LblFechaInicial = new System.Windows.Forms.Label();
            this.DatagrivVistaCliente = new System.Windows.Forms.DataGridView();
            this.identificaciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teléfonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartPrintDataSet = new SmartPrint.SmartPrintDataSet();
            this.vistaClienteTableAdapter = new SmartPrint.SmartPrintDataSetTableAdapters.VistaClienteTableAdapter();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagrivVistaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartPrintDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(622, 23);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(126, 48);
            this.BtnLimpiar.TabIndex = 115;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(582, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 23);
            this.pictureBox2.TabIndex = 114;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // DateFinal
            // 
            this.DateFinal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFinal.Location = new System.Drawing.Point(459, 48);
            this.DateFinal.Name = "DateFinal";
            this.DateFinal.Size = new System.Drawing.Size(117, 23);
            this.DateFinal.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 112;
            this.label1.Text = "* Fecha Final:";
            // 
            // DateInicial
            // 
            this.DateInicial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateInicial.Location = new System.Drawing.Point(459, 19);
            this.DateInicial.Name = "DateInicial";
            this.DateInicial.Size = new System.Drawing.Size(117, 23);
            this.DateInicial.TabIndex = 111;
            // 
            // LblFechaInicial
            // 
            this.LblFechaInicial.AutoSize = true;
            this.LblFechaInicial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaInicial.Location = new System.Drawing.Point(347, 20);
            this.LblFechaInicial.Name = "LblFechaInicial";
            this.LblFechaInicial.Size = new System.Drawing.Size(106, 16);
            this.LblFechaInicial.TabIndex = 110;
            this.LblFechaInicial.Text = "* Fecha Inicial:";
            // 
            // DatagrivVistaCliente
            // 
            this.DatagrivVistaCliente.AllowUserToAddRows = false;
            this.DatagrivVistaCliente.AllowUserToDeleteRows = false;
            this.DatagrivVistaCliente.AutoGenerateColumns = false;
            this.DatagrivVistaCliente.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.DatagrivVistaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagrivVistaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identificaciónDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.teléfonoDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.DatagrivVistaCliente.DataSource = this.vistaClienteBindingSource;
            this.DatagrivVistaCliente.Location = new System.Drawing.Point(52, 98);
            this.DatagrivVistaCliente.Name = "DatagrivVistaCliente";
            this.DatagrivVistaCliente.ReadOnly = true;
            this.DatagrivVistaCliente.Size = new System.Drawing.Size(645, 373);
            this.DatagrivVistaCliente.TabIndex = 109;
            // 
            // identificaciónDataGridViewTextBoxColumn
            // 
            this.identificaciónDataGridViewTextBoxColumn.DataPropertyName = "Identificación";
            this.identificaciónDataGridViewTextBoxColumn.HeaderText = "Identificación";
            this.identificaciónDataGridViewTextBoxColumn.Name = "identificaciónDataGridViewTextBoxColumn";
            this.identificaciónDataGridViewTextBoxColumn.ReadOnly = true;
            this.identificaciónDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teléfonoDataGridViewTextBoxColumn
            // 
            this.teléfonoDataGridViewTextBoxColumn.DataPropertyName = "Teléfono";
            this.teléfonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.teléfonoDataGridViewTextBoxColumn.Name = "teléfonoDataGridViewTextBoxColumn";
            this.teléfonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vistaClienteBindingSource
            // 
            this.vistaClienteBindingSource.DataMember = "VistaCliente";
            this.vistaClienteBindingSource.DataSource = this.smartPrintDataSet;
            // 
            // smartPrintDataSet
            // 
            this.smartPrintDataSet.DataSetName = "SmartPrintDataSet";
            this.smartPrintDataSet.EnforceConstraints = false;
            this.smartPrintDataSet.Locale = new System.Globalization.CultureInfo("es-CO");
            this.smartPrintDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaClienteTableAdapter
            // 
            this.vistaClienteTableAdapter.ClearBeforeFill = true;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(75, 45);
            this.TxtNombre.MaxLength = 50;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(204, 23);
            this.TxtNombre.TabIndex = 118;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(72, 26);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(163, 16);
            this.LblNombre.TabIndex = 119;
            this.LblNombre.Text = "* Nombre/Razón Social:";
            // 
            // VistaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(791, 504);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DateFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateInicial);
            this.Controls.Add(this.LblFechaInicial);
            this.Controls.Add(this.DatagrivVistaCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.VistaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagrivVistaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartPrintDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker DateFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateInicial;
        private System.Windows.Forms.Label LblFechaInicial;
        private System.Windows.Forms.DataGridView DatagrivVistaCliente;
        private SmartPrintDataSet smartPrintDataSet;
        private System.Windows.Forms.BindingSource vistaClienteBindingSource;
        private SmartPrintDataSetTableAdapters.VistaClienteTableAdapter vistaClienteTableAdapter;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificaciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teléfonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
    }
}