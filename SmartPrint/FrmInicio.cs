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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        Logica.LLoguin Cuenta = new Logica.LLoguin();
           
        
        //LOAD
        private void Inicio_Load(object sender, EventArgs e)
        {
            LblFecha.Text = DateTime.Now.ToString();
        }
             

     
        
        //public void Limpiar() {
        //    TxtContraseña.Clear();
        //    TxtUsuario.Clear();
        
        //}

        // ********************** EVENTOS DEL FORMULARIO *********************************

        // METODO PARA VALIDAR EL INICIO
        public static int Intentos = 0;
        
        public void ValidarUsuario()
            
        {
                try
                {
                    if (TxtUsuario.Text.Equals("") || TxtContraseña.Text.Equals(""))
                       
                    {
                        MessageBox.Show("Debe ingresar un Usuario y Contraseña para acceder", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                         Cuenta = new Logica.LLoguin(TxtUsuario.Text, TxtContraseña.Text);
                        Dictionary<string, string> Usuario = Cuenta.IniciarSesion(Cuenta);

                        if (Usuario.Count>0)
                        {
                            MessageBox.Show("Bienvenid @ " + Usuario["Usuario"], "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (Usuario["perfil"] == "Empleado")
                            {

                                this.Hide();
                                var Inicio = new FrmMenu(Usuario) { BtnUsuarios = { Visible = false }, BtnDian = { Visible = false } };
                                Inicio.Show();
                            }
                                                        
                            else
                            {

                                this.Hide();
                                FrmMenu FrmInicio = new FrmMenu(Usuario);
                                FrmInicio.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario y/o Contraseña incorrectos", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception)
                { }
            }

        //INGRESAR
        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ValidarUsuario();
            }
        }
        private void Ingresar_Click(object sender, EventArgs e)
        {
            ValidarUsuario();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ValidarUsuario();

            }
        }
              
    }
}
