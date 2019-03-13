using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Newskalo.MVC.Startup))]
namespace Newskalo.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
