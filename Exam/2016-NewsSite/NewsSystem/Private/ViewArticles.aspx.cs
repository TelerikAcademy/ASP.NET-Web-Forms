namespace NewsSystem.Private
{
    using Services.Contracts;
    using Ninject;
    using System;
    using System.Linq;
    using System.Web.ModelBinding;
    using System.Linq.Dynamic;
    using Microsoft.AspNet.Identity;
    using Models;

    public partial class ViewArticles : System.Web.UI.Page
    {
        public const string SortDirection = "Ascending";

        [Inject]
        public IArticlesServices ArticlesServices { get; set; }

        [Inject]
        public ICategoriesServices CategoriesServices { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<NewsSystem.Models.Article> lvArticles_GetData([QueryString]string orderBy)
        {
            var result = this.ArticlesServices.GetAll();

            // TODO: validate orderBy parameter

            result = orderBy != null ? result.OrderBy(orderBy + " " + SortDirection) : result.OrderBy(x => x.Id);

            return result;
        }

        public IQueryable<NewsSystem.Models.Category> ddlInsertCategory_GetData()
        {
            return this.CategoriesServices.GetAll();
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void lvArticles_DeleteItem(int id)
        {
            this.ArticlesServices.DeleteById(id);
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void lvArticles_UpdateItem(int id)
        {
            Article updatedArticle = new Article();

            TryUpdateModel(updatedArticle);
            this.ArticlesServices.UpdateById(id, updatedArticle);

            this.Response.Redirect("~/ViewArticle.aspx?id=" + id);
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            this.lvArticles.InsertItemPosition = System.Web.UI.WebControls.InsertItemPosition.LastItem;
        }

        public void lvArticles_InsertItem()
        {
            var newArticle = new Article()
            {
                AuthorId = User.Identity.GetUserId(),
                DateCreated = DateTime.UtcNow
            };
            TryUpdateModel(newArticle);

            if (ModelState.IsValid)
            {
                this.ArticlesServices.Create(newArticle);
            }
        }
    }
}