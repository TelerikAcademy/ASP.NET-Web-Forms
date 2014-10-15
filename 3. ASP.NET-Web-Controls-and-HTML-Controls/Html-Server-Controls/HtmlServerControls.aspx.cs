using System;

namespace Html_Server_Controls
{
    public partial class HtmlServerControls : System.Web.UI.Page
    {
        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            Response.Write("Value: <b>" + this.TextField.Value + "</b>");
        }
    }
}