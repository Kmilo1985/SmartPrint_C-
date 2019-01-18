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
    public partial class FrmRemision : Form
    {
        #region Declaraciones

        readonly LUtilidades _objUtilidades = new LUtilidades();
        private DataTable DTDatos;
        Logica.LOrdenServicio Orden = new LOrdenServicio();//instancia de logica
        #endregion
        private Dictionary<string, string> perfil;//Se declara un diccionario para pasar el perfil que viene del loguin
        public FrmRemision(Dictionary<string, string> Perfil)//constructor que le pasamos un diccionari
        {

            InitializeComponent();
            perfil = Perfil;
            int Numeeo = (Int32.Parse(_remi.MostrarCodigo()) + 1);
            TxtNumero.Text = Numeeo.ToString("D5");
            TxtNumero.Enabled = false;
            Inhabilitar();
            TxtCc.Enabled = true;
            CbxSeleccionServicio.Visible = false;
            txtIva.Enabled = false;
            txtSubtotal.Enabled = false;
            //datatable estable para que me permita en el momento de adicionar un campo, ponerlo debajo del otro si que 
            //me lo sobre escriba
            this.DTDatos = new DataTable();
            this.DTDatos.Columns.Add("Codigo");
            this.DTDatos.Columns.Add("Nombre");
            this.DTDatos.Columns.Add("VrUnitario");
            this.DTDatos.Columns.Add("Cantidad");
            this.DTDatos.Columns.Add("Subtotal");
        }
        public void Clear()//Método para limpiar
        {

            TxtObservaciones.Clear();
            TxtCc.Clear();
            TxtCc.Enabled = true;
            TxtNombre.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
            CbxSeleccionServicio.Visible = false;
            GridViewRemision.DataSource = null;
            TxtTotal.Clear();
            txtIva.Clear();
            txtSubtotal.Clear();
            DTDatos.Clear();
            btnBuscarREmision.Visible = true;
            int Numeeo = (Int32.Parse(_remi.MostrarCodigo()) + 1);
            TxtNumero.Text = Numeeo.ToString("D5");
            TxtNumero.Enabled = false;

        }
        public void InhabilitarGriv()//Método para que no deje mover las columnas del Griv
        {

            GridViewRemision.Columns["Codigo"].ReadOnly = true;
            GridViewRemision.Columns["Nombre"].ReadOnly = true;
            GridViewRemision.Columns["VrUnitario"].ReadOnly = true;
            GridViewRemision.Columns["Subtotal"].ReadOnly = true;
        }
        public void Inhabilitar()//Método para inhabilitar
        {
            TxtCc.Enabled = (false);
            TxtNombre.Enabled = false;
            TxtDireccion.Enabled = (false);
            TxtTelefono.Enabled = (false);
            TxtNumero.Enabled = false;
            TxtTotal.Enabled = false;
        }
        LRemision _remi = new LRemision();
        public void Buscar()
        {
            try
            {
                _remi = new LRemision { Cedula = (TxtCc.Text) };
                var res = _remi.BuscarCedula(_remi);

                if (res != null)
                {
                    if (res.Rows.Count > 0)
                    {
                        Inhabilitar();
                        CbxSeleccionServicio.Visible = true;
                        CbxSeleccionServicio.Enabled = true;
                        TxtNombre.Text = res.Rows[0][1].ToString();
                        TxtDireccion.Text = res.Rows[0][2].ToString();
                        TxtTelefono.Text = res.Rows[0][3].ToString();
                        TxtObservaciones.Text = res.Rows[0][4].ToString();
                    }
                    else
                    {
                        MessageBox.Show("El número de cédula ingresado no existe, por favor registralo", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxtCc.Clear();
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Excepción no controlada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


        }
        public void BuscarRemision()//Método para buscar
        {
            try
            {
                var res = Orden.BuscarRemision(Convert.ToInt32(TxtNumero.Text));
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
                        CbxSeleccionServicio.Visible = true;
                        CbxSeleccionServicio.Enabled = true;
                        TxtNumero.Enabled = false;
                        GridViewRemision.DataSource = Orden.BuscarServicios(Convert.ToInt32(TxtNumero.Text));

                        foreach (DataGridViewRow dts in GridViewRemision.Rows)
                        {
                            var vrUnitario = dts.Cells[2].Value;
                            var cantidad = dts.Cells[3].Value;
                            dts.Cells[4].Value = (Convert.ToInt32(vrUnitario) * Convert.ToInt32(cantidad));

                        }

                        GridViewRemision.AllowUserToOrderColumns = false;//Esto para que no me permita mover las columnas
                        int indiceUltimaFila = GridViewRemision.Rows.Count - 1;
                        GridViewRemision.Rows[indiceUltimaFila].Selected = true;

                    }


                }
                else
                {
                    MessageBox.Show("El número de Remisión ingresado no existe, favor registrar", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtNombre.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El número de Remisión ingresado no existe, O ya hace parte de una factura y por esto no es posible ser modificada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                TxtNombre.Clear();
            }


        }
        public void Guardar()
        {
            TxtObservaciones.Text = TxtObservaciones.Text.Trim();
            var Total = TxtTotal.Text;
            var Fecha = DateVencimiento.Value.DayOfYear - DateTime.Now.DayOfYear;
            if (string.IsNullOrWhiteSpace(TxtCc.Text) || string.IsNullOrWhiteSpace(TxtNombre.Text) || string.IsNullOrWhiteSpace(TxtDireccion.Text)
               || string.IsNullOrWhiteSpace(TxtTotal.Text) || string.IsNullOrWhiteSpace(TxtTelefono.Text) || string.IsNullOrWhiteSpace(DateVencimiento.Text) || Convert.ToInt32(Total) <= 0 || GridViewRemision == null)
            {
                MessageBox.Show("Por favor ingrese la información solicitada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (DateTime.Now > DateVencimiento.Value)
            {
                MessageBox.Show("No puede ser la fecha de vencimiento menor a la fecha de hoy", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (Fecha > 30)
            {
                MessageBox.Show("No puede ingresar una fecha de vencimiento mayor a 30 días", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    _remi.NumeroRemision = Convert.ToInt32(TxtNumero.Text);
                    _remi.Cedula = TxtCc.Text;
                    _remi.FechaVencimiento = Convert.ToDateTime(DateVencimiento.Text);
                    _remi.Observaciones = TxtObservaciones.Text;
                    _remi.SubTotal = Convert.ToInt32(txtSubtotal.Text);
                    _remi.Iva = Convert.ToInt32(txtIva.Text);
                    _remi.Total = Convert.ToInt32(TxtTotal.Text);
                    _remi.Usuario = perfil["Usuario"];



                    if (MessageBox.Show("¿Seguro que desea Continuar?", "SmartPrint", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _remi.GuardarRemision(_remi);
                        var contador = GridViewRemision.Rows.Count;
                        var i = 0;
                        foreach (DataGridViewRow dts in GridViewRemision.Rows)
                        {
                            if (i <= (contador - 1))
                            {

                                _remi.CodigoServicio = Convert.ToInt32(dts.Cells[0].Value);
                                _remi.Cantidad = Convert.ToInt32(dts.Cells[3].Value);
                                _remi.ValorUnitario = Convert.ToInt32(dts.Cells[2].Value);
                                _remi.ValorTotal = Convert.ToInt32(dts.Cells[4].Value);
                                _remi.Nombre = (dts.Cells[1].Value).ToString();
                                _remi.GuardarRemisionServicios(_remi);
                                i++;

                            }
                        }

                        MessageBox.Show("Operación Exitosa", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (MessageBox.Show("¿Desea Generar Informe?", "SmartPrint", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MostrarReporteRemision ReporteRemision = new MostrarReporteRemision();
                            ReporteRemision.NumeroRemision = Convert.ToInt32(TxtNumero.Text);
                            ReporteRemision.ShowDialog();
                            Clear();
                        }
                        else
                        {
                            Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Operación cancelada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Excepción no controlada" + e, "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Dispose();

                }
            }
        }
        private void TxtCc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Buscar();
            }
            if (char.IsDigit(e.KeyChar))
            {
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
        private void CbxSeleccionServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxSeleccionServicio.SelectedItem.Equals("Servicio"))
            {
                var servicios = new FrmServicios(perfil) { BtnAgregar = { Visible = true }, BtnGuardar = { Visible = false }, BtnModificar = { Visible = false }, BtnCancelarSer = { Visible = true } };//oculto y hago visibles los botones que necesito        
                servicios.ShowDialog();
                try
                {
                    if (servicios.TablaSeleccionada.Rows.Count != 0)
                    {

                        // para que me acomode los datos que vienen de la otra tabla
                        foreach (DataRow Dato in servicios.TablaSeleccionada.Rows)
                        {
                            var dr = DTDatos.NewRow();
                            dr["Codigo"] = Dato["Codigo"].ToString();
                            dr["Nombre"] = Dato["Nombre"].ToString();
                            dr["VrUnitario"] = Dato["VrUnitario"].ToString();
                            dr["Cantidad"] = Dato["Cantidad"].ToString();
                            dr["Subtotal"] = Dato["Subtotal"].ToString();
                            this.DTDatos.Rows.Add(dr);
                            GridViewRemision.DataSource = DTDatos;
                            GridViewRemision.ClearSelection();
                            int indiceUltimaFila = GridViewRemision.Rows.Count - 1;
                            GridViewRemision.Rows[indiceUltimaFila].Selected = true;
                            GridViewRemision.Refresh();


                            foreach (DataGridViewRow dts in GridViewRemision.Rows)
                            {
                                var Codigo = dts.Cells[0].Value;
                                bool exist = GridViewRemision.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(Codigo) == dr["Codigo"].ToString());

                                if (exist)
                                {
                                    if (dts.Index == indiceUltimaFila)
                                    {


                                    }
                                    else
                                    {
                                        GridViewRemision.Rows.RemoveAt(indiceUltimaFila);   //eliminar la última fila
                                        MessageBox.Show("El Servicio ya existe", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                    }


                                }
                                else
                                {


                                }
                            }
                            InhabilitarGriv();//Metodo para que no me permita editar, ni borrar datos del griv.
                            GridViewRemision.AllowUserToOrderColumns = false;//Esto para que no me permita mover las columnas
                            Calcular();

                        }
                    }
                }
                catch (Exception)
                {
                    _objUtilidades.Mensajes("Error", "No Selecciono un Servicio ");

                }

            }
            else
            {
                var otrosServicios = new FrmOtrosServicios(perfil) { BtnAgregar = { Visible = true }, BtnGuardar = { Visible = false }, BtnModificar = { Visible = false }, BtnCancelarSer = { Visible = true } };
                otrosServicios.ShowDialog();

                if (otrosServicios.TablaSeleccionada.Rows.Count != 0)
                {

                    foreach (DataRow Dato in otrosServicios.TablaSeleccionada.Rows)
                    {

                        var dr = DTDatos.NewRow();
                        dr["Codigo"] = Dato["Codigo"].ToString();
                        dr["Nombre"] = Dato["Nombre"].ToString();
                        dr["VrUnitario"] = Dato["VrUnitario"].ToString();
                        dr["Cantidad"] = Dato["Cantidad"].ToString();
                        dr["Subtotal"] = Dato["Subtotal"].ToString();
                        this.DTDatos.Rows.Add(dr);
                        GridViewRemision.DataSource = DTDatos;
                        GridViewRemision.ClearSelection();
                        int indiceUltimaFila = GridViewRemision.Rows.Count - 1;
                        GridViewRemision.Rows[indiceUltimaFila].Selected = true;
                        foreach (DataGridViewRow dts in GridViewRemision.Rows)
                        {
                            var Codigo = dts.Cells[0].Value;
                            bool exist = GridViewRemision.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(Codigo) == dr["Codigo"].ToString());

                            if (exist)
                            {
                                if (dts.Index == indiceUltimaFila)
                                {


                                }
                                else
                                {
                                    GridViewRemision.Rows.RemoveAt(indiceUltimaFila);   //Para eliminar la fila
                                    MessageBox.Show("El Servicio ya existe", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }


                            }
                            else
                            {


                            }
                        }

                    }

                    InhabilitarGriv();//Metodo para que no me permita editar, ni borrar datos del griv.
                    GridViewRemision.AllowUserToOrderColumns = false;//Esto para que no me permita mover las columnas
                    Calcular();
                }
            }
        }
        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            Clear();
        }
        public void Calcular()
        {
            try
            {
                var Iva = 0;
                var total = 0;
                foreach (DataGridViewRow dts in GridViewRemision.Rows)
                {

                    var vrUnitario = dts.Cells[2].Value;
                    var cantidad = dts.Cells[3].Value;

                    if (Convert.ToInt32(cantidad) > 0)
                    {

                        total += (Convert.ToInt32(vrUnitario) * Convert.ToInt32(cantidad));
                        dts.Cells[4].Value = (Convert.ToInt32(vrUnitario) * Convert.ToInt32(cantidad)).ToString();
                        Iva = (Convert.ToInt32(total) * Convert.ToInt32(16) / 100);
                        txtSubtotal.Text = total.ToString();
                        txtIva.Text = Iva.ToString();
                        TxtTotal.Text = (total + Iva).ToString();

                    }
                    else if (cantidad == null)
                    {
                        txtIva.Clear();
                        TxtTotal.Clear();
                        txtSubtotal.Clear();
                        dts.Cells[3].ErrorText = "";
                        break;
                    }
                    else
                    {
                        MessageBox.Show("La cantidad no puede ser igual a 0", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtIva.Clear();
                        TxtTotal.Clear();
                        txtSubtotal.Clear();
                        break;
                    }

                }


            }
            catch (Exception)
            {

                MessageBox.Show("Datos errados", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIva.Clear();
                TxtTotal.Clear();
                txtSubtotal.Clear();



            }


        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
            _objUtilidades.Mensajes("Advertencia", "Operaciòn Cancelada");
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void CbxSeleccionServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void GridViewRemision_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Calcular();
        }

        private void btnBuscarREmision_Click(object sender, EventArgs e)
        {
            Clear();
            TxtNumero.Clear();
            TxtNumero.Enabled = true;
            TxtCc.Enabled = false;
            
            btnBuscarREmision.Visible = false;

        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BuscarRemision();

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

        private void TxtNumero_Leave(object sender, EventArgs e)
        {
            BuscarRemision();
        }

        private void GridViewRemision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Delete))
            {
                txtIva.Clear();
                TxtTotal.Clear();
                txtSubtotal.Clear();
                Calcular();
            }
        }

        private void GridViewRemision_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Delete))
            {
                if (GridViewRemision != null)
                {
                    foreach (DataGridViewRow dts in GridViewRemision.Rows)
                    {
                    dts.Cells[2].Value.Equals(null);
                    txtIva.Clear();
                    TxtTotal.Clear();
                    txtSubtotal.Clear();

                      
                    }

                   
                }
                
            }
        }

    }
}
