namespace LikesDemo.Migrations
{
    using LikesDemo.Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LikesDemo.Models.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(LikesDemo.Models.AppDbContext context)
        {
            if (context.Posts.Any())
            {
                return;
            }

            List<Post> posts = new List<Post>();
            posts.Add(new Post() { Title = "Fisrt Post", Content = "ads ashfk adsghfladsg" });
            posts.Add(new Post() { Title = "Second Post", Content = "ads ashfk adsghfladsg" });
            
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
