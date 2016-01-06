using System;
using System.Web.Security;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Roles.IsUserInRole("Administrators"))
        {
            LabelMessage.Text += "You are an administrator.";
        }
        else if (Roles.IsUserInRole("Users"))
        {
            MembershipUser currentUser = Membership.GetUser();
            LabelMessage.Text += "You are an user: " + currentUser;
        }
    }
}
