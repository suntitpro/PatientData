using System.Data.Entity.Migrations;

namespace PatientData.DataContext.ApplicationMigrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"DataContext\IdentityMigrations";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDb context)
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
