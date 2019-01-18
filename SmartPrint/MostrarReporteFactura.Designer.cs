namespace SmartPrint
{
    partial class MostrarReporteFactura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarReporteFactura));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SmartPrintDataSet = new SmartPrint.SmartPrintDataSet();
            this.ReporteFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteFacturaTableAdapter = new SmartPrint.SmartPrintDataSetTableAdapters.ReporteFacturaTableAdapter();
            this.SeleccionDianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SeleccionDianTableAdapter = new SmartPrint.SmartPrintDataSetTableAdapters.SeleccionDianTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SmartPrintDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeleccionDianBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetFactura";
            reportDataSource1.Value = this.ReporteFacturaBindingSource;
            reportDataSource2.Name = "DatasetDian";
            reportDataSource2.Value = this.SeleccionDianBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SmartPrint.ReporteFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(693, 352);
            this.reportViewer1.TabIndex = 0;
            // 
            // SmartPrintDataSet
            // 
            this.SmartPrintDataSet.DataSetName = "SmartPrintDataSet";
            this.SmartPrintDataSet.EnforceConstraints = false;
            this.SmartPrintDataSet.Locale = new System.Globalization.CultureInfo("es-CO");
            this.SmartPrintDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteFacturaBindingSource
            // 
            this.ReporteFacturaBindingSource.DataMember = "ReporteFactura";
            this.ReporteFacturaBindingSource.DataSource = this.SmartPrintDataSet;
            // 
            // ReporteFacturaTableAdapter
            // 
            this.ReporteFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // SeleccionDianBindingSource
            // 
            this.SeleccionDianBindingSource.DataMember = "SeleccionDian";
            this.SeleccionDianBindingSource.DataSource = this.SmartPrintDataSet;
            // 
            // SeleccionDianTableAdapter
            // 
            this.SeleccionDianTableAdapter.ClearBeforeFill = true;
            // 
            // MostrarReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 352);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MostrarReporteFactura";
            this.Text = "ReporteFactura";
            this.Load += new System.EventHandler(this.MostrarReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SmartPrintDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeleccionDianBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteFacturaBindingSource;
        private SmartPrintDataSet SmartPrintDataSet;
        private System.Windows.Forms.BindingSource SeleccionDianBindingSource;
        private SmartPrintDataSetTableAdapters.ReporteFacturaTableAdapter ReporteFacturaTableAdapter;
        private SmartPrintDataSetTableAdapters.SeleccionDianTableAdapter SeleccionDianTableAdapter;
    }
}