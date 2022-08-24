using CIAT.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;

namespace CIAT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DatosPropietario()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ObtenerBeneficiarios()
        {
            return Json(new { data = _context.DatosPropietario.ToList() });
        }

        [HttpGet]
        public IActionResult UbicacionesGanado()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ZonasDeforestacion()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
