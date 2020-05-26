using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Todo.Services;

namespace Todo.Web.IoC
{
    public class ContainerConfig : ContainerBuilder
    {
        public static void ConfigureContainer()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterControllers(typeof(MvcApplication).Assembly);

            containerBuilder.RegisterType<TodoService>().As<ITodoService>();
            containerBuilder.RegisterType<AuthService>().As<IAuthService>();

            var container = containerBuilder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}