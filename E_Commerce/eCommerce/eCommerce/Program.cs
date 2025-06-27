using eCommerce.Dal;
using eCommerce.Models;
using eCommerce.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using eCommerce.Data;

var builder = WebApplication.CreateBuilder(args);

// 🔗 Connection string for Identity (SQL Server)
var connectionString = builder.Configuration.GetConnectionString("eCommerceContextConnection")
    ?? throw new InvalidOperationException("Connection string 'eCommerceContextConnection' not found.");

// ✅ Fix IHttpContextAccessor issue
builder.Services.AddHttpContextAccessor();

// 🔐 Identity, MVC, and Sessions
builder.Services.AddMemoryCache();
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSession(options =>
{
    options.Cookie.IsEssential = true;
    options.Cookie.HttpOnly = true;
});

// 🔌 Configure MySQL for application data
builder.Services.AddDbContext<ECommerceDbContext>(options =>
{
    var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
    options.UseMySql(builder.Configuration.GetConnectionString("InfowayeCommerceConStr"), serverVersion);
});

// 🔌 Configure SQL Server for Identity
builder.Services.AddDbContext<eCommerceContext>(options =>
{
    options.UseSqlServer(connectionString);
});

// 🔐 Configure Identity
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<eCommerceContext>();

// 🛒 Register repositories
builder.Services.AddTransient<ICommonRepository<Customer>, CommonRepository<Customer>>();
builder.Services.AddTransient<ICommonRepository<Category>, CommonRepository<Category>>();
builder.Services.AddTransient<ICommonRepository<Product>, CommonRepository<Product>>();
builder.Services.AddTransient<ICommonRepository<Cart>, CommonRepository<Cart>>();
builder.Services.AddTransient<ICommonRepository<CartItem>, CommonRepository<CartItem>>();
builder.Services.AddTransient<ICartRepository, CartRepository>();

var app = builder.Build();

// 🌐 Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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

// 🎯 Create Roles
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

// 🎯 Create Default Users
using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

    string adminEmail = "admin@ecommerce.com";
    string adminPassword = "Prasad@123";

    if (await userManager.FindByEmailAsync(adminEmail) == null)
    {
        var user = new IdentityUser(adminEmail) { UserName = adminEmail, Email = adminEmail };
        await userManager.CreateAsync(user, adminPassword);
        await userManager.AddToRoleAsync(user, "Admin");
    }

    string customerEmail = "prasad@ecommerce.com";
    string customerPassword = "PraasdS@123";

    if (await userManager.FindByEmailAsync(customerEmail) == null)
    {
        var user = new IdentityUser(customerEmail) { UserName = customerEmail, Email = customerEmail };
        await userManager.CreateAsync(user, customerPassword);
        await userManager.AddToRoleAsync(user, "Customer");
    }
}

app.Run();
