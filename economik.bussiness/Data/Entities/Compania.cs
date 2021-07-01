using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economick_Software.Data.Entities
{
    [Table("Companias")]
    public class Compania
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Nit { get; set; }
        public string Direccion { get; set; }
        public Ciudad Ciudad { get; set; }
        public RolInfo Rol { get; set; }
    }
}
