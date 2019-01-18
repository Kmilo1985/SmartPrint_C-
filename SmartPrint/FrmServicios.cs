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
    public partial class FrmServicios : Form
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
        LServicios _serv = new LServicios();
        List<string> _listSeleccionados = new List<string>();
        public DataTable _selection;
        private Dictionary<string, string> perfil;//Se declara un diccionario para pasar el perfil que viene del loguin
        public DataTable TablaSeleccionada
        {
            get { return _selection; }
        }
        #endregion
        public FrmServicios(Dictionary<string, string> Perfil)//constructor que le pasamos un diccionari
        {
            InitializeComponent();
            perfil = Perfil;
            BtnModificar.Enabled = false;
            TxtItem.Enabled = false;
            var Aux = _serv.MostrarCodigo().Rows[0][1];
            int Numeeo = Convert.ToInt32(Aux) + 1;
            TxtItem.Text = Numeeo.ToString("D4");
            BtnAgregar.Visible = false;
            BtnCancelarSer.Visible = false;
            GridViewServicios.ReadOnly = true;
            GridViewServicios.AllowUserToOrderColumns = false;


        }
        public void Clear()//Método para limpiar
        {
            TxtItem.Enabled = false;
            TxtNombre.Clear();
            TxtObservaciones.Clear();
            TxtValorUni.Clear();
            Habilitar();
            BtnGuardar.Enabled = true;
            BtnModificar.Enabled = false;
            CbxTipo.SelectedItem = (null);
            GridViewServicios.DataSource = null;
            bnBuscarItem.Visible = true;
            MostrarTodos();
            var Aux = _serv.MostrarCodigo().Rows[0][1];
            int Numeeo = Convert.ToInt32(Aux) + 1;
            TxtItem.Text = Numeeo.ToString("D4");

        }
        public void Inhabilitar()//Método para inhabilitar
        {
            TxtNombre.Enabled = false;
            TxtObservaciones.Enabled = false;
            CbxTipo.Enabled = false;
            TxtValorUni.Enabled = false;

        }
        public void Habilitar()//Método para habilitar
        {

            TxtNombre.Enabled = true;
            TxtObservaciones.Enabled = true;
            CbxTipo.Enabled = true;
            TxtValorUni.Enabled = true;

        }
        public void Comun()//Para guardar y Modificar
        {
            TxtNombre.Text = TxtNombre.Text.Trim();
            TxtObservaciones.Text = TxtObservaciones.Text.Trim();
            try
            {
                if (string.IsNullOrWhiteSpace(TxtNombre.Text) || string.IsNullOrWhiteSpace(CbxTipo.Text) ||
                    string.IsNullOrWhiteSpace(TxtItem.Text) || string.IsNullOrWhiteSpace(TxtValorUni.Text) || CbxTipo.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("Por favor ingrese la información solicitada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    _serv.Nombre = TxtNombre.Text;
                    _serv.Tipo = CbxTipo.SelectedItem.ToString();
                    _serv.Codigo = int.Parse(TxtItem.Text);
                    _serv.Observaciones = TxtObservaciones.Text;
                    _serv.ValorUnitario = float.Parse(TxtValorUni.Text);
                    _serv.Usuario = perfil["Usuario"];
                    TxtNombre.Text = TxtNombre.Text.Trim();
                    TxtObservaciones.Text = TxtObservaciones.Text.Trim();
                    var Valor = _serv.ValorUnitario;

                    if (Valor < 100)
                    {
                        MessageBox.Show("El valor no es permitido", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxtValorUni.Clear();

                    }
                    else
                    {

                        if (MessageBox.Show("¿Seguro que desea Continuar?", "SmartPrint", MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            _serv.Guardar(_serv);
                            MessageBox.Show("Operación Exitosa", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();

                        }
                        else
                        {
                            MessageBox.Show("Operación Cancelada",
                                           "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }

                        var Aux = _serv.MostrarCodigo().Rows[0][1];
                        int Numeeo = Convert.ToInt32(Aux) + 1;
                        TxtItem.Text = Numeeo.ToString("D4");
                        TxtItem.Enabled = false;
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
        public void MostrarTodos()//Método para mostrar para todos
        {
            var DUsuarios = _serv.MostrarTodos();
            GridViewServicios.DataSource = DUsuarios;

        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();

        }
        public void BuscarCodigo()
        {
            try
            {

                _serv = new LServicios { Codigo = int.Parse(TxtItem.Text) };
                var res = _serv.Buscar(_serv);
                if (res == null) return;
                TxtItem.Enabled = false;
                TxtNombre.Text = res.Rows[0][1].ToString();
                CbxTipo.SelectedItem = res.Rows[0][2].ToString();
                TxtValorUni.Text = res.Rows[0][3].ToString();
                TxtObservaciones.Text = res.Rows[0][4].ToString();
                BtnModificar.Enabled = true;
                BtnGuardar.Enabled = false;
                Habilitar();
                GridViewServicios.DataSource = res;
               
            }
            catch (Exception)
            {
                MessageBox.Show("Servicio no Existe ", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Inhabilitar();
                BtnGuardar.Enabled = false;
                TxtItem.Enabled = true;
                TxtItem.Clear();

            }

        }
        public void BuscarNombre()
        {
            try
            {

                _serv = new LServicios { Nombre = (TxtNombre.Text) };
                var res = _serv.BuscarNombre(_serv);
                if (res == null) return;
                TxtItem.Enabled = false;
                TxtItem.Text = res.Rows[0][0].ToString();
                CbxTipo.SelectedItem = res.Rows[0][2].ToString();
                TxtValorUni.Text = res.Rows[0][3].ToString();
                TxtObservaciones.Text = res.Rows[0][4].ToString();
                BtnModificar.Enabled = true;
                BtnGuardar.Enabled = false;
                Habilitar();
                GridViewServicios.DataSource = res;
             

            }
            catch (Exception)
            {
                MessageBox.Show("Servicio no Existe ", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Inhabilitar();
                BtnGuardar.Enabled = false;
                TxtNombre.Enabled = true;
                TxtNombre.Clear();

            }

        }
        private void FrmServicios_Load(object sender, EventArgs e)
        {
            MostrarTodos();
            if (BtnCancelarSer.Visible == true)
            {
                IntPtr hmenu = GetSystemMenu(this.Handle, 0);

                int cnt = GetMenuItemCount(hmenu);

                // remove 'close' action

                RemoveMenu(hmenu, cnt - 1, MF_DISABLED | MF_BYPOSITION);

                // remove extra menu line

                RemoveMenu(hmenu, cnt - 2, MF_DISABLED | MF_BYPOSITION);

                DrawMenuBar(this.Handle);
            }
            else
            {

            }
        }
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BuscarNombre();

            }
            if (e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                BuscarNombre();

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
                _objUtilidades.Mensajes("Advertencia", "Solo se permiten letras");
                e.Handled = true;
            }
        }
        private void TxtItem_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BuscarCodigo();
               
            }
            if (e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                BuscarCodigo();

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
        private void TxtValorUni_KeyPress(object sender, KeyPressEventArgs e)
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
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Comun();
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Comun();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

            TxtNombre.Clear();
            CbxTipo.SelectedItem = (null);
            TxtObservaciones.Clear();
            TxtValorUni.Clear();
            TxtItem.Enabled = true;
            TxtItem.Clear();
            Inhabilitar();
            bnBuscarItem.Visible = false;
            GridViewServicios.DataSource = null;
                   
        }
        public void BtnCancelar_Click(object sender, EventArgs e)
        {
            _selection = new DataTable();
            _selection.Columns.Add("Codigo");
            _selection.Columns.Add("Nombre");
            _selection.Columns.Add("VrUnitario");
            _selection.Columns.Add("Cantidad");
            _selection.Columns.Add("Subtotal");
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
                var lstSelect = GridViewServicios.SelectedRows;
                foreach (DataGridViewRow datos in lstSelect)
                {
                    var dr = _selection.NewRow();
                    dr["Codigo"] = datos.Cells[2].Value;
                    dr["Nombre"] = datos.Cells[0].Value;
                    dr["VrUnitario"] = datos.Cells[4].Value;
                    dr["Cantidad"] = 1;
                    dr["Subtotal"] = 0;
                    _selection.Rows.Add(dr);
                }
                BtnAgregar.Visible = false;
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Excepción no controlada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Error); //throw new Exception(ex.Message);
            }

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        
        }

        private void CbxTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

       
        
       
    }
}
