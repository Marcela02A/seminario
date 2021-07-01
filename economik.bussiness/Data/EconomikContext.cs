using Economick_Software.Data.Entities;
using Economick_Software.Data.Init;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economick_Software.Data
{
    public class EconomikContext : DbContext
    {
        static EconomikContext()
        {
            Database.SetInitializer(new EconomikInitializer());
        }

        public DbSet<UserInfo> Users { get; set; }
        public DbSet<Compania> Compania { get; set; }
        public DbSet<Compra> Compra { get; set; }
        public DbSet<CompraProducto> CompraProducto { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<RolInfo> RolInfo { get; set; }
        public DbSet<TipoDocumento> TipoDocumento { get; set; }
        public DbSet<Ciudad> Ciudad { get; set; }

        public DbSet<Venta> Venta { get; set; }
        public DbSet<VentaProducto> VentaProducto { get; set; }

        public EconomikContext() : base("EconomikContext") {
    
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
