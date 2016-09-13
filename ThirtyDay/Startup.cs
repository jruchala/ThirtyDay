using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThirtyDay.Startup))]
namespace ThirtyDay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
