using System.Reflection;
using Autofac;
using Hosts.Editor.Windows;

namespace Hosts.Editor.Infrastructure
{
    public class DependencyResolver : IDependencyResolver
    {

        private IContainer _container;
        protected IContainer Container => _container ?? (_container = CreateContainer());

        private IContainer CreateContainer()
        {
            var builder = new ContainerBuilder();
            // Register each type in the application as the implementation for it's interface(s) by default
            var appAssembly = Assembly.GetAssembly(typeof(MainWindow));
            builder.RegisterAssemblyTypes(appAssembly).AsImplementedInterfaces().InstancePerDependency();
            //Register the current instance of the resolver as a singleton
            builder.RegisterInstance(this).AsImplementedInterfaces().SingleInstance();
            // Register forms
            builder.RegisterType<MainWindow>().AsSelf().InstancePerDependency();

            return builder.Build();
        }

        public T Resolve<T>()
        {
            return Container.Resolve<T>();
        }
    }
}