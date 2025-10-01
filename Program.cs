using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AIEmergencyNavigation.Data;
using AIEmergencyNavigation.Services;
using AIEmergencyNavigation.Areas.Identity.Data;
using Rotativa.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Configure DB
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

// Identity
builder.Services.AddDefaultIdentity<AIEmergencyNavigationUser>(options =>
    options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// DI: HttpClient factory (fix: use builder.Services)
builder.Services.AddHttpClient();

// custom services
builder.Services.AddScoped<ICustomEmailSender, EmailSender>();
builder.Services.AddScoped<RazorViewToStringRenderer>();

var app = builder.Build();

// seed roles (async scope)
using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    string[] roles = { "Admin", "Police", "Ambulance", "Fire Brigade", "User" };

    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
        {
            await roleManager.CreateAsync(new IdentityRole(role));
        }
    }
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.UseRotativa();

app.Run();
