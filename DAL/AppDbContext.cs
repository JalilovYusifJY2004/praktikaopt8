using Microsoft.EntityFrameworkCore;
using Praktika1opt.Models;

namespace Praktika1opt.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


      public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
