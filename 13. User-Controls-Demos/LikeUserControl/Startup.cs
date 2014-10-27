using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LikeUserControl.Startup))]
namespace LikeUserControl
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
