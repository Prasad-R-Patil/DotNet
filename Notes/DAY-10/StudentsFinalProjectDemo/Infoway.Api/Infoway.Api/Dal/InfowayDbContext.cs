using Infoway.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Infoway.Api.Dal;

public class InfowayDbContext : DbContext
{
    public InfowayDbContext()
    {

    }
    public InfowayDbContext(DbContextOptions<InfowayDbContext> options) : base(options) { }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql("Server=192.168.100.80;PORT=3306;Database=InfowayApiDb;User Id=saleel;Password=saleel", serverVersion);
        }
    }
}
