using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class NegocioEmpleado
    {

        // método para listar Empleados
        public static DataTable ListarEmpleado()
        {
            DatosEmpleado datosEmpleado = new DatosEmpleado();
            return datosEmpleado.Listar();
        }

        // meétodo para buscar a los Empleados

        // método para insertar a los Empleados

        public static string InsertarEmpleado( string Nombre,string Cargo, string Oficina, Decimal Salario, string Telefono, DateTime FechaIngreso)
        {
            DatosEmpleado datosEmpleado = new DatosEmpleado();
            Empleado empleadoObj = new Empleado();
            empleadoObj.Nombre = Nombre;
            empleadoObj.Cargo = Cargo;
            empleadoObj.Oficina = Oficina;
            empleadoObj.Salario = Salario;
            empleadoObj.Telefono = Telefono;
            empleadoObj.FechaIngreso = FechaIngreso;
            return datosEmpleado.Insertar(empleadoObj);
        }

        // método actualizar Empleados
        public static string ActualizarEmpleado(int IdEmpleado, string Nombre, string Cargo, string Oficina, Decimal Salario, string Telefono, DateTime FechaIngreso)
        {
            DatosEmpleado datosEmpleado = new DatosEmpleado();
            Empleado empleadoObj = new Empleado();
            empleadoObj.IdEmpleado = IdEmpleado;
            empleadoObj.Nombre = Nombre;
            empleadoObj.Cargo = Cargo;
            empleadoObj.Oficina = Oficina;
            empleadoObj.Salario = Salario;
            empleadoObj.Telefono = Telefono;
            empleadoObj.FechaIngreso = FechaIngreso;
            return datosEmpleado.actualizar(empleadoObj);
        }
        
        // método para eliminar los registro de los Empleados

        public static string EliminarEmpleado(int IdEmpleado)
        {
            DatosEmpleado datosEmpleado = new DatosEmpleado();
            return datosEmpleado.Eliminar(IdEmpleado);
        }

    }
}
