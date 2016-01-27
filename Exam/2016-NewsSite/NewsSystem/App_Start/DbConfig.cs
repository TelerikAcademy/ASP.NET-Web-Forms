namespace NewsSystem.App_Start
{
    using NewsSystem.Data;
    using System.Data.Entity;
    using NewsSystem.Data.Migrations;

    public class DbConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NewsSystemDbContext, Configuration>());

            NewsSystemDbContext.Create().Database.Initialize(true);
        }
    }
}