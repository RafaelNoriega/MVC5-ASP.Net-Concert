using Microsoft.AspNet.Identity.EntityFramework;

namespace MVCRockers.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("MVCDatabase", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        object placeHolderVariable;
        public System.Data.Entity.DbSet<MVCRockers.Models.Concert> Concerts { get; set; }
    }
}