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
    public partial class FrmMenu : Form
    {
        private Dictionary<string, string> perfil;
        Logica.LDian _Dian = new Logica.LDian();//instancia de la Dian

        public FrmMenu(Dictionary<string, string> Perfil)
        {
            InitializeComponent();
            perfil = Perfil;
            BtnDian.Visible = true;

        }

        //boton empleados
        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            FrmEmpleado FrmInicio = new FrmEmpleado(perfil);
            FrmInicio.ShowDialog();
        }
        //Boton proveedor
        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            FrmProveedores FrmInicio = new FrmProveedores(perfil);
            FrmInicio.ShowDialog();
        }
        //Boton Ciente
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            FrmClientes FrmInicio = new FrmClientes(perfil);
            FrmInicio.ShowDialog();

        }
        //Boton Remision
        private void BtnRemision_Click(object sender, EventArgs e)
        {
            FrmRemision FrmInicio = new FrmRemision(perfil);
            FrmInicio.ShowDialog();
        }
        //boton Orden
        private void BtnOrden_Click(object sender, EventArgs e)
        {
            FrmOrdenServicio FrmInicio = new FrmOrdenServicio(perfil);
            FrmInicio.ShowDialog();
        }
        //boton Factura
        private void BtnFactura_Click(object sender, EventArgs e)
        {
            
                FrmFactura Factura = new FrmFactura(perfil);
                Factura.ShowDialog();
           

        }
        //Boton Servicio
        private void BtnServicios_Click(object sender, EventArgs e)
        {
            FrmServicios FrmInicio = new FrmServicios(perfil);
            FrmInicio.ShowDialog();
        }
        //Boton otros servicio
        private void BtnOtros_Click(object sender, EventArgs e)
        {
            FrmOtrosServicios FrmInicio = new FrmOtrosServicios(perfil);
            FrmInicio.ShowDialog();
        }
        //Boton consultas
        private void BtnConsultas_Click(object sender, EventArgs e)
        {
            FrmConsultas FrmInicio = new FrmConsultas();
            FrmInicio.ShowDialog();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios FrmInicio = new FrmUsuarios(perfil);
            FrmInicio.ShowDialog();

        }
        //Para que no permita cerrarlo si hay otro formulario abierto
        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count > 3)
            {
                MessageBox.Show("Existen otras ventanas Abiertas, cierrelas", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;

            }
            else
            {
                Application.Exit();
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnDian_Click(object sender, EventArgs e)
        {
            

                FrmDian FrmInicio = new FrmDian(perfil) ;
                FrmInicio.ShowDialog();


        }

        }
    }

