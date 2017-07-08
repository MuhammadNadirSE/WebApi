using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(APIs.Startup))]
namespace APIs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
