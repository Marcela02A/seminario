using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace economik.console.Controllers
{
    public static class UtilExtension
    {
        public static T Resolve<T>(this Controller controller)
        {
            return (T)App_Start.RegisterDependency.ServiceProvider.GetService(typeof(T));
        }
    }
}