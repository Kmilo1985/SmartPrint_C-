//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdenServicio
    {
        public OrdenServicio()
        {
            this.Factura = new HashSet<Factura>();
        }
    
        public int NumeroOrden { get; set; }
        public int NumeroRemision { get; set; }
        public string Cedula { get; set; }
        public string Asignado { get; set; }
        public System.DateTime FechaOrden { get; set; }
        public System.DateTime FechaInicial { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual Remision Remision { get; set; }
        public virtual ICollection<Factura> Factura { get; set; }
    }
}