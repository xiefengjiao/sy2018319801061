using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sy201831980106.Startup))]
namespace sy201831980106
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
