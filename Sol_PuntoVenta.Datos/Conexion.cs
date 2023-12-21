using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sol_PuntoVenta.Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private static Conexion con = null;

        private Conexion()
        {
            this.Base = "BD_PUNTOVENTA";
            this.Servidor = "DESKTOP-5TFVT23";
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor +
             "; Database=" + this.Base +
             ";Integrated Security=True;";
            }
            catch(Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion getInstancia()
        {
            if (con == null) 
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
