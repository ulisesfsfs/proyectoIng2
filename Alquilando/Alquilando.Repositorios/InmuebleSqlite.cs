using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alquilando.Aplicacion.Interfaces;
using Alquilando.Aplicacion.Interfaces;
using Alquilando.Aplicacion.Entidades;
namespace Alquilando.Repositorios
{
	public class InmuebleSqlite:IRepositorioInmueble
	{

		public List<Inmueble> getInmuebles()
		{
			using var db = new AlquilandoDbContext();
			return db.Inmuebles.ToList();
		}

		public List<Inmueble> getInmueblesNoPausados()
		{
			using var db = new AlquilandoDbContext();
			return db.Inmuebles.Where(i => i.estaPausado == false).ToList();
		}

		public List<Inmueble> getInmueblesLocalidadFecha(String localidad,DateTime fechaIni,DateTime fehcaFin)
		{
			String local = localidad.ToLower();
			return null;
		}

		public void agregar(Inmueble inmueble)
		{
			using var db = new AlquilandoDbContext();
			inmueble.localidad = inmueble.localidad.ToLower();
			db.Add(inmueble);
			db.SaveChanges();
		}

		public void eliminar(int id)
		{
			using (var db = new AlquilandoDbContext())
			{
				Inmueble? inmuebleEliminar = db.Inmuebles.Where(i => i.id == id).SingleOrDefault();

				db.Remove(inmuebleEliminar);
				db.SaveChanges();

			}
		}

		public void pausar(int id)
		{
			using (var db = new AlquilandoDbContext())
			{
				Inmueble? inmueblePausar = db.Inmuebles.Where(i => i.id == id).SingleOrDefault();

				inmueblePausar.estaPausado = true;
				db.SaveChanges();

			}

		}

		public bool existe(String nombre)
		{
			using (var db = new AlquilandoDbContext())
			{
				var inmueble = db.Inmuebles.Where(i =>i.nombre .Equals(nombre)).SingleOrDefault();
				if (inmueble != null)
					return true;
				else
					return false;
			}
		}
	}
}
