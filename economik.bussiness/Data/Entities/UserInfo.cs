using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economick_Software.Data.Entities
{

    [Table("users")]
    public class UserInfo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Numero_documento { get; set; }
        public string Direccion { get; set; }
        public string Contrasena { get; set; }
        public RolInfo Rol { get; set; }
        public Ciudad Ciudad { get; set; }
        public TipoDocumento Tipo_documento { get; set; }
        public string Correo { get; set; }
    }


}
