using System;
using System.Web.UI.WebControls;

namespace EntityDataSourceDemo
{
    public partial class CustomersEditor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonInsertCustomer_Click(object sender, EventArgs e)
        {
            this.ListViewCustomers.InsertItemPosition = InsertItemPosition.LastItem;
        }

        protected void ListViewCustomers_ItemInserted(object sender,
            ListViewInsertedEventArgs e)
        {
            this.ListViewCustomers.InsertItemPosition = InsertItemPosition.None;
        }
    }
}