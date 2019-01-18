using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Datos
{
    public class DUsuarios
    {
        DComun Comun = new DComun();
        readonly SmartPrintEntities _context = new SmartPrintEntities();


        public List<string> GestionarUsuarios(String codigo, String usuario, String contrasena, String perfil, String estado, string Creador)
        {
            var usuarios = _context.GestionarUsuarios(codigo, usuario, contrasena, perfil, estado, Creador).ToList();
            return usuarios;
        }

        public DataTable Buscar(String codigo)
        {
            var usuarios = (from u in _context.Usuarios
                            join E in _context.Empleado
                            on u.CedulaEmpleado equals E.CedulaEmpleado
                            where E.CedulaEmpleado == codigo
                            select new { E.CedulaEmpleado, Nombre = E.PrimerNombre + " " + E.SegundoNombre + " " + E.SegundoApellido + " " + E.SegundoApellido, u.Usuario, u.Contrasena, u.Perfil, u.Estado, u.Creador, u.Fecha }).ToList();
            return DComun.ToDataTable(usuarios);
        }

        public DataTable BuscarNombre(String codigo)
        {
            var usuarios = (from E in _context.Empleado
                            where E.CedulaEmpleado == codigo
                            select new { E.CedulaEmpleado, Nombre = E.PrimerNombre + " " + E.SegundoNombre + " " + E.SegundoApellido + " " + E.SegundoApellido }).ToList();
            return DComun.ToDataTable(usuarios);
        }

        //Método para llenar gridview
        public DataTable MostrarTodos()
        {
            return DComun.ToDataTable(_context.VistaUsuarios.ToList());
        }
        }
}
