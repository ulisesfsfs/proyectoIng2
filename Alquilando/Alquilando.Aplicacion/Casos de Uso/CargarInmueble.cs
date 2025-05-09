using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alquilando.Aplicacion.Entidades;
using Alquilando.Aplicacion.Interfaces;
using Alquilando.Aplicacion.Servicios;

namespace Alquilando.Aplicacion.Casos_de_Uso
{
	public class CargarInmueble(IRepositorioInmueble db)
	{


		private ServicioCargarInmueble sv = new ServicioCargarInmueble(db);
		public void cargarInmueble(Inmueble inmueble)
		{
			sv.validar(inmueble);
			db.agregar(inmueble);
		}
	}
}
