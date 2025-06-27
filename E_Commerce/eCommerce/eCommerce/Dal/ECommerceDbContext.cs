using eCommerce.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Dal;

public class ECommerceDbContext : DbContext // :base class is options
{
    public ECommerceDbContext()
    {

    }
    public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
    {

    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products{ get; set; }
    public DbSet<Customer> Customers{ get; set; }
    public DbSet<Cart> Carts{ get; set; }
    public DbSet<CartItem> CartItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql("Server = localhost; PORT = 3306; Database = E_commerce_Db; User Id = root; Password = Prasad@0102", serverVersion);
        }
    }
}
