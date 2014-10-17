using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP.NET_MVC_Template.Startup))]
namespace ASP.NET_MVC_Template
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
