namespace DummyBazaarBerko.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DummyBazaarBerko.Models.DummyBazaarModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DummyBazaarBerko.Models.DummyBazaarModel context)
        {
            context.ManagerTypes.AddOrUpdate(m => m.ID, new Models.ManagerType() { ID = 1, Name = "Admin" });
            context.ManagerTypes.AddOrUpdate(m => m.ID, new Models.ManagerType() { ID = 2, Name = "Moderatör" });

            context.Managers.AddOrUpdate(m => m.ID, new Models.Manager() { ID = 1, Name = "Berke", Surname = "Berber", Mail = "berkeberber@gmail.com", ManagerType_ID = 1, Password = "12345678", UserName = "berke.berber", IsActive = true });
        }
    }
}
