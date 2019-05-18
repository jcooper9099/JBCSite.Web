using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using JBCSite.Services;
using JBCSite.Auth;

namespace JBCSite.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IDemoService, DemoService>();
            container.RegisterType<IUserService, UserService>();
           
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}