using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fit5032_MyCSS.Startup))]
namespace Fit5032_MyCSS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
