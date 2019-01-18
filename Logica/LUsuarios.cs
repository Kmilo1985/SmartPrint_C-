using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LUsuarios
    {
        public LUsuarios()
        {

        }
        Datos.DUsuarios Usuarios = new Datos.DUsuarios();
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Usuario { get; set; }
        public String Contrasena { get; set; }
        public String Perfil { get; set; }
        public String Estado { get; set; }
        public String Creador { get; set; }

        public LUsuarios(String Codigo, String Usuario, String Nombre, String Contrasena, String Perfil, String Estado, string creador)
        {
            this.Codigo = Codigo;
            this.Nombre = Nombre;
            this.Usuario = Usuario;
            this.Contrasena = Contrasena;
            this.Perfil = Perfil;
            this.Estado = Estado;
            Creador = creador;
        }
        public List<string> GestionarServicios(LUsuarios Usu)
        {
            return Usuarios.GestionarUsuarios(Usu.Codigo, Usu.Usuario, Usu.Contrasena, Usu.Perfil, Usu.Estado, Usu.Creador);
        }

        public DataTable Buscar(LUsuarios Usu)
        {
            return Usuarios.Buscar(Usu.Codigo);
        }

        public DataTable BuscarNombre(LUsuarios Usu)
        {
            return Usuarios.BuscarNombre(Usu.Codigo);
        }

        //MOSTRAR LISTADO DE CUENTAS
        public DataTable MostrarTodos()
        {
            return Usuarios.MostrarTodos();
        }

    }
}
