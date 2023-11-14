using Microsoft.AspNetCore.Mvc;

namespace PaseanDog.Areas.General.Controllers
{
    [Area("General")]
    public class InicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

