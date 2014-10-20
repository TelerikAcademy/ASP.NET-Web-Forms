using System;

namespace SqlDataSourceDemo
{
    public partial class CategoriesAndProducts : System.Web.UI.Page
    {
        protected void GridViewCategories_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            int selectedCategoryId = (int)
                this.GridViewCategories.SelectedDataKey.Value;
            this.SqlDataSourceProducts.FilterExpression = 
                "CategoryID=" + selectedCategoryId;

            string selectedCategoryName =
                this.GridViewCategories.SelectedRow.Cells[1].Text;
            this.LiteralCategory.Text = 
                String.Format("from category \"{0}\"", selectedCategoryName);
        }
    }
}
