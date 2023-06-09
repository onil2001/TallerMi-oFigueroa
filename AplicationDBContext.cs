using Microsoft.EntityFrameworkCore;
using MiñoFigueroa.models;


namespace MiñoFigueroa
{
    public class AplicationDBContext : DbContext
    {
        public AplicationDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

    }
}