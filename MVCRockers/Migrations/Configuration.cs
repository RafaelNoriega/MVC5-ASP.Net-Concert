namespace MVCRockers.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCRockers.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            //Will check that the DB matches the Model everytime the app starts
            AutomaticMigrationsEnabled = false;
            ContextKey = "MVCRockers.Models.ApplicationDbContext";
        }

        protected override void Seed(MVCRockers.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
