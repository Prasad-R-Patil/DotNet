using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ORM_Assignment.Models;
using ORM_Assignment.Models.Models;


namespace ProductOrderORM.DAL;

internal class PurchaseOrderDbContext : DbContext
{
    public PurchaseOrderDbContext() { }

    public PurchaseOrderDbContext(DbContextOptions<PurchaseOrderDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Shipper> Shippers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 33));

        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql(
                "Server=localhost;PORT=3306;Database=ORM;User Id=root;Password=Prasad@0102",
                serverVersion);
        }
    }
}
