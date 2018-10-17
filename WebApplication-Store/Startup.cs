using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication_Store.Startup))]
namespace WebApplication_Store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
