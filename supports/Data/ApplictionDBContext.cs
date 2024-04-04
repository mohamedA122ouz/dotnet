using Microsoft.EntityFrameworkCore;
using supports.Models;

namespace supports.Data {
    public class ApplictionDBContext : DbContext{
        public ApplictionDBContext(DbContextOptions<ApplictionDBContext> options): base(options)
        {
            
        }
        public DbSet<Product> products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "nike" },
                new Company { Id = 2,Name = "addidas"}
            );

        }
    }
}
