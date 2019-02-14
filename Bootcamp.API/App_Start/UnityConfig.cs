using Bussines_Logic.Interface;
using Bussines_Logic.Interface.Service;
using Common.Interface;
using Common.Interface.Master;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace Bootcamp.API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            //this is Service Area
            container.RegisterType<iSupplierService, SupplierService>();
            //this is Repository Area
            container.RegisterType<iSupplierRepository, SupplierRepository>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}