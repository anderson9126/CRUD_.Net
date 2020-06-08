using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Usuario
    {
        public int ID { get; set; }
        public String nombre_user { get; set; }
        public String contraseña { get; set; }

        public Usuario() { }

        public Usuario(int ID, String nombre_user, String contraseña) {
            this.ID = ID;
            this.nombre_user = nombre_user;
            this.contraseña = contraseña;
        }
    }
}
