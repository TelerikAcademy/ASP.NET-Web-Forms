using System;
using System.Web.Security;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Disable the Web browser's cache
        Response.CacheControl = "no-cache";
        Response.ExpiresAbsolute = DateTime.Now;
        Response.AddHeader("Pragma", "no-cache");
        Response.AddHeader("Pragma", "no-store");
        Response.AddHeader("cache-control", "no-cache");

        lblMessage.Text = "Welcome, " + Page.User.Identity.Name + "!";
    }

    protected void btnLoguot_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        Response.Redirect("Login.aspx");
    }
}
