using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alquilando.Aplicacion.Entidades;
using Alquilando.Aplicacion.Interfaces;

namespace Alquilando.Aplicacion.Servicios
{
	public class ServicioCargarInmueble(IRepositorioInmueble db)
	{

		public void validar(Inmueble inmueble)
		{
			String error = "";
			if (db.existe(inmueble.nombre))
			{
				error= "Ya existe otro inmueble con el mismo nombre";
			}
			if (!error.Equals(""))
			{
				throw new Exception(error);
			}
		}
	}
}
