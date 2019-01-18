namespace SmartPrint
{
    partial class VistaDian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaDian));
            this.DatagrivVistaCliente = new System.Windows.Forms.DataGridView();
            this.rangoInicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangoFianlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resoluciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaDianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartPrintDataSet = new SmartPrint.SmartPrintDataSet();
            this.vistaDianTableAdapter = new SmartPrint.SmartPrintDataSetTableAdapters.VistaDianTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DatagrivVistaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaDianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartPrintDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DatagrivVistaCliente
            // 
            this.DatagrivVistaCliente.AllowUserToAddRows = false;
            this.DatagrivVistaCliente.AllowUserToDeleteRows = false;
            this.DatagrivVistaCliente.AutoGenerateColumns = false;
            this.DatagrivVistaCliente.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.DatagrivVistaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagrivVistaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rangoInicialDataGridViewTextBoxColumn,
            this.rangoFianlDataGridViewTextBoxColumn,
            this.resoluciónDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.DatagrivVistaCliente.DataSource = this.vistaDianBindingSource;
            this.DatagrivVistaCliente.Location = new System.Drawing.Point(12, 37);
            this.DatagrivVistaCliente.Name = "DatagrivVistaCliente";
            this.DatagrivVistaCliente.ReadOnly = true;
            this.DatagrivVistaCliente.Size = new System.Drawing.Size(642, 372);
            this.DatagrivVistaCliente.TabIndex = 110;
            // 
            // rangoInicialDataGridViewTextBoxColumn
            // 
            this.rangoInicialDataGridViewTextBoxColumn.DataPropertyName = "Rango Inicial";
            this.rangoInicialDataGridViewTextBoxColumn.HeaderText = "Rango Inicial";
            this.rangoInicialDataGridViewTextBoxColumn.Name = "rangoInicialDataGridViewTextBoxColumn";
            this.rangoInicialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rangoFianlDataGridViewTextBoxColumn
            // 
            this.rangoFianlDataGridViewTextBoxColumn.DataPropertyName = "Rango Fianl";
            this.rangoFianlDataGridViewTextBoxColumn.HeaderText = "Rango Fianl";
            this.rangoFianlDataGridViewTextBoxColumn.Name = "rangoFianlDataGridViewTextBoxColumn";
            this.rangoFianlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resoluciónDataGridViewTextBoxColumn
            // 
            this.resoluciónDataGridViewTextBoxColumn.DataPropertyName = "Resolución";
            this.resoluciónDataGridViewTextBoxColumn.HeaderText = "Resolución";
            this.resoluciónDataGridViewTextBoxColumn.Name = "resoluciónDataGridViewTextBoxColumn";
            this.resoluciónDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vistaDianBindingSource
            // 
            this.vistaDianBindingSource.DataMember = "VistaDian";
            this.vistaDianBindingSource.DataSource = this.smartPrintDataSet;
            // 
            // smartPrintDataSet
            // 
            this.smartPrintDataSet.DataSetName = "SmartPrintDataSet";
            this.smartPrintDataSet.EnforceConstraints = false;
            this.smartPrintDataSet.Locale = new System.Globalization.CultureInfo("es-CO");
            this.smartPrintDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaDianTableAdapter
            // 
            this.vistaDianTableAdapter.ClearBeforeFill = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(9, 425);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(272, 13);
            this.label11.TabIndex = 111;
            this.label11.Text = "El número 1 indica que rango está activo en el momento";
            // 
            // VistaDian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(680, 449);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DatagrivVistaCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VistaDian";
            this.Text = "VistaDian";
            this.Load += new System.EventHandler(this.VistaDian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagrivVistaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaDianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartPrintDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatagrivVistaCliente;
        private SmartPrintDataSet smartPrintDataSet;
        private System.Windows.Forms.BindingSource vistaDianBindingSource;
        private SmartPrintDataSetTableAdapters.VistaDianTableAdapter vistaDianTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangoInicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangoFianlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resoluciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label11;
    }
}