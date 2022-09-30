using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BilimkanaAmerican.Models
{
      public class ApplicationContext : IdentityDbContext<User, IdentityRole, string>
        {
         DbSet<User> Users { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options){
/*            Database.EnsureDeleted();
*//*            Database.EnsureCreated();
*/        }

   /*     protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            foreach(var foreign in builder.Model.GetEntityTypes().SelectMany(e=>e.GetForeignKeys()))
            {
                foreign.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }*/

    }
}
