using NewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsSite
{
    public partial class Home : Page
    {
        public NewsDbContext dbContext;

        public Home()
        {
            this.dbContext = new NewsDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<NewsSite.Models.Article> ListViewArticles_GetData()
        {
            return this.dbContext.Articles.OrderBy(c => c.ID);
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Category> ListViewCategories_GetData()
        {
            return this.dbContext.Categories.OrderBy(c => c.Name);
        }

        protected string GetTitle(NewsSite.Models.Article article)
        {
            return string.Format("<strong>{0}</strong> <i> by {1}</i>", Server.HtmlEncode(article.Title), Server.HtmlEncode(article.Author.UserName));
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<NewsSite.Models.Article> ListViewPopularArticles_GetData()
        {
            return this.dbContext.Articles
                .Where(a => a.Likes.Count == 0 || a.Likes.Sum(l => l.Value) > 0)
                .OrderByDescending(a => a.Likes.Sum(l => l.Value))
                .ThenBy(a => a.DateCreated).Take(3);
        }
    }
}