using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquilando.Aplicacion.Interfaces
{
	public interface IServicioEmail
	{

		public  Task enviarEmail(String receptor,String tema, String cuerpo);
	}
}
