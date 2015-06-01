using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(homeless_shelter.Startup))]
namespace homeless_shelter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
