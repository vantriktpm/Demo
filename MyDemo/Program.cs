using Microsoft.EntityFrameworkCore;
using MyDemo.EF.DataContext;
using MyDemo.Services;

var builder = WebApplication.CreateBuilder(args);
//builder.WebHost.UseUrls("http://*:80");
// Add services to the container.
builder.Services.AddControllersWithViews();

ConfigurationManager configuration = builder.Configuration; // allows both to access and to set up the config
IWebHostEnvironment environment = builder.Environment;

var server = configuration["DatabaseServer"] ?? ".";
var port = configuration["DatabasePort"] ?? "1433";
var user = configuration["DatabaseUser"] ?? "SA";
var password = configuration["DatabasePassword"] ?? "12345";
var database = configuration["DatabaseName"] ?? "BookDb";

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer($"Server={server},{port};Initial Catalog={database};User ID={user};Password={password}"));

var app = builder.Build();

DatabaseManagementServices.MigrationInitiallisation(app);

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
