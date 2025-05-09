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
		public String localidad { get; set; }
        public double precioDia { get; set; }

        public String direccion { get; set; }
        public int habitaciones { get; set; }

        public int camas { get; set; }

        public int diasMinimosAlquiler { get; set; }

        public bool tienePileta { get; set; }
        public bool tieneInternet { get; set; }
        public bool tieneGasNatural { get; set; }
        public bool tieneCable { get; set; }
        public bool tieneAire { get; set; }
        
        public Usuario encargado { get; set; }
    
        public String politicaDevolucion { get; set; }
		//los valores posibles de esta variable son:
		//SinDevolucion , Devolucion50 , Devolucion100

		//Los valores posibles de esta variable son:
		//Seña,Total,Sin Pago
        public String politicaPago { get; set; }

		public bool estaPausado { get; set; }

		public Inmueble(string nombre, double precioDia, string direccion, int habitaciones, int camas, int diasMinimosAlquiler, bool tienePileta, bool tieneInternet, bool tieneGasNatural, bool tieneCable, bool tieneAire, Usuario encargado, string politicaDevolucion, string politicaPago)
		{
			this.nombre = nombre;
			this.precioDia = precioDia;
			this.direccion = direccion;
			this.habitaciones = habitaciones;
			this.camas = camas;
			this.diasMinimosAlquiler = diasMinimosAlquiler;
			this.tienePileta = tienePileta;
			this.tieneInternet = tieneInternet;
			this.tieneGasNatural = tieneGasNatural;
			this.tieneCable = tieneCable;
			this.tieneAire = tieneAire;
			this.encargado = encargado;
			this.politicaDevolucion = politicaDevolucion;
			this.politicaPago = politicaPago;
		}

		public Inmueble()
		{

		}
	}
}
