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
            this.Seguridad = false;
        }

        // Generamos un metodo publico para generar el string de conexion
        public SqlConnection crearConexion()
        {
            // declaramos una variable de tipo sqlConection
            SqlConnection cadena = new SqlConnection();
            try
            {
                // creamos la cadena de conexion
                cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";

                if (this.Seguridad)
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrate Security = SSPI";
                }
                else
                {
                    cadena.ConnectionString = cadena.ConnectionString + "User Id=" + this.Usuario + ";Password=" + this.Clave;
                }
            }
            catch (Exception ex)
            {
                cadena =  null;
                throw ex; // aqui mostramos un mensaje por el erro de la conexion a BD
            }
            return cadena;
        }

        // crear un metodo para generar una instancia al contructor dentro de esta clase
        public static Conexion crearInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
