using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebWareHouse.Startup))]
namespace WebWareHouse
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
