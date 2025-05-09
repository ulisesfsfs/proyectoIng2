using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alquilando.Aplicacion;
using Alquilando.Aplicacion.Entidades;
using Alquilando.Aplicacion.Interfaces;
namespace Alquilando.Repositorios
{
    public class UsuariosSql:IRepositorioUsuarios
    {

        public  void agregar(Usuario usuario)
        {
            using var db = new AlquilandoDbContext();
            db.Add(usuario);
            db.SaveChanges();
        }

        public bool existe(String email)
        {
            using (var db = new AlquilandoDbContext())
            {
                var usuario = db.Usuarios.Where(u => u.email.Equals(email)).SingleOrDefault();
                if (usuario != null)
                    return true;
                else
                    return false;
            }
		}

        public bool pertenece(String email,String contraseña)
        {
            using var db = new AlquilandoDbContext();
            return db.Usuarios.First(u => u.email.Equals(email)).contraseña.Equals(contraseña);
        }
    }
}
