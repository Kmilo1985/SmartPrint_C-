using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Logica;
using System.Runtime.InteropServices;


namespace SmartPrint
{
    public partial class FrmOtrosServicios : Form
    {
        #region Declaraciones
        [DllImport("user32.dll", EntryPoint = "GetSystemMenu")]

        private static extern IntPtr GetSystemMenu(IntPtr hwnd, int revert);

        [DllImport("user32.dll", EntryPoint = "GetMenuItemCount")]

        private static extern int GetMenuItemCount(IntPtr hmenu);

        [DllImport("user32.dll", EntryPoint = "RemoveMenu")]

        private static extern int RemoveMenu(IntPtr hmenu, int npos, int wflags);

        [DllImport("user32.dll", EntryPoint = "DrawMenuBar")]

        private static extern int DrawMenuBar(IntPtr hwnd);

        private const int MF_BYPOSITION = 0x0400;

        private const int MF_DISABLED = 0x0002;
        readonly LUtilidades _objUtilidades = new LUtilidades();
        //INSTANCIA DE LOGICA
        private DataTable _selection;//Cración de un DATATAble
        LServicios _serv = new LServicios();//instancia de servicios
        LOtrosServicios _otrosSer = new LOtrosServicios();//Instancia de logica
        List<string> _listSeleccionados = new List<string>();//Creación de una lista
        private Dictionary<string, string> perfil;//Se declara un diccionario para pasar el perfil que viene del loguin
        public DataTable TablaSeleccionada
        {
            get { return _selection; }
        }
        #endregion
        public FrmOtrosServicios(Dictionary<string, string> Perfil)//constructor que le pasamos un diccionario
        {
            InitializeComponent();
            perfil = Perfil;
            BtnModificar.Enabled = false;
            TxtCodigo.Enabled = false;
            var Aux = _serv.MostrarCodigo().Rows[0][1];
            int Numeeo = Convert.ToInt32(Aux) + 1;
            TxtCodigo.Text = Numeeo.ToString("D4");
            BtnAgregar.Visible = false;
            GridViewOtrosServ.ReadOnly = true;//metodo para que no permita editar las columnas del griv
            GridViewOtrosServ.AllowUserToOrderColumns = false;//Metodo para que no permita cambiar las columnas de lugar


        }
        public void Clear()//Método para limpiar
        {
            TxtCodigo.Clear();
            TxtCodigo.Enabled = false;
            TxtNombre.Clear();
            TxtObservaciones.Clear();
            TxtSerial.Clear();
            TxtValorUni.Clear();
            CbxProveedor.Text = "";
            Habilitar();
            BtnGuardar.Enabled = true;
            BtnModificar.Enabled = false;
            btnBuscar.Visible = true;
            GridViewOtrosServ.DataSource = null;
            MostrarTodos();
            var Aux = _serv.MostrarCodigo().Rows[0][1];
            int Numeeo = Convert.ToInt32(Aux) + 1;
            TxtCodigo.Text = Numeeo.ToString("D4");

        }
        public void MostrarTodos()//Metodo para limpiar
        {
            var dOtrosUsuarios = _otrosSer.MostrarTodos();
            GridViewOtrosServ.DataSource = dOtrosUsuarios;
        }
        public void Inhabilitar()//Método para inhabilitar
        {
            TxtNombre.Enabled = false;
            TxtObservaciones.Enabled = false;
            CbxProveedor.Enabled = false;
            TxtValorUni.Enabled = false;
            TxtSerial.Enabled = false;
        }
        public void Habilitar()//Método para habilitar
        {
            TxtNombre.Enabled = true;
            TxtObservaciones.Enabled = true;
            CbxProveedor.Enabled = true;
            TxtValorUni.Enabled = true;
            TxtSerial.Enabled = true;
        }
        public void Comun()//Método para guardar y modificar
        {
            TxtNombre.Text = TxtNombre.Text.Trim();
            TxtObservaciones.Text = TxtObservaciones.Text.Trim();
            TxtSerial.Text = TxtSerial.Text.Trim();
            try
            {
                if ((TxtCodigo.Text.Equals("")) || (TxtNombre.Text.Equals("")) || (TxtSerial.Text.Equals("")) || (TxtValorUni.Text.Equals("")))
                {
                    MessageBox.Show("Por favor ingrese la información solicitada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if ((CbxProveedor.SelectedIndex.Equals("")))
                {
                    MessageBox.Show("Por favor Seleccion una opción válida", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _otrosSer = new LOtrosServicios
                    {
                        Codigo = int.Parse(TxtCodigo.Text),
                        Nombre = TxtNombre.Text,
                        Serial = TxtSerial.Text,
                        ValorUnitario = float.Parse(TxtValorUni.Text),
                        IdProveedor = CbxProveedor.SelectedValue.ToString(),
                        Observaciones = this.TxtObservaciones.Text,
                        Usuario = perfil["Usuario"]

                    };
                    TxtNombre.Text = TxtNombre.Text.Trim();
                    TxtObservaciones.Text = TxtObservaciones.Text.Trim();
                    TxtSerial.Text = TxtSerial.Text.Trim();
                    var Valor = TxtValorUni.Text;

                    if (Convert.ToInt32(Valor) < 100)
                    {
                        MessageBox.Show("Valor no permitido", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtValorUni.Clear();
                    }
                    else
                    {

                        if (MessageBox.Show("¿Desea cotinuar?", "SmartPrint", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //mensaje de exito
                            _otrosSer.Guardar(_otrosSer);
                            MessageBox.Show("Operación exitosa", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                        }
                        else
                        {

                            MessageBox.Show("Operación Cancelada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        var Aux = _serv.MostrarCodigo().Rows[0][1];
                        int Numeeo = Convert.ToInt32(Aux) + 1;
                        TxtCodigo.Text = Numeeo.ToString("D4");
                        TxtCodigo.Enabled = false;
                        MostrarTodos();
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Excepción no controlada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
            }
        }
       private void BtnGuardar_Click(object sender, EventArgs e)
       {
           Comun();
       }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Comun();
        }
        private void FrmOtrosServicios_Load(object sender, EventArgs e)
        {
          MostrarTodos();
            if(BtnCancelarSer.Visible==true){
          IntPtr hmenu = GetSystemMenu(this.Handle, 0);

          int cnt = GetMenuItemCount(hmenu);

          // remove 'close' action

          RemoveMenu(hmenu, cnt - 1, MF_DISABLED | MF_BYPOSITION);

          // remove extra menu line

          RemoveMenu(hmenu, cnt - 2, MF_DISABLED | MF_BYPOSITION);

          DrawMenuBar(this.Handle);
            }else{
            
            }
                     
        }

        //private void GridViewOtrosServ_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (GridViewOtrosServ.CurrentRow != null)
        //    {
        //        TxtCodigo.Text = GridViewOtrosServ.CurrentRow.Cells[0].Value.ToString();
        //        TxtNombre.Text = GridViewOtrosServ.CurrentRow.Cells[2].Value.ToString();
        //        TxtSerial.Text = GridViewOtrosServ.CurrentRow.Cells[5].Value.ToString();
        //        TxtValorUni.Text = GridViewOtrosServ.CurrentRow.Cells[6].Value.ToString();
        //        CbxProveedor.SelectedItem = GridViewOtrosServ.CurrentRow.Cells[1].Value.ToString();
        //        TxtObservaciones.Text = GridViewOtrosServ.CurrentRow.Cells[4].Value.ToString();
        //    }
        //    BtnModificar.Enabled = true;
        //    BtnGuardar.Enabled = false;
        //}

        // CARGAR COMBOBOX
        public void CargarCombobox()
        {
            var dOtrosSer = _otrosSer.MostrarProveedores();
            CbxProveedor.DataSource = dOtrosSer;
            CbxProveedor.DisplayMember = "RazonSocial"; // PARA QUE LO DESPLIEGUE
            CbxProveedor.ValueMember = "Nit";
            CbxProveedor.SelectedIndex = -1;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
           
        }
        public void Buscar()
        {
            try
            {
                _otrosSer = new LOtrosServicios { Codigo = int.Parse(TxtCodigo.Text) };
                var res = _otrosSer.Buscar(_otrosSer);

                if (res == null) return;
                TxtCodigo.Enabled = false;
                TxtNombre.Text = res.Rows[0][3].ToString();
                TxtSerial.Text = res.Rows[0][5].ToString();
                TxtValorUni.Text = res.Rows[0][6].ToString();
                CbxProveedor.Text = res.Rows[0][2].ToString();
                CbxProveedor.SelectedValue= res.Rows[0][1].ToString();
                TxtObservaciones.Text = res.Rows[0][4].ToString();
                BtnModificar.Enabled = true;
                BtnGuardar.Enabled = false;
                Habilitar();
                GridViewOtrosServ.DataSource = res;
             
            }
            catch (Exception)
            {

                MessageBox.Show("Servicio no existe ", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Inhabilitar();
                BtnGuardar.Enabled = false;
                TxtCodigo.Enabled = true;
                TxtCodigo.Clear();
            }
        }

        public void buscarNombre() {
            try
            {
                _otrosSer = new LOtrosServicios { Nombre = (TxtNombre.Text) };
                var res = _otrosSer.BuscarNombre(_otrosSer);

                if (res == null) return;
                TxtCodigo.Enabled = false;
                TxtCodigo.Text = res.Rows[0][0].ToString();
                TxtSerial.Text = res.Rows[0][5].ToString();
                TxtValorUni.Text = res.Rows[0][6].ToString();
                CbxProveedor.Text = res.Rows[0][2].ToString();
                CbxProveedor.SelectedValue = res.Rows[0][1].ToString();
                TxtObservaciones.Text = res.Rows[0][4].ToString();
                BtnModificar.Enabled = true;
                BtnGuardar.Enabled = false;
                Habilitar();
                GridViewOtrosServ.DataSource = res;

            }
            catch (Exception)
            {

                MessageBox.Show("Servicio no existe ", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Inhabilitar();
                BtnGuardar.Enabled = false;
                TxtNombre.Enabled = true;
                TxtNombre.Clear();
            }
        
        
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buscarNombre();

            }
            if (e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                buscarNombre();

            }
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Solo Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Buscar();
               

            }
            if (e.KeyChar == Convert.ToChar(Keys.Tab))
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
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void TxtValorUni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {


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
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                _selection = new DataTable();
                _selection.Columns.Add("Codigo");
                _selection.Columns.Add("Nombre");
                _selection.Columns.Add("VrUnitario");
                _selection.Columns.Add("Cantidad");
                _selection.Columns.Add("Subtotal");

                var lstSelect = GridViewOtrosServ.SelectedRows;
                foreach (DataGridViewRow datos in lstSelect)
                {
                    var dr = _selection.NewRow();
                    dr["Codigo"] = datos.Cells[0].Value;
                    dr["Nombre"] = datos.Cells[2].Value;
                    dr["VrUnitario"] = datos.Cells[5].Value;
                    dr["Cantidad"] = 1;
                    dr["Subtotal"] = 0;
                    _selection.Rows.Add(dr);
                }
                BtnAgregar.Visible = false;
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Debe Ingresar un Servicio Valido", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Error); //throw new Exception(ex.Message);
            }



        }

        private void BtnCancelarSer_Click(object sender, EventArgs e)
        {
            _selection = new DataTable();
            _selection.Columns.Add("Codigo");
            _selection.Columns.Add("Nombre");
            _selection.Columns.Add("VrUnitario");
            _selection.Columns.Add("Cantidad");
            _selection.Columns.Add("Subtotal");
            Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            TxtNombre.Clear();
            TxtObservaciones.Clear();
            TxtSerial.Clear();
            TxtValorUni.Clear();
            TxtCodigo.Enabled = true;
            TxtCodigo.Clear();
            btnBuscar.Visible = false;
            Inhabilitar();
            GridViewOtrosServ.DataSource = null;

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

            TxtNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtNombre.Text);
            TxtNombre.SelectionStart = TxtNombre.Text.Length;//PARA QUE TODAS LAS PRIMERAS LETRAS SEAN MAYUSCULAS
        }

        private void TxtObservaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtObservaciones.Text.Length == 0)// LA PRIMERA LETRA ESTE EN MAYUSCULA
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else if (TxtObservaciones.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void CbxProveedor_Click(object sender, EventArgs e)
        {
            CargarCombobox();
        }

        private void CbxProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void FrmOtrosServicios_FormClosing(object sender, FormClosingEventArgs e)
        {
       //     if (MessageBox.Show("¿Seguro que desea Salir de formulario?", "SmartPrint",
       //MessageBoxButtons.YesNo) == DialogResult.Yes)
       //     {
       //         // Cancel the Closing event from closing the form.
       //         e.Cancel = true;
       //         // Call method to save file...
            }



       
        
        }
    }
