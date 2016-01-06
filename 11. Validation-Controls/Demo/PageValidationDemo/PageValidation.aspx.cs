using System;

public partial class PageValidation : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            this.LabelMessage.Text = "The page is valid!";
            // Perform some logic here
        }
        this.LabelMessage.Visible = Page.IsValid;
        // An else clause is unneeded – the page will
        // be returned to the user and all error 
        // messages will be displayed
    }

    protected void CustomValidator1_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
    {

    }
}
