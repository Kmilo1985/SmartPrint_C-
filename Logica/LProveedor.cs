using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LProveedor
    {
        public LProveedor()
        {

        }
        Datos.DProveedor Proveedor = new Datos.DProveedor();

        public String Nit { get; set; }
        public String Razon { get; set; }
        public String Contacto { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public int Ext { get; set; }
        public String Fax { get; set; }
        public String Celular { get; set; }
        public String Email { get; set; }
        public String Observaciones { get; set; }
        public String Habilitar { get; set; }
        public String Usuario { get; set; }

        public LProveedor(String Nit, String Razon, String Contacto, String Direccion, String Telefono, int Ext, String Fax, String Celular, String Email, String Observaciones, String Habilitar, String usuario)
        {
            this.Nit = Nit;
            this.Razon = Razon;
            this.Contacto = Contacto;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Ext = Ext;
            this.Fax = Fax;
            this.Celular = Celular;
            this.Email = Email;
            this.Observaciones = Observaciones;
            this.Habilitar = Habilitar;
            Usuario = usuario;
        }
        public List<string> GestionarProveedor(LProveedor Prov)
        {
            return Proveedor.GestionarProveedor(Prov.Nit, Prov.Razon, Prov.Contacto, Prov.Direccion, Prov.Telefono, Prov.Ext, Prov.Fax, Prov.Celular, Prov.Email, Prov.Observaciones, Prov.Habilitar, Prov.Usuario);
        }

        public DataTable Buscar(LProveedor Prov)
        {
            return Proveedor.Buscar(Prov.Nit);
        }
        public DataTable BuscarProveedor(DateTime FechaInicial, DateTime FechaFinal)
        {
            return Proveedor.BuscarProveedor(FechaInicial, FechaFinal);
        }
    }
}
