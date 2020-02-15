using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Online_Store.Web.Startup))]
namespace Online_Store.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
