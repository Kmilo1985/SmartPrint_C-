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

namespace SmartPrint
{
    public partial class FrmEmpleado : Form
    {

        #region Declaraciones

        readonly LUtilidades _objUtilidades = new LUtilidades();
        #endregion
        private Dictionary<string, string> perfil;//Se declara un diccionario para pasar el perfil que viene del loguin
        public FrmEmpleado(Dictionary<string, string> Perfil)//constructor que le pasamos un diccionario
        {
            InitializeComponent();
            BtnModificar.Enabled = false;//para que el modificar inicié inactivo
            CkbActivo.Checked = true;// Para que el check aparezca activo
            DateRetiro.Enabled = false;//Para que la fecha de retiro quede inhabilitada
            perfil = Perfil;
            TxtCc.Focus();

        }
        Logica.LEmpleados Emp = new Logica.LEmpleados();//INSTANCIA DE LOGICA
        public bool ValidarEmail(string email) //VALIDACIÓN DEL CORREO ELECTRONICO
        {
            const string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expresion))
            {
                return Regex.Replace(email, expresion, String.Empty).Length == 0;
            }
            else
            { return false; }
        }
        public void validarchek() //Método para validar la fecha de Retiro
        {

            if (ChekFecha.Checked == true)
            {
                DateRetiro.Enabled = true;

            }
            else
            {
                DateRetiro.Enabled = false;
            }

        }
        public void Trim() // Para Quitar espacios en blanco antes y despues
        {
            TxtPapellido.Text = TxtPapellido.Text.Trim();
            TxtSnombre.Text = TxtSnombre.Text.Trim();
            TxtSapellido.Text = TxtSapellido.Text.Trim();
            TxtDireccion.Text = TxtDireccion.Text.Trim();
            TxtPnombre.Text = TxtPnombre.Text.Trim();
            txtCargo.Text = txtCargo.Text.Trim();
            TxtObservaciones.Text = TxtObservaciones.Text.Trim();
            txtSalario.Text = txtSalario.Text.Trim();
            txtEps.Text = txtEps.Text.Trim();
            txtCompensaciones.Text = txtCompensaciones.Text.Trim();
            txtPensiones.Text = txtPensiones.Text.Trim();
            txtARP.Text = txtARP.Text.Trim();
            TxtEmail.Text = TxtEmail.Text.Trim();
            txtCargo.Text = txtCargo.Text.Trim();




        }
        public void Replace() // Para Quitar espacios en blanco antes y despues
        {
            TxtPapellido.Text = TxtPapellido.Text.Replace("   ", " ");
            TxtSnombre.Text = TxtSnombre.Text.Replace("   ", " ");
            TxtSapellido.Text = TxtSapellido.Text.Replace("   ", " ");
            TxtDireccion.Text = TxtDireccion.Text.Replace("   ", " ");
            TxtPnombre.Text = TxtPnombre.Text.Replace("   ", " ");
            TxtObservaciones.Text = TxtObservaciones.Text.Replace("   ", " ");
            txtSalario.Text = txtSalario.Text.Replace("   ", " ");
            txtEps.Text = txtEps.Text.Replace("   ", " ");
            txtCompensaciones.Text = txtCompensaciones.Text.Replace("   ", " ");
            txtPensiones.Text = txtPensiones.Text.Replace("   ", " ");
        }
        public void Clear()//METODO lIMPIAR
        {
            TxtCc.Clear();
            TxtPnombre.Clear();
            TxtSnombre.Clear();
            TxtPapellido.Clear();
            TxtSapellido.Clear();
            TxtTelefono.Clear();
            TxtCelular.Clear();
            TxtDireccion.Clear();
            TxtEmail.Clear();
            CmbSexo.SelectedItem = (null);
            DateNacimiento.ResetText();
            DateIngreso.ResetText();
            DateRetiro.ResetText();
            DateRetiro.Enabled = false;
            ChekFecha.Checked = false;
            TxtObservaciones.Clear();
            CmbDisponibilidad.SelectedItem = (null);
            txtCargo.Clear();
            cbxContrato.Text="";
            txtSalario.Clear();
            txtEps.Clear();
            txtCompensaciones.Clear();
            txtPensiones.Clear();
            txtARP.Clear();
            CkbActivo.Checked = true;
            TxtCc.Focus();
            BtnGuardar.Enabled = true;
            BtnModificar.Enabled = false;
            Habilitar();
            TxtCc.Focus();
        }
        public void Inhabilitar()//METODO INHABILITAR
        {
            TxtCc.Enabled = false;
            TxtPnombre.Enabled = false;
            TxtSnombre.Enabled = (false);
            TxtPapellido.Enabled = (false);
            TxtSapellido.Enabled = (false);
            TxtTelefono.Enabled = (false);
            TxtCelular.Enabled = (false);
            TxtDireccion.Enabled = (false);
            TxtEmail.Enabled = (false);
            CmbSexo.Enabled = (false);
            DateNacimiento.Enabled = (false);
            DateIngreso.Enabled = (false);
            DateRetiro.Enabled = (false);
            TxtObservaciones.Enabled = (false);
            CmbDisponibilidad.Enabled = (false);
            cbxContrato.Enabled = (false);
            txtSalario.Enabled = (false);
            txtEps.Enabled = (false);
            txtCompensaciones.Enabled = (false);
            txtPensiones.Enabled = (false);
            txtARP.Enabled = (false);
            txtCargo.Enabled = false;

        }
        public void Habilitar()//METODO HABILITAR
        {
            TxtCc.Enabled = true;
            TxtPnombre.Enabled = true;
            TxtSnombre.Enabled = (true);
            TxtPapellido.Enabled = (true);
            TxtSapellido.Enabled = (true);
            TxtTelefono.Enabled = (true);
            TxtCelular.Enabled = (true);
            TxtDireccion.Enabled = (true);
            TxtEmail.Enabled = (true);
            CmbSexo.Enabled = (true);
            DateNacimiento.Enabled = (true);
            DateIngreso.Enabled = (true);
            TxtObservaciones.Enabled = (true);
            CmbDisponibilidad.Enabled = (true);
            cbxContrato.Enabled = (true);
            txtSalario.Enabled = (true);
            txtEps.Enabled = (true);
            txtCompensaciones.Enabled = (true);
            txtPensiones.Enabled = (true);
            txtARP.Enabled = (true);
            txtCargo.Enabled = true;
        }
        public void comun()//METODO COMUN PARA QUE BUSQUE Y MODIFIQUE
        {
            Trim();
            Replace();
            var edad = DateTime.Now.Year - DateNacimiento.Value.Year; //Opción para comparar enteros con datetime
            //validación para que todas las cajas de textos esten llenas
            if ((TxtCc.Text.Equals("")) || (TxtPnombre.Text.Equals("")) || (TxtTelefono.Text.Equals("")) || (TxtPapellido.Text.Equals(""))
                || (TxtDireccion.Text.Equals("")) || (TxtEmail.Text.Equals("")) || (txtSalario.Text.Equals(""))
                || (txtEps.Text.Equals("")) || (txtCompensaciones.Text.Equals("")) || (txtPensiones.Text.Equals("")) || (txtARP.Text.Equals("")))
            {

                MessageBox.Show("Por favor ingrese la información solicitada", "Smartprint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //validaciones para los datatime
                if (DateIngreso.Value < DateNacimiento.Value)
                {
                    MessageBox.Show("Por favor ingrese una fecha válida, la fecha de ingreso no puede ser menor a la de nacimiento", "Smartprint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if ((ChekFecha.Checked == true) && (DateRetiro.Value < DateIngreso.Value))
                {
                    MessageBox.Show("Por favor ingrese una fecha válida, la fecha de retiro no puede ser menor a la de ingreso, si no desea guardar la fecha de retiro en este momento desactive la opción", "Smartprint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if ((60 < edad) || (edad < 18))
                {
                    MessageBox.Show("Por favor ingrese una fecha de nacimiento válida, Debe ser mayor de edad o Menor de 60 años", "Smartprint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //Para validar que los combox esten con una opción 
                }
                else if ((CmbSexo.SelectedIndex.Equals(-1)) || (CmbDisponibilidad.SelectedIndex.Equals(-1)) || (cbxContrato.SelectedIndex.Equals("")))
                {
                    MessageBox.Show("Por favor haga una selección válida", "Smartprint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //validación del correo
                    var email = ValidarEmail(TxtEmail.Text);
                    if (!email)
                    {
                        MessageBox.Show("Debe ingresar una dirección de correo electrónico válida", "Smartprint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TxtEmail.Clear();//limpiar el email
                    }
                    else
                    {
                        try
                        {
                            Emp = new LEmpleados//Intancia de logica
                            {
                                Cedula = (TxtCc.Text), //se le llevan los campos de las cajas de texto
                                PrimerNombre = (TxtPnombre.Text),
                                SegundoNombre = (TxtSnombre.Text),
                                PrimerApellido = (TxtPapellido.Text),
                                SegundoApellido = (TxtSapellido.Text),
                                Telefono = (TxtTelefono.Text),
                                Celular = (TxtCelular.Text),
                                Direccion = (TxtDireccion.Text),
                                Email = (TxtEmail.Text),
                                Sexo = CmbSexo.SelectedItem.ToString(),
                                FechaDeIngreso = (DateIngreso.Value),
                                FechaDeNacimiento = (DateNacimiento.Value),
                                Disponibilidad = CmbDisponibilidad.SelectedItem.ToString(),
                                Cargo = txtCargo.Text,
                                Observaciones = (TxtObservaciones.Text),
                                Estado = (CkbActivo.Checked ? "A" : "I"),
                                Contrato = cbxContrato.Text.ToString(),
                                Salario = float.Parse(txtSalario.Text),
                                Eps = txtEps.Text,
                                Compensaciones = txtCompensaciones.Text,
                                Pensiones = txtPensiones.Text,
                                ARP = txtARP.Text,
                                Usuario = perfil["Usuario"]

                            };
                            Trim();//quitar espacios adelante y atrás
                            Replace();//quitar doble espacio
                            var Cedula = Emp.Cedula;
                            if (Cedula.Length >= 6)//VALIDA QUE LA CÉDULA SEA MAYOR A 6
                            {
                                if (MessageBox.Show("¿Seguro que desea Continuar?", "SmartPrint", MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    if (ChekFecha.Checked == true)
                                    {
                                        Emp.FechaDeRetiro = (DateRetiro.Value);

                                    }
                                    else
                                    {

                                        Emp.FechaDeRetiro = null;
                                    }
                                    Emp.GestionarEmpleado(Emp);
                                    MessageBox.Show("Operación exitosa", "Smartprint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Clear();
                                }
                                else
                                {
                                    MessageBox.Show("Operación cancelada", "Smartprint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("La cédula no puede ser menor a 6 caracteres", "Smartprint", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Excepción no controlada", "Smartprint", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Dispose();
                        }
                    }
                }
            }
        }
        private void BtnGuardar_Click_1(object sender, EventArgs e)
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
        private void TxtCc_KeyPress(object sender, KeyPressEventArgs e)
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
                _objUtilidades.Mensajes("Advertencia", "Solo se permiten números");
                e.Handled = true;
            }
        }
        private void TxtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))//solo permite numeros
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

                      
            else
            {
                _objUtilidades.Mensajes("Advertencia", "Solo se permiten Letras");
                e.Handled = true;
            }
            if (TxtPnombre.Text.Length == 0)// LA PRIMERA LETRA ESTE EN MAYUSCULA
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else if (TxtPnombre.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];

        }
        private void TxtPapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //else if (Char.IsSeparator(e.KeyChar)) Permite  la tecla espace
            //{
            //    e.Handled = false;
            //}
            else
            {
                _objUtilidades.Mensajes("Advertencia", "Solo se permiten Letras");
                e.Handled = true;
            }
            if (TxtPapellido.Text.Length == 0)// LA PRIMERA LETRA ESTE EN MAYUSCULA
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else if (TxtPapellido.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }
        private void TxtSnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            
            else
            {
                _objUtilidades.Mensajes("Advertencia", "Solo se permiten Letras");
                //MessageBox.Show("Solo Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            if (TxtSnombre.Text.Length == 0)// LA PRIMERA LETRA ESTE EN MAYUSCULA
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else if (TxtSnombre.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void TxtSapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            
            else
            {
                _objUtilidades.Mensajes("Advertencia", "no se permiten números");
                //MessageBox.Show("Solo Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }

            if (TxtSapellido.Text.Length == 0)// LA PRIMERA LETRA ESTE EN MAYUSCULA
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else if (TxtSapellido.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        public void Buscar() //METODO PARA BUSCAR
        {

            try
            {
                Emp = new LEmpleados { Cedula = (TxtCc.Text) };
                var res = Emp.Buscar(Emp);
                if (res != null)
                {

                    TxtPnombre.Text = res.Rows[0][1].ToString();
                    TxtSnombre.Text = res.Rows[0][2].ToString();
                    TxtPapellido.Text = res.Rows[0][3].ToString();
                    TxtSapellido.Text = res.Rows[0][4].ToString();
                    TxtTelefono.Text = res.Rows[0][5].ToString();
                    TxtCelular.Text = res.Rows[0][6].ToString();
                    TxtDireccion.Text = res.Rows[0][7].ToString();
                    TxtEmail.Text = res.Rows[0][8].ToString();
                    DateNacimiento.Value = DateTime.Parse(res.Rows[0][10].ToString());
                    txtCargo.Text = res.Rows[0][11].ToString();
                    DateIngreso.Value = DateTime.Parse(res.Rows[0][12].ToString());
                    CmbSexo.SelectedItem = res.Rows[0][9].ToString();

                    if (res.Rows[0][14].ToString().Equals(""))
                    {
                        DateRetiro.Value = DateTime.Now;
                    }
                    else
                    {
                        DateRetiro.Value = DateTime.Parse(res.Rows[0][14].ToString());
                    }

                    CmbDisponibilidad.SelectedItem = res.Rows[0][13].ToString();
                    txtSalario.Text = res.Rows[0][18].ToString();
                    cbxContrato.Text = "";
                    cbxContrato.SelectedText= res.Rows[0][17].ToString();
                    txtPensiones.Text = res.Rows[0][20].ToString();
                    txtEps.Text = res.Rows[0][19].ToString();
                    txtARP.Text = res.Rows[0][22].ToString();
                    txtCompensaciones.Text = res.Rows[0][22].ToString();
                    TxtObservaciones.Text = res.Rows[0][15].ToString();
                    TxtCc.Enabled = (false);
                    BtnGuardar.Enabled = false;
                    BtnModificar.Enabled = true;

                    if (res.Rows[0][16].ToString().Equals("A"))
                    {
                        CkbActivo.Checked = (true);
                        Habilitar(); //Permite habilitar los campos
                        TxtCc.Enabled = false;

                    }
                    else
                    {
                        CkbActivo.Checked = (false);
                        Inhabilitar();
                    }
                }
            }

            catch(Exception)
            {
                
            }
        }

        private void FocoTxtCc(object sender, EventArgs e)
        {
            Buscar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
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

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (char.IsDigit(e.KeyChar))//solo permite numeros
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
                 //var aux = txtSalario.Text;

                 //aux= aux.Remove(aux.Length - 1);
             }
        }
        private void txtPensiones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar)) //Permite  la tecla espace
            {
                e.Handled = false;
            }
            else
            {
                _objUtilidades.Mensajes("Advertencia", "Solo se permiten Letras");
                e.Handled = true;
            }
            if (TxtPapellido.Text.Length == 0)// LA PRIMERA LETRA ESTE EN MAYUSCULA
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else if (TxtPapellido.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void txtARP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))// Permite  la tecla espace
            {
                e.Handled = false;
            }
            else
            {
                _objUtilidades.Mensajes("Advertencia", "Solo se permiten Letras");
                e.Handled = true;
            }
            if (TxtPapellido.Text.Length == 0)// LA PRIMERA LETRA ESTE EN MAYUSCULA
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else if (TxtPapellido.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void txtContrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))// Permite  la tecla espace
            {
                e.Handled = false;
            }
            else
            {
                _objUtilidades.Mensajes("Advertencia", "Solo se permiten Letras");
                e.Handled = true;
            }
            if (TxtPapellido.Text.Length == 0)// LA PRIMERA LETRA ESTE EN MAYUSCULA
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else if (TxtPapellido.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void txtEps_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar)) //Permite  la tecla espace
            {
                e.Handled = false;
            }
            else
            {
                _objUtilidades.Mensajes("Advertencia", "Solo se permiten Letras");
                e.Handled = true;
            }
            if (TxtPapellido.Text.Length == 0)// LA PRIMERA LETRA ESTE EN MAYUSCULA
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else if (TxtPapellido.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void txtCompensaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))// Permite  la tecla espace
            {
                e.Handled = false;
            }
            else
            {
                _objUtilidades.Mensajes("Advertencia", "Solo se permiten Letras");
                e.Handled = true;
            }
            if (TxtPapellido.Text.Length == 0)// LA PRIMERA LETRA ESTE EN MAYUSCULA
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else if (TxtPapellido.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void ChekFecha_Click(object sender, EventArgs e)
        {
            validarchek();
        }

        private void CmbSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CmbDisponibilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbxContrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'smartPrintDataSet.BuscarContrato' Puede moverla o quitarla según sea necesario.
            cbxContrato.SelectedIndex = -1;

        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            VistaEmpleados Empleado = new VistaEmpleados();
            Empleado.ShowDialog();
        }

        private void cbxContrato_Click(object sender, EventArgs e)
        {
           
            this.buscarContratoTableAdapter.Fill(this.smartPrintDataSet.BuscarContrato);
            cbxContrato.Text = "";
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPensiones_TextChanged(object sender, EventArgs e)
        {
            txtPensiones.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtPensiones.Text);
            txtPensiones.SelectionStart = txtPensiones.Text.Length;//PARA QUE TODAS LAS PRIMERAS LETRAS SEAN MAYUSCULAS
        }

        private void txtARP_TextChanged(object sender, EventArgs e)
        {
            txtARP.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtARP.Text);
            txtARP.SelectionStart = txtARP.Text.Length;//PARA QUE TODAS LAS PRIMERAS LETRAS SEAN MAYUSCULAS
        }

        private void txtEps_TextChanged(object sender, EventArgs e)
        {
            txtEps.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtEps.Text);
            txtEps.SelectionStart = txtEps.Text.Length;//PARA QUE TODAS LAS PRIMERAS LETRAS SEAN MAYUSCULAS
        }

        private void txtCompensaciones_TextChanged(object sender, EventArgs e)
        {
            txtCompensaciones.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtCompensaciones.Text);
            txtCompensaciones.SelectionStart = txtCompensaciones.Text.Length;//PARA QUE TODAS LAS PRIMERAS LETRAS SEAN MAYUSCULAS
        }

        private void txtCompensaciones_KeyPress_1(object sender, KeyPressEventArgs e)
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