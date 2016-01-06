using System;
using System.Web.UI.WebControls;

public partial class Buttons : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.LabelMessage.Text = string.Empty;
    }

    protected void OnBtnClick(object sender, EventArgs e)
    {
        IButtonControl clickedButton = (IButtonControl)sender;
        this.LabelMessage.Text = "Button '" + sender + "' clicked!";
    }

    protected void OnCommand(object sender, CommandEventArgs e)
    {
        this.LabelMessage.Text += "<br/> Command: " + e.CommandName;
    }
}
