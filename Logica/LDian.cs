using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LDian
    {
        Datos.DDian dian = new Datos.DDian();
        //public float FechaInical { get; set; }
        //public float FechaFinal { get; set; }
        public string Usuario { get; set; }
        public string Resolucion { get; set; }
        public float RangoInicial{ get; set; }
        public float RangoFinal { get; set; }
        public LDian() { }
        public LDian(float rangoInical, float rangoFinal, string usuario,string resolucion,float rangofinal)
        {

            RangoInicial = rangoInical;
            RangoFinal = rangoFinal;
            Usuario = usuario;
            Resolucion = resolucion;
            RangoFinal = rangofinal;
        }

        public List<string> Gestionar(LDian Dian)
        {

            return dian.Gestionar( Dian.RangoInicial, Dian.RangoFinal,Dian.Usuario,Dian.Resolucion);
        }
        public DataTable Mostrar()
        {

            return dian.MostrarRango();
        }

        public DataTable Rango(LDian Dian)
        {

            return dian.RangoFinal(Dian.RangoFinal);
        }
    }
}

