using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SiteMap_VS2013_Identity.Startup))]
namespace SiteMap_VS2013_Identity
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
