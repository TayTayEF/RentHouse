using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThueTro_DACS.Startup))]
namespace ThueTro_DACS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
