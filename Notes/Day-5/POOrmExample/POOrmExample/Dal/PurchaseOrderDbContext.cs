using Microsoft.EntityFrameworkCore;
using POOrmExample.Models;

namespace POOrmExample.Dal;

public class PurchaseOrderDbContext : DbContext
{
    public PurchaseOrderDbContext()
    {
        
    }
    public PurchaseOrderDbContext(DbContextOptions<PurchaseOrderDbContext> optionsBuilder) : base(optionsBuilder)
    {

    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql("Server=192.168.100.80;PORT=3306;Database=Sakila;User Id=saleel;Password=saleel", serverVersion);
        }
    }
}
