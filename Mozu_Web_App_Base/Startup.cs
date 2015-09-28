using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mozu_Web_App_Base.Startup))]
namespace Mozu_Web_App_Base
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
