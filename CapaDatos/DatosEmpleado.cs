using System;
using System.Collections.Generic;
using System.Data; // nos permitye usar el meotodo DataTable
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class DatosEmpleado
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
    }
}
