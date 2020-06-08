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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!Page.IsPostBack)
            {
                List<Cliente> ListaCli = new List<Cliente>();
                ListaCli = EventoLN.getInstance().ListaCliente();

                foreach (Cliente cliente in ListaCli)
                {
                    ddlCliente.Items.Add(new ListItem(cliente.nombreApellido.ToString(), cliente.id_cliente.ToString()));
                }
            }
        }

        private Evento GetEntidadEvento()
        {
            Evento objevento = new Evento();
            objevento.id_cliente = Convert.ToInt32(ddlCliente.SelectedValue);
            objevento.cantidad_personas = Convert.ToInt32(txtpersonas.Text);
            objevento.motivo = ddlMotivo.SelectedValue;
            objevento.estado = Estado.SelectedValue;
            objevento.fecha_evento = Convert.ToDateTime(fechaEvento.Text);
            objevento.observaciones = observacion.Text;

            return objevento;
        }

        protected void btnRegistrarEvento_Click(object sender, EventArgs e)
        {
            //registro cliente
            Evento objevento = GetEntidadEvento();
            //envio a logica de negocio
            bool respuesta = EventoLN.getInstance().RegistrarEvento(objevento);
            if (respuesta == true)
            {
                Response.Write("<script>alert('insert evento CORRECTO')</script>");
            }
            else
            {
                Response.Write("<script>alert('insert evento  mal')</script>");

            }


        }
    }
}