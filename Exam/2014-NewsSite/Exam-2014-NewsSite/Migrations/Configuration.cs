namespace NewsSite.Migrations
{
    using NewsSite.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NewsSite.Models.NewsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        public static Random Rand = new Random();

        protected override void Seed(NewsSite.Models.NewsDbContext context)
        {
            if (context.Categories.Any())
            {
                return;
            }

            SeedData seedData = new SeedData();
            context.Categories.AddOrUpdate(seedData.Categories.ToArray());
            context.Articles.AddOrUpdate(seedData.Articles.ToArray());
        }
    }
}
