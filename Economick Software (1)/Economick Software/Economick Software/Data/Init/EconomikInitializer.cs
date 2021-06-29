using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economick_Software.Data.Init
{
    public class EconomikInitializer : CreateDatabaseIfNotExists<EconomikContext>
    {
        public override void InitializeDatabase(EconomikContext context)
        {
            if (context.Database.CreateIfNotExists())
            {
                context.Users.Add(new Entities.UserInfo { Nombres = "jose" });
                context.Users.Add(new Entities.UserInfo { Apellidos = "hector" });
                context.SaveChanges();
            }
            base.InitializeDatabase(context);

        }
    }
}
