using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Skibur.Web.Startup))]
namespace Skibur.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
