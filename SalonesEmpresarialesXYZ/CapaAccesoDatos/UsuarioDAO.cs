using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class UsuarioDAO
    {
        private static UsuarioDAO daoUsuario = null;
        private UsuarioDAO() { }

        public static UsuarioDAO getInstance()
        {
            if (daoUsuario == null)
            {
                daoUsuario = new UsuarioDAO();
            }
            return daoUsuario;
        }

        public Usuario IngresoSistema(String usuario, String contra)
        {

            SqlConnection conexion = null;
            SqlCommand cmd = null;
            Usuario objUsuario = null;
            SqlDataReader dr = null;

            try
            {
                conexion = Conexion.getInstance().ConexionDB();
                cmd = new SqlCommand("spIngresoSistema", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmUser", usuario);
                cmd.Parameters.AddWithValue("@prmPass", contra);
                conexion.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    objUsuario = new Usuario();
                    // objUsuario.ID = Convert.ToInt32(dr["idUsuer"].ToString());
                    objUsuario.nombre_user = dr["nombre_user"].ToString();
                    objUsuario.contraseña = dr["contraseña"].ToString();
                }
            }
            catch (Exception ex)
            {
                objUsuario = null;
                throw ex;
            }

            finally
            {
                conexion.Close();

            }
            return objUsuario;
        }


    }
}
