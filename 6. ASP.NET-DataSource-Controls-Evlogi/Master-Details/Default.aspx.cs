using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Master_Details
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ListBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FormViewCustomer.PageIndex = this.ListBoxCustomers.SelectedIndex;
            this.FormViewCustomer.DataBind();

            this.DetailsVeiwCustomer.DataSource = this.edsCustomers;
            this.DetailsVeiwCustomer.PageIndex = this.ListBoxCustomers.SelectedIndex;
            this.DetailsVeiwCustomer.DataBind();

            this.headerOrders.Visible = true;
        }

        protected void GridViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.headerOrderDetails.Visible = true;
        }

        protected void lvOrderDetails_Sorting(object sender, ListViewSortEventArgs e)
        {

        }

        protected void lvOrderDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}