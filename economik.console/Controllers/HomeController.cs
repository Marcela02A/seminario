using Economick_Software.Data;
using Economick_Software.Data.Entities;
using economik.console.Controllers.DTO;
using System.Linq;
using System.Web.Mvc;

namespace economik.console.Controllers
{
    public class HomeController : Controller
    {
        private readonly EconomikContext context;

        public HomeController()
        {
            context = this.Resolve<EconomikContext>();
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Economik";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login(string message)
        {
            ViewBag.Message = "Economik Software";
            ViewBag.msg = message;

            return View();
        }

        [HttpPost]
        public ActionResult Login([Bind] UserInfo model)
        {
            if (ModelState.IsValid)
            {
                if (context.Users.Any(x => x.Correo == model.Correo && x.Contrasena == model.Contrasena))
                {
                    return RedirectToAction(nameof(Index));
                }

                ViewBag.Error = "Usuario incorrecto";

                return View();
            }

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Title = "Economik";

            UserDTO userDTO = new UserDTO();

            userDTO.Roles = context
                .RolInfo
                .Select(x => new ComboDTO
                {
                    Id = x.Id,
                    Value = x.descripcion
                }).ToList();

            userDTO.DocumentList = context
                .TipoDocumento
                .Select(x => new ComboDTO
                {
                    Id = x.Id,
                    Value = x.Descripcion
                }).ToList();

            userDTO.Cities = context
                .Ciudad
                .Select(x => new ComboDTO
                {
                    Id = x.Id,
                    Value = x.Nombres
                }).ToList();

            return View(userDTO);
        }

        [HttpPost]
        public ActionResult Register([Bind] UserDTO model)
        {
            var userInfo = new UserInfo
            {
                Apellidos = model.LastName,
                Ciudad = context.Ciudad.Find(model.CityId),
                Correo = model.Email,
                Contrasena = model.Password,
                Direccion = model.Address,
                Nombres = model.Name,
                Numero_documento = model.Document,
                Tipo_documento = context.TipoDocumento.Find(model.DocumentType),
                Rol = context.RolInfo.Find(model.RolId)
            };

            context.Users.Add(userInfo);

            context.SaveChanges();

            return RedirectToAction(nameof(Login), new { message = "usuario creado" });
        }
    }
}