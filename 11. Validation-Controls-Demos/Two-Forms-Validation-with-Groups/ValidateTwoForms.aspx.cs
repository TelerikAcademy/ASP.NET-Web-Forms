using System;

namespace TwoFormsValidation
{
    public partial class ValidateTwoForms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSearchByNames_Click(object sender, EventArgs e)
        {
            this.Page.Validate("ValidationGroupNames");
            if (this.Page.IsValid)
            {
                this.LabelIsValid.Text = "Names are valid.";
            }
        }

        protected void ButtonSearchByTown_Click(object sender, EventArgs e)
        {
            this.Page.Validate("ValidationGroupTown");
            if (this.Page.IsValid)
            {
                this.LabelIsValid.Text = "Town is valid.";
            }
        }
    }
}