using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BienvenidosUY_2.Startup))]
namespace BienvenidosUY_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
