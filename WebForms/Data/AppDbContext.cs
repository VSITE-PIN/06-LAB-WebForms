using System.Data.Entity;
using WebForms.Models;

namespace WebForms.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("cs")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}