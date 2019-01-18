using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DRemision
    {
        DComun _comun = new DComun();
        readonly SmartPrintEntities _context = new SmartPrintEntities();

        public DataTable ObtenerServicios()
        {
            try
            {
                var objTabla = (_context.ObtenerServicios()).ToList();
                return DComun.ToDataTable(objTabla);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ObtenerOtrosServicios()
        {
            try
            {
                var objTabla = (_context.ObtenerOtroServicio()).ToList();
                return DComun.ToDataTable(objTabla);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable BuscarCedula(String cedula)
        {
            var remision = (from c in _context.Cliente
                            where c.Cedula == cedula
                            select new { c.Cedula, c.Nombre, c.Direccion, c.Telefono, c.Observaciones }).ToList();
            return DComun.ToDataTable(remision);
        }
        public String MostrarCodigo()
        {
            var mostrarMax = (from r in _context.Remision
                              select r.NumeroRemision).Max().ToString();
            return mostrarMax;
        }

        public List<string> GuardarRemision(int numeroRemision, string identificacion, DateTime fechaVencimiento, string observaciones, float subtotal, float Iva, float Total, string Usuario)
        {
            //Se le estan asiganando a esas constantes los campos que vienen de Base de datos, se esta haciendo la 
            //conexion a la bd por el Contex y se llama el procedimiento para que Guarde
            var remision = new List<string>(_context.RegistrarRemision(numeroRemision, identificacion, fechaVencimiento,
                observaciones, subtotal, Iva, Total, Usuario));
            return remision;

        }

        public List<string> GuardarRemisionServicios(int numeroRemision, int item, int cantidad, int vrUnitario, int total, String Nombre)
        {
            var remision = new List<string>(_context.RegistrarRemisionServicios(numeroRemision, item, cantidad, vrUnitario, total, Nombre));
            return remision;

        }
       

    }
       

}
