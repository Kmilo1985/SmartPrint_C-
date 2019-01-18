using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DConsultas
    {
        DComun Comun = new DComun();
        readonly SmartPrintEntities context = new SmartPrintEntities();

        public DataTable Buscar(String cedula)
        {
            var consulta = (from C in context.Cliente
                            where C.Cedula == cedula
                            select new { C.Cedula, C.Nombre }).ToList();
            return DComun.ToDataTable(consulta);
        }
        public DataTable BuscarFactura(String cedula, DateTime FechaInicial, DateTime FechaFinal)
        {
            var Factura = (context.BuscarFacturaFechaCedula(cedula, FechaInicial, FechaFinal)).ToList();
            return DComun.ToDataTable(Factura);
        }
        public DataTable BuscarOden(String cedula, DateTime FechaInicial, DateTime FechaFinal)
        {
            var Orden = (context.BuscarOrdenFechaCedula(cedula, FechaInicial, FechaFinal)).ToList();
            return DComun.ToDataTable(Orden);
        }
        public DataTable BuscarRemision(String cedula, DateTime FechaInicial, DateTime FechaFinal)
        {
            var Remision = (context.BuscarRemisionFechaCedula(cedula, FechaInicial, FechaFinal)).ToList();
            return DComun.ToDataTable(Remision);
        }

        public DataTable BuscarMora(String cedula)
        {
            var Mora = (context.BuscarMora(cedula)).ToList();
            return DComun.ToDataTable(Mora);
        }
    }
}
