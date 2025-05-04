using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquilando.Aplicacion.Entidades
{
    public class Usuario
    {

        public int id { get; set; }
        public String email { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String nacionalidad { get; set; }
        public String telefono { get; set; }
        public String DNI { get; set; }
        public String contraseña { get; set; }

        private TarjetaCredito tarjeta;
       
        //rol =1 cliente
        //rol=2 admin
        //rol=3 encargado
        public int rol { get; set; }


        public Usuario()
        {

        }
        public Usuario(string email, string nombre, string apellido, string nacionalidad, string telefono, String dNI, string contraseña)
        {
            this.email = email;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
            this.telefono = telefono;
            DNI = dNI;
            this.contraseña = contraseña;
        }
    }
}
