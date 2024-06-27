using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class Conexion
    {
        //
        // Declaramos las variables privadas de esta clase
        //
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad; // nos permitira establecer el metodo de autenticacion a sql
        private static Conexion con = null;  // creamos un objeto de tipo conexion que es el que vamos a compartir

        private Conexion()
        {
            this.Base = "BDUSERS";
            this.Servidor = "TLK1762-MARLONA\\SQLEXPRESS";
            this.Usuario = "sa";
            this.Clave = "1802Maximo";
            this.Seguridad = true;
        }

        // Generamos un metodo publico para generar el string de conexion
        public SqlConnection crearConexion()
        {
            // declaramos una variable de tipo sqlConection
            SqlConnection cadena = new SqlConnection();
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
