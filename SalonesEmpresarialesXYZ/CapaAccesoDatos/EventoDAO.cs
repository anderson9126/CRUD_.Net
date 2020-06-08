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
    public class EventoDAO
    {
        private static EventoDAO daoEvento = null;
        private EventoDAO() { }

        public static EventoDAO getInstance()
        {
            if (daoEvento == null)
            {
                daoEvento = new EventoDAO();
            }
            return daoEvento;
        }

        public bool RegistrarEvento(Evento objEvento)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            bool respuesta = false;
            try
            {
                con = Conexion.getInstance().ConexionDB();
                cmd = new SqlCommand("spInsertarEvento", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_cliente", objEvento.id_cliente);
                cmd.Parameters.Add("@fecha_evento", objEvento.fecha_evento);
                cmd.Parameters.Add("@cantidad_personas", objEvento.cantidad_personas);
                cmd.Parameters.Add("@motivo", objEvento.motivo);
                cmd.Parameters.Add("@observacion", objEvento.observaciones);
                cmd.Parameters.Add("@estado", objEvento.estado);
                
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

        public List<Cliente> ListaCliente() {

            List<Cliente> ListaCli = new List<Cliente>();
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                con = Conexion.getInstance().ConexionDB();
                cmd = new SqlCommand("spListaClientes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                dr = cmd.ExecuteReader();
                

                while (dr.Read()) {
                    Cliente objcliente = new Cliente();
                    objcliente.id_cliente = Convert.ToInt32(dr["id_cliente"].ToString());
                    objcliente.nombreApellido = dr["nombreApellido"].ToString();

                    ListaCli.Add(objcliente);
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
            return ListaCli;
        }

    }
}
