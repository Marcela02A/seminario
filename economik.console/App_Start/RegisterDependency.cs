using Microsoft.Extensions.DependencyInjection;
using System;

namespace economik.console.App_Start
{
    public static class RegisterDependency
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public static void Init()
        {
            ConfigureServices();
        }

        private static void ConfigureServices()
        {
            ServiceCollection services = new ServiceCollection();

            bussiness.RegisterDependency.Init(services);

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}