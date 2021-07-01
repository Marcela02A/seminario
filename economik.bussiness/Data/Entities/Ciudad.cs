using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economick_Software.Data.Entities
{
    [Table("Ciudad")]
    public class Ciudad
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        public string Nombres { get; set; }

        public decimal Longitud { get; set; }
        public decimal Latitud { get; set; }
    }
}
