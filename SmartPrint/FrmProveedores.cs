using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Logica;
using System.Collections.Generic;


namespace SmartPrint
{
    public partial class FrmProveedores : Form
    {
        private Dictionary<string, string> perfil;//Se declara un diccionario para pasar el perfil que viene del loguin
        public FrmProveedores(Dictionary<string, string> Perfil)//constructor que le pasamos un diccionario
        {
            InitializeComponent();
            CkbActivo.Checked = true;
            perfil = Perfil;
            BtnModificar.Enabled = false;
        }
        LProveedor _prov = new LProveedor();//instancia de logica
        public bool ValidarEmail(string email)//VALIDACIÓN DEL CORREO ELECTRONICO
        {
            const string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expresion))
            {
                return Regex.Replace(email, expresion, String.Empty).Length == 0;
            }
            return false;
        }
        public void Trim()//Método para quitar espacios
        {

            TxtRazon.Text = TxtRazon.Text.Trim();//quitar campos vacios antes y despues del texto
            TxtDireccion.Text = TxtDireccion.Text.Trim();
            TxtContacto.Text = TxtContacto.Text.Trim();
            TxtObservaciones.Text = TxtObservaciones.Text.Trim();
            TxtEmail.Text = TxtEmail.Text.Trim();

        }
        public void Replace()//Método para quitar doble espacio
        {
            TxtRazon.Text = TxtRazon.Text.Replace("   ", " ");//quitar campos vacios antes y despues del texto
            TxtDireccion.Text = TxtDireccion.Text.Replace("   ", " ");
            TxtContacto.Text = TxtContacto.Text.Replace("   ", " ");
            TxtObservaciones.Text = TxtObservaciones.Text.Replace("   ", " ");
        }
        public void Clear()  //MÉTODO LIMPIAR
        {
            TxtNit.Clear();
            TxtRazon.Clear();
            TxtContacto.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
            TxtExt.Clear();
            TxtCelular.Clear();
            TxtFax.Clear();
            TxtEmail.Clear();
            TxtObservaciones.Clear();
            CkbActivo.Checked = true;
            TxtNit.Enabled = true;
            TxtNit.Focus();
            Habilitar();
            BtnGuardar.Enabled = true;
            BtnModificar.Enabled = false;
        }
        public void Inhabilitar()//METODO INHABILITAR
        {
            TxtNit.Enabled = false;
            TxtRazon.Enabled = false;
            TxtContacto.Enabled = (false);
            TxtDireccion.Enabled = (false);
            TxtTelefono.Enabled = (false);
            TxtExt.Enabled = (false);
            TxtCelular.Enabled = (false);
            TxtFax.Enabled = (false);
            TxtEmail.Enabled = (false);
            TxtObservaciones.Enabled = (false);
        }
        public void Habilitar()   //METODO HABILITAR
        {
            TxtNit.Enabled = true;
            TxtRazon.Enabled = true;
            TxtContacto.Enabled = true;
            TxtDireccion.Enabled = true;
            TxtTelefono.Enabled = true;
            TxtExt.Enabled = true;
            TxtCelular.Enabled = true;
            TxtFax.Enabled = true;
            TxtEmail.Enabled = true;
            TxtObservaciones.Enabled = true;

        }
        public void comun()//Método para guardar
        {
            Trim();
            Replace();
            try
            {
                if ((TxtNit.Text.Equals("")) || (TxtRazon.Text.Equals("")) || (TxtContacto.Text.Equals("")) || (TxtDireccion.Text.Equals(""))
                  || (TxtTelefono.Text.Equals("")) || (TxtEmail.Text.Equals("")))
                {
                    MessageBox.Show("Por favor ingrese la información solicitada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //validación del correo
                    bool Email = ValidarEmail(TxtEmail.Text);
                    if (!Email)
                    {
                        MessageBox.Show("Debe ingresar una dirección de correo electrónico válida", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxtEmail.Clear();
                    }
                    else
                    {

                        _prov = new LProveedor();
                        _prov.Nit = (TxtNit.Text);
                        _prov.Razon = (TxtRazon.Text);
                        _prov.Contacto = (TxtContacto.Text);
                        _prov.Direccion = (TxtDireccion.Text);
                        _prov.Telefono = (TxtTelefono.Text);
                        _prov.Ext = TxtExt.Text != "" ? Int32.Parse(TxtExt.Text) : 0;
                        _prov.Fax = (TxtFax.Text);
                        _prov.Celular = (TxtCelular.Text);
                        _prov.Email = (TxtEmail.Text);
                        _prov.Observaciones = (TxtObservaciones.Text);
                        _prov.Habilitar = (CkbActivo.Checked ? "A" : "I");
                        _prov.Usuario = perfil["Usuario"];
                        Trim();
                        Replace();


                        //Mensaje para preguntar si està o no seguro del registro.
                        if (MessageBox.Show("¿Seguro que desea Continuar?", "SmartPrint", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MessageBox.Show("Operación exitosa", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _prov.GestionarProveedor(_prov);
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Operacion Cancelada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Excepción no controlada ", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            comun();
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            comun();
        }
        public void Buscar()
        {
            try
            {
                _prov = new Logica.LProveedor();
                _prov.Nit = (TxtNit.Text);
                DataTable Res = _prov.Buscar(_prov);
                if (Res != null)
                {
                    var Aux = Res.Rows[0][5].ToString();
                    TxtRazon.Text = Res.Rows[0][1].ToString();
                    TxtContacto.Text = Res.Rows[0][2].ToString();
                    TxtDireccion.Text = Res.Rows[0][3].ToString();
                    TxtTelefono.Text = Res.Rows[0][4].ToString();
                    if (0 == Convert.ToInt32(Aux))
                    {
                        TxtExt.Clear();
                    }
                    else
                    {
                        TxtExt.Text = Res.Rows[0][5].ToString();
                    }
                    TxtFax.Text = Res.Rows[0][6].ToString();
                    TxtCelular.Text = Res.Rows[0][7].ToString();
                    TxtEmail.Text = Res.Rows[0][8].ToString();
                    TxtObservaciones.Text = Res.Rows[0][9].ToString();
                    TxtNit.Enabled = false;
                    BtnGuardar.Enabled = (false);
                    BtnModificar.Enabled = true;
                    if (Res.Rows[0][10].ToString().Equals("A"))
                    {
                        this.CkbActivo.Checked = (true);
                        Habilitar();//Permite habilitar los campos
                        TxtNit.Enabled = (false);

                    }
                    else
                    {
                        this.CkbActivo.Checked = (false);
                        Inhabilitar();
                    }
                }
            }
            catch (Exception)
            {
               
            }
        }
        //CONDICIÓN DE SOLO NÚMEROS
        private void TxtNit_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void TxtExt_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void TxtCelular_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void TxtFax_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        //CONDICION DE SOLO LETRAS
        private void TxtContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void TxtNit_Foco(object sender, EventArgs e)
        {
            Buscar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void TxtRazon_TextChanged(object sender, EventArgs e)
        {
            TxtRazon.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtRazon.Text);
            TxtRazon.SelectionStart = TxtRazon.Text.Length;//PARA QUE TODAS LAS PRIMERAS LETRAS SEAN MAYUSCULAS
        }

        private void TxtContacto_TextChanged(object sender, EventArgs e)
        {
            TxtContacto.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtContacto.Text);
            TxtContacto.SelectionStart = TxtContacto.Text.Length;//PARA QUE TODAS LAS PRIMERAS LETRAS SEAN MAYUSCULAS
        }

        private void TxtDireccion_TextChanged(object sender, EventArgs e)
        {
            TxtDireccion.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtDireccion.Text);
            TxtDireccion.SelectionStart = TxtDireccion.Text.Length;//PARA QUE TODAS LAS PRIMERAS LETRAS SEAN MAYUSCULAS
        }

        private void TxtObservaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtObservaciones.Text.Length == 0)// LA PRIMERA LETRA ESTE EN MAYUSCULA
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else if (TxtObservaciones.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            VistaProveedore Proveedores = new VistaProveedore();
            Proveedores.ShowDialog();
        }
    }
}