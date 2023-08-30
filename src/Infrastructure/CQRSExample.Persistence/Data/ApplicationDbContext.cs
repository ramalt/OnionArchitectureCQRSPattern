using CQRSExample.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSExample.Persistence.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Seeding
            builder.Entity<Product>().HasData(
                new Product() { Id = Guid.NewGuid(), Name = "Framework Laptop", Value = 1999, Quantity = 100 },
                new Product() { Id = Guid.NewGuid(), Name = "Monster Notebook", Value = 400, Quantity = 50 },
                new Product() { Id = Guid.NewGuid(), Name = "ASUS Notebook", Value = 599, Quantity = 90 },
                new Product() { Id = Guid.NewGuid(), Name = "IdeaPad Notebook", Value = 785, Quantity = 80 });


            base.OnModelCreating(builder);
        }
        
    }
}