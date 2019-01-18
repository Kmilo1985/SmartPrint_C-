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
    public partial class MostrarReporteRemision : Form
    {
        public MostrarReporteRemision()
        {
            InitializeComponent();
        }
        public int NumeroRemision { get; set; }
        public String  Cedula { get; set; }
        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public int Telefono { get; set; }
        public DateTime FechaRemision  { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public String Observaciones { get; set; }
        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SmartPrintDataSet.ReporteRemision' Puede moverla o quitarla según sea necesario.
            this.ReporteRemisionTableAdapter.Fill(this.SmartPrintDataSet.ReporteRemision,NumeroRemision);

            this.reportViewer1.RefreshReport();
        }
    }
}
