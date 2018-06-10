using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CubeAfricaDemo.Startup))]
namespace CubeAfricaDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
