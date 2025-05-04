using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alquilando.Aplicacion.Entidades;

namespace Alquilando.Aplicacion.Interfaces
{
	public interface IRepositorioUsuarios
	{

		public void agregar(Usuario usuario);
		public bool existe(String email);

		public bool pertenece(String email, String contraseña);
	}
}
