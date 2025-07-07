using Microsoft.EntityFrameworkCore;
using MyInitApi_6adb681ac5c44c3686fbe2f4d46f11f6.Models;

namespace MyInitApi_6adb681ac5c44c3686fbe2f4d46f11f6.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
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
