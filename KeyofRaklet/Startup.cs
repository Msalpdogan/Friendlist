using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KeyofRaklet.Startup))]
namespace KeyofRaklet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
