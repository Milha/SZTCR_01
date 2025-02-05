using Microsoft.AspNetCore.Mvc;
using SZTCR_01.Data;
using SZTCR_01.Models.Domain;
using SZTCR_01.Models.ViewModels;

namespace SZTCR_01.Controllers
{
    public class AdministratorController : Controller
    {
        private readonly SztcrDbContext sztcrDbContext;

        public AdministratorController(SztcrDbContext sztcrDbContext)
        {
            this.sztcrDbContext = sztcrDbContext;
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeRequest addEmployeeRequest)
        {

            var radnik = new Radnik
            {
                Ime = addEmployeeRequest.Ime,
                Prezime = addEmployeeRequest.Prezime,
                Pozicija = addEmployeeRequest.Pozicija
            };

            sztcrDbContext.Radnici.Add(radnik);
            sztcrDbContext.SaveChanges();

            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            var radnici = sztcrDbContext.Radnici.ToList();

            return View(radnici);
        }
    }
}
