using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GetTest3.web.Startup))]
namespace GetTest3.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
