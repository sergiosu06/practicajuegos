using Microsoft.EntityFrameworkCore;
using ProyectoVideoJuegos.Models;
using VideojuegosSergio.Models;

namespace VideojuegosSergio.Contexto
{
    public class Aplicacion_contexto : DbContext
    {
        public Aplicacion_contexto
            (DbContextOptions<Aplicacion_contexto> options)
            : base(options) { }

        public DbSet<Email> Email { 
            get; set; 
        }
        public DbSet<Usuarios> Usuarios { 
            get; set; 
        }
        public DbSet<Video_juegos> Video_juegos { 
            get; set; 
        }

    }
}