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

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Profile> Profiles { get; set; }  
        
        public DbSet<Category> Categories { get; set; }

        public DbSet<Item> Items { get; set; }  
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Product 1", price = 1.0 }
                    );

            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { Id=1, Name="Ali Ibrahim", Degree="PhD"},
                new Teacher { Id=2, Name= "Anthony", Degree="Student"}
                );
        }
    }

}
