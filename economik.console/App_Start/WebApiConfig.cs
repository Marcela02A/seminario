using economik.console.App_Start;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace economik.console
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var services = Configuration();

            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.DependencyResolver = new DefaultDependencyResolver(services);
        }

        public static IServiceCollection AddControllersAsServices(this IServiceCollection services,
        IEnumerable<Type> controllerTypes)
        {
            foreach (var type in controllerTypes)
            {
                services.AddTransient(type);
            }

            return services;
        }

        private static IServiceProvider Configuration()
        {
            var services = new ServiceCollection();

            services.AddControllersAsServices(typeof(WebApiConfig).Assembly.GetExportedTypes()
                .Where(t => !t.IsAbstract && !t.IsGenericTypeDefinition)
                .Where(t => typeof(IHttpController).IsAssignableFrom(t)
                            || t.Name.EndsWith("Controller", StringComparison.OrdinalIgnoreCase)));

            var serviceProvider = services.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
