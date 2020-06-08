using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class VistaEventosDAO
    {

        private static VistaEventosDAO daoVistaEvento = null;
        private VistaEventosDAO() { }

        public static VistaEventosDAO getInstance()
        {
            if (daoVistaEvento == null)
            {
                daoVistaEvento = new VistaEventosDAO();
            }
            return daoVistaEvento;
        }

        public List<VistaEvento> ListaEventos()
        {

            List<VistaEvento> ListaVistaE = new List<VistaEvento>();
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                con = Conexion.getInstance().ConexionDB();
                cmd = new SqlCommand("spListaEventos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    VistaEvento objvistaEve = new VistaEvento();
                    objvistaEve.codigo = Convert.ToInt32(dr["codigo"].ToString());
                    objvistaEve.fecha_evento = Convert.ToDateTime(dr["fecha_evento"].ToString());
                    objvistaEve.cantidad_personas = Convert.ToInt32(dr["cantidad_personas"].ToString());
                    objvistaEve.motivo = dr["motivo"].ToString();
                    objvistaEve.estado = dr["estado"].ToString();
                    objvistaEve.cedula = Convert.ToInt32(dr["cedula"].ToString());
                    objvistaEve.nombreApellido = dr["nombreApellido"].ToString();
                    objvistaEve.telefono = dr["telefono"].ToString();
                    objvistaEve.correo = dr["correo"].ToString();

                    ListaVistaE.Add(objvistaEve);
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
            return ListaVistaE;
        }

        public  string EliminaEvento(int id_evento)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            string rta = "mal";
            try
            {
                con = Conexion.getInstance().ConexionDB();
                cmd = new SqlCommand("spEliminaEvento", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_evento", id_evento);
                
                con.Open();

                int filas = cmd.ExecuteNonQuery();
                if (filas > 0) rta = "Elimino El evento con exito";
            }
            catch (Exception ex)
            {
                rta = "Error al eliminar evento";
                throw ex;
            }

            finally
            {
                con.Close();

            }
            
            return rta;
        }
        }
}
