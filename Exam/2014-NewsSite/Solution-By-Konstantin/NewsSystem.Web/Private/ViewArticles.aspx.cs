namespace NewsSystem.Web.Private
{
    using Data.Models;
    using Data.Services.Contracts;
    using Ninject;
    using System;
    using System.Linq;
    using System.Linq.Dynamic;
    using Microsoft.AspNet.Identity;
    using System.Web.ModelBinding;
    using System.Web.UI.WebControls;

    public partial class ViewArticles : System.Web.UI.Page
    {
        [Inject]
        public IArticlesServices ArticlesServices { get; set; }

        [Inject]
        public ICategoriesServices CategoriesServices { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Article> lvArticles_GetData([QueryString]string orderBy)
        {
            var result = this.ArticlesServices.GetAll();

            // TODO: validate orderBy or create dictionary

            result = string.IsNullOrEmpty(orderBy) ? result.OrderBy(x => x.Id) : result.OrderBy(orderBy + " Ascending");

            return result;
        }

        public IQueryable<Category> ddlCategories_GetData()
        {
            return this.CategoriesServices.GetAll();
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void lvArticles_UpdateItem(int id)
        {
            var article = new Article();

            TryUpdateModel(article);

            this.ArticlesServices.UpdateById(id, article);
        }

        public void lvArticles_DeleteItem(int id)
        {
            this.ArticlesServices.DeleteById(id);

            this.Response.Redirect(this.Request.RawUrl);
        }

        public void lvArticles_InsertItem()
        {
            var articleToInsert = new Article();
            TryUpdateModel(articleToInsert);

            articleToInsert.AuthorId = Page.User.Identity.GetUserId();
            articleToInsert.DateCreated = DateTime.UtcNow;

            this.ArticlesServices.Create(articleToInsert);
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            this.lvArticles.InsertItemPosition = System.Web.UI.WebControls.InsertItemPosition.LastItem;
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            this.lvArticles.InsertItemPosition = System.Web.UI.WebControls.InsertItemPosition.None;
        }

        protected void Unnamed_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = args.Value.Length >= 3;
        }
    }
}