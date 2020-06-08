using CapaEntidades;
using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class Login_salon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario objUser = UsuarioLN.getInstance().IngresoSistema(txtUsuario.Text, txtPassword.Text);

            if (objUser != null)
            {
                Response.Write("<script>alert('USER CORRECTO')</script>");
                Response.Redirect("formInscripcion.aspx");
            }
            else
            {
                Response.Write("<script>alert('USER incorrecto')</script>");
            }

        }
    }
}