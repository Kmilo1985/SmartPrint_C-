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
    public partial class MostrarReporteOrden : Form
    {
        public MostrarReporteOrden()
        {
            InitializeComponent();
        }
        public int NumeroOrden { get; set; }
        private void MostrarReporteOrden_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SmartPrintDataSet.ReporteOrden' Puede moverla o quitarla según sea necesario.
            this.ReporteOrdenTableAdapter.Fill(this.SmartPrintDataSet.ReporteOrden,NumeroOrden);

            this.reportViewer1.RefreshReport();
        }
    }
}
