namespace NewsSystem.Web.Private
{
    using Data.Models;
    using Data.Services.Contracts;
    using Ninject;
    using System;
    using System.Linq;
    using System.Web.UI.WebControls;

    public partial class ViewCategories : System.Web.UI.Page
    {
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
        public IQueryable<Category> gvCategories_GetData()
        {
            return this.CategoriesServices.GetAll().OrderBy(x => x.Id);
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void gvCategories_UpdateItem(int id)
        {
            var editTitleBox = this.gvCategories.Rows[this.gvCategories.EditIndex].Controls[0].Controls[0] as TextBox;

            // TODO: validate if null

            this.CategoriesServices.UpdateNameById(id, editTitleBox.Text);
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void gvCategories_DeleteItem(int id)
        {
            this.CategoriesServices.DeleteId(id);
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            this.CategoriesServices.Create(this.tbInsert.Text);

            this.tbInsert.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.tbInsert.Text = "";
        }
    }
}