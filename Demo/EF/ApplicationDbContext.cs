using Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.EF
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Book> Books { get; set; }
    }
}
