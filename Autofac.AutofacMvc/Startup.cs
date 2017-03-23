using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Autofac.AutofacMvc.Startup))]
namespace Autofac.AutofacMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
