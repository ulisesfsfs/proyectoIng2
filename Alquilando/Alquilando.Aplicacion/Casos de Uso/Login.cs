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
	public class Login(IRepositorioUsuarios db)
	{
		private ServicioLogin sv = new ServicioLogin(db);

		public void login(String email,String contraseña )
		{
			sv.validar(email,contraseña);
		}
	}
}
