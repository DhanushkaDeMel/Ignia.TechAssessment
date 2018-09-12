using ServerHosting.Core.Contracts.DataProviders;
using ServerHosting.Core.Contracts.Services;
using ServerHosting.Core.DataProviders;
using ServerHosting.Core.Services;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace ServerHosting.WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IServerStateDataProvider, ServerStateDataProvider>();
            container.RegisterType<IServerStatusService, ServerStatusService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}