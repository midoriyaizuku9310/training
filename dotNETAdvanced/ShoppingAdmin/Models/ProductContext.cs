
using Microsoft.EntityFrameworkCore;

namespace ShoppingAdmin.Models
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Product { get; set;}

        public ProductContext(DbContextOptions<ProductContext >options) : base(options) { }
    }
}
