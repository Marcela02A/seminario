using System.Collections.Generic;

namespace economik.console.Controllers.DTO
{
    public class UserDTO
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int RolId { get; set; }
        public List<ComboDTO> Roles { get; set; }
        public string Password { get; set; }
        public int DocumentType { get; set; }
        public List<ComboDTO> DocumentList { get; set; }
        public string Document { get; set; }
        public int CityId { get; set; }
        public List<ComboDTO> Cities { get; set; }
        public string Address { get; set; }

        public bool InfoMail { get; set; }
    }
}