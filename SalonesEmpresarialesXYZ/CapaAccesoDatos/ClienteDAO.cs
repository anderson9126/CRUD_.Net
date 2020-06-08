using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace CapaAccesoDatos
{
   public  class ClienteDAO
    {
        private static ClienteDAO daoCliente = null;
        private ClienteDAO() { }

        public static ClienteDAO getInstance()
        {
            if (daoCliente == null)
            {
                daoCliente = new ClienteDAO();
            }
            return daoCliente;
        }

        public bool RegistrarCliente(Cliente objCliente)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            bool respuesta = false;
            try
            {
                con = Conexion.getInstance().ConexionDB();
                cmd = new SqlCommand("spInsertarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@cedula", objCliente.cedula);
                cmd.Parameters.Add("@nombreApellido", objCliente.nombreApellido);
                cmd.Parameters.Add("@telefono", objCliente.telefono);
                cmd.Parameters.Add("@correo", objCliente.correo);
                cmd.Parameters.Add("@departamento", objCliente.departamento);
                cmd.Parameters.Add("@ciudad", objCliente.ciudad);
                cmd.Parameters.Add("@edad", objCliente.edad);
                con.Open();

                int filas = cmd.ExecuteNonQuery();
                if (filas > 0) respuesta = true;
            }
            catch (Exception ex)
            {
                respuesta = false;
                throw ex;
            }

            finally
            {
                con.Close();

            }
            return respuesta;
        }

        public bool EditarCliente(Cliente objCliente)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            bool respuesta = false;
            try
            {
                con = Conexion.getInstance().ConexionDB();
                cmd = new SqlCommand("spEditarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_cliente", objCliente.id_cliente);
                cmd.Parameters.Add("@cedula", objCliente.cedula);
                cmd.Parameters.Add("@nombreApellido", objCliente.nombreApellido);
                cmd.Parameters.Add("@telefono", objCliente.telefono);
                cmd.Parameters.Add("@correo", objCliente.correo);
                cmd.Parameters.Add("@departamento", objCliente.departamento);
                cmd.Parameters.Add("@ciudad", objCliente.ciudad);
                cmd.Parameters.Add("@edad", objCliente.edad);
                con.Open();

                int filas = cmd.ExecuteNonQuery();
                if (filas > 0) respuesta = true;
            }
            catch (Exception ex)
            {
                respuesta = false;
                throw ex;
            }

            finally
            {
                con.Close();

            }
            return respuesta;
        }

        

        public List<Cliente> BuscaCliente(int cedula)
        {
            List<Cliente> clientesb = new List<Cliente>();
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                con = Conexion.getInstance().ConexionDB();
                cmd = new SqlCommand("spBuscacliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@prmcedula", cedula);
                con.Open();
                dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    Cliente objcliente = new Cliente();
                    objcliente.id_cliente = Convert.ToInt32(dr["id_cliente"].ToString());
                    objcliente.cedula = Convert.ToInt32(dr["cedula"].ToString());
                    objcliente.nombreApellido = dr["nombreApellido"].ToString();
                    objcliente.telefono = dr["telefono"].ToString();
                    objcliente.correo = dr["correo"].ToString();
                    objcliente.departamento = dr["departamento"].ToString();
                    objcliente.ciudad = dr["ciudad"].ToString();
                    objcliente.edad = Convert.ToInt32(dr["edad"].ToString());


                    clientesb.Add(objcliente);
                }




            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();

            }
            return clientesb;
        }
    }
}
