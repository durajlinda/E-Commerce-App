using E_Commerce_App_Temp.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_App_Temp.Data
{
    public class ApplicationDbContextRazor : DbContext
    {
        public ApplicationDbContextRazor(DbContextOptions<ApplicationDbContextRazor> options) : base(options)
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
