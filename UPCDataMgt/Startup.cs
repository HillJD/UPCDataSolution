using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UPCDataMgt.Startup))]
namespace UPCDataMgt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
