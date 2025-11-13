using Microsoft.EntityFrameworkCore;

namespace mvcApp2312144.Models.Entites
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
              : base(options)
        { }
        public DbSet<Product> Products { get; set; }
    }
}
