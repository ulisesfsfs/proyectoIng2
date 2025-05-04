using System;
using Alquilando.Aplicacion;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Alquilando.Aplicacion.Entidades;

namespace Alquilando.Repositorios
{
    public class AlquilandoDbContext:DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Inmueble> Inmuebles { get; set; }
        public DbSet<TarjetaCredito> Tarjetas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder
 optionsBuilder)
        {
            optionsBuilder.UseSqlite("data source=Alquilando.sqlite");
        }

    }
}
