using Microsoft.EntityFrameworkCore;
using Project.DotNet.Api.Models;

namespace Project.DotNet.Api.DAL;

public class DotNetDbContext : DbContext
{
    protected DotNetDbContext()
    {
    }

    public DotNetDbContext(DbContextOptions<DotNetDbContext> options) : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql("Server=localhost;PORT=3306;Database=DNJR_Api_DB;User Id=root;Password=Prasad@0102", serverVersion);
        }
    }

}
