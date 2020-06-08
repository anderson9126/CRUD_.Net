using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class ClienteLN
    {
        private static ClienteLN objCliente = null;
        private ClienteLN() { }
        public static ClienteLN getInstance()
        {
            if (objCliente == null)
            {
                objCliente = new ClienteLN();
            }
            return objCliente;
        }

        public bool RegistrarCliente(Cliente objCliente)
        {
            try
            {
                return ClienteDAO.getInstance().RegistrarCliente(objCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool EditarCliente(Cliente objCliente)
        {
            try
            {
                return ClienteDAO.getInstance().EditarCliente(objCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Cliente> BuscaCliente(int cedula)
        {
            
            
            try
            {
                
                return ClienteDAO.getInstance().BuscaCliente(cedula);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
 

    }
}
