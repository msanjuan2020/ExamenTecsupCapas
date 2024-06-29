using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data; // nos permitye usar el meotodo DataTable
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosEmpleado
    {
        // primero creamos un metodo para listar a los empleados de la tabla de la bd
        public DataTable Listar()
        {
            SqlDataReader resultado; 
            DataTable tablaEmpleado = new DataTable();
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.crearInstancia().crearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Empleados_ListarEmpleados",con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                resultado = cmd.ExecuteReader();
                tablaEmpleado.Load(resultado);
                return tablaEmpleado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            { 
                if (con != null) { con.Close();}
            }
        }

        // Metodo para buscar elementos
        public DataTable Buscar(string valor)
        {
            SqlDataReader resultado;
            DataTable tablaEmpleado = new DataTable();
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.crearInstancia().crearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Empleados_BuscarEmpleados", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Valor", SqlDbType.VarChar).Value = valor;
                con.Open();
                resultado = cmd.ExecuteReader();
                tablaEmpleado.Load(resultado);
                return tablaEmpleado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con != null) { con.Close(); }
            }
        }

        // meotodo para insertar datos del alumno
        public string Insertar(Empleado empleado)
        {
            string respuesta;
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.crearInstancia().crearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Empleados_InsertarEmpleados", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = empleado.Nombre;
                cmd.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = empleado.Cargo;
                cmd.Parameters.Add("@Oficina", SqlDbType.VarChar).Value = empleado.Oficina;
                cmd.Parameters.Add("@Salario", SqlDbType.Decimal).Value = empleado.Salario;
                cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = empleado.Telefono;
                cmd.Parameters.Add("@FechaIngreso", SqlDbType.Date).Value = empleado.FechaIngreso;
                con.Open();
                respuesta = cmd.ExecuteNonQuery() == 1 ? "ok" : "Error al registrar los datos del empleado";
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con != null) { con.Close(); }
            }
            return respuesta;
        }

        // metodo que actualiza los registros de empleados
        public string  actualizar(Empleado empleado)
        {
            string respuesta;
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.crearInstancia().crearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Empleados_EditarEmpleados", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@EmpleadoId", SqlDbType.Int).Value = empleado.IdEmpleado;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = empleado.Nombre;
                cmd.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = empleado.Cargo;
                cmd.Parameters.Add("@Oficina", SqlDbType.VarChar).Value = empleado.Oficina;
                cmd.Parameters.Add("@Salario", SqlDbType.Decimal).Value = empleado.Salario;
                cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = empleado.Telefono;
                cmd.Parameters.Add("@FechaIngreso", SqlDbType.Date).Value = empleado.FechaIngreso;
                con.Open();
                respuesta = cmd.ExecuteNonQuery() == 1 ? "ok" : "Error al actualizar los datos del empleado";
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con != null) { con.Close(); }
            }
            return respuesta;
        }

        // meotod para eliminar registros del empleado
        public string Eliminar(int Id)
        {
            string respuesta;
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.crearInstancia().crearConexion();
                SqlCommand cmd = new SqlCommand("Sp_Empleados_EditarEmpleados", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@EmpleadoId", SqlDbType.Int).Value = Id;
                con.Open();
                respuesta = cmd.ExecuteNonQuery() == 1 ? "ok" : "Error al eliminar el registro del empleado";
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con != null) { con.Close(); }
            }
            return respuesta;
        }
    }
}
