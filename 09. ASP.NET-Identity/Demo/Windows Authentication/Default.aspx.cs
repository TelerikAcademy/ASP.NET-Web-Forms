using System;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        spnAuthenticated.InnerText = User.Identity.IsAuthenticated.ToString();
        spnUserName.InnerText = User.Identity.Name;
        spnAuthenticationType.InnerText = User.Identity.AuthenticationType;
    }
}
