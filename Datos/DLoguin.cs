using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;

namespace Datos
{
    public class DLoguin
    {
        // ENTIDAD 
        readonly SmartPrintEntities _context = new SmartPrintEntities();
        DComun comun = new DComun();


        // INICIAR SESION
        public Dictionary<string, string> IniciarSesion(string usu, string pass)
        {

            Dictionary<string, string> Usuario = new Dictionary<string, string>();
            var usuarios = _context.Loguin(usu, pass).ToList();

            if (usuarios.Count != 0)
            {
                Usuario.Add("Usuario", usuarios.First().Usuario);
                Usuario.Add("perfil", usuarios.First().Perfil);

            }


            return Usuario;
        }

    }
}
