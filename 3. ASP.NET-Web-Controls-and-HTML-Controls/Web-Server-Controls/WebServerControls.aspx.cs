using System;

namespace Web_Server_Controls
{
    public partial class WebServerControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            this.LabelResult.Text = 
                "You entered: <b>" + this.TextBoxInput.Text + "</b>.<br/>";
            this.LabelResult.Visible = true;
        }
    }
}
