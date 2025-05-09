using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alquilando.Aplicacion.Entidades;

namespace Alquilando.Aplicacion.Interfaces
{
	public interface IRepositorioInmueble
	{

		public List<Inmueble> getInmuebles();

		public List<Inmueble> getInmueblesLocalidadFecha(String localidad, DateTime fechaInicio, DateTime fechaFin);

		public bool existe(String nombre);
		public void agregar(Inmueble inmueble);
	}
}
