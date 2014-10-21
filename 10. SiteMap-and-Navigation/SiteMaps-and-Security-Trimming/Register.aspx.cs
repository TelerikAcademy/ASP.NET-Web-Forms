using System;
using System.Web.Security;

namespace SiteMap_and_Navigation
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Membership.CreateUser(this.TextBoxUsername.Text, this.TextBoxPassword.Text);
                AddUserToRole(this.TextBoxUsername.Text, this.DropDownListRole.SelectedValue);
                FormsAuthentication.RedirectFromLoginPage(this.TextBoxUsername.Text, false);
                Response.Redirect("~/Home.aspx");
            }
            catch (Exception ex)
            {
                this.LiteralErrorMessage.Text = "Error: " + ex.Message;
            }
        }

        private void AddUserToRole(string userName, string roleName)
        {
            if (!Roles.RoleExists(roleName))
            {
                Roles.CreateRole(roleName);
            }
            Roles.AddUserToRole(userName, roleName);
        }
    }
}