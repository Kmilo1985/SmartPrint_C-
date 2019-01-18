using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LOrdenServicio
    {
        public LOrdenServicio() { }

        Datos.DOrdenServicio Orden = new Datos.DOrdenServicio();
        public int NumeroOrden { get; set; }
        public int NumeroRemision { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Asignado { get; set; }
        public DateTime FechaOrden { get; set; }
        public string Observaciones { get; set; }
        public string Estado { get; set; }
        public int Cantidad { get; set; }
        public float ValorUnitario { get; set; }
        public float ValorTotal { get; set; }
        public string Usuario { get; set; }

        public LOrdenServicio(int NumeroORden, int NumeroRemision, string cedula, string nombre, string direccion, int telefono, string Asigando, DateTime fechaOrden, string Estado, string observaciones, int cantidad, float valorUnitario, float valorTotal, string usuario)
        {
            this.NumeroOrden = NumeroOrden;
            this.NumeroRemision = NumeroRemision;
            this.Cedula = cedula;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Asignado = Asignado;
            this.FechaOrden = FechaOrden;
            this.Observaciones = observaciones;
            this.Estado = Estado;
            this.Cantidad = cantidad;
            this.ValorUnitario = valorUnitario;
            this.ValorTotal = valorTotal;
            Usuario = usuario;
        }

        public String Mostrarcodigo()
        {
            return Orden.MostrarCodigo();
        }

        public DataTable CargarRemision(int NumeroRemision)
        {
            return Orden.CargarRemision(NumeroRemision);
        }
        public DataTable BuscarRemision(int NumeroRemision)
        {
            return Orden.BuscarRemision(NumeroRemision);
        }

        public DataTable BuscarServicios(int numeroRemision)
        {
            return Orden.BuscarOrdenesServices(numeroRemision);
        }

        public List<string> GuardarOrden(LOrdenServicio Ord)
        {

            return Orden.GuardarOrdenServicio(Ord.NumeroOrden, Ord.NumeroRemision, Ord.Cedula, Ord.Asignado, Ord.FechaOrden, Ord.Estado, Ord.Observaciones, Ord.Usuario);

        }
        public DataTable ListEmpleados()
        {
            return Orden.VistaCombo();
        }

    }
}
