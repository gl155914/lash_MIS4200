using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lash_MIS4200.Startup))]
namespace lash_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
