using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Logica;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SmartPrint
{
    public partial class FrmClientes : Form
    {

        #region Declaraciones
        readonly LUtilidades _objUtilidades = new LUtilidades();
        private Dictionary<string, string> perfil;//Se declara un diccionario para pasar el perfil que viene del loguin
      
        LClientes _clien = new LClientes(); //INSTANCIA DE LOGICA
               #endregion
        public FrmClientes(Dictionary<string, string> Perfil)//constructor que le pasamos un diccionario
        {
            InitializeComponent();
            perfil = Perfil;
            CkbActivo.Checked = true;// Para que el check aparezca activo
            BtnModificar.Enabled = false;//para que el modificar inicié inactivo
            TxtCc.Focus();
        }

        public bool ValidarEmail(string email)//VALIDACIÓN DEL CORREO ELECTRONICO
        {
            const string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expresion))
            {
                return Regex.Replace(email, expresion, String.Empty).Length == 0;
            }
            return false;
        }
      
        public void Trim()  //Quitar espacios antes y despues
        {
            TxtDireccion.Text = TxtDireccion.Text.Trim();
            TxtNombre.Text = TxtNombre.Text.Trim();
            TxtObservaciones.Text = TxtObservaciones.Text.Trim();
          
        }
        public void Replace()//metodo para Quitar el doble espacio
        {
            TxtObservaciones.Text = TxtObservaciones.Text.Replace("   ", " ");
            TxtNombre.Text = TxtNombre.Text.Replace("   ", " ");
            TxtDireccion.Text = TxtDireccion.Text.Replace("   ", " ");

        }
        public void Clear()//MÉTODO LIMPIAR
        {
            TxtCc.Clear();
            TxtNombre.Clear();
            TxtTelefono.Clear();
            TxtExt.Clear();
            TxtCelular.Clear();
            TxtFax.Clear();
            TxtDireccion.Clear();
            TxtEmail.Clear();
            TxtObservaciones.Clear();
            TxtContacto.Clear();
            CkbActivo.Checked = true;
            Habilitar();
            BtnModificar.Enabled = false;
            BtnGuardar.Enabled = true;
            TxtCc.Focus();

        }
        public void Inhabilitar()//METODO INHABILITAR
        {
            TxtCc.Enabled = (false);
            TxtNombre.Enabled = (false);
            TxtTelefono.Enabled = (false);
            TxtExt.Enabled = (false);
            TxtCelular.Enabled = (false);
            TxtFax.Enabled = (false);
            TxtDireccion.Enabled = (false);
            TxtEmail.Enabled = (false);
            TxtObservaciones.Enabled = (false);
            TxtContacto.Enabled = false;

        }
        public void Habilitar()//METODO HABILITAR
        {
            TxtCc.Enabled = (true);
            TxtNombre.Enabled = (true);
            TxtTelefono.Enabled = (true);
            TxtExt.Enabled = (true);
            TxtCelular.Enabled = (true);
            TxtFax.Enabled = (true);
            TxtDireccion.Enabled = (true);
            TxtEmail.Enabled = (true);
            TxtObservaciones.Enabled = (true);
            TxtObservaciones.Enabled = (true);
            CkbActivo.Enabled = (true);
            TxtContacto.Enabled = true;

        }
        public void Buscar()  //METODO PARA BUSCAR
        {
            try
            {
                _clien = new Logica.LClientes();// INTANCIA DE LOGICA
                _clien.Cedula = (TxtCc.Text);// SE LE LLEVA LA CEDULA DE LOGICA LO QUE HAY EN LA CAJA DE TEXTO
                DataTable Res = _clien.Buscar(_clien); //SE EMPLEA UN DATATABLE PARA LLEVARLE TODOS LOS DATOS Y POSTERIOR UARDARLOS EN LA INTANCIA Y ALLI PASAR AL PROCEDIMIENTO
                if (Res != null)//VALIDAR QUE LA REPUESTA SEA DIFERENTE DE NULL
                { //SE LLEVAN A CADA UNO DE LAS CAJAS DE TEXTO LOS CAMPOS QUE VIENEN DEL PROCEDIMIENTO
                    var Aux = Res.Rows[0][3].ToString();
                    TxtNombre.Text = Res.Rows[0][1].ToString();
                    TxtTelefono.Text = Res.Rows[0][2].ToString();
                    if (0 == Convert.ToInt32(Aux))
                    {
                        TxtExt.Clear();
                    }
                    else
                    {
                        TxtExt.Text = Res.Rows[0][3].ToString();
                    }
                    TxtCelular.Text = Res.Rows[0][4].ToString();
                    TxtFax.Text = Res.Rows[0][5].ToString();
                    TxtDireccion.Text = Res.Rows[0][6].ToString();
                    TxtEmail.Text = Res.Rows[0][7].ToString();
                    TxtObservaciones.Text = Res.Rows[0][8].ToString();
                    TxtContacto.Text = Res.Rows[0][10].ToString();
                    TxtCc.Enabled = (false);
                    BtnGuardar.Enabled = (false);
                    BtnModificar.Enabled = true;

                    if (Res.Rows[0][9].ToString().Equals("A"))// VALIDAMOS QUE SI VIENE EN EL CAMPO ESTADO UNA "A" LAS CAJAS DE TEXTO ESTEN ACTIVAS
                    {
                        this.CkbActivo.Checked = (true);
                        Habilitar();//Permite habilitar los campos
                        TxtCc.Enabled = (false);
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
        private void TxtCc_KeyPress(object sender, KeyPressEventArgs e)
        {//VALIDACION PARA QUE AL DARLE ENTER DISPARE EL ROCEDIMIENTO
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Buscar();
            }//VALIDACIONES PARA QUE SOLO RECIBA NÙMEROS
            
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;

            }

        }
        private void TxtPnombre_KeyPress(object sender, KeyPressEventArgs e)
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
                _objUtilidades.Mensajes("Advertencia", "Solo se permiten letras");
                e.Handled = true;
            }
        }
        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
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
                _objUtilidades.Mensajes("Advertencia", "Solo se permiten letras");
                e.Handled = true;
            }
        }
        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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
                _objUtilidades.Mensajes("Advertencia", "Solo se permiten números");
                e.Handled = true;
            }
        }
        private void TxtExt_KeyPress(object sender, KeyPressEventArgs e)
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
                _objUtilidades.Mensajes("Advertencia", "Solo se permiten números");
                e.Handled = true;
            }
        }
        private void TxtCelular_KeyPress(object sender, KeyPressEventArgs e)
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
                _objUtilidades.Mensajes("Advertencia", "Solo se permiten números");
                e.Handled = true;
            }
        }
        private void TxtFax_KeyPress(object sender, KeyPressEventArgs e)
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
                _objUtilidades.Mensajes("Advertencia", "Solo se permiten números");
                e.Handled = true;
            }
        }
        private void TxtCc_Foco(object sender, EventArgs e)
        {
            Buscar();
        }
        public void Comun()//METODO COMUN PARA QUE GUardar Y MODIFIQUE
        {
            Trim();
            Replace();
            //VALIDACIONES PARA QUE LAS CAJAS DE TEXTO NO VAYAN VACIAS
            if ((TxtCc.Text.Equals("")) || (TxtNombre.Text.Equals("")) || (TxtTelefono.Text.Equals(""))
                || (TxtDireccion.Text.Equals("")) || (TxtEmail.Text.Equals("")))
            {
                MessageBox.Show("Por favor ingrese la información solicitada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                //validación del correo
                var email = ValidarEmail(TxtEmail.Text);
                if (!email)
                {
                    MessageBox.Show("Debe ingresar una dirección de correo electrónico válida", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtEmail.Clear();//Limpia la caja del correo
                }

                else
                {
                    _clien = new LClientes//INTACIA DE LOGICA
                    {
                        Cedula = (TxtCc.Text),//SE LE LLEVA A CADA DATO LO QUE SE INGRESO A LA CAJA DE TEXTO
                        Nombre = (TxtNombre.Text),
                        Telefono = (TxtTelefono.Text),
                        Ext = TxtExt.Text != "" ? Int32.Parse(TxtExt.Text) : 0,
                        Celular = (TxtCelular.Text),
                        Fax = (TxtFax.Text),
                        Direccion = (TxtDireccion.Text),
                        Email = (TxtEmail.Text),
                        Observaciones = (TxtObservaciones.Text),
                        Habilitar = (CkbActivo.Checked ? "A" : "I"),
                        Usuario = perfil["Usuario"],
                        Contacto=TxtContacto.Text

                    };
                    //PARA QUE LAS CAJAS ELIMINES ESPACIOS ANTES Y DESPUES DEL TEXTO
                    Trim();//QUITA ESPACIOS ADELANTE Y ATRAS
                    Replace();//QUITA DOBLE ESPACIOS
                    var Cedula = _clien.Cedula;
                    if (Cedula.Length >= 6)//VALIDA QUE LA CÉDULA SEA MAYOR A 6
                    {
                        if (MessageBox.Show("¿Seguro que desea Continuar?", "SmartPrint", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _clien.GestionarCliente(_clien);//DISPARA EL PROCEDIMIENTO
                            Clear();//BORRAR
                            //mensaje de exito
                            MessageBox.Show("Operación exitosa", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Operación cancelada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {
                        MessageBox.Show("La cédula/Nit no puede ser menor a 6 caracteres", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }


            }

        }
        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            Comun();// INTANCIA PARA GUARDAR
        }
        private void BtnModificar_Click_1(object sender, EventArgs e)
        {
            Comun();
        }
        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            Clear();//INTACIA LIMPIAR
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();// PARA SALIR DE LA VENTANA
        }
        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

            TxtNombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtNombre.Text);
            TxtNombre.SelectionStart = TxtNombre.Text.Length;//PARA QUE TODAS LAS PRIMERAS LETRAS SEAN MAYUSCULAS
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
        private void BtnClientes_Click(object sender, EventArgs e)
        {
            VistaClientes Clientes = new VistaClientes();
            Clientes.ShowDialog();
        }

        private void TxtContacto_TextChanged(object sender, EventArgs e)
        {
            TxtContacto.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtContacto.Text);
            TxtContacto.SelectionStart = TxtContacto.Text.Length;//PARA QUE TODAS LAS PRIMERAS LETRAS SEAN MAYUSCULAS
        }

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
                _objUtilidades.Mensajes("Advertencia", "Solo se permiten letras");
                e.Handled = true;
            }

        }
    }
}