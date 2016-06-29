using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FTM1._0.Startup))]
namespace FTM1._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
