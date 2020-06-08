using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class VistaEvento
    {

        public int codigo { get; set; }
        public DateTime fecha_evento { get; set; }
        public int cantidad_personas { get; set; }
        public String motivo { get; set; }
        public String estado { get; set; }
        public int cedula { get; set; }
       public String nombreApellido { get; set; }
       public String telefono { get; set; }
       public String correo { get; set; }
        public VistaEvento() { }

        public VistaEvento(int codigo,DateTime fecha_evento, int cantidad_personas, String motivo, String estado, int cedula, String nombreApellido, String telefono, String correo)
        {
            this.codigo = codigo;
            this.fecha_evento = fecha_evento;
            this.cantidad_personas = cantidad_personas;
            this.motivo = motivo;
            this.estado = estado;
            this.cedula = cedula;
            this.nombreApellido = nombreApellido;
            this.telefono = telefono;
            this.correo = correo;
        }
    }
}
