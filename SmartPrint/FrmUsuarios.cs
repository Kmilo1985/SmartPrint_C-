using System;
using System.Windows.Forms;
using Logica;
using System.Data;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace SmartPrint
{
    public partial class FrmUsuarios : Form
    {

        #region Declaraciones

        readonly LUtilidades _objUtilidades = new LUtilidades();
        private Dictionary<string, string> perfil;

        #endregion
        public FrmUsuarios(Dictionary<string, string> Perfil)
        {

            InitializeComponent();
            perfil = Perfil;
            Inhabilitar();
            TxtCodigo.Enabled = true;
            TxtConfirmar.Visible = false;
            LblConfirmar.Visible = false;
            GridViewUsuario.AllowUserToOrderColumns = false;
            GridViewUsuario.ReadOnly = true;
            BtnGuardar.Enabled = false;
        }
        LUsuarios _usu = new LUsuarios();
        public bool ValidarContraseña(string Contraseña)
        {
            const string Expresion = "(?=^.{8,15}$)((?=.*\n)(?=.*[A-Z])(?=.*[a-z])|(?=.*\n)(?=.*[^A-Za-z0-9])(?=.*[a-z])|(?=.*[^A-Za-z0-9])(?=.*[A-Z])(?=.*[a-z])|(?=.*\n)(?=.*[A-Z])(?=.*[^A-Za-z0-9]))^.*";

            if (Regex.IsMatch(Contraseña, Expresion))
            {
                return Regex.Replace(Contraseña, Expresion, String.Empty).Length == 0;
            }
            else
            { return false; }
        }
        public void Clear()//Método para limpiar
        {
            TxtCodigo.Clear();
            TxtNombre.Clear();
            TxtUsuario.Clear();
            TxtContraseña.Clear();
            TxtConfirmar.Clear();
            TxtConfirmar.Visible = false;
            LblConfirmar.Visible = false;
            Inhabilitar();
            TxtCodigo.Enabled = true;
            CbxEstado.SelectedItem = null;
            CbxPerfil.SelectedItem = null;
            MostrarTodos();
            BtnGuardar.Enabled = false;
            BtnModificar.Enabled = false;
        }
        public void Habilitar()//Método para habilitar
        {

            TxtUsuario.Enabled = true;
            TxtContraseña.Enabled = true;
            CbxEstado.Enabled = true;
            CbxPerfil.Enabled = true;

        }
        public void Inhabilitar()//Método para inhabilitar
        {
            TxtCodigo.Enabled = false;
            TxtNombre.Enabled = false;
            TxtUsuario.Enabled = false;
            TxtContraseña.Enabled = false;
            CbxEstado.Enabled = false;
            CbxPerfil.Enabled = false;
        }
        public void Comun()//Método para guardar y modificar
        {
            TxtUsuario.Text = TxtUsuario.Text.Trim();
            TxtContraseña.Text = TxtContraseña.Text.Trim();
            if ((TxtCodigo.Text.Equals("")) || (TxtNombre.Text.Equals("")) || (TxtUsuario.Text.Equals("")) || (TxtContraseña.Text.Equals("")) || (TxtConfirmar.Text.Equals("")))
            {
                MessageBox.Show("Por favor ingrese la información solicitada", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if ((CbxEstado.SelectedIndex.Equals(-1)) || (CbxPerfil.SelectedIndex.Equals(-1)))
            {
                MessageBox.Show("Por favor Seleccione una opción válida", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                var Contraseña = ValidarContraseña(TxtContraseña.Text);
                if (!Contraseña)
                {
                    MessageBox.Show("Debe ingresar una contraseña válida", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtContraseña.Clear();
                }
                else
                {
                    try
                    {
                        var Confirmar = TxtConfirmar.Text;
                        _usu = new LUsuarios
                        {
                            Codigo = TxtCodigo.Text,
                            Usuario = TxtUsuario.Text,
                            Contrasena = TxtContraseña.Text,
                            Perfil = CbxPerfil.SelectedItem.ToString(),
                            Estado = CbxEstado.SelectedItem.ToString(),
                            Creador = perfil["Usuario"]

                        };
                        TxtUsuario.Text = TxtUsuario.Text.Trim();
                        TxtContraseña.Text = TxtContraseña.Text.Trim();

                        if (_usu.Contrasena != Confirmar)
                        {

                            MessageBox.Show("La confirmación de la contraseña no coincide ", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {

                            if (MessageBox.Show("¿Desea cotinuar?", "SmartPrint", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                            {

                                _usu.GestionarServicios(_usu);
                                MessageBox.Show("Operación exitosa", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Clear();
                                MostrarTodos();
                            }
                            else
                            {

                                MessageBox.Show("Operación Cancelada",
                                                     "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("El Usuario ya existe", "SmartPtint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtUsuario.Clear();
                    }

                }
            }
        }
        public void MostrarTodos()
        {
            var dUsuarios = _usu.MostrarTodos();
            GridViewUsuario.DataSource = dUsuarios;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Comun();
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Comun();
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();

        }
        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
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
                _objUtilidades.Mensajes("Advertencia", "Solo números");
                //MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
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
                _objUtilidades.Mensajes("Advertencia", "Solo letras");
                //MessageBox.Show("Solo Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        public void Buscar()
        {
            try
            {
                _usu = new Logica.LUsuarios();
                _usu.Codigo = (TxtCodigo.Text);
                DataTable res = _usu.Buscar(_usu);
                if (res != null)
                {
                   
                    TxtCodigo.Enabled = false;
                    TxtNombre.Enabled = false;
                    BtnModificar.Enabled = true;
                    TxtNombre.Text = res.Rows[0][1].ToString();
                    TxtUsuario.Text = res.Rows[0][2].ToString();
                    TxtContraseña.Text = res.Rows[0][3].ToString();
                    CbxPerfil.SelectedItem = res.Rows[0][4].ToString();
                    CbxEstado.SelectedItem = res.Rows[0][5].ToString();
                    TxtConfirmar.Text = res.Rows[0][3].ToString();
                    TxtConfirmar.Visible = true;
                    LblConfirmar.Visible = true;
                    BtnGuardar.Enabled = false;
                    GridViewUsuario.DataSource = res;

                    if (res.Rows[0][5].ToString().Equals("Activo"))
                    {
                        Habilitar(); //Permite habilitar los campos
                        BtnGuardar.Enabled = false;

                    }

                    else
                    {
                        Inhabilitar();
                        CbxEstado.Enabled = true;
                        BtnGuardar.Enabled = false;
                    }
                 
                }
                else
                {

                }

            }
            catch (Exception)
            {
                try
                {
                    DataTable Res1 = _usu.BuscarNombre(_usu);
                    if (Res1 != null)
                    {
                        TxtCodigo.Enabled = false;
                        TxtNombre.Enabled = false;
                        TxtNombre.Text = Res1.Rows[0][1].ToString();
                        Habilitar();
                        TxtConfirmar.Visible = true;
                        LblConfirmar.Visible = true;
                        BtnModificar.Enabled = false;
                        BtnGuardar.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Usuario y Empleado no Existen, por favor registre primero el empleado", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Inhabilitar();
                    TxtCodigo.Enabled = true;
                    Clear();
                }


            }
        }
        //METODO PARA LLENAR EL GRIDVIEW
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            MostrarTodos();
         }

        private void GridViewUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewUsuario.CurrentRow != null)
            {
                TxtCodigo.Text = GridViewUsuario.CurrentRow.Cells[0].Value.ToString();
                TxtNombre.Text = GridViewUsuario.CurrentRow.Cells[1].Value.ToString();
                TxtUsuario.Text = GridViewUsuario.CurrentRow.Cells[2].Value.ToString();
                TxtContraseña.Text = GridViewUsuario.CurrentRow.Cells[3].Value.ToString();
                TxtConfirmar.Text = GridViewUsuario.CurrentRow.Cells[3].Value.ToString();
                CbxPerfil.SelectedItem = GridViewUsuario.CurrentRow.Cells[4].Value.ToString();
                CbxEstado.SelectedItem = GridViewUsuario.CurrentRow.Cells[5].Value.ToString();
            }
            BtnModificar.Enabled = true;
            BtnGuardar.Enabled = false;
            TxtCodigo.Enabled = false;
            TxtNombre.Enabled = false;
            TxtConfirmar.Visible = true;
            LblConfirmar.Visible = true;
            Habilitar();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void CbxPerfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void CbxEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

      
    }
}




