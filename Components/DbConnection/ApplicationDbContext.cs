using Component.Model;
using Microsoft.EntityFrameworkCore;

namespace Component.DbConnection
{
   public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }

    }
}