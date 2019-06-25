using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CentresApplication.Startup))]
namespace CentresApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
