using Microsoft.EntityFrameworkCore;
using MyDemo.EF.DataContext;

namespace MyDemo.Services
{
    public static class DatabaseManagementServices
    {
        public static void MigrationInitiallisation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                serviceScope.ServiceProvider.GetService<ApplicationDbContext>().Database.Migrate();
            }
        }
    }
}