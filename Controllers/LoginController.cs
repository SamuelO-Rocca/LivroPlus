using Microsoft.AspNetCore.Mvc;
using Livro.Models;

namespace Livro.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                // Lógica de autenticação
                return RedirectToAction("Dashboard", "Home");
            }

            return View(model);
        }
    }
}
