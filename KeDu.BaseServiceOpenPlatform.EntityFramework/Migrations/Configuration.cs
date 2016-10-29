using System.Data.Entity.Migrations;

namespace KeDu.BaseServiceOpenPlatform.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<BaseServiceOpenPlatform.EntityFramework.BaseServiceOpenPlatformDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BaseServiceOpenPlatform";
        }

        protected override void Seed(BaseServiceOpenPlatform.EntityFramework.BaseServiceOpenPlatformDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
