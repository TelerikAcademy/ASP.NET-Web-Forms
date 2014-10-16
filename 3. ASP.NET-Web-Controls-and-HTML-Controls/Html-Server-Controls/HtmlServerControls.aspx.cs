using System;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Html_Server_Controls
{
    public partial class HtmlServerControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            Response.Write("Value: <b>" + this.TextField.Value + "</b>");
        }
    }
}