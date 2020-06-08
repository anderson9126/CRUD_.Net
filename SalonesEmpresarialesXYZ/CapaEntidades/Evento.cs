using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Evento
    {
        public int id_cliente { get; set; }
        public DateTime fecha_evento { get; set; }
        public int cantidad_personas { get; set; }
        public String motivo { get; set; }
        public String observaciones { get; set; }
        public String estado { get; set; }
       

        public Evento() { }

        public Evento(int id_cliente, DateTime fecha_evento, int cantidad_personas, String motivo, String observaciones, String estado)
        {
            this.id_cliente = id_cliente;
            this.fecha_evento = fecha_evento;
            this.cantidad_personas = cantidad_personas;
            this.motivo = motivo;
            this.observaciones = observaciones;
            this.estado = estado;
        }
    }
}
