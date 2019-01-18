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
    public partial class ReporteGeneralFactura : Form
    {
        public ReporteGeneralFactura()
        {
            InitializeComponent();
        }
        public DateTime Fechainicial { get; set; }
        public DateTime FechaFinal { get; set; }
        private void ReporteGeneralFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SmartPrintDataSet.ReporteGeneralFactura' Puede moverla o quitarla según sea necesario.
            this.ReporteGeneralFacturaTableAdapter.Fill(this.SmartPrintDataSet.ReporteGeneralFactura,Fechainicial,FechaFinal);

            this.reportViewer1.RefreshReport();
        }
    }
}
