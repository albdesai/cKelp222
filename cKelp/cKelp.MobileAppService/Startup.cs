using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(cKelp.MobileAppService.Startup))]

namespace cKelp.MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}