using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MonTest.Startup))]
namespace MonTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
