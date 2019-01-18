namespace SmartPrint
{
    partial class ReporteGeneralFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteGeneralFactura));
            this.ReporteGeneralFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SmartPrintDataSet = new SmartPrint.SmartPrintDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReporteGeneralFacturaTableAdapter = new SmartPrint.SmartPrintDataSetTableAdapters.ReporteGeneralFacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteGeneralFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmartPrintDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteGeneralFacturaBindingSource
            // 
            this.ReporteGeneralFacturaBindingSource.DataMember = "ReporteGeneralFactura";
            this.ReporteGeneralFacturaBindingSource.DataSource = this.SmartPrintDataSet;
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
            reportDataSource1.Name = "GeneralFactura";
            reportDataSource1.Value = this.ReporteGeneralFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SmartPrint.ReporteGeneralFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(766, 319);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteGeneralFacturaTableAdapter
            // 
            this.ReporteGeneralFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteGeneralFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 319);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteGeneralFactura";
            this.Text = "ReporteGeneralFactura";
            this.Load += new System.EventHandler(this.ReporteGeneralFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteGeneralFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmartPrintDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteGeneralFacturaBindingSource;
        private SmartPrintDataSet SmartPrintDataSet;
        private SmartPrintDataSetTableAdapters.ReporteGeneralFacturaTableAdapter ReporteGeneralFacturaTableAdapter;
    }
}