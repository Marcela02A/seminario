using Economick_Software.Data.Entities;
using System.Collections.Generic;

namespace economik.console.Controllers.DTO
{
    public class CompanyDTO
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Nit { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }

        public int CiudadId { get; set; }
        public int RolId { get; set; }

        public string Rol { get; set; }

        public List<ComboDTO> Cities { get; set; }

        public List<ComboDTO> Roles { get; set; }

        public static CompanyDTO Map(Compania compania)
        {
            return new CompanyDTO()
            {
                Id = compania.Id,
                Nit = compania.Nit,
                Ciudad = compania.Ciudad?.Nombres,
                Nombres = compania.Nombres,
                CiudadId = compania.Ciudad?.Id ?? -1,
                Direccion = compania.Direccion,
                RolId = compania.Rol?.Id ?? -1,
                Rol = compania.Rol?.descripcion
            };
        }
    }
}