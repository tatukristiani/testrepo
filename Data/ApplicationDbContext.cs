using Microsoft.EntityFrameworkCore;
using Genapi_37e044ae_b317_4a3b_9cde_fbaee5205681.Models;

namespace Genapi_37e044ae_b317_4a3b_9cde_fbaee5205681.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public void EnsureDatabaseCreated()
        {
            this.Database.EnsureCreated();
        }
    }
}
