using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MonMusiqueSite.Startup))]
namespace MonMusiqueSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
