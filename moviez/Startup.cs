using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(moviez.Startup))]
namespace moviez
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
