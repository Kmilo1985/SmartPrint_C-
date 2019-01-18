using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LClientes
    {
        Datos.DClientes Clientes = new Datos.DClientes();
        public LClientes()
        {
        }

        public string Cedula { get; set; }
        public String Nombre { get; set; }
        public String Telefono { get; set; }
        public int Ext { get; set; }
        public string Celular { get; set; }
        public String Fax { get; set; }
        public String Direccion { get; set; }
        public String Email { get; set; }
        public string Observaciones { get; set; }
        public String Habilitar { get; set; }
        public string Usuario { get; set; }
        public string Contacto { get; set; }



        public LClientes(String cedula, String nombre, String telefono, int ext, String celular, string fax,
            String direccion, String email, String observaciones, String habilitar, string usuario, string contacto)
        {
            Cedula = cedula;
            Nombre = nombre;
            Telefono = telefono;
            Ext = ext;
            Celular = celular;
            Fax = fax;
            Direccion = direccion;
            Email = email;
            Observaciones = observaciones;
            Habilitar = habilitar;
            Contacto = contacto;
            //Usuario = usuario;
        }

        public List<string> GestionarCliente(LClientes CLien)
        {

            return Clientes.GestionarCliente(CLien.Cedula, CLien.Nombre, CLien.Telefono, CLien.Ext, CLien.Celular,
                CLien.Fax, CLien.Direccion, CLien.Email, CLien.Observaciones, CLien.Habilitar, CLien.Usuario,CLien.Contacto);
        }
        public DataTable Buscar(LClientes CLien)
        {
            return Clientes.Buscar(CLien.Cedula);
        }

        public DataTable BuscarCliente(DateTime FechaInicial, DateTime FechaFinal)
        {
            return Clientes.BuscarCliente(FechaInicial, FechaFinal);
        }

        public DataTable BuscarNombre(LClientes CLien)
        {
            return Clientes.BuscarNombre(CLien.Nombre);
        }

    }
}
