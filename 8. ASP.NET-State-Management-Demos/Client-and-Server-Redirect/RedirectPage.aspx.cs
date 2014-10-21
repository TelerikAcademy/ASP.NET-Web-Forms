using System;

public partial class RedirectPage : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void buttonServerRedirect_Click(object sender, EventArgs e)
    {
        Page.Server.Transfer("TheNewPage.aspx");
    }

    protected void buttonRedirect_Click(object sender, EventArgs e)
    {
        Page.Response.Redirect("TheNewPage.aspx");
    }
}
