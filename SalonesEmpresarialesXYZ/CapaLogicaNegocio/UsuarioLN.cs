using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaAccesoDatos;

using System.Linq.Expressions;

namespace CapaLogicaNegocio
{
    public class UsuarioLN
    {
        private static UsuarioLN objUsuario = null;
        private UsuarioLN() { }
        public static UsuarioLN getInstance()
        {
            if (objUsuario == null)
            {
                objUsuario = new UsuarioLN();
            }
            return objUsuario;
        }

        public Usuario IngresoSistema(String usuario, String contra)
        {

            try
            {
                return UsuarioDAO.getInstance().IngresoSistema(usuario, contra);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
