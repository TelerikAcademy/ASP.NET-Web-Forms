using System;
using System.Collections.Generic;

namespace GridViewDemo
{
    public partial class DetailsViewDemo : System.Web.UI.Page
    {
        List<Customer> customers = new List<Customer>()
        {
            new Customer() { FirstName = "Nikolay", LastName = "Kostov", Email = "nikolay@kostov.com", Phone = "0894 77 22 53", IsSenior=true },
            new Customer() { FirstName = "Bai", LastName = "Kenov", Email = "bai.kenov@gmail.com", Phone = "0899 555 444" },
            new Customer() { FirstName = "Kaka", LastName = "Doncho", Email = "kaka.doncho@abv.net", Phone = "095 955 955" }
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            this.DetailsViewCustomer.DataSource = this.customers;
            this.DetailsViewCustomer.DataBind();
        }

        protected void DetailsViewCustomer_PageIndexChanging(object sender, 
            System.Web.UI.WebControls.DetailsViewPageEventArgs e)
        {
            this.DetailsViewCustomer.PageIndex = e.NewPageIndex;
            this.DetailsViewCustomer.DataSource = this.customers;
            this.DetailsViewCustomer.DataBind();
        }
    }
}
