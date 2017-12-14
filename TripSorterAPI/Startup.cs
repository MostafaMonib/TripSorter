using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TripSorterAPI.Startup))]

namespace TripSorterAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}