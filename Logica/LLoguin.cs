using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Logica
{
    public class LLoguin
    {
        Datos.DLoguin Cuenta = new Datos.DLoguin();
        public LLoguin()
        {
        }

        // CONSTRUCTOR POR DEFECTO
        public LLoguin(string Usu, string Pass)
        {
            this.Usuario = Usu;
            this.Constraseña = Pass;
        }
        public LLoguin(string Usu, string Pass, string perfil)
        {
            this.Usuario = Usu;
            this.Constraseña = Pass;
            //this.Perfil = perfil;
        }
        // ************************* MANEJO DE PROPIEDADES C# *************************

        public string Usuario { get; set; }
        public string Constraseña { get; set; }
        public string Perfil { get; set; }


        // ************************* MÉTODOS DE LA CLASE *************************

        // INICIAR SESIÓN
        public Dictionary<string, string> IniciarSesion(LLoguin usu)
        {
            return Cuenta.IniciarSesion(usu.Usuario, usu.Constraseña);
            //return Inicio;
        }
    }
}
