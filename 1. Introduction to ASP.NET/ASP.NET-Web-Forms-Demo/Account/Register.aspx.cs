using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Web;
using System.Web.UI;

namespace ASP.NET_Web_Forms_Demo.Account
{
    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            string userName = UserName.Text;
            try
            {
                var store = new IdentityStoreManager();
                var storeManager = new IdentityStoreManagerSync(store);
                var authManager = new IdentityAuthenticationManagerSync(new IdentityAuthenticationManager(store));
                User u = new User(userName) { UserName = userName };
                if (storeManager.CreateLocalUser(u, Password.Text)) 
                {
                    authManager.SignIn(new HttpContextWrapper(Context), u.Id, isPersistent: false);
                    IdentityConfig.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                }
            }
            catch (IdentityException ex)
            {
                ErrorMessage.Text = ex.Message;
            }
        }
    }
}