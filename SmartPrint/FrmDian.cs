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
    public partial class FrmDian : Form
    {
        Logica.LDian _dian = new Logica.LDian();
        private Dictionary<string, string> perfil;//Se declara un diccionario para pasar el perfil que viene del loguin
        public FrmDian(Dictionary<string, string> Perfil)//constructor que le pasamos un diccionario
        {   
            InitializeComponent();
         

            perfil = Perfil;
        }
         //INSTANCIA DE LOGICA

        public void Validar() {
           
            
            
           var res = _dian.Rango(_dian);
           if (res == null) return;
           var Num1 = res.Rows[0][1].ToString();
           var num2 = float.Parse(txtFinal.Text);
           if (num2 <= float.Parse(Num1)) {
           MessageBox.Show("Rango invalido, verifique", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Error);
           txtFinal.Clear();
           TxtInicial.Clear();
               
           
           }


            
        }
        public void Gestionar()//Método para guardar y moficar
        {
            Validar();

            if ((string.IsNullOrWhiteSpace(TxtInicial.Text)) || (string.IsNullOrWhiteSpace(txtFinal.Text)) || (string.IsNullOrWhiteSpace(txtResoucion.Text)))
            {

                MessageBox.Show("Debe ingresar todos los datos solicitados", "SmartPrint");

            }
            else if (Convert.ToInt32(TxtInicial.Text) >= Convert.ToInt32(txtFinal.Text))
            {
                MessageBox.Show("El Rango inicial no puede ser menor al Final", "Smarprint", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                   


                try
                {

                    _dian = new Logica.LDian//INTACIA DE LOGICA
                    {


                        RangoInicial = float.Parse(TxtInicial.Text),
                        RangoFinal = float.Parse(txtFinal.Text),
                        Usuario = perfil["Usuario"],
                        Resolucion = txtResoucion.Text
                    };

                    if (MessageBox.Show("¿Seguro que desea Continuar?", "SmartPrint", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Validar();
                       
                        _dian.Gestionar(_dian);//DISPARA EL PROCEDIMIENTO
                        TxtInicial.Clear();//BORRAR
                        txtFinal.Clear();

                        txtResoucion.Clear();
                        //mensaje de exito
                        MessageBox.Show("Operación exitosa", "Smartprint", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Operación cancelada", "Smartprint", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
                
                catch (Exception e)
                {
                    MessageBox.Show("No se puede guardar ese rango, por favor Verificar que no esté ya registrado", "SmartPrint", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
            }
        }
        
        private void TxtInicial_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Advertencia", "Solo se permiten números");
                e.Handled = true;
            }
        }
        private void txtFinal_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Advertencia", "Solo se permiten números");
                e.Handled = true;
            }

        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Gestionar();
        }

        private void BtnDian_Click(object sender, EventArgs e)
        {
            VistaDian Dian = new VistaDian();
            Dian.ShowDialog();
        }
      
    }
}
