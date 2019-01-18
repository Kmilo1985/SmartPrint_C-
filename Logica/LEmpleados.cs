using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LEmpleados
    {
        public LEmpleados()
        {

        }
        Datos.DEmpleados Empleado = new Datos.DEmpleados();


        public String Cedula { get; set; }
        public String PrimerNombre { get; set; }
        public String SegundoNombre { get; set; }
        public String PrimerApellido { get; set; }
        public String SegundoApellido { get; set; }
        public String Telefono { get; set; }
        public String Celular { get; set; }
        public String Direccion { get; set; }
        public String Email { get; set; }
        public String Sexo { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public String Cargo { get; set; }
        public DateTime FechaDeIngreso { get; set; }
        public String Disponibilidad { get; set; }
        public DateTime? FechaDeRetiro { get; set; }
        public String Observaciones { get; set; }
        public String Estado { get; set; }
        public String Contrato { get; set; }
        public float Salario { get; set; }
        public String Eps { get; set; }
        public String Compensaciones { get; set; }
        public String Pensiones { get; set; }
        public String ARP { get; set; }
        public String Usuario { get; set; }




        public LEmpleados(String cedula, String primerNombre, String segundoNombre, String primerApellido, String segundoApellido,
                        String telefono, String celular, String direccion, String email, String sexo, DateTime fechaDeNacimiento, String cargo,
                        DateTime fechaDeIngreso, String disponibilidad, DateTime? fechaDeRetiro, String observaciones, String estado, String contrato, float salario,
                        String eps, string compensaciones, String pensiones, String Arp, String usuario)
        {
            Cedula = cedula;
            PrimerNombre = primerNombre;
            SegundoNombre = segundoNombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Telefono = telefono;
            Celular = celular;
            Direccion = direccion;
            Email = email;
            Sexo = sexo;
            FechaDeNacimiento = fechaDeNacimiento;
            Cargo = cargo;
            FechaDeIngreso = fechaDeIngreso;
            Disponibilidad = disponibilidad;
            FechaDeRetiro = fechaDeRetiro;
            Observaciones = observaciones;
            Estado = estado;
            Contrato = contrato;
            Salario = salario;
            Eps = eps;
            Compensaciones = compensaciones;
            Pensiones = pensiones;
            ARP = Arp;
            Usuario = usuario;



        }
        public List<string> GestionarEmpleado(LEmpleados emp)
        {

            return Empleado.GestionarEmpleado(emp.Cedula, emp.PrimerNombre, emp.SegundoNombre, emp.PrimerApellido, emp.SegundoApellido, emp.Telefono, emp.Celular, emp.Direccion,
                                             emp.Email, emp.Sexo, emp.FechaDeNacimiento, emp.Cargo, emp.FechaDeIngreso, emp.Disponibilidad, emp.FechaDeRetiro, emp.Observaciones,
                                             emp.Estado, emp.Contrato, emp.Salario, emp.Eps, emp.Compensaciones, emp.Pensiones, emp.ARP, emp.Usuario);
        }

        public DataTable Buscar(LEmpleados emp)
        {

            return Empleado.Buscar(emp.Cedula);
        }
        public DataTable BuscarEmpleado(DateTime FechaInicial, DateTime FechaFinal)
        {
            return Empleado.BuscarEmpleado(FechaInicial, FechaFinal);
        }



    }
}

