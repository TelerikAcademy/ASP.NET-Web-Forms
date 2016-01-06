using System;

namespace Data_Binding_Simple_Example
{
    public partial class DataBindingSimpleExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Bind the towns
				var towns = new[] 
                { 
                    new {ID = 1, Name = "Sofia"},
                    new {ID = 2, Name = "Plovdiv"},
                    new {ID = 3, Name = "Varna"},
                };
                this.ListBoxTowns.DataSource = towns;
                this.ListBoxTowns.DataBind();

				// Bind the Yes/No drop-down-list
				var answers = new string[] { "Yes", "No" };
				this.DropDownYesNo.DataSource = answers;
				this.DropDownYesNo.DataBind();
            }
        }

        protected void DropDownYesNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LabelSelectedYesNo.Text = this.DropDownYesNo.SelectedValue;
        }

        protected void ListBoxTowns_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LabelSelectedTown.Text = this.ListBoxTowns.SelectedValue;
        }
    }
}
