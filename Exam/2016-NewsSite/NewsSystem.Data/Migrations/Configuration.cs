namespace NewsSystem.Data.Migrations
{
    using Models;
    using NewsSystem.Migrations;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<NewsSystem.Data.NewsSystemDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(NewsSystem.Data.NewsSystemDbContext context)
        {
            if (context.Articles.Any())
            {
                return;
            }

            var user = new User()
            {
                UserName = "Kon"
            };

            context.Users.Add(user);

            context.SaveChanges();

            var seed = new SeedData(user);

            seed.Categories.ForEach(x => context.Categories.Add(x));

            seed.Articles.ForEach(x => context.Articles.Add(x));

            context.SaveChanges();
        }
    }
}
