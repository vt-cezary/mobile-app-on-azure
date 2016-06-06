using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(vt_mobile_appService.Startup))]

namespace vt_mobile_appService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}