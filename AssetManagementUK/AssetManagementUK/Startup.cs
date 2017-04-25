using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AssetManagementUK.Startup))]
namespace AssetManagementUK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
