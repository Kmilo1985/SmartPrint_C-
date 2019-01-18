using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LOtrosServicios
    {
        public LOtrosServicios()
        {

        }

        readonly Datos.DOtrosServicios _otrosServicios = new Datos.DOtrosServicios();

        public int Codigo { get; set; }
        public String IdProveedor { get; set; }
        public String Nombre { get; set; }
        public String Observaciones { get; set; }
        public String Serial { get; set; }
        public float ValorUnitario { get; set; }
        public string Usuario { get; set; }

        public LOtrosServicios(int codigo, String idProveedor, String nombre, String observaciones, String serial, float valorUnitarios, string usuario)
        {
            this.Codigo = codigo;
            this.IdProveedor = idProveedor;
            this.Nombre = nombre; ;
            this.Observaciones = observaciones;
            this.Serial = Serial;
            this.ValorUnitario = ValorUnitario;
            Usuario = usuario;
        }

        public List<string> Guardar(LOtrosServicios lOtrosSer)
        {
            return _otrosServicios.Guardar(lOtrosSer.Codigo, lOtrosSer.IdProveedor, lOtrosSer.Nombre, lOtrosSer.Observaciones, lOtrosSer.Serial, lOtrosSer.ValorUnitario, lOtrosSer.Usuario);
        }

        //MOSTRAR LISTADO GRIDVIEW
        public DataTable MostrarTodos()
        {
            return _otrosServicios.MostrarTodos();
        }
        //LLAMAR LA VISTA PARA LLENAR EL COMBO
        public DataTable MostrarProveedores()
        {
            return _otrosServicios.MostrarProveedores();
        }
        //METODO PARA BUSCAR
        public DataTable Buscar(LOtrosServicios otrosSEr)
        {
            return _otrosServicios.Buscar(otrosSEr.Codigo);
        }

        public DataTable BuscarNombre(LOtrosServicios otrosSEr)
        {
            return _otrosServicios.BuscarNombre(otrosSEr.Nombre);
        }

    }
}

