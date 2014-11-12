using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TiConference.Startup))]
namespace TiConference
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
