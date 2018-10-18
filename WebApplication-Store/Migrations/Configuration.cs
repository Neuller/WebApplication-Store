namespace WebApplication_Store.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication_Store.Models.WebApplication_StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;

            // Migração Automatizada
            AutomaticMigrationDataLossAllowed = true;

            ContextKey = "WebApplication_Store.Models.WebApplication_StoreContext";
        }

        protected override void Seed(WebApplication_Store.Models.WebApplication_StoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
