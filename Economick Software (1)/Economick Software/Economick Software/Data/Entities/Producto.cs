using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economick_Software.Data.Entities
{
    [Table("Producto")]
    public class Producto
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
        public long precio { get; set; }
        public int  Stock { get; set; }
    }
}
