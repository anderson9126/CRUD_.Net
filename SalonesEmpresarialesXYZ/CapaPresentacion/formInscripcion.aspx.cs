using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaLogicaNegocio;

using System.Web.Services;

namespace CapaPresentacion
{
    public partial class PanelCentro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlEdad.Items.AddRange(Enumerable.Range(18, 81).Select(edad => new ListItem(edad.ToString())).ToArray());

            if (!Page.IsPostBack)
            {
            }

        }
        private Cliente GetEntidad()
        {
            Cliente objcliente = new Cliente(); 
            objcliente.cedula = Convert.ToInt32(txtCedula.Text);
            objcliente.nombreApellido = txtNombreApellido.Text;
            objcliente.telefono = txtTelefono.Text;
            objcliente.correo = txtEmail.Text;
            objcliente.departamento = txtDepartamento.Text;
            objcliente.ciudad = txtCiudad.Text;
            objcliente.edad = Convert.ToInt32(ddlEdad.SelectedValue);

            return objcliente;
        }
        private Cliente GetEntidad2()
        {
            Cliente objcliente = new Cliente();
            objcliente.id_cliente = Convert.ToInt32(idCliente.Text);
            objcliente.cedula = Convert.ToInt32(txtCedula.Text);
            objcliente.nombreApellido = txtNombreApellido.Text;
            objcliente.telefono = txtTelefono.Text;
            objcliente.correo = txtEmail.Text;
            objcliente.departamento = txtDepartamento.Text;
            objcliente.ciudad = txtCiudad.Text;
            objcliente.edad = Convert.ToInt32(ddlEdad.SelectedValue);

            return objcliente;
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            //registro cliente
            Cliente objcliente = GetEntidad();
            //envio a logica de negocio
            bool respuesta = ClienteLN.getInstance().RegistrarCliente(objcliente);
            if (respuesta == true)
            {
                Response.Write("<script>alert('insert CORRECTO')</script>");
            }
            else
            {
                Response.Write("<script>alert('insert mal')</script>");

            }
        }
        [WebMethod]
        public static List<Cliente> BuscaCliente(int cedula)
        {
            List<Cliente> Clienteb = new List<Cliente>();
            Clienteb=ClienteLN.getInstance().BuscaCliente(cedula);
            

            return Clienteb;
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            //registro cliente
            Cliente objcliente = GetEntidad2();
            //envio a logica de negocio
            bool respuesta = ClienteLN.getInstance().EditarCliente(objcliente);
            if (respuesta == true)
            {
                Response.Write("<script>alert('Edit CORRECTO')</script>");
            }
            else
            {
                Response.Write("<script>alert('Edit mal')</script>");

            }
        }
    }
}