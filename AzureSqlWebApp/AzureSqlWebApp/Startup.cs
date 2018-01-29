using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureSqlWebApp.Startup))]
namespace AzureSqlWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
