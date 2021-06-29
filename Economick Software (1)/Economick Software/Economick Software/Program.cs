using Economick_Software.Bussiness;
using Economick_Software.Bussiness.Interfaces;
using Economick_Software.Data;
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

        private static IServiceProvider ServiceProvider { get; set; }

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
            services.AddTransient<IUser, User>();
            services.AddScoped<EconomikContext>();
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
