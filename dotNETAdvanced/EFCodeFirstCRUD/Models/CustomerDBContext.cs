using Microsoft.EntityFrameworkCore;

namespace EFCodeFirstCRUD.Models
{
    public class CustomerDBContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=CustomerDB;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Customer> customers { get; set;}
    }
}
