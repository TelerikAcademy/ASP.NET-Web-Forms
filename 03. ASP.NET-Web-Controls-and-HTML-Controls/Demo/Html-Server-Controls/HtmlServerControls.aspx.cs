namespace Html_Server_Controls
{
    using System;

    public partial class HtmlServerControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            Response.Write("Value: <b>" + this.TextField.Value + "</b>");
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {

        }
    }
}