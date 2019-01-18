namespace SmartPrint
{
    partial class VistaEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaEmpleados));
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.btnBucar = new System.Windows.Forms.PictureBox();
            this.DateFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DateInicial = new System.Windows.Forms.DateTimePicker();
            this.LblFechaInicial = new System.Windows.Forms.Label();
            this.DatagrivVistaEmpleado = new System.Windows.Forms.DataGridView();
            this.vistaEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartPrintDataSet = new SmartPrint.SmartPrintDataSet();
            this.vistaEmpleadoTableAdapter = new SmartPrint.SmartPrintDataSetTableAdapters.VistaEmpleadoTableAdapter();
            this.vistaEmpleadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cédulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teléfonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnBucar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagrivVistaEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartPrintDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaEmpleadoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(639, 28);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(126, 48);
            this.BtnLimpiar.TabIndex = 121;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnBucar
            // 
            this.btnBucar.Image = ((System.Drawing.Image)(resources.GetObject("btnBucar.Image")));
            this.btnBucar.Location = new System.Drawing.Point(608, 39);
            this.btnBucar.Name = "btnBucar";
            this.btnBucar.Size = new System.Drawing.Size(24, 23);
            this.btnBucar.TabIndex = 120;
            this.btnBucar.TabStop = false;
            this.btnBucar.Click += new System.EventHandler(this.btnBucar_Click);
            // 
            // DateFinal
            // 
            this.DateFinal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFinal.Location = new System.Drawing.Point(485, 39);
            this.DateFinal.Name = "DateFinal";
            this.DateFinal.Size = new System.Drawing.Size(117, 23);
            this.DateFinal.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 118;
            this.label1.Text = "* Fecha Final:";
            // 
            // DateInicial
            // 
            this.DateInicial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateInicial.Location = new System.Drawing.Point(193, 38);
            this.DateInicial.Name = "DateInicial";
            this.DateInicial.Size = new System.Drawing.Size(117, 23);
            this.DateInicial.TabIndex = 117;
            // 
            // LblFechaInicial
            // 
            this.LblFechaInicial.AutoSize = true;
            this.LblFechaInicial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaInicial.Location = new System.Drawing.Point(81, 39);
            this.LblFechaInicial.Name = "LblFechaInicial";
            this.LblFechaInicial.Size = new System.Drawing.Size(106, 16);
            this.LblFechaInicial.TabIndex = 116;
            this.LblFechaInicial.Text = "* Fecha Inicial:";
            // 
            // DatagrivVistaEmpleado
            // 
            this.DatagrivVistaEmpleado.AllowUserToAddRows = false;
            this.DatagrivVistaEmpleado.AllowUserToDeleteRows = false;
            this.DatagrivVistaEmpleado.AutoGenerateColumns = false;
            this.DatagrivVistaEmpleado.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.DatagrivVistaEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagrivVistaEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cédulaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.teléfonoDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.DatagrivVistaEmpleado.DataSource = this.vistaEmpleadoBindingSource1;
            this.DatagrivVistaEmpleado.Location = new System.Drawing.Point(25, 90);
            this.DatagrivVistaEmpleado.Name = "DatagrivVistaEmpleado";
            this.DatagrivVistaEmpleado.ReadOnly = true;
            this.DatagrivVistaEmpleado.Size = new System.Drawing.Size(741, 386);
            this.DatagrivVistaEmpleado.TabIndex = 115;
            // 
            // vistaEmpleadoBindingSource
            // 
            this.vistaEmpleadoBindingSource.DataMember = "VistaEmpleado";
            this.vistaEmpleadoBindingSource.DataSource = this.smartPrintDataSet;
            // 
            // smartPrintDataSet
            // 
            this.smartPrintDataSet.DataSetName = "SmartPrintDataSet";
            this.smartPrintDataSet.EnforceConstraints = false;
            this.smartPrintDataSet.Locale = new System.Globalization.CultureInfo("es-CO");
            this.smartPrintDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaEmpleadoTableAdapter
            // 
            this.vistaEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // vistaEmpleadoBindingSource1
            // 
            this.vistaEmpleadoBindingSource1.DataMember = "VistaEmpleado";
            this.vistaEmpleadoBindingSource1.DataSource = this.smartPrintDataSet;
            // 
            // cédulaDataGridViewTextBoxColumn
            // 
            this.cédulaDataGridViewTextBoxColumn.DataPropertyName = "Cédula";
            this.cédulaDataGridViewTextBoxColumn.HeaderText = "Cédula";
            this.cédulaDataGridViewTextBoxColumn.Name = "cédulaDataGridViewTextBoxColumn";
            this.cédulaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // VistaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(791, 504);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.btnBucar);
            this.Controls.Add(this.DateFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateInicial);
            this.Controls.Add(this.LblFechaInicial);
            this.Controls.Add(this.DatagrivVistaEmpleado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.VistaEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBucar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagrivVistaEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartPrintDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaEmpleadoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.PictureBox btnBucar;
        private System.Windows.Forms.DateTimePicker DateFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateInicial;
        private System.Windows.Forms.Label LblFechaInicial;
        private System.Windows.Forms.DataGridView DatagrivVistaEmpleado;
        private SmartPrintDataSet smartPrintDataSet;
        private System.Windows.Forms.BindingSource vistaEmpleadoBindingSource;
        private SmartPrintDataSetTableAdapters.VistaEmpleadoTableAdapter vistaEmpleadoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cédulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teléfonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vistaEmpleadoBindingSource1;
    }
}