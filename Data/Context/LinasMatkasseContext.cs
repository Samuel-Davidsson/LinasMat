using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Data.Context
{
    public class LinasMatkasseContext : DbContext
    {
    
        public DbSet<User> User { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<Review> Review { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                      "Server = SAMUEL; Database = LinasDB; Trusted_Connection = True; ");
        }
    }
}
