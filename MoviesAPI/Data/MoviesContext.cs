using Microsoft.EntityFrameworkCore;
using MoviesAPI.Data.Entities;

namespace MoviesAPI.Data
{
    public class MoviesContext:DbContext
    {
        public MoviesContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Gender>Gender { get; set; }

    }

}
