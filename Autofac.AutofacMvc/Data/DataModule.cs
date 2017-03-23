using Autofac.AutofacMvc.Dependencies;

namespace Autofac.AutofacMvc.Data
{
    public class DataModule : Module
    {
        private readonly string _webServer;

        public DataModule(string webServer)
        {
            _webServer = webServer;
        }
        protected override void Load(ContainerBuilder builder)
        {
            // Create the Concrete Object
            builder.Register(c => new ConcreteObjectConfiguration { WebServer = _webServer}).As<IWebConfiguration>();
            base.Load(builder);
        }
    }
}