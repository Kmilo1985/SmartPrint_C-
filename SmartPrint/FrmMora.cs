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
    public partial class FrmMora : Form
    {
        public FrmMora()
        {
            InitializeComponent();
        }

        private void FrmMora_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'smartPrintDataSet.VistaMora' Puede moverla o quitarla según sea necesario.
            this.vistaMoraTableAdapter.Fill(this.smartPrintDataSet.VistaMora);
            
           
        }
        Logica.LConsultas Consulta = new Logica.LConsultas();//intancia de logica
        private void LblBuscar_Click(object sender, EventArgs e)
        {
            
                Consulta = new Logica.LConsultas();
                Consulta.Cedula = (TxtCc.Text);
                DataTable res = Consulta.BuscarMora(Consulta);
                if (res != null)
                {
                    if (res.Rows.Count > 0)
                    {
                        GrivMora.DataSource = res;
                    }
                    else {
                        MessageBox.Show("No hay nada que coincida con la busquedad", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {

                    MessageBox.Show("No hay nada que coincida con la busquedad", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            GrivMora.DataSource = null;
            TxtCc.Clear();
            GrivMora.DataSource = (this.smartPrintDataSet.VistaMora);

        }
    }
}
