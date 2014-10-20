using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityDataSourceListBox
{
    public partial class EFDataSourceMasterDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ListBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FormViewCustomer.PageIndex = this.ListBoxCustomers.SelectedIndex;
            this.FormViewCustomer.DataBind();
        }
    }
}
