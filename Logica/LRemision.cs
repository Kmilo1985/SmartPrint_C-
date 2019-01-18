using System;
using System.Collections.Generic;
using System.Data;
using Datos;

namespace Logica
{
    public class LRemision
    {
        public LRemision() { }

        DRemision _remision = new DRemision();
        public int NumeroRemision { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public DateTime FechaRemision { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Observaciones { get; set; }
        public int CodigoServicio { get; set; }
        public int Cantidad { get; set; }
        public float ValorUnitario { get; set; }
        public float ValorTotal { get; set; }
        public float SubTotal { get; set; }
        public float Iva { get; set; }

        public float Total { get; set; }
        public string Usuario { get; set; }

        public LRemision(int numeroRemision, string cedula, string nombre, string direccion, int telefono, DateTime fechaRemision, DateTime fechaVencimiento, string observaciones, int codigoServicio, int cantidad, float valorUnitario, float valorTotal, float subtotal, float iva, float total, string usuario)
        {
            NumeroRemision = numeroRemision;
            Cedula = cedula;
            Direccion = direccion;
            Telefono = telefono;
            FechaRemision = fechaRemision;
            Observaciones = observaciones;
            CodigoServicio = codigoServicio;
            Cantidad = cantidad;
            ValorUnitario = valorUnitario;
            ValorTotal = valorTotal;
            SubTotal = subtotal;
            Iva = iva;
            Total = total;
            Nombre = nombre;
            Usuario = usuario;
        }

        public DataTable BuscarCedula(LRemision remi)
        {
            return _remision.BuscarCedula(remi.Cedula);
        }
        public String MostrarCodigo()
        {
            return _remision.MostrarCodigo();
        }
        public DataTable ObtenerServicios()
        {
            var objTabla = _remision.ObtenerServicios();
            return objTabla;
        }
        public DataTable ObtenerOtroServicios()
        {
            var objTabla = _remision.ObtenerOtrosServicios();
            return objTabla;
        }


        public List<string> GuardarRemision(LRemision remision)
        {
            return _remision.GuardarRemision(NumeroRemision, Cedula, FechaVencimiento, Observaciones, SubTotal, Iva, Total, Usuario);
        }
        public List<string> GuardarRemisionServicios(LRemision remision)
        {
            return _remision.GuardarRemisionServicios(NumeroRemision, CodigoServicio, Cantidad, Convert.ToInt32(ValorUnitario), Convert.ToInt32(ValorTotal), Nombre);
        }
    }
}
