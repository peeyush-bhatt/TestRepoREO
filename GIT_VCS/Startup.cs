using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GIT_VCS.Startup))]
namespace GIT_VCS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
