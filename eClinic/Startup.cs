using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eClinic.Startup))]
namespace eClinic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
