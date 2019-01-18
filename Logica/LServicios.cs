using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LServicios
    {
        readonly Datos.DServicios _servicios = new Datos.DServicios();

        public LServicios() { }


        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Codigo { get; set; }
        public string Observaciones { get; set; }
        public float ValorUnitario { get; set; }
        public string Usuario { get; set; }

        public LServicios(string nombre, string tipo, int codigo, string observaciones, float valorUnitario, string usuario)
        {

            Nombre = nombre;
            Tipo = tipo;
            Codigo = codigo;
            Observaciones = observaciones;
            ValorUnitario = valorUnitario;
            Usuario = usuario;


        }

        public List<string> Guardar(LServicios ser)
        {

            return _servicios.Guardar(ser.Nombre, ser.Tipo, ser.Codigo, ser.Observaciones, ser.ValorUnitario, ser.Usuario);

        }


        public DataTable MostrarTodos()
        {
            return _servicios.MostrarTodos();

        }

        public DataTable Buscar(LServicios ser)
        {
            return _servicios.BuscarCodigo(ser.Codigo);

        }
        public DataTable BuscarNombre(LServicios ser)
        {
            return _servicios.BuscarNombre(ser.Nombre);

        }

        public DataTable MostrarCodigo()
        {

            return _servicios.MostrarCodigo();
        }



    }
}
