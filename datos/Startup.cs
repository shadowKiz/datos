using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(datos.Startup))]
namespace datos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
