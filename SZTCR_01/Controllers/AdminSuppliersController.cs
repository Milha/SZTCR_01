using Microsoft.AspNetCore.Mvc;
using SZTCR_01.Data;
using SZTCR_01.Models.Domain;
using SZTCR_01.Models.ViewModels;

namespace SZTCR_01.Controllers
{
    public class AdminSuppliersController : Controller
    {
        private readonly SztcrDbContext sztcrDbContext;

        public AdminSuppliersController(SztcrDbContext sztcrDbContext)
        {
            this.sztcrDbContext = sztcrDbContext;
        }

        [HttpGet]
        public IActionResult AddSupplier()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddSupplier(AddSupplierRequest addSupplierRequest)
        {
            var dobavljac = new Dobavljac
            {
                NazivDobavljaca = addSupplierRequest.NazivDobavljaca,
                AdresaDobavljaca = addSupplierRequest.AdresaDobavljaca,
                EmailDobavljaca = addSupplierRequest.EmailDobavljaca
            };

            sztcrDbContext.Dobavljaci.Add(dobavljac);
            sztcrDbContext.SaveChanges();

            return RedirectToAction("ListSupplier");
        }

        [HttpGet]
        public IActionResult ListSupplier()
        {
            var dobavljaci = sztcrDbContext.Dobavljaci.ToList();

            return View(dobavljaci);
        }

        [HttpGet]
        public IActionResult EditSupplier(Guid id)
        {
            var dobav = sztcrDbContext.Dobavljaci.FirstOrDefault(x => x.Id == id);

            if (dobav != null)
            {
                var editSupplerRequest = new EditSupplierRequest
                {
                    Id = dobav.Id,
                    NazivDobavljaca = dobav.NazivDobavljaca,
                    AdresaDobavljaca = dobav.AdresaDobavljaca,
                    EmailDobavljaca = dobav.EmailDobavljaca
                };

                return View(editSupplerRequest);

            }
            
            return View(null);
        }

        [HttpPost]
        public IActionResult EditSupplier(EditSupplierRequest editSupplierRequest)
        {
            var dobav = new EditSupplierRequest
            {
                Id = editSupplierRequest.Id,
                NazivDobavljaca = editSupplierRequest.NazivDobavljaca,
                AdresaDobavljaca = editSupplierRequest.AdresaDobavljaca,
                EmailDobavljaca = editSupplierRequest.EmailDobavljaca
            };

            var existDobav = sztcrDbContext.Dobavljaci.Find(dobav.Id);

            if(existDobav != null)
            {
                existDobav.NazivDobavljaca = dobav.NazivDobavljaca;
                existDobav.AdresaDobavljaca = dobav.AdresaDobavljaca;
                existDobav.EmailDobavljaca = dobav.EmailDobavljaca;

                sztcrDbContext.SaveChanges();
                return RedirectToAction("ListSupplier");
            }

            return RedirectToAction("EditSupplier", new { id = editSupplierRequest.Id });
        }
    }
}
