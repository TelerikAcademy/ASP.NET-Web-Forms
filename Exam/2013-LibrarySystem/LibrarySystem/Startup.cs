using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LibrarySystem.Startup))]
namespace LibrarySystem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
