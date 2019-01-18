using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPrint
{
    public partial class MostrarReporteFactura : Form
    {
        public MostrarReporteFactura()
        {
            InitializeComponent();
        }
        public int NumeroFactura { get; set; }
        private void MostrarReporteFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SmartPrintDataSet.SeleccionDian' Puede moverla o quitarla según sea necesario.
            this.SeleccionDianTableAdapter.Fill(this.SmartPrintDataSet.SeleccionDian);
            // TODO: esta línea de código carga datos en la tabla 'SmartPrintDataSet.ReporteFactura' Puede moverla o quitarla según sea necesario.
            this.ReporteFacturaTableAdapter.Fill(this.SmartPrintDataSet.ReporteFactura, NumeroFactura);

            this.reportViewer1.RefreshReport();
        }
    }
}
