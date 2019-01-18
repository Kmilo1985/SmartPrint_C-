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
    public partial class MostrarReporteGeneralRemision : Form
    {
        public MostrarReporteGeneralRemision()
        {
            InitializeComponent();
        }
        public DateTime Fechainicial { get; set; }
        public DateTime FechaFinal { get; set; }
        private void MostrarReporteGeneralRemision_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SmartPrintDataSet.ReporteGeneralRemision' Puede moverla o quitarla según sea necesario.
            this.ReporteGeneralRemisionTableAdapter.Fill(this.SmartPrintDataSet.ReporteGeneralRemision, Fechainicial, FechaFinal);

            this.reportViewer1.RefreshReport();
        }
    }
}
