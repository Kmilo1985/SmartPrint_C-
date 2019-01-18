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
    public partial class FrmConsultas : Form
    {
        public FrmConsultas()
        {
            InitializeComponent();
            GridViewFactura.ReadOnly = true;//Esto para que no me permita editar las columnas
            GridViewOS.ReadOnly = true;//Esto para que no me permita editar las columnas
            GridViewRemision.ReadOnly = true;
            //MostrarMora();
        }
        Logica.LConsultas Consulta = new Logica.LConsultas();//intancia de logica

        public void Clear()//Método para limpiar
        {
            TxtCc.Clear();
            TxtNombre.Clear();
            TxtNumero.Clear();
            cmbNumero.SelectedItem = null;
            GridViewRemision.DataSource = null;
            GridViewOS.DataSource = null;
            GridViewFactura.DataSource = null;
            DateInicial.ResetText();
            DateFinal.ResetText();
            cmbReporte.SelectedItem = null;
        }
        public void Buscar()//Método para buscar
        {
            try
            {
                Consulta = new Logica.LConsultas();
                Consulta.Cedula = (TxtCc.Text);
                DataTable res = Consulta.Buscar(Consulta);
                if (res != null)
                {
                    TxtNombre.Text = res.Rows[0][1].ToString();
                    if (res.Rows.Count > 0)
                    {

                        GridViewFactura.DataSource = Consulta.BuscarFactura((TxtCc.Text), DateInicial.Value, DateFinal.Value);
                        GridViewOS.DataSource = Consulta.BuscarOrden((TxtCc.Text), DateInicial.Value, DateFinal.Value);
                        GridViewRemision.DataSource = Consulta.BuscarRemision((TxtCc.Text), DateInicial.Value, DateFinal.Value);
                        GridViewFactura.AllowUserToOrderColumns = false;//Esto para que no me permita mover las columnas
                        GridViewOS.AllowUserToOrderColumns = false;//Esto para que no me permita mover las columnas
                        GridViewRemision.AllowUserToOrderColumns = false;

                    }
                }
                else
                {

                    MessageBox.Show("No hay nada que coincida con la busquedad", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("La cédula ingresada no existe ", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        //public void MostrarMora()
        //{
        //    var dMora = Consulta.MostrarMora();
        //    GrivMora.DataSource = dMora;
        //}   
        private void LblBuscar_Click_1(object sender, EventArgs e)
        {
            Buscar();
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void cmbNumero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNumero.SelectedItem != null)
            {
                if (cmbNumero.SelectedItem.Equals("Remision"))
                {
                    MostrarReporteRemision ReporteRemision = new MostrarReporteRemision();
                    ReporteRemision.NumeroRemision = Convert.ToInt32(TxtNumero.Text);
                    ReporteRemision.ShowDialog();
                }
                else if (cmbNumero.SelectedItem.Equals("Factura"))
                {

                    MostrarReporteFactura ReporteFactura = new MostrarReporteFactura();
                    ReporteFactura.NumeroFactura = Convert.ToInt32(TxtNumero.Text);
                    ReporteFactura.ShowDialog();

                }
                else
                {

                    MostrarReporteOrden ReporteOrden = new MostrarReporteOrden();
                    ReporteOrden.NumeroOrden = Convert.ToInt32(TxtNumero.Text);
                    ReporteOrden.ShowDialog();

                }
            }

            Clear();
        }
        private void cmbReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReporte.SelectedItem != null)
            {
                if (cmbReporte.SelectedItem.Equals("Remision"))
                {
                    MostrarReporteGeneralRemision ReporteRemision = new MostrarReporteGeneralRemision();
                    ReporteRemision.Fechainicial = Convert.ToDateTime(DateInicial.Text);
                    ReporteRemision.FechaFinal = Convert.ToDateTime(DateFinal.Text);
                    ReporteRemision.ShowDialog();
                }
                else if (cmbReporte.SelectedItem.Equals("Factura"))
                {

                    ReporteGeneralFactura ReporteFactura = new ReporteGeneralFactura();
                    ReporteFactura.Fechainicial = Convert.ToDateTime(DateInicial.Text);
                    ReporteFactura.FechaFinal = Convert.ToDateTime(DateFinal.Text);
                    ReporteFactura.ShowDialog();
                }
                else
                {

                    MostrarReporteGeneralOrden ReporteOrden = new MostrarReporteGeneralOrden();
                    ReporteOrden.Fechainicial = Convert.ToDateTime(DateInicial.Text);
                    ReporteOrden.FechaFinal = Convert.ToDateTime(DateFinal.Text);
                    ReporteOrden.ShowDialog();

                }
            }

            Clear();
        }
        private void TxtCc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Buscar();
            }
        }

        private void cmbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbReporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'smartPrintDataSet.VistaMora' Puede moverla o quitarla según sea necesario.
            this.vistaMoraTableAdapter.Fill(this.smartPrintDataSet.VistaMora);

        }

        private void btnMora_Click(object sender, EventArgs e)
        {
            FrmMora Mora = new FrmMora();
            Mora.ShowDialog();
        }
    }
}
