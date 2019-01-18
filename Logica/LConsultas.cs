using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LConsultas
    {
        Datos.DConsultas Consultas = new Datos.DConsultas();
        public LConsultas()
        {
        }

        public string Cedula { get; set; }
        public String Nombre { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public int NumeroFactura { get; set; }
        public int NumeroOrden { get; set; }
        public string Observaciones { get; set; }
        public float ValorTotal { get; set; }
        public float Impuestos { get; set; }
        public float Iva { get; set; }
        public float Descuentos { get; set; }


        public LConsultas(String Cedula, String Nombre, DateTime FechaFinal, DateTime FechaInicial, int NumerFactura, int NumeroOrden, string observaciones, float valorTotal, float Iva, float Impuestos, float Descuentos)
        {
            this.Nombre = Nombre;
            this.Cedula = Cedula;
            this.FechaInicial = FechaInicial;
            this.FechaFinal = FechaFinal;
            this.ValorTotal = valorTotal;
            this.Iva = Iva;
            this.Impuestos = Impuestos;
            this.Descuentos = Descuentos;
            this.Observaciones = observaciones;
        }

        public DataTable Buscar(LConsultas Con)
        {
            return Consultas.Buscar(Con.Cedula);
        }

        public DataTable BuscarFactura(String Cedula, DateTime FechaInicial, DateTime FechaFinal)
        {
            return Consultas.BuscarFactura(Cedula, FechaInicial, FechaFinal);
        }
        public DataTable BuscarOrden(String Cedula, DateTime FechaInicial, DateTime FechaFinal)
        {
            return Consultas.BuscarOden(Cedula, FechaInicial, FechaFinal);
        }
        public DataTable BuscarRemision(String Cedula, DateTime FechaInicial, DateTime FechaFinal)
        {
            return Consultas.BuscarRemision(Cedula, FechaInicial, FechaFinal);
        }

        public DataTable BuscarMora(LConsultas Con)
        {
            return Consultas.BuscarMora(Con.Cedula);
        }

    }
}
