namespace LikeUserControl.Migrations
{
    using LikeUserControl.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LikeUserControl.Models.ForumDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(LikeUserControl.Models.ForumDbContext context)
        {
            if (context.Posts.Any())
            {
                return;
            }

            List<Post> posts = new List<Post>
            {
                new Post() { Title = "First post", Description = "Some text 1 Some text 1 Some text 1 Some text 1 ", DateCreated = DateTime.Now },
                new Post() { Title = "Second post", Description = "Some text 2 Some text 2 Some text 2 Some text 2 ", DateCreated = DateTime.Now },
            };

            context.Posts.AddOrUpdate(posts.ToArray());


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
