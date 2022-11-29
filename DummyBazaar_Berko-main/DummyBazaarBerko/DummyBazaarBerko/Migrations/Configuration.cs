namespace DummyBazaarBerko.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DummyBazaarBerko.Models.DummyBazaarBerko>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DummyBazaarBerko.Models.DummyBazaarBerko context)
        {
            context.ManagerTypes.AddOrUpdate(m => m.ID, new Models.ManagerType() { ID = 1, Name = "Admin" });
            context.ManagerTypes.AddOrUpdate(m => m.ID, new Models.ManagerType() { ID = 2, Name = "Moderatör" });
        }
    }
}
