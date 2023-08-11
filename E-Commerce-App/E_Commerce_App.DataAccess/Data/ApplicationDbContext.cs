using E_Commerce_App.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_App.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)

        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                               new Category { Id = 1, Name = "Action", DisplayOrder = 1 },

                               new Category { Id = 2, Name = "Biography", DisplayOrder = 2 },
                                 new Category { Id = 3, Name = "Horror", DisplayOrder = 3 }


                                                                                                      );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "The Alchemist",
                    Author = "Paulo Coelho",
                    Description = "The Alchemist is a novel by Brazilian author Paulo Coelho that was first published in 1988. Originally written in Portuguese, it became a widely translated international bestseller.",
                    ISBN = "978-0-06-231500-7",
                    ListPrice = 99,
                    Price = 99,
                    Price50 = 85,
                    Price100 = 80,
                }

               

                );
        }
    }
}
