using Microsoft.EntityFrameworkCore;
using NextUp.API.Models.Domain;

namespace NextUp.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>()
                .Property(g => g.EstimatedLengthInHours)
                .HasPrecision(5, 1);

            modelBuilder.Entity<Review>()
                .Property(r => r.Rating)
                .HasPrecision(4, 2);
        }
    }
}
