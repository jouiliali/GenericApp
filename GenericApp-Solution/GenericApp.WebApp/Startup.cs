using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GenericApp.WebApp.Startup))]
namespace GenericApp.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
