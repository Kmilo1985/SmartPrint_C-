namespace SmartPrint
{
    partial class VistaProveedore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaProveedore));
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.DateFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DateInicial = new System.Windows.Forms.DateTimePicker();
            this.LblFechaInicial = new System.Windows.Forms.Label();
            this.DatagrivVistaProveedor = new System.Windows.Forms.DataGridView();
            this.nitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razónSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teléfonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaproveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartPrintDataSet = new SmartPrint.SmartPrintDataSet();
            this.vistaproveedorTableAdapter = new SmartPrint.SmartPrintDataSetTableAdapters.vistaproveedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagrivVistaProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaproveedorBindingSource)).BeginInit();
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
            this.BtnLimpiar.Location = new System.Drawing.Point(611, 34);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(126, 48);
            this.BtnLimpiar.TabIndex = 121;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(580, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 23);
            this.btnBuscar.TabIndex = 120;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // DateFinal
            // 
            this.DateFinal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFinal.Location = new System.Drawing.Point(457, 45);
            this.DateFinal.Name = "DateFinal";
            this.DateFinal.Size = new System.Drawing.Size(117, 23);
            this.DateFinal.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 118;
            this.label1.Text = "* Fecha Final:";
            // 
            // DateInicial
            // 
            this.DateInicial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateInicial.Location = new System.Drawing.Point(165, 44);
            this.DateInicial.Name = "DateInicial";
            this.DateInicial.Size = new System.Drawing.Size(117, 23);
            this.DateInicial.TabIndex = 117;
            // 
            // LblFechaInicial
            // 
            this.LblFechaInicial.AutoSize = true;
            this.LblFechaInicial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaInicial.Location = new System.Drawing.Point(53, 45);
            this.LblFechaInicial.Name = "LblFechaInicial";
            this.LblFechaInicial.Size = new System.Drawing.Size(106, 16);
            this.LblFechaInicial.TabIndex = 116;
            this.LblFechaInicial.Text = "* Fecha Inicial:";
            // 
            // DatagrivVistaProveedor
            // 
            this.DatagrivVistaProveedor.AllowUserToAddRows = false;
            this.DatagrivVistaProveedor.AllowUserToDeleteRows = false;
            this.DatagrivVistaProveedor.AutoGenerateColumns = false;
            this.DatagrivVistaProveedor.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.DatagrivVistaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagrivVistaProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nitDataGridViewTextBoxColumn,
            this.razónSocialDataGridViewTextBoxColumn,
            this.contactoDataGridViewTextBoxColumn,
            this.teléfonoDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.DatagrivVistaProveedor.DataSource = this.vistaproveedorBindingSource;
            this.DatagrivVistaProveedor.Location = new System.Drawing.Point(53, 95);
            this.DatagrivVistaProveedor.Name = "DatagrivVistaProveedor";
            this.DatagrivVistaProveedor.ReadOnly = true;
            this.DatagrivVistaProveedor.Size = new System.Drawing.Size(644, 375);
            this.DatagrivVistaProveedor.TabIndex = 115;
            // 
            // nitDataGridViewTextBoxColumn
            // 
            this.nitDataGridViewTextBoxColumn.DataPropertyName = "Nit";
            this.nitDataGridViewTextBoxColumn.HeaderText = "Nit";
            this.nitDataGridViewTextBoxColumn.Name = "nitDataGridViewTextBoxColumn";
            this.nitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razónSocialDataGridViewTextBoxColumn
            // 
            this.razónSocialDataGridViewTextBoxColumn.DataPropertyName = "Razón social";
            this.razónSocialDataGridViewTextBoxColumn.HeaderText = "Razón social";
            this.razónSocialDataGridViewTextBoxColumn.Name = "razónSocialDataGridViewTextBoxColumn";
            this.razónSocialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactoDataGridViewTextBoxColumn
            // 
            this.contactoDataGridViewTextBoxColumn.DataPropertyName = "Contacto";
            this.contactoDataGridViewTextBoxColumn.HeaderText = "Contacto";
            this.contactoDataGridViewTextBoxColumn.Name = "contactoDataGridViewTextBoxColumn";
            this.contactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teléfonoDataGridViewTextBoxColumn
            // 
            this.teléfonoDataGridViewTextBoxColumn.DataPropertyName = "Teléfono";
            this.teléfonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.teléfonoDataGridViewTextBoxColumn.Name = "teléfonoDataGridViewTextBoxColumn";
            this.teléfonoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // vistaproveedorBindingSource
            // 
            this.vistaproveedorBindingSource.DataMember = "vistaproveedor";
            this.vistaproveedorBindingSource.DataSource = this.smartPrintDataSet;
            // 
            // smartPrintDataSet
            // 
            this.smartPrintDataSet.DataSetName = "SmartPrintDataSet";
            this.smartPrintDataSet.Locale = new System.Globalization.CultureInfo("es-CO");
            this.smartPrintDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaproveedorTableAdapter
            // 
            this.vistaproveedorTableAdapter.ClearBeforeFill = true;
            // 
            // VistaProveedore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(791, 504);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.DateFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateInicial);
            this.Controls.Add(this.LblFechaInicial);
            this.Controls.Add(this.DatagrivVistaProveedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaProveedore";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.VistaProveedore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagrivVistaProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaproveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartPrintDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.DateTimePicker DateFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateInicial;
        private System.Windows.Forms.Label LblFechaInicial;
        private System.Windows.Forms.DataGridView DatagrivVistaProveedor;
        private SmartPrintDataSet smartPrintDataSet;
        private System.Windows.Forms.BindingSource vistaproveedorBindingSource;
        private SmartPrintDataSetTableAdapters.vistaproveedorTableAdapter vistaproveedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razónSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teléfonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
    }
}