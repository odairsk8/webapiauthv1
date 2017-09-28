namespace WebApiAuthentication.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApiAuthentication.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApiAuthentication.Context.AuthContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebApiAuthentication.Context.AuthContext context)
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

            context.Clients.AddOrUpdate(new Client() { Id = "ConsoleApp", Secret = "cb081ad8e74bfb58b1f0cbec60ee496b", Name= "console", ApplicationType = ApplicationTypes.NativeConfidential, Active = true, RefreshTokenLifeTime = 14400, AllowedOrigin = "*" });
            context.Clients.AddOrUpdate(new Client() { Id = "WebApp", Secret = "cb081ad8e74bfb58b1f0cbec60ee496b", Name = "javascript", ApplicationType = ApplicationTypes.JavaScript, Active = true, RefreshTokenLifeTime = 7200, AllowedOrigin = "http://localhost:52096" });

        }
    }
}
