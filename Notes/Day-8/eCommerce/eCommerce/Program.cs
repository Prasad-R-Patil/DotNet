using eCommerce.Dal;
using eCommerce.Models;
using eCommerce.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSession(options =>
{
    options.Cookie.IsEssential = true;
    options.Cookie.HttpOnly = true;
});

builder.Services.AddDbContext<ECommerceDbContext>(options =>
{
    var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
    options.UseMySql("Server=192.168.100.80;PORT=3306;Database=InfowayEComDb;User Id=saleel;Password=saleel", serverVersion);
});

builder.Services.AddTransient<ICommonRepository<Customer>,CommonRepository<Customer>>();
builder.Services.AddTransient<ICommonRepository<Category>, CommonRepository<Category>>();
builder.Services.AddTransient<ICommonRepository<Product>, CommonRepository<Product>>();
builder.Services.AddTransient<ICommonRepository<Cart>, CommonRepository<Cart>>();
builder.Services.AddTransient<ICommonRepository<CartItem>, CommonRepository<CartItem>>();
builder.Services.AddTransient<ICartRepository, CartRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
