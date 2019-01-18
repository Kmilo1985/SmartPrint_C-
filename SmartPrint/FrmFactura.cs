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
    public partial class FrmFactura : Form

    {
        Logica.LUtilidades _objUtilidades = new Logica.LUtilidades();
        Logica.LFactura Factura = new Logica.LFactura();//instancia de logica
        Logica.LDian _Dian = new Logica.LDian();//instancia de la Dian
        private DataTable DTDatos;
        string NumeroRemision;

        private Dictionary<string, string> perfil;//Se declara un diccionario para pasar el perfil que viene del loguin
        public FrmFactura(Dictionary<string, string> Perfil)//constructor que le pasamos un diccionario
        {
            InitializeComponent();
            perfil = Perfil;
            MostrarCodigo();
            TxtFactura.Enabled = false;
            Inhabilitar();
            GridViewFactura.AllowUserToOrderColumns = false;
            GridViewFactura.ReadOnly = true;
            TxtOrden.Focus();
            TxtImpuesto.Visible = false;
           

            this.DTDatos = new DataTable();

            this.DTDatos.Columns.Add("Item");
            this.DTDatos.Columns.Add("Cantidad");
            this.DTDatos.Columns.Add("VrUnitario");
            this.DTDatos.Columns.Add("ValorTotal");
            this.DTDatos.Columns.Add("Impuestos");
            this.DTDatos.Columns.Add("Iva");
            this.DTDatos.Columns.Add("Descuentos");
        }
        public void MostrarCodigo()//Método para mostrar el último codigo 
        {
            try
            {
                var Aux = Factura.Mostrarcodigo().Rows[0][1];
                if (Aux != null & Convert.ToInt32(Aux) >= 0)
                {
                    int Numeeo = Convert.ToInt32(Aux) + 1;
                    TxtFactura.Text = Numeeo.ToString("D5");
                    Alerta();
                }
                else
                {
                    MessageBox.Show("El código supera el rango establecido, por favor actualice el rango de la Dian", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    TxtFactura.Clear();
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("El código supera el rango establecido, por favor actualice el rango de la Dian", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //TxtFactura.Clear();
     
            }
        }
        public void Alerta()//método para alertar cuando falte poco para terminar la Dian
        {
            var Aux = Factura.Mostrarcodigo().Rows[0][1];
            int Numeeo = Convert.ToInt32(Aux) + 1;
            var Aux2 = _Dian.Mostrar().Rows[0][1];
            int Numeeo2 = Convert.ToInt32(Aux2);
            int Resta = Numeeo2 - Numeeo;
            if (Resta <= 50)
            {

                MessageBox.Show(" Su rango está por cadudar, códigos faltantes " + Resta.ToString("D5"), "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void Clear()//Método para limpiar
        {
            TxtOrden.Clear();
            TxtOrden.Enabled = true;
            TxtCc.Clear();
            TxtNombre.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
            TxtObservaciones.Clear();
            TxtTotal.Clear();
            TxtFactura.Clear();
            CbxEstado.SelectedItem = (null);
            DateVencimiento.ResetText();
            DateVencimiento.Enabled = true;
            CbxEstado.Enabled = true;
            GridViewFactura.DataSource = null;
            TxtIva.Clear();
            TxtImpuesto.Clear();
            TxtDescuento.Clear();
            txtSubtotal.Clear();
            cbmPago.SelectedItem = null;
            CkbActivo.Visible = false;
            BtnBuscar.Visible = true;
            MostrarCodigo();
            TxtOrden.Focus();


        }
        public void Inhabilitar()//Método para inhabilitar
        {
            TxtCc.Enabled = false;
            TxtDireccion.Enabled = false;
            TxtTelefono.Enabled = false;
            TxtTotal.Enabled = false;
            TxtNombre.Enabled = false;
            TxtIva.Enabled = false;
            txtSubtotal.Enabled = false;
            TxtImpuesto.Enabled = false;
            //TxtDescuento.Enabled = false;
            CkbActivo.Visible=false;

        }
        public void Buscar()//método para buscar
        {
            try
            {
                var res = Factura.CargarOrden(Convert.ToInt32(TxtOrden.Text));
                if (res != null)
                {
                    if (res.Rows.Count > 0)
                    {

                        TxtNombre.Text = res.Rows[0][1].ToString();
                        TxtCc.Text = res.Rows[0][0].ToString();
                        TxtDireccion.Text = res.Rows[0][2].ToString();
                        TxtTelefono.Text = res.Rows[0][3].ToString();
                        CbxEstado.SelectedItem = res.Rows[0][4].ToString();
                        NumeroRemision = res.Rows[0][5].ToString();
                        TxtOrden.Enabled = false;
                        TxtDescuento.Enabled = true;
                        TxtImpuesto.Enabled = false;
                   

                        GridViewFactura.DataSource = Factura.BuscarServicios(Convert.ToInt32(TxtOrden.Text));

                        var SubtotalServ = 0;
                        var Iva = 0;
                        var Total = 0;
                        foreach (DataGridViewRow dts in GridViewFactura.Rows)
                        {
                            var Codigo = dts.Cells[0].Value;// variables a las cuales les llevamos los datos consultados para hacer calculos
                            var vrUnitario = dts.Cells[2].Value;
                            var cantidad = dts.Cells[3].Value;
                            var SubTotal = dts.Cells[4].Value;
                            SubtotalServ += (Convert.ToInt32(vrUnitario) * Convert.ToInt32(cantidad));
                            dts.Cells[4].Value = (Convert.ToInt32(vrUnitario) * Convert.ToInt32(cantidad));
                            Iva = (Convert.ToInt32(SubtotalServ) * Convert.ToInt32(16) / 100);
                        }
                        txtSubtotal.Text = (SubtotalServ).ToString();//llevar todo a la caja de texto
                        TxtIva.Text = Iva.ToString();
                        TxtTotal.Text = (SubtotalServ + Iva).ToString();
                        TxtDescuento.Text = 0.ToString();
                    }
                    else
                    {
                        MessageBox.Show("El número de Orden de Servicio ingresado no existe, favor registrar", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Excepción no controlada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        public void BuscarFactura() {

            try
            {
                var res = Factura.BuscarFactura(Convert.ToInt32(TxtFactura.Text));
                if (res != null)
                {
                    if (res.Rows.Count > 0)
                    {
                        
                        TxtOrden.Text = res.Rows[0][20].ToString();
                        TxtNombre.Text = res.Rows[0][2].ToString();
                        TxtCc.Text = res.Rows[0][1].ToString();
                        TxtDireccion.Text = res.Rows[0][3].ToString();
                        TxtTelefono.Text = res.Rows[0][4].ToString();
                        CbxEstado.SelectedItem = res.Rows[0][7].ToString();
                        DateVencimiento.Value = DateTime.Parse(res.Rows[0][6].ToString());
                        txtSubtotal.Text = res.Rows[0][13].ToString();
                        TxtIva.Text = res.Rows[0][14].ToString();
                        TxtImpuesto.Text = (1).ToString(); //res.Rows[0][15].ToString();
                        TxtDescuento.Text = res.Rows[0][16].ToString();
                        TxtTotal.Text = res.Rows[0][17].ToString();
                        cbmPago.SelectedItem = res.Rows[0][19].ToString();
                        TxtOrden.Enabled = false;
                        CbxEstado.Enabled = true;
                        CkbActivo.Visible = true;
                        TxtImpuesto.Enabled = false;
                        TxtDescuento.Enabled = false;
                        if (res.Rows[0][21].ToString().Equals("Activa"))// VALIDAMOS QUE SI VIENE EN EL CAMPO ESTADO UNA "A" LAS CAJAS DE TEXTO ESTEN ACTIVAS
                        {
                            this.CkbActivo.Checked = (true);
                         
                        }

                        else
                        {
                            this.CkbActivo.Checked = (false);
                        
                        }
                   
                        GridViewFactura.DataSource = Factura.BuscarServicios(Convert.ToInt32(TxtOrden.Text));

                        var SubtotalServ = 0;
                        var Iva = 0;
                        foreach (DataGridViewRow dts in GridViewFactura.Rows)
                        {
                            var Codigo = dts.Cells[0].Value;// variables a las cuales les llevamos los datos consultados para hacer calculos
                            var vrUnitario = dts.Cells[2].Value;
                            var cantidad = dts.Cells[3].Value;
                            var SubTotal = dts.Cells[4].Value;
                            SubtotalServ += (Convert.ToInt32(vrUnitario) * Convert.ToInt32(cantidad));
                            dts.Cells[4].Value = (Convert.ToInt32(vrUnitario) * Convert.ToInt32(cantidad));
                            Iva = (Convert.ToInt32(SubtotalServ) * Convert.ToInt32(16) / 100);
                        }
                        txtSubtotal.Text = (SubtotalServ).ToString();//llevar todo a la caja de texto
                        TxtIva.Text = Iva.ToString();
                        TxtFactura.Enabled = false;
                        DateVencimiento.Enabled = false;
                        CbxEstado.Enabled = false;

                    }
                    else
                    {
                        MessageBox.Show("El número de Orden de Servicio ingresado no existe, favor registrar", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Excepción no controlada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        
        
        
        
        }
        public void Guardar()//Método para guardar
        {
            TxtObservaciones.Text = TxtObservaciones.Text.Trim();

            var Fecha = DateVencimiento.Value.DayOfYear - DateTime.Now.DayOfYear;
            if (string.IsNullOrWhiteSpace(TxtCc.Text) || string.IsNullOrWhiteSpace(DateVencimiento.Text) || string.IsNullOrWhiteSpace(TxtDescuento.Text)
                 || string.IsNullOrWhiteSpace(TxtIva.Text) || string.IsNullOrWhiteSpace(TxtFactura.Text) || cbmPago.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Por favor ingrese la información solicitada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (CbxEstado.SelectedItem.Equals("Pendiente (P)") || CbxEstado.SelectedItem.Equals("No Conforme(N)"))
            {
                MessageBox.Show("La Orden de Servicio debe estar en estado finalizado, favor verficar", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (DateTime.Now >= DateVencimiento.Value)
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
                    Factura.NumeroFactura = Convert.ToInt32(TxtFactura.Text);
                    Factura.NumeroOrden = Convert.ToInt32(TxtOrden.Text);
                    Factura.Cedula = TxtCc.Text;
                    Factura.FechaFactura = Convert.ToDateTime(DateVencimiento.Text);
                    Factura.Observaciones = TxtObservaciones.Text;
                    Factura.ValorTotal = 1;
                    Factura.Iva = Convert.ToInt32(TxtTotal.Text); 
                    Factura.Descuentos = Convert.ToInt32(TxtDescuento.Text);
                    Factura.Impuestos = Convert.ToInt32(TxtIva.Text);
                    Factura.Subtotal = Convert.ToInt32(txtSubtotal.Text);
                    Factura.Estado = CbxEstado.SelectedItem.ToString();
                    Factura.Usuario = perfil["Usuario"];
                    Factura.Mora = cbmPago.SelectedItem.ToString();
                    Factura.NumeroRemision = Convert.ToInt32(NumeroRemision);
                   TxtObservaciones.Text = TxtObservaciones.Text.Trim();

                    if (MessageBox.Show("¿Seguro que desea Continuar?", "SmartPrint", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        Factura.GuardarFactura(Factura);
                        MessageBox.Show("Operación exitosa", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     

                        if (MessageBox.Show("¿Desea Generar el informe?", "SmartPrint", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MostrarReporteFactura ReporteFactura = new MostrarReporteFactura();
                            ReporteFactura.NumeroFactura = Convert.ToInt32(TxtFactura.Text);
                            ReporteFactura.ShowDialog();
                            Clear();
                          
                            TxtFactura.Enabled = false;
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
                catch (Exception)
                {
                    MessageBox.Show("Excepción no controlada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Dispose();
                }

            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void TxtOrden_KeyPress(object sender, KeyPressEventArgs e)
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
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void calcular()//Método para calcular
        {

         
            var Caldescuento = 0;
            //var Calimpuestos = 0;
            var InDescuento = TxtDescuento.Text;
            //var InImpuestos = TxtImpuesto.Text;
            var Iva = TxtIva.Text;

            foreach (DataGridViewRow dts in GridViewFactura.Rows)
            {
                // variables a las cuales les llevamos los datos consultados para hacer calculos
                var vrUnitario = dts.Cells[2].Value;
                var cantidad = dts.Cells[3].Value;
                var SubtotalServ = txtSubtotal.Text;
                //SubtotalServ += (Convert.ToInt32(vrUnitario) * Convert.ToInt32(cantidad));
                //Validacion para que no ingresen 0 a las cajas de texto
                try
                {
                    if (Convert.ToInt32(InDescuento) >= 0)
                        {
                        Caldescuento = (Convert.ToInt32(SubtotalServ) * Convert.ToInt32(InDescuento)) / 100;//Calcular descuento
                        //Calimpuestos = (Convert.ToInt32(SubtotalServ) * Convert.ToInt32(InImpuestos)) / 100;//calcular impuesto
                        TxtTotal.Text = (Convert.ToInt32(SubtotalServ) + Convert.ToInt32(Iva) - Caldescuento).ToString();//llevar todo a la caja de texto
                        TxtDescuento.Text = (Caldescuento).ToString();//llevarle el calculo a la caja de texto de nuevo
                        //TxtImpuesto.Text = (Calimpuestos).ToString();
                        TxtDescuento.Enabled = false;
                        TxtImpuesto.Enabled = false;
                        break;
                    }
                    else {
                        TxtImpuesto.Clear();
                        TxtDescuento.Clear();
                      
                    }
                }
                catch 
                {
                    TxtImpuesto.Clear();
                    TxtDescuento.Clear();
                              
                }
            }


        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            calcular();
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
        
          try
          {

            if (CkbActivo.Visible == false)
            {
                Guardar();
            }
            else
            {
                if (CkbActivo.Checked == false)
                {
                    Factura.NumeroFactura = Convert.ToInt32(TxtFactura.Text);
                    Factura.EstadoFac = "Anulada";
                    Factura.Mora = cbmPago.SelectedItem.ToString();
                    if (MessageBox.Show("¿Seguro que desea Continuar?", "SmartPrint", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        Factura.Modificar(Factura);
                        MessageBox.Show("Operación exitosa", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                       
                    }
                    else
                    {
                        MessageBox.Show("Operación cancelada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                 }
                else
                {
                    Factura.NumeroFactura = Convert.ToInt32(TxtFactura.Text);
                    Factura.EstadoFac = "Activa";
                    Factura.Mora = cbmPago.SelectedItem.ToString();
                    if (MessageBox.Show("¿Seguro que desea Continuar?", "SmartPrint", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        Factura.Modificar(Factura);
                        MessageBox.Show("Operación exitosa", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Operación cancelada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                    }
                 
                 }
            
            
            }
            catch (Exception ex) { 
                 MessageBox.Show("Operación cancelada"+ex, "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             

        }
             
        }    
        private void button1_Click(object sender, EventArgs e)
        {
            FrmDian FrmInicio = new FrmDian(perfil);
            FrmInicio.ShowDialog();
          
        }
        private void TxtImpuesto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void TxtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            
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
            MessageBox.Show("Operación cancelada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void cbmPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void CbxEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void txtproImpuesto_KeyPress(object sender, KeyPressEventArgs e)
        {

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

        private void txtporDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                calcular();

            }

            if (char.IsDigit(e.KeyChar))
            {
                calcular();
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

        private void txtproImpuesto_Leave(object sender, EventArgs e)
        {
            calcular();
        }

        private void txtporDescuento_Leave(object sender, EventArgs e)
        {
            calcular();
        }

        private void TxtFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BuscarFactura();

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Inhabilitar();
            Clear();
            TxtOrden.Enabled = false;
            TxtObservaciones.Enabled = false;
            TxtFactura.Enabled = true;
            TxtFactura.Clear();
            BtnBuscar.Visible = false;
            CbxEstado.Enabled = false;
            DateVencimiento.Enabled = false;

        }

        private void TxtDescuento_Leave(object sender, EventArgs e)
        {
            calcular();
           
            
        }

        private void BtnDian_Click(object sender, EventArgs e)
        {
            FrmDian FrmInicio = new FrmDian(perfil);
            FrmInicio.ShowDialog();
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {

        }
    }
}
