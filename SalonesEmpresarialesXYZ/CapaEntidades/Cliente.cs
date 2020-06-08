using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cliente
    {
        public int id_cliente { get; set; }
        public int cedula { get; set; }
        public String nombreApellido { get; set; }
        public String telefono { get; set; }
        public String correo { get; set; }
        public String departamento { get; set; }
        public String ciudad { get; set; }
        public int edad { get; set; }

        public Cliente() { }

        public Cliente(int id_cliente,int cedula, String nombreApellido, String telefono, String correo, String departamento, String ciudad, int edad)
        {
            this.id_cliente = id_cliente;
            this.cedula = cedula;
            this.nombreApellido = nombreApellido;
            this.telefono = telefono;
            this.correo = correo;
            this.departamento = departamento;
            this.ciudad = ciudad;
            this.edad = edad;
        }
    }
   
}
