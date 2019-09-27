using Microsoft.EntityFrameworkCore;
using MoviesAPI.Entities;

namespace MoviesAPI.Services
{
    public class MoviesDbContext : DbContext
    {

        public DbSet<Movie> Movies { get; set; }

        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }

}