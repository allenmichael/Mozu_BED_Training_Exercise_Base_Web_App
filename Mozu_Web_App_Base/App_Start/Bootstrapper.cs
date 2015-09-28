using System.Reflection;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Mozu.Api.WebToolKit;
using Mozu.Api.Events;
using Mozu_Web_App_Base.Handlers;

namespace Mozu_Web_App_Base.App_Start
{
    public class Bootstrapper : AbstractWebApiBootstrapper
    {
        public override void InitializeContainer(ContainerBuilder containerBuilder)
        {
            base.InitializeContainer(containerBuilder);
            containerBuilder.RegisterControllers(Assembly.GetExecutingAssembly());
            containerBuilder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            containerBuilder.RegisterType<ApplicationEventHandler>().As<IApplicationEvents>();
        }
    }
}