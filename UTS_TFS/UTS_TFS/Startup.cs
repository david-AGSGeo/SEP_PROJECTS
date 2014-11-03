using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UTS_TFS.Startup))]
namespace UTS_TFS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
