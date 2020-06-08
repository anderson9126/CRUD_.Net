using CapaLogicaNegocio;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

namespace CapaPresentacion
{
    public partial class VistaEventos : System.Web.UI.Page
    {
        StringBuilder tabled = new StringBuilder();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            List<VistaEvento> ListaVEv = new List<VistaEvento>();
            ListaVEv = VistaEventoLN.getInstance().ListaEventos();
            
            
            tabled.Append("<table class='table'>");
            tabled.Append("<thead class='thead-dark'><tr><th scope ='col'>Accion</th><th scope ='col'> Fecha evento</th><th scope ='col'> Nº Personas</th><th scope ='col'> Motivo</th><th scope ='col'> Estado</th><th scope ='col'> Cedula</th><th scope ='col'> Nombre Apellido</th><th scope ='col'> Telefono</th><th scope ='col'> Correo </th ></tr></thead>");
            tabled.Append("<tbody>");
            foreach (VistaEvento cliente in ListaVEv)
            {
                //tabled.Append("<tr style='text-align:center;'><td><a onclick='pruevas()' >" + cliente.codigo + "</a></td>");
                tabled.Append("<tr style='text-align:center;'><td><buton class='btn btn-danger' onclick='eliminar(" + cliente.codigo+")' value='" + cliente.codigo + "'>Borrar</buton></td>");
                tabled.Append("<td>" + cliente.fecha_evento.ToShortDateString() +"</td>");
                tabled.Append("<td>" + cliente.cantidad_personas + "</td>");
                tabled.Append("<td>" + cliente.motivo + "</td>");
                tabled.Append("<td>" + cliente.estado + "</td>");
                tabled.Append("<td>" + cliente.cedula + "</td>");
                tabled.Append("<td>" + cliente.nombreApellido + "</td>");
                tabled.Append("<td>" + cliente.telefono + "</td>");
                tabled.Append("<td>" + cliente.correo + "</td></tr>");
                
                
            }
            tabled.Append("</tbody></table>");
            panel1.Controls.Add(new Literal { Text = tabled.ToString() });

            if (!Page.IsPostBack)
            {
            }

        }

        [WebMethod]
        public static string EliminaEvento( int id_evento)
        {
           String res = VistaEventoLN.getInstance().EliminaEvento(id_evento);
              
           return res;
        }
    }
}





