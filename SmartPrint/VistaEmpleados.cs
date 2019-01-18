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
    public partial class VistaEmpleados : Form
    {
        public VistaEmpleados()
        {
            InitializeComponent();
        }

        private void VistaEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'smartPrintDataSet.VistaEmpleado' Puede moverla o quitarla según sea necesario.
            this.vistaEmpleadoTableAdapter.Fill(this.smartPrintDataSet.VistaEmpleado);

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            DatagrivVistaEmpleado.DataSource = (this.smartPrintDataSet.VistaEmpleado);
            DateInicial.ResetText();
            DateFinal.ResetText();
        }

        private void btnBucar_Click(object sender, EventArgs e)
        {
            Logica.LEmpleados _emp = new Logica.LEmpleados();
            DatagrivVistaEmpleado.DataSource = _emp.BuscarEmpleado(DateInicial.Value, DateFinal.Value);
        }
    }
}
