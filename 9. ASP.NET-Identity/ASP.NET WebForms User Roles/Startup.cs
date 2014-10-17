using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP.NET_WebForms_User_Roles___N.Startup))]
namespace ASP.NET_WebForms_User_Roles___N
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
