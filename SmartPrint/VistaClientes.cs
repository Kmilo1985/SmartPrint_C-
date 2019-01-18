using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace SmartPrint
{
    public partial class VistaClientes : Form
    {
        Logica.LClientes _clien = new Logica.LClientes(); 
        public VistaClientes()
        {
            InitializeComponent();
        }
       
     
        private void VistaClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'smartPrintDataSet.VistaCliente' Puede moverla o quitarla según sea necesario.
            this.vistaClienteTableAdapter.Fill(this.smartPrintDataSet.VistaCliente);

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            DatagrivVistaCliente.DataSource = (this.smartPrintDataSet.VistaCliente);
            DateInicial.ResetText();
            DateFinal.ResetText();
            TxtNombre.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            
                DatagrivVistaCliente.DataSource = _clien.BuscarCliente(DateInicial.Value, DateFinal.Value);
                     
            
          }
        public void BuscarNombre() {

            _clien = new LClientes { Nombre = (TxtNombre.Text) };
            var res = _clien.BuscarNombre(_clien);

            if (res == null) return;
            DatagrivVistaCliente.DataSource = res;

           
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
             if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BuscarNombre();
                //DatagrivVistaCliente.DataSource = _clien.BuscarNombre(TxtNombre.Text);
                
            }
        }
    }
}
