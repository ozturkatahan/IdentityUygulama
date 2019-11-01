using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityUygulama.Startup))]
namespace IdentityUygulama
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
