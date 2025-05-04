using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alquilando.Aplicacion.Interfaces;

namespace Alquilando.Aplicacion.Servicios
{
	public class ServicioLogin(IRepositorioUsuarios db)
	{

		public  void validar(String email,String contraseña)
		{
			String error = "";
			if ((!db.existe(email)) || (db.existe(email)&&(db.pertenece(email,contraseña))))
			{
				error = "Los datos ingresados son incorrectos";
				throw new Exception(error);
			}
		}
	}
}
