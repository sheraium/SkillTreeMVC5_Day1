using Autofac;
using Autofac.Integration.Mvc;
using SkillTreeMVC5_Day1.Repository;
using System.Reflection;
using System.Web.Mvc;

namespace SkillTreeMVC5_Day1
{
    public class AutofacConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();

            // Register Controllers
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            // Register UnitOfWork
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            // Register Services
            //builder.RegisterType<LedgerService>().As<LedgerService>();
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(a => a.Name.EndsWith("Service")).AsSelf();
            
            // Build container, and Set resolver
            var container = builder.Build();
            var resolver = new AutofacDependencyResolver(container);
            DependencyResolver.SetResolver(resolver);
        }
    }
}