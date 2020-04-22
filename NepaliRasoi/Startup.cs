using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NepaliRasoi.Startup))]
namespace NepaliRasoi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
