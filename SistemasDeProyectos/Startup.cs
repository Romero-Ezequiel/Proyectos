using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemasDeProyectos.Startup))]
namespace SistemasDeProyectos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
