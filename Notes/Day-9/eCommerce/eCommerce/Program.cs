using eCommerce.Dal;
using eCommerce.Models;
using eCommerce.Repositories;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Identity;
using eCommerce.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("eCommerceContextConnection") ?? throw new InvalidOperationException("Connection string 'eCommerceContextConnection' not found.");
builder.Services.AddMemoryCache();
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSession(options =>
{
    options.Cookie.IsEssential = true;
    options.Cookie.HttpOnly = true;
});

builder.Services.AddDbContext<ECommerceDbContext>(options =>
{
    var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
    options.UseMySql(builder.Configuration.GetConnectionString("InfowayeCommerceConStr"), serverVersion);
});
builder.Services.AddDbContext<eCommerceContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<eCommerceContext>();


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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var roles = new[] { "Admin", "Customer" };
    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
        {
            await roleManager.CreateAsync(new IdentityRole(role));
        }
    }
}
//Creating Users  - This block will get executed everytime the application starts/restarts. We are seeding the users
using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
    string adminUser = "admin@ecommerce.com";
    string adminPassword = "Welcome@123";
    if (await userManager.FindByEmailAsync(adminUser) == null)
    {
        var user = new IdentityUser(adminUser) { UserName = adminUser, Email = adminUser };
        await userManager.CreateAsync(user, adminPassword);
        await userManager.AddToRoleAsync(user, "Admin");
    }
    string customer1 = "alisha.c@ecommerce.com";
    string customer1Password = "Welcome@123";
    if (await userManager.FindByEmailAsync(customer1) == null)
    {
        var user = new IdentityUser(customer1) { UserName = customer1, Email = customer1 };
        await userManager.CreateAsync(user, customer1Password);
        await userManager.AddToRoleAsync(user, "Customer");
    }
}
app.Run();
