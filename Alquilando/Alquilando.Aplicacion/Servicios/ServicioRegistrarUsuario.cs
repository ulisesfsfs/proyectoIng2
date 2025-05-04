using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alquilando.Aplicacion.Interfaces;


namespace Alquilando.Aplicacion.Servicios
{
    public class ServicioRegistrarUsuario(IRepositorioUsuarios db)
    {
        public  void validar(String email,String contraseña)
        {
            String error = "";
            if (db.existe(email))
            {
                error += "El correo ya esta en uso \n";
            }
            if (contraseña.Length < 8)
            {
                error += "La contraseña no cumple con los requisitos minimos de seguridad";
            }
            if (!error.Equals(""))
            {
                throw new Exception(error);
            }
        }
    }
}
