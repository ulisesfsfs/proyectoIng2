using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquilando.Aplicacion.Entidades
{
    public class Inmueble
    {
		public int id { get; set; }

		public String nombre { get; set; }

        public String direccion { get; set; }
        public int habitaciones { get; set; }

        public int camas { get; set; }

        public int diasMinimosAlquiler { get; set; }

        public bool tienePileta { get; set; }
        public bool tieneInternet { get; set; }
        public bool tieneGasNatural { get; set; }
        public bool tieneCable { get; set; }
        public bool tieneAire { get; set; }
    }
}
