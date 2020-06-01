using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gnar.MVC.Startup))]
namespace Gnar.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
