﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economick_Software.Data.Entities
{
    [Table("Venta_producto")]
    public class VentaProducto
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public Producto Producto{ get; set; }
        public int Cantidad { get; set; }
        public Venta Venta { get; set; }

    }
}
