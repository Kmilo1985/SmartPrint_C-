namespace SmartPrint
{
    partial class MostrarReporteOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarReporteOrden));
            this.ReporteOrdenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SmartPrintDataSet = new SmartPrint.SmartPrintDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReporteOrdenTableAdapter = new SmartPrint.SmartPrintDataSetTableAdapters.ReporteOrdenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteOrdenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmartPrintDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteOrdenBindingSource
            // 
            this.ReporteOrdenBindingSource.DataMember = "ReporteOrden";
            this.ReporteOrdenBindingSource.DataSource = this.SmartPrintDataSet;
            // 
            // SmartPrintDataSet
            // 
            this.SmartPrintDataSet.DataSetName = "SmartPrintDataSet";
            this.SmartPrintDataSet.EnforceConstraints = false;
            this.SmartPrintDataSet.Locale = new System.Globalization.CultureInfo("es-CO");
            this.SmartPrintDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetOrden";
            reportDataSource1.Value = this.ReporteOrdenBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SmartPrint.ReporteOrden.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(700, 307);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteOrdenTableAdapter
            // 
            this.ReporteOrdenTableAdapter.ClearBeforeFill = true;
            // 
            // MostrarReporteOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 307);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MostrarReporteOrden";
            this.Text = "Reporte Orden de Servicio";
            this.Load += new System.EventHandler(this.MostrarReporteOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteOrdenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmartPrintDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteOrdenBindingSource;
        private SmartPrintDataSet SmartPrintDataSet;
        private SmartPrintDataSetTableAdapters.ReporteOrdenTableAdapter ReporteOrdenTableAdapter;
    }
}