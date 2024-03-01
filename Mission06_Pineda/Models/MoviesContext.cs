using Microsoft.EntityFrameworkCore;

namespace Mission06_Pineda.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        {
        }

        public DbSet<MovieModel> Movies { get; set; }
    }
}
