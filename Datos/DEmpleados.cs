using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Datos
{
    public class DEmpleados
    {
        DComun _comun = new DComun();
        Datos.SmartPrintEntities _context = new SmartPrintEntities();
        public List<string> GestionarEmpleado(String cedula, String primerNombre, String segundoNombre, String primerApellido,
                                            String segundoApellido, String telefono, String celular, String direccion, String email, String sexo, DateTime fechaDeNacimiento,
                                            String cargo, DateTime fechaDeIngreso, String disponibilidad, DateTime? fechaDeRetiro, String observaciones, String estado, String Contrato,
                                            float Salario, String Eps, String Compensaciones, String Pensiones, String ARP, string Usuario)
        {
            var empleados = _context.GestionarEmpleado(cedula, primerNombre, segundoNombre, primerApellido, segundoApellido, telefono, celular,
                                                        direccion, email, sexo, fechaDeNacimiento, cargo, fechaDeIngreso, disponibilidad, fechaDeRetiro, observaciones, estado,
                                                        Contrato, Salario, Eps, Compensaciones, Pensiones, ARP, Usuario).ToList();
            return empleados;
        }


        public DataTable Buscar(String cedula)
        {
            var Ser = (from E in _context.Empleado
                       where E.CedulaEmpleado == cedula
                       select new
                       {
                           E.CedulaEmpleado,
                           E.PrimerNombre,
                           E.SegundoNombre,
                           E.PrimerApellido,
                           E.SegundoApellido,
                           E.Telefono,
                           E.Celular,
                           E.Direccion,
                           E.Email,
                           E.Sexo,
                           E.FechadeNacimiento,
                           E.Cargo,
                           E.FechadeIngreso,
                           E.Disponibilidad,
                           E.FechadeRetiro,
                           E.Observaciones,
                           E.Estado,
                           E.Contrato,
                           E.Salario,
                           E.Eps,
                           E.CajaCompensaciones,
                           E.Pensiones,
                           E.ARP
                       }).ToList();
            return DComun.ToDataTable(Ser);
        }
        public DataTable BuscarEmpleado(DateTime FechaInicial, DateTime FechaFinal)
        {
            var Cliente = (_context.BuscaEmpleados(FechaInicial, FechaFinal)).ToList();
            return DComun.ToDataTable(Cliente);
        }
    }
    
}

    

