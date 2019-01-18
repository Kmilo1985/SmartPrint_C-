using System;
using System.Windows.Forms;
using Logica;
using System.Collections.Generic;

namespace SmartPrint
{
    public partial class FrmOrdenServicio : Form
    {
        #region DEclaraciones
        readonly LUtilidades _objUtilidades = new LUtilidades();
        #endregion
        private Dictionary<string, string> perfil;//Se declara un diccionario para pasar el perfil que viene del loguin
        public FrmOrdenServicio(Dictionary<string, string> Perfil)//constructor que le pasamos un diccionario
        {

            InitializeComponent();
            perfil = Perfil;
            int Numeeo = (Int32.Parse(Orden.Mostrarcodigo()) + 1);
            TxtOrdenServ.Text = Numeeo.ToString("D5");
            TxtOrdenServ.Enabled = false;
            Inhabilitar();
            CargarCombox();
            GridViewOrden.ReadOnly = true;//Para que no permita modificar el griv
            TxtRemision.Focus();
        }

        Logica.LOrdenServicio Orden = new LOrdenServicio();//instancia de logica
        //readonly LServicios _servicios = new LServicios();//instancia de servicios
        public void CargarCombox()//Para cargar el combo con los empleados 
        {

            var DOrdenServicio = Orden.ListEmpleados();
            cmbEmpleados.DataSource = DOrdenServicio;
            cmbEmpleados.DisplayMember = "NombreCompleto"; // PARA QUE LO DESPLIEGUE
            cmbEmpleados.ValueMember = "CedulaEmpleado";
            cmbEmpleados.SelectedIndex = -1;

        }
        private void Clear()//Método para limpiar
        {
            TxtRemision.Clear();
            TxtRemision.Enabled = true;
            TxtCc.Clear();
            TxtNombre.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
            TxtObservaciones.Clear();
            TxtTotal.Clear();
            CbxEstado.SelectedItem = (null);
            txtSubtotal.Clear();
            txtIva.Clear();
            DateOrden.ResetText();
            cmbEmpleados.SelectedItem = (null);
            //cmbEmpleados.SelectedText = ("Seleccione...");
            GridViewOrden.DataSource = null;
            TxtRemision.Focus();
        }
        public void Inhabilitar()//Método para inhabilitar
        {

            TxtCc.Enabled = false;
            TxtDireccion.Enabled = false;
            TxtTelefono.Enabled = false;
            TxtTotal.Enabled = false;
            TxtNombre.Enabled = false;
            txtIva.Enabled = false;
            txtSubtotal.Enabled = false;
        }
        public void Buscar()//Método para buscar
        {
            try
            {
                var res = Orden.CargarRemision(Convert.ToInt32(TxtRemision.Text));
                if (res != null)
                {
                    if (res.Rows.Count > 0)
                    {
                        TxtNombre.Text = res.Rows[0][1].ToString();
                        TxtCc.Text = res.Rows[0][0].ToString();
                        TxtDireccion.Text = res.Rows[0][2].ToString();
                        TxtTelefono.Text = res.Rows[0][3].ToString();
                        txtIva.Text = res.Rows[0][5].ToString();
                        txtSubtotal.Text = res.Rows[0][4].ToString();
                        TxtTotal.Text = res.Rows[0][6].ToString();
                        TxtRemision.Enabled = false;
                        GridViewOrden.DataSource = Orden.BuscarServicios(Convert.ToInt32(TxtRemision.Text));

                        foreach (DataGridViewRow dts in GridViewOrden.Rows)
                        {
                            var Codigo = dts.Cells[0].Value;
                            var vrUnitario = dts.Cells[2].Value;
                            var cantidad = dts.Cells[3].Value;
                            var SubTotal = dts.Cells[4].Value;
                            dts.Cells[3].Value = (Convert.ToInt32(vrUnitario) * Convert.ToInt32(cantidad));

                        }

                        GridViewOrden.AllowUserToOrderColumns = false;//Esto para que no me permita mover las columnas

                    }
                    else
                    {
                        MessageBox.Show("El número de Remisión ingresado no existe, favor registrar", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error, intente de nuevo", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        public void Guardar()//Método para guardar 
        {
            TxtObservaciones.Text = TxtObservaciones.Text.Trim();
            var Fecha = DateOrden.Value.DayOfYear- DateTime.Now.DayOfYear;
            if (string.IsNullOrWhiteSpace(TxtCc.Text) || string.IsNullOrWhiteSpace(TxtNombre.Text) || string.IsNullOrWhiteSpace(TxtDireccion.Text)
                                                      || string.IsNullOrWhiteSpace(TxtTelefono.Text) || string.IsNullOrWhiteSpace(DateOrden.Text)
                || cmbEmpleados.SelectedIndex.Equals(-1) || CbxEstado.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Por favor ingrese la información solicitada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (DateTime.Now >= DateOrden.Value)
            {
                MessageBox.Show("No puede ser la fecha de vencimiento menor a la fecha de hoy", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (Fecha>30)
            {
                MessageBox.Show("No puede ingresar una fecha de vencimiento mayor a 30 días", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    Orden = new LOrdenServicio
                    {
                        NumeroOrden = (Convert.ToInt32(TxtOrdenServ.Text)),
                        NumeroRemision = (Convert.ToInt32(TxtRemision.Text)),
                        Cedula = TxtCc.Text,
                        Asignado = cmbEmpleados.SelectedValue.ToString(),
                        FechaOrden = DateOrden.Value,
                        Estado = CbxEstado.SelectedItem.ToString(),
                        Observaciones = TxtObservaciones.Text,
                        Usuario = perfil["Usuario"]
                    };


                    if (MessageBox.Show("¿Seguro que desea Continuar?", "SmartPrint", MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        Orden.GuardarOrden(Orden);
                        MessageBox.Show("Operación exitosa", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        if (MessageBox.Show("¿Desea Generar Informe?", "SmartPrint", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MostrarReporteOrden ReporteOrden = new MostrarReporteOrden();
                            ReporteOrden.NumeroOrden = Convert.ToInt32(TxtOrdenServ.Text);
                            ReporteOrden.ShowDialog();
                            int Numeeo = (Int32.Parse(Orden.Mostrarcodigo()) + 1);
                            TxtOrdenServ.Text = Numeeo.ToString("D5");
                            TxtOrdenServ.Enabled = false;
                        }
                        else
                        {
                            int Numeeo = (Int32.Parse(Orden.Mostrarcodigo()) + 1);
                            TxtOrdenServ.Text = Numeeo.ToString("D5");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Operación cancelada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Excepción no controlada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Dispose();
                }

            }
        }
        private void TxtRemision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Buscar();
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                _objUtilidades.Mensajes("Advertencia", "Solo se permiten números");
                e.Handled = true;
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
            _objUtilidades.Mensajes("Advertencia", "Operaciòn Cancelada");

        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmbEmpleados_Click(object sender, EventArgs e)
        {
            CargarCombox();
        }

        private void cmbEmpleados_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CbxEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        
    }
}
