using CapaAccesoDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class EventoLN
    {
        private static EventoLN objEvento = null;
        private EventoLN() { }
        public static EventoLN getInstance()
        {
            if (objEvento == null)
            {
                objEvento = new EventoLN();
            }
            return objEvento;
        }

        public bool RegistrarEvento(Evento objEvento)
        {
            try
            {
                return EventoDAO.getInstance().RegistrarEvento(objEvento);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<Cliente> ListaCliente()
        {

            try
            {
                return EventoDAO.getInstance().ListaCliente();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
