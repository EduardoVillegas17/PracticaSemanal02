using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PractSem2.Startup))]
namespace PractSem2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
