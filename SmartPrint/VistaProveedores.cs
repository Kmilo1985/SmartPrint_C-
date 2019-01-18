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
    public partial class VistaProveedore : Form
    {
        public VistaProveedore()
        {
            InitializeComponent();
        }
        Logica.LProveedor prove = new Logica.LProveedor();
        private void VistaProveedore_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'smartPrintDataSet.vistaproveedor' Puede moverla o quitarla según sea necesario.
            this.vistaproveedorTableAdapter.Fill(this.smartPrintDataSet.vistaproveedor);

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            DatagrivVistaProveedor.DataSource = (this.smartPrintDataSet.vistaproveedor);
            DateInicial.ResetText();
            DateFinal.ResetText();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DatagrivVistaProveedor.DataSource = prove.BuscarProveedor(DateInicial.Value, DateFinal.Value);
        }
    }
}
