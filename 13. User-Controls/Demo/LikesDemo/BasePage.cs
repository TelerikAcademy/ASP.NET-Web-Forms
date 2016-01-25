namespace LikesDemo
{
    using LikesDemo.Models;
    using System.Web.UI;

    public class BasePage : Page
    {
        public AppDbContext dbContext { get; set; }

        public BasePage()
        {
            this.dbContext = new AppDbContext(); 
        }
    }
}
