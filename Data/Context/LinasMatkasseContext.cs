using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Data.Context
{
    public class LinasMatkasseContext : DbContext
    {
        public LinasMatkasseContext()
        {
        }

        public LinasMatkasseContext(DbContextOptions options) :base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<RecipeIngredients> RecipeIngredients { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(
        //              "Server = SAMUEL; Database = LinasDB; Trusted_Connection = True; ");
        //}
    }
}
