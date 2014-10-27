using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LikesDemo.Startup))]
namespace LikesDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
