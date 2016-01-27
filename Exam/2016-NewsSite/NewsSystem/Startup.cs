using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewsSystem.Startup))]
namespace NewsSystem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
