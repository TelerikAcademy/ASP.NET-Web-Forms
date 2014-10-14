using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Web;
using System.Web.UI;

namespace ASP.NET_Web_Forms_Demo.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register";
            OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
            if (IsValid)
            {
                // Validate the user password
                var manager = new IdentityAuthenticationManagerSync();
                if (manager.CheckPasswordAndSignIn(new HttpContextWrapper(Context), UserName.Text, Password.Text, RememberMe.Checked))
                {
                    IdentityConfig.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                }
                else
                {
                    FailureText.Text = "Your login attempt was not successful. Please try again.";
                    ErrorMessage.Visible = true;
                }
            }
        }
    }
}