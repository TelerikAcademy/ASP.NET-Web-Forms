using System;
using System.Web.Security;

namespace SiteMap_and_Navigation
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var users = Membership.GetAllUsers();
            this.BulletedListUsers.DataSource = users;
            this.BulletedListUsers.DataBind();
        }
    }
}
