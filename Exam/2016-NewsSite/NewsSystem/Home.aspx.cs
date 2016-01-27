namespace NewsSystem
{
    using Models;
    using NewsSystem.Services.Contracts;
    using Ninject;
    using System;
    using System.Linq;

    public partial class Home : System.Web.UI.Page
    {
        public const int TopArticlesDisplayCountByLikes = 3;

        [Inject]
        public IArticlesServices ArticlesServices { get; set; }

        [Inject]
        public ICategoriesServices CategoriesServices { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public System.Collections.IEnumerable ArticlesRepeater_GetData()
        {
            return this.ArticlesServices.GetTop(TopArticlesDisplayCountByLikes);
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Category> lvCategories_GetData()
        {
            return this.CategoriesServices.GetAll();
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Article> lvArticlesForCategory_GetData()
        {
            return null;
        }
    }
}