using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication20210503.Startup))]
namespace WebApplication20210503
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
