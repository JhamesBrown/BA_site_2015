using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BA_site.Startup))]
namespace BA_site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
