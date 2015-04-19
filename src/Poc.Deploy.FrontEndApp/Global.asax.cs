namespace Poc.Deploy.FrontEndApp
{
    using System.Runtime.InteropServices;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    using Autofac;
    using Autofac.Integration.Mvc;

    using Poc.Deploy.FrontEndApp.Caching;
    using Poc.Deploy.FrontEndApp.Caching.Decorators;
    using Poc.Deploy.FrontEndApp.DataAccess;

    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            CreateDiContainerWithRegistrations();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void CreateDiContainerWithRegistrations()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterModule<AutofacWebTypesModule>();

            builder.RegisterSource(new ViewRegistrationSource());

            builder.RegisterFilterProvider();

            builder.RegisterType<RedisConnection>().AsSelf().SingleInstance();
            builder.RegisterType<RedisCacheProxy>().As<ICacheStoreProxy>().InstancePerRequest();

            builder.RegisterType<EmployersRepository>().Named<IEmployersRepository>("employerRepository").InstancePerRequest();

            builder.RegisterDecorator<IEmployersRepository>(
                (ctx, target) => new EmployersRepositoryCacheDecorator(target, ctx.Resolve<ICacheStoreProxy>()),
                fromKey:  "employerRepository");

            builder.RegisterType<EmployersOperations>().Named<IEmployersOperations>("employerOperations").InstancePerRequest();

            builder.RegisterDecorator<IEmployersOperations>(
                (ctx, target) => new EmployersOperationsCacheDecorator(target, ctx.Resolve<ICacheStoreProxy>()), 
                fromKey: "employerOperations");

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
