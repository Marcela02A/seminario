using Economick_Software.Data;
using Economick_Software.Data.Entities;
using economik.console.Controllers.DTO;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace economik.console.Controllers
{
    public class CompanyController : Controller
    {
        private readonly EconomikContext context;

        public CompanyController()
        {
            context = this.Resolve<EconomikContext>();
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Economik";
            return View(context.Compania.Include(x => x.Rol).ToList());
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            context.Compania.Remove(context.Compania.Find(id));
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            CompanyDTO companyDTO = CompanyDTO.Map(context.Compania
                .Include(x => x.Ciudad)
                .Include(x => x.Rol)
                .FirstOrDefault());

            companyDTO.Roles = context.RolInfo
                .Select(x => new ComboDTO { Id = x.Id, Value = x.descripcion })
                .ToList();

            companyDTO.Cities = context.Ciudad
                .Select(x => new ComboDTO { Id = x.Id, Value = x.Nombres })
                .ToList();

            return View(companyDTO);
        }

        [HttpPost]
        public ActionResult Edit(int id, [Bind] CompanyDTO model)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}