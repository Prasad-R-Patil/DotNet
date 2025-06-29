using Infoway.Api.Dal;
using Infoway.Api.Models;
using Infoway.Api.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<ICommonRepository<Customer>,CommonRepository<Customer>>();
builder.Services.AddTransient<ICommonRepository<Employee>, CommonRepository<Employee>>();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {          
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
        policy.AllowAnyOrigin();
    });
});

builder.Services.AddDbContext<InfowayDbContext>(options =>
{
    var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
    options.UseMySql("Server=192.168.100.80;PORT=3306;Database=InfowayApiDb;User Id=saleel;Password=saleel", serverVersion);
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
