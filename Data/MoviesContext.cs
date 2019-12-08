using Microsoft.EntityFrameworkCore;
using MoviesApp.Models;
namespace MoviesApp.Data
{
    public class MoviesContext: DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options): base(options) {}
        public DbSet<Models.Movie>Movies { get; set; }
    }
}