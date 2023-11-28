using Microsoft.EntityFrameworkCore;
using practice3.Model;

namespace practice3.Db
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
                
        }

        public DbSet<Subjects> subjects { get; set; }

    }
}
