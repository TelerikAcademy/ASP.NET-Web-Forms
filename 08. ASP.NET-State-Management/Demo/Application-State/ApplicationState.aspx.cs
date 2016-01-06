using System;

public partial class ApplicationState : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void buttonAddLoad_Click(object sender, EventArgs e)
    {
        Application.Lock();
        Application["Users"] = (int)Application["Users"] + 1;
        Application.UnLock();
    }

    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);

        Application.Lock();
        if (Application["Users"] == null)
        {
            Application["Users"] = 0;
        }
        Application.UnLock();
        labelLoads.Text = Application["Users"].ToString();
    }
}
