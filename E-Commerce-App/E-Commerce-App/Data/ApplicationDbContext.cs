using E_Commerce_App.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_App.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)

        {

        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                               new Category { Id = 1, Name = "Electronics", DisplayOrder = 1 },
                               new Category { Id = 2, Name = "Clothes", DisplayOrder = 2 },
                               new Category { Id = 3, Name = "Grocery", DisplayOrder = 3 },
                               new Category { Id = 4, Name = "Books", DisplayOrder = 4 },
                               new Category { Id = 5, Name = "Furniture", DisplayOrder = 5 }
                                                                                                      );
        }
    }
}
