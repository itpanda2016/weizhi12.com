using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Teldrassil.Startup))]
namespace Teldrassil
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
