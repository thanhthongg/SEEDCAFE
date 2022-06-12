using Microsoft.EntityFrameworkCore;
namespace SEEDCAFE.Models
{
    public class CafeDbContext : DbContext
    {
        public CafeDbContext(DbContextOptions<CafeDbContext> options)
        : base(options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}