using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewsSite.Startup))]
namespace NewsSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
