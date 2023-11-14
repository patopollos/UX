using Microsoft.AspNetCore.Mvc;

namespace PaseanDog.Areas.Paseadores.Controllers

{
    [Area("Paseadores")]
    public class InicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }

		public IActionResult Aviso()
		{
			return View();
		}
	}
}
