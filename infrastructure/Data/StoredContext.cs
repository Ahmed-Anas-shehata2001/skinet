

using infrastructure.Data;
using core.Entites;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.Data
{
    public class StoredContext : DbContext
    {
        public StoredContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> prodcut { get; set;}
        
    }
}