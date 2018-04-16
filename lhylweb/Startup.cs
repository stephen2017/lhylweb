using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lhylweb.Startup))]
namespace lhylweb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
