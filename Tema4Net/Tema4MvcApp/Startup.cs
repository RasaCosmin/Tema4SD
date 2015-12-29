using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tema4MvcApp.Startup))]
namespace Tema4MvcApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
