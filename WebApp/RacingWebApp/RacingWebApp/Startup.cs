using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RacingWebApp.Startup))]
namespace RacingWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
