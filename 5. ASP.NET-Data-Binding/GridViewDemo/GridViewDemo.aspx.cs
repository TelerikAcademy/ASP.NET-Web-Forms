using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace GridViewDemo
{
    public partial class GridViewDemo : System.Web.UI.Page
    {
        List<Customer> customers = new List<Customer>()
        {
            new Customer() { ID=11, FirstName = "Nikolay", LastName = "Kostov", Email = "nikolay@kostov.com", Phone = "0894 77 22 53", IsSenior=true },
            new Customer() { ID=22, FirstName = "Bai", LastName = "Kenov", Email = "bai.Kenov@gmail.com", Phone = "0899 555 444" },
            new Customer() { ID=33, FirstName = "Kaka", LastName = "Doncho", Email = "kaka.doncho@abv.net", Phone = "095 955 955" }
        };

        protected void Page_Init(object sender, EventArgs e)
        {
            this.customers.AddRange(customers);
            this.customers.AddRange(customers);
            this.customers.AddRange(customers);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.GridViewCustomers.DataSource = this.customers;
                this.GridViewCustomers.DataBind();
            }
        }

        protected void GridViewCustomers_PageIndexChanging(object sender, 
            System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            this.GridViewCustomers.PageIndex = e.NewPageIndex;
            this.GridViewCustomers.DataSource = this.customers;
            this.GridViewCustomers.DataBind();
        }

        protected void GridViewCustomers_RowDataBound(object sender,
            GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onmouseover"] =
                    "this.style.background='#EEEEEE';this.style.cursor='hand'";
                e.Row.Attributes["onmouseout"] =
                    "this.style.background='white'";
                e.Row.Attributes["onclick"] =
                    ClientScript.GetPostBackClientHyperlink(
                    this.GridViewCustomers, "Select$" + e.Row.RowIndex);
            }
        }

        protected void GridViewCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LabelSelectedItem.Text =
                "Selected customer ID = " +
                this.GridViewCustomers.SelectedDataKey.Value;
        }
    }
}
