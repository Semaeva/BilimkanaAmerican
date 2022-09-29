using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BilimkanaAmerican.Models
{
      public class ApplicationContext : IdentityDbContext<User>
        {
         DbSet<User> Users { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options){
/*            Database.EnsureDeleted();
*/            Database.EnsureCreated();
        }

    }
}
