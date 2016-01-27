namespace NewsSystem
{
    using Services.Contracts;
    using Ninject;
    using System;
    using System.Web.ModelBinding;

    public partial class ViewArticle : System.Web.UI.Page
    {
        [Inject]
        public IArticlesServices ArticlesServices { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public NewsSystem.Models.Article fvArticle_GetItem([QueryString]string id)
        {
            // TODO: validation and error message
            return this.ArticlesServices.GetById(int.Parse(id));
        }
    }
}