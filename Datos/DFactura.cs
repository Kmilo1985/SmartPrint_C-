using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DFactura
    {
        Datos.DComun Comun = new Datos.DComun();
        Datos.SmartPrintEntities context = new Datos.SmartPrintEntities();

        public List<string> GuardarFactura(int NumeroFactura, int NumeroOrden, String Cedula, DateTime FechaFactura, String Observaciones, float Subtotal, float ValorIva, float Impuestos, float Descuento, float Total, string Estado, string Usuario, string Mora, string EstadoFac, int NumeroRemision)
        {
            var empleados = context.RegistrarFactura(NumeroFactura, NumeroOrden, Cedula, FechaFactura, Observaciones, Total, ValorIva, Descuento, Impuestos, Subtotal, Estado, Usuario, Mora, EstadoFac,NumeroRemision).ToList();
            return empleados;
        }

        public DataTable CargarOrden(int NumeroOrden)
        {
            var Factura = (from O in context.OrdenServicio
                           join C in context.Cliente
                           on O.Cedula equals C.Cedula
                           where O.NumeroOrden == NumeroOrden
                           select new { O.Cedula, C.Nombre, C.Direccion, C.Telefono, O.Estado,O.NumeroRemision }).ToList();
            return DComun.ToDataTable(Factura);
        }
      
        public DataTable BuscarOrdenesServices(int numeroOrden)
        {
            var lstOrdenes = (context.BuscarServicioFactura(numeroOrden)).ToList();
            return DComun.ToDataTable(lstOrdenes);
        }
        public DataTable MostrarCodigo()
        {

            var mostrarMax = (context.MostrarCodigoFactura()).ToList();
            return DComun.ToDataTable(mostrarMax);
        }
        public DataTable BuscarFactura(int NumeroFactura)
        {

            var mostrarMax = (context.ReporteFactura(NumeroFactura)).ToList();
            return DComun.ToDataTable(mostrarMax);
        }

        public List<string> Modificar(int NumeroFactura, string EstadoFac, string Mora)
        {
            var empleados = context.InhabilitarFactura(NumeroFactura, EstadoFac, Mora).ToList(); 
            return empleados;
        }

    }
}
