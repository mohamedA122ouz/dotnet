using Microsoft.EntityFrameworkCore;
using supports.Models;

namespace supports.Data {
    public class ApplictionDBContext : DbContext{
        public ApplictionDBContext(DbContextOptions<ApplictionDBContext> options): base(options)
        {
            
        }
        public DbSet<Product> products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Product>();
        }
    }
}
