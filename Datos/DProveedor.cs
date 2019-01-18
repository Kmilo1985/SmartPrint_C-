using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DProveedor
    {
        Datos.DComun Comun = new Datos.DComun();
        Datos.SmartPrintEntities context = new Datos.SmartPrintEntities();
        public List<string> GestionarProveedor(String Nit, String Razon, String Contacto, String Direccion, String Telefono, int Ext, String Fax, String Celular, String Email, String Observaciones, String Habilitar, string Usuario)
        {
            List<string> Proveedores = context.GestionarProveedor(Nit, Razon, Contacto, Direccion, Telefono, Ext, Fax, Celular, Email, Observaciones, Habilitar, Usuario).ToList();
            return Proveedores;

        }
        public DataTable Buscar(String cedula)
        {
            var Ser = (from P in context.Proveedores
                       where P.Nit == cedula
                       select new { P.Nit, P.RazonSocial, P.Contacto, P.Direccion, P.Telefono, P.Ext, P.Fax, P.Celular, P.Email, P.Observaciones, P.Habilitar }).ToList();
            return DComun.ToDataTable(Ser);
        }
        public DataTable BuscarProveedor(DateTime FechaInicial, DateTime FechaFinal)
        {
            var Cliente = (context.BuscarProveedor(FechaInicial, FechaFinal)).ToList();
            return DComun.ToDataTable(Cliente);
        }

    }
}