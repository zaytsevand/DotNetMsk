using Autofac;
using Topshelf;
using Topshelf.Autofac;

namespace DotNetMsk._10.DemoTestProject.Host
{
    public class Program
    {
        private static IContainer _container;

        private static IContainer Container => _container ?? (_container = BuildContainer());

        private static void Main()
        {
            HostFactory.Run(config =>
            {
                config.Service<IService>(settings =>
                {
                    settings.ConstructUsingAutofacContainer();
                    settings.WhenStarted(s => s.Start());
                    settings.WhenStopped(s => s.Stop());
                });

                config.UseAutofacContainer(Container);
            });
        }

        private static IContainer BuildContainer()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<OwinHostService>().As<IService>();
            containerBuilder.RegisterType<OwinHostServiceConfig>().AsSelf().SingleInstance();

            return containerBuilder.Build();
        }
    }
}