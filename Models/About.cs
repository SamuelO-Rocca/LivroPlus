using Microsoft.AspNetCore.Mvc;

namespace SeuProjeto.Controllers
{
    public class Sobre : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
