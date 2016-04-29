using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Configuration;
using Autofac.Integration.Mvc;
using GeneralSys.App;
using GeneralSys.Domain.Interface;
using GeneralSys.Repository;

namespace GeneralSys.AdminWeb
{
    public class Ioc
    {
        public static void InitIoc()
        {
            var builder = new ContainerBuilder();

            builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IRepository<>));

            builder.RegisterModule(new ConfigurationSettingsReader("autofac"));
            builder.RegisterType<UserManagerApp>();
            builder.RegisterType<SysResourceManagerApp>();

            // Register your MVC controllers.
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // OPTIONAL: Register model binders that require DI.
            builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
            builder.RegisterModelBinderProvider();

            // OPTIONAL: Register web abstractions like HttpContextBase.
            builder.RegisterModule<AutofacWebTypesModule>();

            // OPTIONAL: Enable property injection in view pages.
            builder.RegisterSource(new ViewRegistrationSource());

            // OPTIONAL: Enable property injection into action filters.
            builder.RegisterFilterProvider();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        /// <summary>
        /// 从容器中获取对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static T GetFromFac<T>()
        {
            return (T)DependencyResolver.Current.GetService(typeof(T));
        }
    }
}