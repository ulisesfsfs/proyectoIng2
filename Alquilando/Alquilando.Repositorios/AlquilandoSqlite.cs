using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Alquilando.Repositorios
{
    public class AlquilandoSqlite
    {

        public static void Inicializar()
        {
            using var db = new AlquilandoDbContext();
            if (db.Database.EnsureCreated())
            {
                var connection = db.Database.GetDbConnection();
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "PRAGMA journal_mode=DELETE;";
                    command.ExecuteNonQuery();
                }

            }


        }
    }
}
