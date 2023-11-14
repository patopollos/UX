using Microsoft.AspNetCore.Mvc;

namespace PaseanDog.Areas.Clientes.Controllers
{
    [Area("Clientes")]
    public class InicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Servicio()
        {
            return View();
        }

		public IActionResult Registro()
		{
			return View();
		}
	}
}
