using Microsoft.EntityFrameworkCore;
namespace StoreApi.Models
{
  public class StoreContext : DbContext
  {
    public StoreContext(DbContextOptions<StoreContext>options) 
    : base(options)
    {}
    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Shipper> Shippers { get; set; }
  }
}