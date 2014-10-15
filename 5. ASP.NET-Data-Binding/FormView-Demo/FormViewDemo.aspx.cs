using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace FormView_Demo
{
    public partial class FormViewDemo : System.Web.UI.Page
    {
        List<Customer> customers = new List<Customer>()
        {
            new Customer() { FirstName = "Nikolay", LastName = "Kostov", Email = "nikolay@kostov.com", Phone = "0894 77 22 53", IsSenior=true },
            new Customer() { FirstName = "Bai", LastName = "Kenov", Email = "bai.kenov@gmail.com", Phone = "0899 555 444" },
            new Customer() { FirstName = "Kaka", LastName = "Doncho", Email = "kaka.doncho@abv.net", Phone = "095 955 955" }
        };

		protected void Page_Load(object sender, EventArgs e)
		{
			if (IsPostBack)
			{
				this.customers = (List<Customer>)ViewState["customers"];
			}
		}

		protected void Page_PreRender(object sender, EventArgs e)
		{
			this.FormViewCustomer.DataSource = this.customers;
			this.FormViewCustomer.DataBind();
			ViewState["customers"] = this.customers;
		}

		protected void FormViewCustomer_PageIndexChanging(
			object sender, FormViewPageEventArgs e)
        {
            this.FormViewCustomer.PageIndex = e.NewPageIndex;
            this.FormViewCustomer.DataSource = this.customers;
            this.FormViewCustomer.DataBind();
        }

		protected void LinkButtonEdit_Click(object sender, EventArgs e)
		{
			this.FormViewCustomer.ChangeMode(FormViewMode.Edit);
			this.MultiViewButtons.SetActiveView(this.ViewEditMode);
		}

        protected void LinkButtonSave_Click(object sender, EventArgs e)
        {
            this.FormViewCustomer.ChangeMode(FormViewMode.ReadOnly);
            this.MultiViewButtons.SetActiveView(this.ViewNormalMode);
            int customerIndex = this.FormViewCustomer.PageIndex;
			TextBox textBoxPhone = (TextBox)
				this.FormViewCustomer.FindControl("TextBoxPhone");
			this.customers[customerIndex].Phone = textBoxPhone.Text;
			TextBox textBoxEmail = (TextBox)
				this.FormViewCustomer.FindControl("TextBoxEmail");
			this.customers[customerIndex].Email = textBoxEmail.Text;
		}
        protected void LinkButtonCancel_Click(object sender, EventArgs e)
        {
            this.FormViewCustomer.ChangeMode(FormViewMode.ReadOnly);
            this.MultiViewButtons.SetActiveView(this.ViewNormalMode);
        }

        protected void EditButton_Command(object sender, CommandEventArgs e)
        {
            var args = e.CommandArgument;
        }
    }
}
