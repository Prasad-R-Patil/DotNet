using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using ProductOrderORM.Models;

namespace ProductOrderORM.DAL;

internal class PurchaseOrderDbContext:DbContext
{
    public PurchaseOrderDbContext() { }

    public PurchaseOrderDbContext(DbContextOptions <PurchaseOrderDbContext> optionsBuilder) : base(optionsBuilder)
    {

    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 33));

        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql("Server=192.168.100.80;PORT=3306;Database=Group024;User Id=group024;Password=welcome", serverVersion);
        }
    }


   
}
