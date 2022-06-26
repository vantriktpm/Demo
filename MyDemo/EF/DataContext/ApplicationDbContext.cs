using Microsoft.EntityFrameworkCore;

namespace MyDemo.EF.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }

        public virtual DbSet<Book>? Books { get; set; }
    }
}
