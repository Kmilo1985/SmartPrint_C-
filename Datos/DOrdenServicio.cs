using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DOrdenServicio
    {
        Datos.DComun Comun = new Datos.DComun();
        Datos.SmartPrintEntities context = new Datos.SmartPrintEntities();

        public List<string> GuardarOrdenServicio(int numeroOrden, int numeroRemision, string Cedula, string CedulaEmpleado, DateTime fechaOrden, string estado, String observaciones, String Usuario)
        {

            var Orden = new List<string>(context.RegistrarOrden(numeroOrden, numeroRemision, Cedula, CedulaEmpleado, fechaOrden, estado, observaciones, Usuario));
            return Orden;

        }
        public String MostrarCodigo()
        {

            var mostrarMax = (from O in context.OrdenServicio
                              select O.NumeroOrden).Max().ToString();
            return mostrarMax;
        }


        public DataTable CargarRemision(int NumeroRemision)
        {
            var Ordenes = (from R in context.Remision
                           join C in context.Cliente
                           on R.CcNit equals C.Cedula
                           where R.NumeroRemision == NumeroRemision
                           select new { R.CcNit, C.Nombre, C.Direccion, C.Telefono, R.Subtotal, R.Iva, R.Total }).ToList();
            return DComun.ToDataTable(Ordenes);
        }
        public DataTable BuscarRemision(int numeroRemision)
        {
            var lstOrdenes = (context.BuscarRemision(numeroRemision)).ToList();
            return DComun.ToDataTable(lstOrdenes);
        }
        public DataTable BuscarOrdenesServices(int numeroRemision)
        {
            var lstOrdenes = (context.SpBuscar_RemisionServicios(numeroRemision)).ToList();
            return DComun.ToDataTable(lstOrdenes);
        }
        public DataTable VistaCombo()
        {
            var lstEmpleados = (context.VistaEmpleados).ToList();
            return DComun.ToDataTable(lstEmpleados);
        }
    }
}
