using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GamesCatalog.Startup))]
namespace GamesCatalog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
