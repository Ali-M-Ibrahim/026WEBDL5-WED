using Microsoft.EntityFrameworkCore;
using TPINCIWED.Models;

namespace TPINCIWED.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(


                new Product { Id = 1, Name = "Product 1", price = 1.0 }

                    );
        }
    }

}
