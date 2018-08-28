using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_PRoject.Startup))]
namespace MVC_PRoject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
