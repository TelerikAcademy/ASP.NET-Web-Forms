namespace NewsSystem.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<NewsSystem.Data.NewsSystemDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(NewsSystem.Data.NewsSystemDbContext context)
        {
            if(context.Articles.Any())
            {
                return;
            }

            var seed = new SeedData(new Models.User()
            {
                UserName = "Kon"
            });

            context.Users.Add(seed.Author);

            context.SaveChanges();

            seed.Categories.ForEach(x => context.Categories.Add(x));

            seed.Articles.ForEach(x => context.Articles.Add(x));

            context.SaveChanges();
        }
    }
}
