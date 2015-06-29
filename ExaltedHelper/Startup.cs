using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExaltedHelper.Startup))]
namespace ExaltedHelper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
