using System;
using System.Web.Security;

public partial class Login : System.Web.UI.Page
{
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (FormsAuthentication.Authenticate(tbUsername.Text, tbPassword.Text))
        {
            FormsAuthentication.RedirectFromLoginPage(tbUsername.Text, false);
        }
        else
        {
            lblErrorMessage.Text = "Invalid login!";
        }
    }
}
