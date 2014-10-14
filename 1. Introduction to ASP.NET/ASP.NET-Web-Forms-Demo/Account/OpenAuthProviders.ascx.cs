using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace ASP.NET_Web_Forms_Demo.Account
{
    public partial class OpenAuthProviders : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                var provider = Request.Form["provider"];
                if (provider == null)
                {
                    return;
                }
                // Request a redirect to the external login provider
                string redirectUrl = ResolveUrl(String.Format(CultureInfo.InvariantCulture, "~/Account/RegisterExternalLogin?{0}={1}&returnUrl={2}", IdentityConfig.ProviderNameKey, provider, ReturnUrl));
                var manager = new IdentityAuthenticationManagerSync();
                manager.Challenge(new HttpContextWrapper(Context), provider, redirectUrl);
                Response.StatusCode = 401;
                Response.End();
            }
        }

        public string ReturnUrl { get; set; }

        public IEnumerable<string> GetProviderNames()
        {
            var manager = new IdentityAuthenticationManagerSync();
            return manager.GetExternalAuthenticationTypes(new HttpContextWrapper(Context)).Select(t => t.AuthenticationType);
        }
    }
}