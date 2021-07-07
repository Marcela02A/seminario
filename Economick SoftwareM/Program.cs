using Economick_Software.Bussiness;
using Economick_Software.Bussiness.Interfaces;
using Economick_Software.Data;
using Economick_Software.Forms;
using economik.bussiness;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economick_Software
{
    static class Program
    {

        public static IServiceProvider ServiceProvider { get; set; }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureServices();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(ServiceProvider.GetRequiredService<Form1>());
        }


        private static void ConfigureServices()
        {
            ServiceCollection services = new ServiceCollection();

            services.AddTransient<Form1>();
            services.AddTransient<Form3>();
            services.AddTransient<Form4>();
            services.AddTransient<Clientes>();
            services.AddTransient<Recuperar>();

            RegisterDependency.Init(services);

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
