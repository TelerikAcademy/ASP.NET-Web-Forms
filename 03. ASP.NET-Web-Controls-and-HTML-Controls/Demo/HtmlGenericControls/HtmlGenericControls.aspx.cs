using System;

namespace HtmlGenericControls
{
    public partial class HtmlGenericControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.MetaInfo.Attributes["name"] = "description";
            this.MetaInfo.Attributes["content"] = 
                "The page was generated on: " + DateTime.Now.ToString();
        }        
    }
}
