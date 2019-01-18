using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LFactura
    {
        public LFactura() { }

        Datos.DFactura Factura = new Datos.DFactura();

        public int NumeroFactura { get; set; }
        public int NumeroOrden { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Estado { get; set; }
        public DateTime FechaFactura { get; set; }
        public string Observaciones { get; set; }
        public float Subtotal { get; set; }
        public float ValorTotal { get; set; }
        public float Impuestos { get; set; }
        public float Iva { get; set; }
        public float Descuentos { get; set; }
        public string Usuario { get; set; }
        public string Mora { get; set; }
        public string EstadoFac { get; set; }
        public int NumeroRemision { get; set; }


        public LFactura(int numeroFactura, int numeroOrden, string cedula, string nombre, string direccion, int telefono, DateTime fechaFactura, string estado, string observaciones, float valorTotal, float iva, float impuestos, float descuentos, float subtotal, string usuario, string mora, string estadofac,int numeroRemision)
        {
            NumeroFactura = numeroFactura;
            NumeroOrden = numeroOrden;
            Cedula = cedula;
            Direccion = direccion;
            Telefono = telefono;
            FechaFactura = fechaFactura;
            Observaciones = observaciones;
            Estado = estado;
            ValorTotal = valorTotal;
            Iva = iva;
            Impuestos = impuestos;
            Descuentos = descuentos;
            Subtotal = subtotal;
            Usuario = usuario;
            Mora = mora;
            EstadoFac = estadofac;
            NumeroRemision = numeroRemision;


        }


        public DataTable Mostrarcodigo()
        {
            return Factura.MostrarCodigo();
        }

        public List<string> GuardarFactura(LFactura fac)
        {
            return Factura.GuardarFactura(fac.NumeroFactura, fac.NumeroOrden, fac.Cedula, fac.FechaFactura, fac.Observaciones, fac.ValorTotal, fac.Iva, fac.Descuentos, fac.Impuestos, fac.Subtotal, fac.Estado, fac.Usuario, fac.Mora, fac.EstadoFac,fac.NumeroRemision).ToList();

        }
        public DataTable CargarOrden(int NumeroOrden)
        {
            return Factura.CargarOrden(NumeroOrden);
        }
        public DataTable BuscarServicios(int numeroRemision)
        {
            return Factura.BuscarOrdenesServices(numeroRemision);
        }
        public DataTable BuscarFactura(int NumeroFactura)
        {
            return Factura.BuscarFactura(NumeroFactura);
        }
        public List<string> Modificar(LFactura fac)
        {
            return Factura.Modificar(fac.NumeroFactura, fac.EstadoFac, fac.Mora).ToList();

        }

    }


}
