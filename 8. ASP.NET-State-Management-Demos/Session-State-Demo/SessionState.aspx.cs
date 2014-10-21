using System;

public partial class SessionState : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void buttonAddLoad_Click(object sender, EventArgs e)
    {
        Session["Clicks"] = (int)Session["Clicks"] + 1;
    }

    protected override void OnPreRender(EventArgs e)
    {
        if (Session["Clicks"] == null)
        {
            Session["Clicks"] = 0;
        }
        LabelPageLoads.Text = Session["Clicks"].ToString();
    }
}
