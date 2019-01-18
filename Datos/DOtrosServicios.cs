using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DOtrosServicios
    {
        Datos.DComun Comun = new Datos.DComun();
        readonly SmartPrintEntities _context = new SmartPrintEntities();

        public List<string> Guardar(int codigo, String idProveedor, String nombre, String observaciones, String serial, float valorUnitario, String Usuario)
        {
            var otrosServicios = _context.GestionarOtrosServicio(codigo, idProveedor, nombre, observaciones, serial, valorUnitario, Usuario).ToList();
            return otrosServicios;
        }
        //METODO PARA LLENAR EL GRIDVIEW
        public DataTable MostrarTodos()
        {
            return DComun.ToDataTable(_context.VistaOtrosServicios.ToList());
        }

        //METODO PARA LLENAR EL COMBOBOX DE PROVEEDORES
        public DataTable MostrarProveedores()
        {
            return DComun.ToDataTable(_context.MostrarComboProveedor.ToList());
        }

        public DataTable Buscar(int codigo)
        {
            var otrosSEr = (from o in _context.OtrosServicios
                            join p in _context.Proveedores
                            on o.Idproveedor equals p.Nit
                            where o.Codigo == codigo
                            select new { o.Codigo,o.Idproveedor, p.RazonSocial, o.Nombre, o.Observaciones, o.Serial, o.ValorUnitario, o.Usuario, o.Fecha }).ToList();
            return DComun.ToDataTable(otrosSEr);
        }

        public DataTable BuscarNombre(String Nombre)
        {
            var otrosSEr = (from o in _context.OtrosServicios
                            join p in _context.Proveedores
                            on o.Idproveedor equals p.Nit
                            where o.Nombre == Nombre
                            select new { o.Codigo, o.Idproveedor, p.RazonSocial, o.Nombre, o.Observaciones, o.Serial, o.ValorUnitario, o.Usuario, o.Fecha }).ToList();
            return DComun.ToDataTable(otrosSEr);
        }

    }
}