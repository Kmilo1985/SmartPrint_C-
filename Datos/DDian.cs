using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DDian
    {
        Datos.DComun Comun = new Datos.DComun();
        Datos.SmartPrintEntities context = new Datos.SmartPrintEntities();
        public List<string> Gestionar(float RangoInicial, float RangoFinal, string Usuario,string Resolucion)
        {
            List<string> Dian = context.RangoDian( RangoInicial, RangoFinal, Usuario,Resolucion).ToList();
            return Dian;
        }
        public DataTable MostrarRango()
        {
            var Mostrar = context.MostrarDian().ToList();
            return DComun.ToDataTable(Mostrar);
        }

        //public DataTable RangoFinal(float RangoFinal){ 
        //    var Rango = (from C in context.Dian
        //               where C.RangoFinal == RangoFinal
        //               select new { C.RangoFinal }).ToList();
        //    return DComun.ToDataTable(Rango);
        
        
        //}
        public DataTable RangoFinal(float RangoFinal){ 
            var Rango =  context.SeleccionarRango().ToList();
            return DComun.ToDataTable(Rango);


        }

    }
}
