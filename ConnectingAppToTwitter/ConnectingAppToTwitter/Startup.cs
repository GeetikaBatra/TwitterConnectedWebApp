using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConnectingAppToTwitter.Startup))]
namespace ConnectingAppToTwitter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
