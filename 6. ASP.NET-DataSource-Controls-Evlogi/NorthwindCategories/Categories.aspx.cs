using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NorthwindCategories
{
    public partial class Categories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridViewCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            var grid = sender as GridView;
            var selectedCategoryId = grid.SelectedDataKey.Value;
            this.SqlDataSourceProducts.FilterExpression = "CategoryID=" + selectedCategoryId;

            string categoryName = grid.SelectedRow.Cells[1].Text;
            this.ltSelectedCategory.Text = string.Format(@"from category ""{0}""", categoryName);
        }
    }
}