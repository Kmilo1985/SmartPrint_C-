using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DClientes
    {
        Datos.DComun Comun = new Datos.DComun();
        Datos.SmartPrintEntities context = new Datos.SmartPrintEntities();


        //Metodo que nos permite llamar procedimiento para modificar y registrar
        public List<string> GestionarCliente(string Cedula, String Nombre, String Telefono, int Ext, String Celular, string Fax,
           String Direccion, String Email, String Observaciones, String Habilitar, String Usuario,string Contacto)
        {
            List<string> Clientes = context.GestionarCliente(Cedula, Nombre, Telefono, Ext, Celular, Fax, Direccion, Email,
            Observaciones, Habilitar, Usuario,Contacto).ToList();

            return Clientes;
        }
        // metodo que nos permite Llamar el procedimiento que  Guarda y Modifica

        public DataTable Buscar(String cedula)
        {
            var Ser = (from C in context.Cliente
                       where C.Cedula == cedula
                       select new { C.Cedula, C.Nombre, C.Telefono, C.Ext, C.Celular, C.Fax, C.Direccion, C.Email, C.Observaciones, C.Habilitar,C.Contacto }).ToList();
            return DComun.ToDataTable(Ser);
        }
        public DataTable BuscarCliente(DateTime FechaInicial, DateTime FechaFinal)
        {
            var Cliente = (context.BuscClientes(FechaInicial, FechaFinal)).ToList();
            return DComun.ToDataTable(Cliente);
        }
        //public DataTable BuscarNombre(String Nombre)
        //{
        //    var otrosSEr = (from C in context.Cliente

        //                    where C.Nombre == Nombre
        //                    select new { C.Cedula, C.Nombre, C.Telefono, C.Celular, C.Usuario, C.Fecha }).ToList();
        //    return DComun.ToDataTable(otrosSEr);
        //}
        public DataTable BuscarNombre(String Nombre)
        {
            var otrosSEr = (context.BuscarNomCli(Nombre)).ToList();

            return DComun.ToDataTable(otrosSEr);
        }
    }
}
