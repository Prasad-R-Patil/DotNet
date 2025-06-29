using Microsoft.EntityFrameworkCore;
using Project.DotNet.Api.DAL;
using Project.DotNet.Api.Models;
using Project.DotNet.Api.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddTransient<ICommonRepository<Customer> , CommonRepository<Customer>>();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
        policy.AllowAnyOrigin();
    });
});


builder.Services.AddDbContext<DotNetDbContext>(options =>
{
    var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
    options.UseMySql("Server=localhost;PORT=3306;Database=DNJR_Api_DB;User Id=root;Password=Prasad@0102", serverVersion);
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
