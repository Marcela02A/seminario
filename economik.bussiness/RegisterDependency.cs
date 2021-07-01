using Economick_Software.Bussiness;
using Economick_Software.Bussiness.Interfaces;
using Economick_Software.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace economik.bussiness
{
    public static class RegisterDependency
    {
        public static void Init(ServiceCollection services)
        {
            services.AddTransient<IUser, User>();
            services.AddScoped<EconomikContext>();
        }
    }
}
