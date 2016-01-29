namespace NewsSystem.Web
{
    using NewsSystem.Data.Models;
    using NewsSystem.Data.Services.Contracts;
    using Ninject;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Home : System.Web.UI.Page
    {
        [Inject]
        public IArticlesServices ArticlesServices { get; set; }

        [Inject]
        public ICategoriesServices CategoriesServices { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Article> repeaterArticle_GetData1()
        {
            return this.ArticlesServices.GetTop(3);
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Category> lvCategories_GetData()
        {
            return this.CategoriesServices.GetAll(); ;
        }
    }
}