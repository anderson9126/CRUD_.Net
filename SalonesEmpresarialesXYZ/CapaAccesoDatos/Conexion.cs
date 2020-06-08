using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        public static Conexion conexion = null;
        private Conexion() { }
        public static Conexion getInstance()
        {
            if (conexion == null)
            {
                conexion = new Conexion();

            }
            return conexion;

        }

        public SqlConnection ConexionDB() {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Server=.; Initial Catalog=prueba_anderson; User ID=anderson;Password=123";
            return conexion;      
        }
    }
}
