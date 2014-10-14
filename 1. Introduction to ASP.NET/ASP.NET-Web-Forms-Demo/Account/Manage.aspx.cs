using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;

namespace ASP.NET_Web_Forms_Demo.Account
{
    public partial class Manage : System.Web.UI.Page
    {
        protected string SuccessMessage
        {
            get;
            private set;
        }

        protected bool CanRemoveExternalLogins
        {
            get;
            private set;
        }

        protected void Page_Load()
        {
            if (!IsPostBack)
            {
                // Determine the sections to render
                var manager = new IdentityStoreManagerSync(new IdentityStoreManager(new IdentityStoreContext()));
                if (manager.HasLocalLogin(User.Identity.GetUserId())) 
                {
                    changePasswordHolder.Visible = true;
                }
                else 
                {
                    setPassword.Visible = true;
                    changePasswordHolder.Visible = false;
                }
                CanRemoveExternalLogins = manager.GetLogins(User.Identity.GetUserId()).Count > 1;

                // Render success message
                var message = Request.QueryString["m"];
                if (message != null) 
                {
                    // Strip the query string from action
                    Form.Action = ResolveUrl("~/Account/Manage");

                    SuccessMessage =
                        message == "ChangePwdSuccess" ? "Your password has been changed."
                        : message == "SetPwdSuccess" ? "Your password has been set."
                        : message == "RemoveLoginSuccess" ? "The account was removed."
                        : String.Empty;
                    successMessage.Visible = !String.IsNullOrEmpty(SuccessMessage);
                }
            }
        }

        protected void ChangePassword_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                var manager = new IdentityStoreManagerSync(new IdentityStoreManager(new IdentityStoreContext()));
                if (manager.ChangePassword(User.Identity.GetUserName(), CurrentPassword.Text, NewPassword.Text)) 
                {
                    Response.Redirect("~/Account/Manage?m=ChangePwdSuccess");
                }
                else 
                {
                    FailureText.Text = "Change password failed";
                }
            }
        }

        protected void SetPassword_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                // Create the local login info and link the local account to the user
                string userName = User.Identity.GetUserName();
                var manager = new IdentityStoreManagerSync(new IdentityStoreManager(new IdentityStoreContext()));
                if (manager.CreateLocalLogin(User.Identity.GetUserId(), User.Identity.GetUserName(), password.Text)) 
                {
                    Response.Redirect("~/Account/Manage?m=SetPwdSuccess");
                }
                else 
                {
                    FailureText.Text = "Failed to set password";
                }
            }
        }

        public IEnumerable<IUserLogin> GetLogins()
        {
            var manager = new IdentityStoreManagerSync(new IdentityStoreManager(new IdentityStoreContext()));
            var accounts = manager.GetLogins(User.Identity.GetUserId());
            CanRemoveExternalLogins = accounts.Count > 1;
            return accounts;
        }

        public void RemoveLogin(string loginProvider, string providerKey)
        {
            var manager = new IdentityStoreManagerSync(new IdentityStoreManager(new IdentityStoreContext()));
            var msg = manager.RemoveLogin(User.Identity.GetUserId(), loginProvider, providerKey)
                ? "?m=RemoveLoginSuccess"
                : String.Empty;
            Response.Redirect("~/Account/Manage" + msg);
        }
    }
}