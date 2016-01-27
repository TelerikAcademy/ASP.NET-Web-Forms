namespace NewsSystem.Private
{
    using NewsSystem.Services.Contracts;
    using Ninject;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
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
        public IQueryable<NewsSystem.Models.Category> gvCategories_GetData1()
        {
            return this.CategoriesServices.GetAll();
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void gvCategories_UpdateItem(int id)
        {
            var editTextBox = this.gvCategories.Rows[this.gvCategories.EditIndex].Controls[0].Controls[0] as TextBox;

            if(editTextBox == null)
            {
                // TODO: error notification
            }

            this.CategoriesServices.UpdateById(id, editTextBox.Text);
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void gvCategories_DeleteItem(int id)
        {
            this.CategoriesServices.DeleteById(id);
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            if(!Page.IsValid)
            {
                return;
            }

            var newCategoryName = this.tbInsertName.Text;

            this.CategoriesServices.Create(newCategoryName);

            this.tbInsertName.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.tbInsertName.Text = "";
        }

        protected void Unnamed_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = this.tbInsertName.Text.Length >= 3;
        }
    }
}