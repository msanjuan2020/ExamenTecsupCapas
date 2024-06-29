using System;
using System.Data;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class NegocioEmpleado
    {

        // método para listar Empleados
        public static DataTable ListarEmpleado()
        {
            DatosEmpleado dato = new DatosEmpleado();
            return dato.Listar();
        }

        // meétodo para buscar a los Empleados
        public static DataTable BuscarEmpleado(string nombre)
        {
            DatosEmpleado dato = new DatosEmpleado();
            return dato.Buscar(nombre);
        }

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
