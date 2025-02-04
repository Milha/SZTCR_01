using Microsoft.AspNetCore.Mvc;

namespace SZTCR_01.Controllers
{
    public class AdministratorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
