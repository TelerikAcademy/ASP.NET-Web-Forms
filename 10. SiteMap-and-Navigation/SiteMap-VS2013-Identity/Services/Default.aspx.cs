using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteMap_VS2013_Identity.Services
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] roles = { "Admin" };
            HttpContext.Current.User = new GenericPrincipal(HttpContext.Current.User.Identity, roles);
        }
    }
}