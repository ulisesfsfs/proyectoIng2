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
    public class RegistrarUsuarioCliente(IRepositorioUsuarios db ,IServicioEmail SvEmail)
    {
        private ServicioRegistrarUsuario sv = new ServicioRegistrarUsuario(db);
       

        //los dos metodos hacen lo mismo, son dos opciones distintas de invocacion

        public  async Task RegistrarUsuario(Usuario usuario)
        {
            sv.validar(usuario.email, usuario.contraseña);
            usuario.rol = 1;
             db.agregar(usuario);
            SvEmail.enviarEmail(usuario.email, "Cuenta creada", "¡Se ha creado su cuenta en Alquilando , Bienvenid@!");
            
        }

        public  async Task RegistrarUsuario(String email,String nombre,String apellido,String contraseña,String nacionalidad,String telefono,String DNI)
        {
            sv.validar(email, contraseña);
            Usuario usuario = new Usuario(email, nombre, apellido, nacionalidad, telefono, DNI, contraseña);
            usuario.rol = 1;
            db.agregar(usuario);
			SvEmail.enviarEmail(usuario.email, "Cuenta creada", "¡Se ha creado su cuenta en Alquilando , Bienvenid@!");
		}
    }
}
