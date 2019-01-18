using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DServicios
    {
        Datos.DComun Comun = new Datos.DComun();
        readonly SmartPrintEntities _context = new SmartPrintEntities();

        //se estan nombrando los campos que necesitamos
        public List<string> Guardar(string nombre, string tipo, int codigo, string observacines, float valorUnitario, string Usuario)
        {

            //Se le estan asiganando a esas constantes los campos que vienen de Base de datos, se esta haciendo la 
            //conexion a la bd por el Contex y se llama el procedimiento para que Guarde
            var servicios = _context.GestionarServicio(nombre, tipo, codigo, observacines, valorUnitario, Usuario).ToList();
            return servicios;

        }
        //sE ESTA LLAMANDO LA VISTA DESDE LA BD PARA QUE MUESTO TODOS LOS CAMPOS EN EL GRIVIEW
        public DataTable MostrarTodos()
        {
            return DComun.ToDataTable(_context.VistaServicios.ToList());
        }


        public DataTable BuscarCodigo(int codigo)
        {
            var Ser = (from S in _context.Servicios
                       where S.Item == codigo
                       select new { S.Item, S.Nombre, S.Tipo, S.ValorUnitario, S.Observaciones, S.Usuario, S.Fecha }).ToList();
            return DComun.ToDataTable(Ser);
        }

        public DataTable BuscarNombre(String Nombre)
        {
            var Ser = (from S in _context.Servicios
                       where S.Nombre == Nombre
                       select new { S.Item, S.Nombre, S.Tipo, S.ValorUnitario, S.Observaciones,S.Usuario, S.Fecha }).ToList();
            return DComun.ToDataTable(Ser);
        }

        public DataTable MostrarCodigo()
        {
            var lstOrdenes = (_context.MostrarCodigo()).ToList();
            return DComun.ToDataTable(lstOrdenes);
        }




    }
}

