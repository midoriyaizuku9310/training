using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using shopping2.Model;

public class ProductContext : DbContext
{


    private readonly string _connectionString;

    public ProductContext(string connectionString)
    {
        _connectionString = connectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
    }

    public DbSet<Product> Product{ get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().ToTable("Product");
    }
}