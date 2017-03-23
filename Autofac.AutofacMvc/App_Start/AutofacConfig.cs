using System.Configuration;
using System.Web.Mvc;
using Autofac.AutofacMvc.Data;
using Autofac.Integration.Mvc;

namespace Autofac.AutofacMvc
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterFilterProvider();
            builder.RegisterSource(new ViewRegistrationSource());
            builder.RegisterModule(new DataModule(ConfigurationManager.AppSettings["WebServer"]));
            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }

}