using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using Service_Layer_Transaction;
using Data_Layer_Transaction;
using Transaction_Project;
namespace Transaction_Project
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            //container.RegisterType<IService_Layer, Service_Layer_Logic>();
            container.RegisterType<IDb_Layer, DB_Layer>();
            container.RegisterType<IRepository, Repository_Logic>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}