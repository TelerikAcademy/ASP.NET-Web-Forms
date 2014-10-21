using System;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace SiteMap_and_Navigation
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void NavigationMenu_MenuItemDataBound(object sender, MenuEventArgs e)
        {
            if (ShouldRemoveItem(e.Item.Text))
            {
                e.Item.Parent.ChildItems.Remove(e.Item);
            }
        }

        private bool ShouldRemoveItem(string menuText)
        {
            MembershipUser currentUser = Membership.GetUser();
            if (menuText == "Logout" && currentUser == null)
            {
                return true;
            }
            if (menuText == "Login" && currentUser != null)
            {
                return true;
            }
            if (menuText == "Register" && currentUser != null)
            {
                return true;
            }
            return false;
        }
    }
}
