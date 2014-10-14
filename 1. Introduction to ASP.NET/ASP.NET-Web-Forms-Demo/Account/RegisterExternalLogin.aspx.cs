using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Security.Claims;
using System.Web;

namespace ASP.NET_Web_Forms_Demo.Account
{
    public partial class RegisterExternalLogin : System.Web.UI.Page
    {
        protected string ProviderName
        {
            get { return (string)ViewState["ProviderName"] ?? String.Empty; }
            private set { ViewState["ProviderName"] = value; }
        }

        protected string ProviderAccountKey
        {
            get { return (string)ViewState["ProviderAccountKey"] ?? String.Empty; }
            private set { ViewState["ProviderAccountKey"] = value; }
        }

        protected void Page_Load()
        {
            // Process the result from an auth provider in the request
            ProviderName = IdentityConfig.GetProviderNameFromRequest(Request);
            if (String.IsNullOrEmpty(ProviderName))
            {
                Response.Redirect("~/Account/Login");
            }
            if (!IsPostBack)
            {
                var manager = new IdentityAuthenticationManagerSync();
                ClaimsIdentity id = manager.GetExternalIdentity(new HttpContextWrapper(Context));
                if (!manager.VerifyExternalIdentity(id, ProviderName))
                {
                    ModelState.AddModelError(String.Empty, "There was an error processing this request.");
                    return;
                }

                if (manager.SignInExternalIdentity(new HttpContextWrapper(Context), id, ProviderName))
                {
                    IdentityConfig.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                }
                else if (User.Identity.IsAuthenticated)
                {
                    if (manager.LinkExternalIdentity(id, User.Identity.GetUserId(), ProviderName))
                    {
                        IdentityConfig.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                    }
                    else
                    {
                        ModelState.AddModelError(String.Empty, "There was an error processing this request.");
                        return;
                    }
                }
                else
                {
                    userName.Text = id.Name;
                }
            }
        }        
        
        protected void LogIn_Click(object sender, EventArgs e)
        {
            CreateAndLoginUser();
        }

        private void CreateAndLoginUser()
        {
            if (!IsValid)
            {
                return;
            }
            try
            {
                var user = new User(userName.Text);
                var manager = new IdentityAuthenticationManagerSync();
                if (manager.CreateAndSignInExternalUser(new HttpContextWrapper(Context), ProviderName, user))
                {
                    IdentityConfig.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                }
                else
                {
                    ModelState.AddModelError(String.Empty, "There was an error processing this request.");
                    return;
                }
            }
            catch (IdentityException e)
            {
                ModelState.AddModelError("", e.Message);
            }
        }
    }
}