namespace SmartPrint
{
    partial class FrmMora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMora));
            this.LblBuscar = new System.Windows.Forms.PictureBox();
            this.LblCc = new System.Windows.Forms.Label();
            this.TxtCc = new System.Windows.Forms.TextBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.GrivMora = new System.Windows.Forms.DataGridView();
            this.numeroFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaMoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smartPrintDataSet = new SmartPrint.SmartPrintDataSet();
            this.vistaMoraTableAdapter = new SmartPrint.SmartPrintDataSetTableAdapters.VistaMoraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LblBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrivMora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaMoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartPrintDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // LblBuscar
            // 
            this.LblBuscar.Image = ((System.Drawing.Image)(resources.GetObject("LblBuscar.Image")));
            this.LblBuscar.Location = new System.Drawing.Point(235, 12);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(24, 23);
            this.LblBuscar.TabIndex = 112;
            this.LblBuscar.TabStop = false;
            this.LblBuscar.Click += new System.EventHandler(this.LblBuscar_Click);
            // 
            // LblCc
            // 
            this.LblCc.AutoSize = true;
            this.LblCc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCc.Location = new System.Drawing.Point(34, 13);
            this.LblCc.Name = "LblCc";
            this.LblCc.Size = new System.Drawing.Size(72, 16);
            this.LblCc.TabIndex = 111;
            this.LblCc.Text = "* C.C/NIT:";
            // 
            // TxtCc
            // 
            this.TxtCc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCc.Location = new System.Drawing.Point(112, 12);
            this.TxtCc.MaxLength = 11;
            this.TxtCc.Name = "TxtCc";
            this.TxtCc.Size = new System.Drawing.Size(117, 23);
            this.TxtCc.TabIndex = 110;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.Image")));
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(341, 12);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(126, 48);
            this.BtnLimpiar.TabIndex = 113;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // GrivMora
            // 
            this.GrivMora.AllowUserToAddRows = false;
            this.GrivMora.AllowUserToDeleteRows = false;
            this.GrivMora.AutoGenerateColumns = false;
            this.GrivMora.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.GrivMora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GrivMora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrivMora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroFacturaDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.GrivMora.DataSource = this.vistaMoraBindingSource;
            this.GrivMora.Location = new System.Drawing.Point(27, 69);
            this.GrivMora.Name = "GrivMora";
            this.GrivMora.ReadOnly = true;
            this.GrivMora.Size = new System.Drawing.Size(440, 344);
            this.GrivMora.TabIndex = 109;
            // 
            // numeroFacturaDataGridViewTextBoxColumn
            // 
            this.numeroFacturaDataGridViewTextBoxColumn.DataPropertyName = "NumeroFactura";
            this.numeroFacturaDataGridViewTextBoxColumn.HeaderText = "NumeroFactura";
            this.numeroFacturaDataGridViewTextBoxColumn.Name = "numeroFacturaDataGridViewTextBoxColumn";
            this.numeroFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vistaMoraBindingSource
            // 
            this.vistaMoraBindingSource.DataMember = "VistaMora";
            this.vistaMoraBindingSource.DataSource = this.smartPrintDataSet;
            // 
            // smartPrintDataSet
            // 
            this.smartPrintDataSet.DataSetName = "SmartPrintDataSet";
            this.smartPrintDataSet.EnforceConstraints = false;
            this.smartPrintDataSet.Locale = new System.Globalization.CultureInfo("es-CO");
            this.smartPrintDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaMoraTableAdapter
            // 
            this.vistaMoraTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(499, 416);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.LblCc);
            this.Controls.Add(this.TxtCc);
            this.Controls.Add(this.GrivMora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMora";
            this.Text = "Mora";
            this.Load += new System.EventHandler(this.FrmMora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LblBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrivMora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaMoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartPrintDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LblBuscar;
        private System.Windows.Forms.Label LblCc;
        private System.Windows.Forms.TextBox TxtCc;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.DataGridView GrivMora;
        private SmartPrintDataSet smartPrintDataSet;
        private System.Windows.Forms.BindingSource vistaMoraBindingSource;
        private SmartPrintDataSetTableAdapters.VistaMoraTableAdapter vistaMoraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}