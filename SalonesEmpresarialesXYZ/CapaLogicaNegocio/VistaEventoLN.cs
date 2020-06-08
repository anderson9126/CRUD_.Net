using CapaAccesoDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class VistaEventoLN
    {

        private static VistaEventoLN objVistaEvento = null;
        private VistaEventoLN() { }
        public static VistaEventoLN getInstance()
        {
            if (objVistaEvento == null)
            {
                objVistaEvento = new VistaEventoLN();
            }
            return objVistaEvento;
        }
        public List<VistaEvento> ListaEventos()
        {

            try
            {
                return VistaEventosDAO.getInstance().ListaEventos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public  string EliminaEvento(int id_evento) {

            try
            {
                return VistaEventosDAO.getInstance().EliminaEvento(id_evento);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
